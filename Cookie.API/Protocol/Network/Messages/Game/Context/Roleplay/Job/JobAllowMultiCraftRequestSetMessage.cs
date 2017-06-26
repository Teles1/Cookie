//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Job
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class JobAllowMultiCraftRequestSetMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5749;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_enabled;
        
        public virtual bool Enabled
        {
            get
            {
                return m_enabled;
            }
            set
            {
                m_enabled = value;
            }
        }
        
        public JobAllowMultiCraftRequestSetMessage(bool enabled)
        {
            m_enabled = enabled;
        }
        
        public JobAllowMultiCraftRequestSetMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteBoolean(m_enabled);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_enabled = reader.ReadBoolean();
        }
    }
}
