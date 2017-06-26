//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Inventory.Items
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ObjectSetPositionMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 3021;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_objectUID;
        
        public virtual uint ObjectUID
        {
            get
            {
                return m_objectUID;
            }
            set
            {
                m_objectUID = value;
            }
        }
        
        private sbyte m_position;
        
        public virtual sbyte Position
        {
            get
            {
                return m_position;
            }
            set
            {
                m_position = value;
            }
        }
        
        private uint m_quantity;
        
        public virtual uint Quantity
        {
            get
            {
                return m_quantity;
            }
            set
            {
                m_quantity = value;
            }
        }
        
        public ObjectSetPositionMessage(uint objectUID, sbyte position, uint quantity)
        {
            m_objectUID = objectUID;
            m_position = position;
            m_quantity = quantity;
        }
        
        public ObjectSetPositionMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhInt(m_objectUID);
            writer.WriteSByte(m_position);
            writer.WriteVarUhInt(m_quantity);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_objectUID = reader.ReadVarUhInt();
            m_position = reader.ReadSByte();
            m_quantity = reader.ReadVarUhInt();
        }
    }
}
