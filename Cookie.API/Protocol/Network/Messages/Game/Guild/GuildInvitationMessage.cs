//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Guild
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GuildInvitationMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5551;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_targetId;
        
        public virtual ulong TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        public GuildInvitationMessage(ulong targetId)
        {
            m_targetId = targetId;
        }
        
        public GuildInvitationMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhLong(m_targetId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_targetId = reader.ReadVarUhLong();
        }
    }
}
