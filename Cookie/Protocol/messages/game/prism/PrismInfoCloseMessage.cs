using Cookie.IO;
using System;

namespace Cookie.Protocol.Network.Messages
{
    public class PrismInfoCloseMessage : NetworkMessage
    {
        public const uint ProtocolId = 5853;
        public override uint MessageID { get { return ProtocolId; } }

        public PrismInfoCloseMessage()
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