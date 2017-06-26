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
    
    
    public class ExchangeClearPaymentForCraftMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6145;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_paymentType;
        
        public virtual byte PaymentType
        {
            get
            {
                return m_paymentType;
            }
            set
            {
                m_paymentType = value;
            }
        }
        
        public ExchangeClearPaymentForCraftMessage(byte paymentType)
        {
            m_paymentType = paymentType;
        }
        
        public ExchangeClearPaymentForCraftMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(m_paymentType);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_paymentType = reader.ReadByte();
        }
    }
}
