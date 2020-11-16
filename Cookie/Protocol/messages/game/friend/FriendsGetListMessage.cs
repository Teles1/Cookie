using Cookie.IO;
using System;

namespace Cookie.Protocol.Network.Messages
{
    public class FriendsGetListMessage : NetworkMessage
    {
        public const uint ProtocolId = 4001;
        public override uint MessageID { get { return ProtocolId; } }

        public FriendsGetListMessage()
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