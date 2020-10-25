using Cookie.IO;
using System;

namespace Cookie.Protocol.Network.Messages
{
    public class ExchangeObjectTransfertAllFromInvMessage : NetworkMessage
    {
        public const uint ProtocolId = 6184;
        public override uint MessageID { get { return ProtocolId; } }

        public ExchangeObjectTransfertAllFromInvMessage()
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