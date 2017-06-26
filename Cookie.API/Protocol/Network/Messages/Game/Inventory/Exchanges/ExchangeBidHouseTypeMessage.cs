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
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ExchangeBidHouseTypeMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5803;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_type;
        
        public virtual uint Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
            }
        }
        
        public ExchangeBidHouseTypeMessage(uint type)
        {
            m_type = type;
        }
        
        public ExchangeBidHouseTypeMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhInt(m_type);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_type = reader.ReadVarUhInt();
        }
    }
}
