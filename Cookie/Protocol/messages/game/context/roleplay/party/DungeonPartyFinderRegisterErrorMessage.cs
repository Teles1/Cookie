using Cookie.IO;
using System;

namespace Cookie.Protocol.Network.Messages
{
    public class DungeonPartyFinderRegisterErrorMessage : NetworkMessage
    {
        public const uint ProtocolId = 6243;
        public override uint MessageID { get { return ProtocolId; } }

        public DungeonPartyFinderRegisterErrorMessage()
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