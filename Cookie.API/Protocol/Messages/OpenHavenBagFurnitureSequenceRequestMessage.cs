using Cookie.API.Utils.IO;
using Cookie.API.Protocol.Enums;
using System.Collections.Generic;
using Cookie.API.Protocol.Network.Messages;
using Cookie.API.Protocol.Network.Types;

namespace Cookie.API.Protocol.Network.Messages
{

    public class OpenHavenBagFurnitureSequenceRequestMessage : NetworkMessage
    {
        public const ushort ProtocolId = 6635;

        public override ushort MessageID => ProtocolId;

        public OpenHavenBagFurnitureSequenceRequestMessage() { }

        public override void Serialize(IDataWriter writer)
        {
        }

        public override void Deserialize(IDataReader reader)
        {
        }
    }
}
