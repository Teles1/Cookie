using Cookie.IO;
using System;

namespace Cookie.Protocol.Network.Messages
{
    public class ExchangeStartOkCraftMessage : NetworkMessage
    {
        public const uint ProtocolId = 5813;
        public override uint MessageID { get { return ProtocolId; } }

        public ExchangeStartOkCraftMessage()
        {
        }

        public override void Serialize(ICustomDataOutput writer)
        {
        }

        public override void Deserialize(ICustomDataInput reader)
        {
        }
    }
}