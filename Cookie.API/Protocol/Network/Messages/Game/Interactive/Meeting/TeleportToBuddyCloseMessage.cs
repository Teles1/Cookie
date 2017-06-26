//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Interactive.Meeting
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class TeleportToBuddyCloseMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6303;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_dungeonId;
        
        public virtual ushort DungeonId
        {
            get
            {
                return m_dungeonId;
            }
            set
            {
                m_dungeonId = value;
            }
        }
        
        private ulong m_buddyId;
        
        public virtual ulong BuddyId
        {
            get
            {
                return m_buddyId;
            }
            set
            {
                m_buddyId = value;
            }
        }
        
        public TeleportToBuddyCloseMessage(ushort dungeonId, ulong buddyId)
        {
            m_dungeonId = dungeonId;
            m_buddyId = buddyId;
        }
        
        public TeleportToBuddyCloseMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_dungeonId);
            writer.WriteVarUhLong(m_buddyId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_dungeonId = reader.ReadVarUhShort();
            m_buddyId = reader.ReadVarUhLong();
        }
    }
}
