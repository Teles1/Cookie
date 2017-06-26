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
    
    
    public class ExchangeRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5505;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_exchangeType;
        
        public virtual byte ExchangeType
        {
            get
            {
                return m_exchangeType;
            }
            set
            {
                m_exchangeType = value;
            }
        }
        
        public ExchangeRequestMessage(byte exchangeType)
        {
            m_exchangeType = exchangeType;
        }
        
        public ExchangeRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(m_exchangeType);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_exchangeType = reader.ReadByte();
        }
    }
}
