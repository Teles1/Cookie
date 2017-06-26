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
    
    
    public class ExchangeItemAutoCraftRemainingMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6015;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_count;
        
        public virtual uint Count
        {
            get
            {
                return m_count;
            }
            set
            {
                m_count = value;
            }
        }
        
        public ExchangeItemAutoCraftRemainingMessage(uint count)
        {
            m_count = count;
        }
        
        public ExchangeItemAutoCraftRemainingMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhInt(m_count);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_count = reader.ReadVarUhInt();
        }
    }
}
