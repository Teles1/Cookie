//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Inventory.Exchanges
{
    using Cookie.API.Utils.IO;
    using Cookie.API.Protocol.Network.Types.Game.Mount;
    using System.Collections.Generic;


    public class UpdateMountBoostMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6179;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<UpdateMountBoost> m_boostToUpdateList;
        
        public virtual List<UpdateMountBoost> BoostToUpdateList
        {
            get
            {
                return m_boostToUpdateList;
            }
            set
            {
                m_boostToUpdateList = value;
            }
        }
        
        private int m_rideId;
        
        public virtual int RideId
        {
            get
            {
                return m_rideId;
            }
            set
            {
                m_rideId = value;
            }
        }
        
        public UpdateMountBoostMessage(List<UpdateMountBoost> boostToUpdateList, int rideId)
        {
            m_boostToUpdateList = boostToUpdateList;
            m_rideId = rideId;
        }
        
        public UpdateMountBoostMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_boostToUpdateList.Count)));
            int boostToUpdateListIndex;
            for (boostToUpdateListIndex = 0; (boostToUpdateListIndex < m_boostToUpdateList.Count); boostToUpdateListIndex = (boostToUpdateListIndex + 1))
            {
                UpdateMountBoost objectToSend = m_boostToUpdateList[boostToUpdateListIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteVarInt(m_rideId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int boostToUpdateListCount = reader.ReadUShort();
            int boostToUpdateListIndex;
            m_boostToUpdateList = new System.Collections.Generic.List<UpdateMountBoost>();
            for (boostToUpdateListIndex = 0; (boostToUpdateListIndex < boostToUpdateListCount); boostToUpdateListIndex = (boostToUpdateListIndex + 1))
            {
                UpdateMountBoost objectToAdd = ProtocolTypeManager.GetInstance<UpdateMountBoost>((short)reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_boostToUpdateList.Add(objectToAdd);
            }
            m_rideId = reader.ReadVarInt();
        }
    }
}
