//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Actions.Fight
{
    using Cookie.API.Utils.IO;
    using Cookie.API.Protocol.Network.Messages.Game.Actions;
    using Cookie.API.Protocol.Network.Types.Game.Context.Fight;
    using System.Collections.Generic;


    public class GameActionFightSummonMessage : AbstractGameActionMessage
    {
        
        public new const uint ProtocolId = 5825;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<GameFightFighterInformations> m_summons;
        
        public virtual List<GameFightFighterInformations> Summons
        {
            get
            {
                return m_summons;
            }
            set
            {
                m_summons = value;
            }
        }
        
        public GameActionFightSummonMessage(List<GameFightFighterInformations> summons)
        {
            m_summons = summons;
        }
        
        public GameActionFightSummonMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_summons.Count)));
            int summonsIndex;
            for (summonsIndex = 0; (summonsIndex < m_summons.Count); summonsIndex = (summonsIndex + 1))
            {
                GameFightFighterInformations objectToSend = m_summons[summonsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            int summonsCount = reader.ReadUShort();
            int summonsIndex;
            m_summons = new System.Collections.Generic.List<GameFightFighterInformations>();
            for (summonsIndex = 0; (summonsIndex < summonsCount); summonsIndex = (summonsIndex + 1))
            {
                GameFightFighterInformations objectToAdd = ProtocolTypeManager.GetInstance<GameFightFighterInformations>((short)reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_summons.Add(objectToAdd);
            }
        }
    }
}
