using Cookie.IO;
using System;

namespace Cookie.Protocol.Network.Messages
{
    public class SocialNoticeSetRequestMessage : NetworkMessage
    {
        public const uint ProtocolId = 6686;
        public override uint MessageID { get { return ProtocolId; } }

        public SocialNoticeSetRequestMessage()
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