//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Basic
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class BasicWhoAmIRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5664;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_verbose;
        
        public virtual bool Verbose
        {
            get
            {
                return m_verbose;
            }
            set
            {
                m_verbose = value;
            }
        }
        
        public BasicWhoAmIRequestMessage(bool verbose)
        {
            m_verbose = verbose;
        }
        
        public BasicWhoAmIRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteBoolean(m_verbose);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_verbose = reader.ReadBoolean();
        }
    }
}
