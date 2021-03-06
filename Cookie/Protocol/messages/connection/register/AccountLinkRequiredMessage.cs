using Cookie.IO;
using System;

namespace Cookie.Protocol.Network.Messages
{
    public class AccountLinkRequiredMessage : NetworkMessage
    {
        public const uint ProtocolId = 6607;
        public override uint MessageID { get { return ProtocolId; } }

        public AccountLinkRequiredMessage()
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