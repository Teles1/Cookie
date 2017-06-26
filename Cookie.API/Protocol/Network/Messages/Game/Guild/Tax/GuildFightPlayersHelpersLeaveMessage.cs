//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Guild.Tax
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GuildFightPlayersHelpersLeaveMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5719;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_fightId;
        
        public virtual int FightId
        {
            get
            {
                return m_fightId;
            }
            set
            {
                m_fightId = value;
            }
        }
        
        private ulong m_playerId;
        
        public virtual ulong PlayerId
        {
            get
            {
                return m_playerId;
            }
            set
            {
                m_playerId = value;
            }
        }
        
        public GuildFightPlayersHelpersLeaveMessage(int fightId, ulong playerId)
        {
            m_fightId = fightId;
            m_playerId = playerId;
        }
        
        public GuildFightPlayersHelpersLeaveMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteInt(m_fightId);
            writer.WriteVarUhLong(m_playerId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_fightId = reader.ReadInt();
            m_playerId = reader.ReadVarUhLong();
        }
    }
}
