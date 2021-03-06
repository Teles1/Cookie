using Cookie.IO;
using System;

namespace Cookie.Protocol.Network.Messages
{
    public class NicknameAcceptedMessage : NetworkMessage
    {
        public const uint ProtocolId = 5641;
        public override uint MessageID { get { return ProtocolId; } }

        public NicknameAcceptedMessage()
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