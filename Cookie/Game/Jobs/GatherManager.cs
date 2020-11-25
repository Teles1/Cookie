using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Cookie.API.Core;
using Cookie.API.Datacenter;
using Cookie.API.Game.Jobs;
using Cookie.API.Game.Map;
using Cookie.API.Game.Map.Elements;
using Cookie.API.Game.World.Pathfinding.Positions;
using Cookie.API.Gamedata;
using Cookie.API.Gamedata.D2i;
using Cookie.API.Gamedata.D2o;
using Cookie.API.Messages;
using Cookie.API.Protocol.Network.Messages;
using Cookie.API.Utils;
using Cookie.Game.Map.Elements;

namespace Cookie.Game.Jobs
{
    public class GatherManager : IGatherManager
    {
        private readonly IAccount _account;
        private int Delay => 10000;
        #region Constructors
        public GatherManager(IAccount account)
        {
            _account = account;
            _account.Network.RegisterPacket<JobExperienceMultiUpdateMessage>(HandleJobExperienceMultiUpdateMessage, MessagePriority.VeryHigh);
            _account.Network.RegisterPacket<JobLevelUpMessage>(HandleJobLevelUpMessage, MessagePriority.VeryHigh);
            _account.Network.RegisterPacket<JobExperienceUpdateMessage>(HandleJobExperienceUpdateMessage,MessagePriority.VeryHigh);
            _account.Network.RegisterPacket<ObtainedItemWithBonusMessage>(HandleObtainedItemWithBonusMessage, MessagePriority.VeryHigh);
            MovementAutoReset = new AutoResetEvent(false);
            InteractiveUsedAutoReset = new AutoResetEvent(false);
            CheckLock = new object();
        }

        #endregion
        #region Variables
        AutoResetEvent MovementAutoReset { get; }
        AutoResetEvent InteractiveUsedAutoReset { get; }
        public bool Launched { get; set; }
        public List<int> ToGather { get; set; }
        public bool AutoGather { get; set; }
        public object CheckLock { get; set; }
        #endregion
        public void Stop()
        {
            if (Launched)
                Launched = false;
        }
        public void DoAutoGather(bool arg)
        {
            AutoGather = !arg;
        }
        /// <summary>
        ///     Starts the Gather routine
        /// </summary>
        /// <param name="params">RessourceList</param>
        /// <param name="autoGather">true if autogathering</param>
        public void Gather(List<int> @params, bool autoGather)
        {/* This function will be responsible for moving close to the element and harvesting if possible.
            Loop thru the items to harvest to check weather that ressource id is present on the items and if it's harvestable.*/
            //Starting getting which element is closer to our bot
            IUsableElement element = GetClosestHarvestable(@params);
            if (element != null)
            {
                Logger.Default.Log($"Element Found. Moving to [{element.CellId}]", API.Utils.Enums.LogMessageType.Arena);
                uint id = element.Element.Id;
                var skillInstanceUid = element.Skills[0].SkillInstanceUid;
                ICellMovement move = _account.Character.Map.MoveToElement(id, 1);
                if (move == null) move = _account.Character.Map.MoveToElement(id, 2);
                move.MovementFinished += (movement, message) =>
                {
                    Logger.Default.Log($"Movement perfomed. Status[{message.Sucess}]", API.Utils.Enums.LogMessageType.Arena);
                    if (message.Sucess)
                        MovementAutoReset.Set();
                };
                move.PerformMovement();
                if (MovementAutoReset.WaitOne(Delay)) //Wait for the movement delay.
                {
                    Logger.Default.Log($"Farming the ressource.", API.Utils.Enums.LogMessageType.Arena);
                    _account.Character.Map.UseElement((int)id, skillInstanceUid); //server will reply with InteractiveUsedMessage then once done InteractiveElementUpdatedMessage
                    if (InteractiveUsedAutoReset.WaitOne(Delay)) // if this returns true we execute Gather. else return;
                        if (_account.Character.PathManager.Launched)
                            _account.Character.PathManager.GatherManagerDoActionByPass();
                }
            }
        }
        private IUsableElement GetClosestHarvestable(List<int> ressourceIdList)
        {
            int distance = 9999;
            int tmpDistance = -1;
            IUsableElement element = new UsableElement();
            lock (CheckLock)
            {
                if (_account.Character.Map.UsableElements.Count > 0)
                {
                    foreach (var ressourceId in ressourceIdList)
                    {
                        foreach (var usableElement in _account.Character.Map.UsableElements)
                        {
                            foreach (var interactiveElement in _account.Character.Map.InteractiveElements.Values)
                            {
                                if (usableElement.Value.Element.Id == interactiveElement.Id && interactiveElement.IsUsable && interactiveElement.TypeId == ressourceId)
                                {
                                    tmpDistance = GetRessourceDistance(usableElement.Value.Element.Id);
                                    if (distance > tmpDistance)
                                    {
                                        distance = tmpDistance;
                                        element = usableElement.Value;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            if (distance == 9999)
                return null;
            return element;
        }
        public bool CanGatherOnMap(List<int> ids)
        {
            lock (CheckLock)
            {
                foreach (int rId in ids)
                {
                    foreach (var uElement in _account.Character.Map.UsableElements)
                    {
                        foreach (var iElement in _account.Character.Map.InteractiveElements.Values)
                        {
                            if (uElement.Value.Element.Id == iElement.Id && iElement.IsUsable && iElement.TypeId == rId)
                                return true;
                        }
                    }
                }
            }
            return false;
        }
        public void Gather()
        {
            Gather(ToGather, AutoGather);
        }
        public List<IUsableElement> TrierDistanceElement(List<int> listDistance, List<IUsableElement> listUsableElement)
        {
            var inOrder = false;

            var listLength = listDistance.Count;
            while (!inOrder)
            {
                inOrder = true;
                for (var i = 0; i <= listLength - 2; i++)
                {
                    if (listDistance[i] <= listDistance[i + 1]) continue;
                    object timeToAccess = listDistance[i];
                    listDistance[i] = listDistance[i + 1];
                    listDistance[i + 1] = Convert.ToInt32(timeToAccess);
                    timeToAccess = listUsableElement[i];
                    listUsableElement[i] = listUsableElement[i + 1];
                    listUsableElement[i + 1] = (IUsableElement) timeToAccess;
                    inOrder = false;
                }
                listLength = listLength - 1;
            }

            return listUsableElement;
        }
        private int GetRessourceDistance(uint id)
        {
            var characterMapPoint = new MapPoint(_account.Character.CellId);
            var statedRessource = _account.Character.Map.StatedElements.FirstOrDefault(se => se.Value.Id == id).Value;
            if (statedRessource == null) return -1;
            var ressourceMapPoint = new MapPoint((int) statedRessource.CellId);
            return characterMapPoint.DistanceTo(ressourceMapPoint);
        }
        #region Handlers
        private void HandleJobExperienceMultiUpdateMessage(IAccount account, JobExperienceMultiUpdateMessage message)
        {
            _account.Character.Jobs = message.ExperiencesUpdate;
        }
        private void HandleJobLevelUpMessage(IAccount account, JobLevelUpMessage message)
        {
            var jobName = D2OParsing.GetJobName(message.JobsDescription.JobId);
            Logger.Default.Log("Votre métier " + jobName + " vient de passer niveau " + message.NewLevel);
        }
        private void HandleJobExperienceUpdateMessage(IAccount account, JobExperienceUpdateMessage message)
        {
            foreach (var job in _account.Character.Jobs)
                if (job.JobId == message.ExperiencesUpdate.JobId)
                {
                    job.JobLevel = message.ExperiencesUpdate.JobLevel;
                    job.JobXP = message.ExperiencesUpdate.JobXP;
                    job.JobXpLevelFloor = message.ExperiencesUpdate.JobXpLevelFloor;
                    job.JobXpNextLevelFloor = message.ExperiencesUpdate.JobXpNextLevelFloor;
                    break;
                }
            Logger.Default.Log(
                $"{FastD2IReader.Instance.GetText(ObjectDataManager.Instance.Get<Job>(message.ExperiencesUpdate.JobId).NameId)} | Level: {message.ExperiencesUpdate.JobLevel} | Exp: {message.ExperiencesUpdate.JobXP}");
        }
        private void HandleObtainedItemWithBonusMessage(IAccount account, ObtainedItemWithBonusMessage message)
        {
            Task.Delay(250).Wait();
            InteractiveUsedAutoReset.Set();
        }
        #endregion Handlers
    }
}