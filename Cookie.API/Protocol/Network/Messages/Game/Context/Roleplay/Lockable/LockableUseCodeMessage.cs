//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Lockable
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class LockableUseCodeMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5667;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_code;
        
        public virtual string Code
        {
            get
            {
                return m_code;
            }
            set
            {
                m_code = value;
            }
        }
        
        public LockableUseCodeMessage(string code)
        {
            m_code = code;
        }
        
        public LockableUseCodeMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteUTF(m_code);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_code = reader.ReadUTF();
        }
    }
}
