//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Character.Choice
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class CharacterSelectedForceMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6068;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_ObjectId;
        
        public virtual int ObjectId
        {
            get
            {
                return m_ObjectId;
            }
            set
            {
                m_ObjectId = value;
            }
        }
        
        public CharacterSelectedForceMessage(int objectId)
        {
            m_ObjectId = objectId;
        }
        
        public CharacterSelectedForceMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteInt(m_ObjectId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_ObjectId = reader.ReadInt();
        }
    }
}
