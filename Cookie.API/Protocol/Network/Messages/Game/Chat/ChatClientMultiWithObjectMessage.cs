//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Chat
{
    using Cookie.API.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ChatClientMultiWithObjectMessage : ChatClientMultiMessage
    {
        
        public new const uint ProtocolId = 862;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ObjectItem> m_objects;
        
        public virtual List<ObjectItem> Objects
        {
            get
            {
                return m_objects;
            }
            set
            {
                m_objects = value;
            }
        }
        
        public ChatClientMultiWithObjectMessage(List<ObjectItem> objects)
        {
            m_objects = objects;
        }
        
        public ChatClientMultiWithObjectMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_objects.Count)));
            int objectsIndex;
            for (objectsIndex = 0; (objectsIndex < m_objects.Count); objectsIndex = (objectsIndex + 1))
            {
                ObjectItem objectToSend = m_objects[objectsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            int objectsCount = reader.ReadUShort();
            int objectsIndex;
            m_objects = new System.Collections.Generic.List<ObjectItem>();
            for (objectsIndex = 0; (objectsIndex < objectsCount); objectsIndex = (objectsIndex + 1))
            {
                ObjectItem objectToAdd = new ObjectItem();
                objectToAdd.Deserialize(reader);
                m_objects.Add(objectToAdd);
            }
        }
    }
}
