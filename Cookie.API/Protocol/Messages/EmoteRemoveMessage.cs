using Cookie.API.Utils.IO;
using Cookie.API.Protocol.Enums;
using System.Collections.Generic;
using Cookie.API.Protocol.Network.Messages;
using Cookie.API.Protocol.Network.Types;

namespace Cookie.API.Protocol.Network.Messages
{

    public class EmoteRemoveMessage : NetworkMessage
    {
        public const ushort ProtocolId = 5687;

        public override ushort MessageID => ProtocolId;

        public byte EmoteId { get; set; }
        public EmoteRemoveMessage() { }

        public EmoteRemoveMessage( byte EmoteId ){
            this.EmoteId = EmoteId;
        }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(EmoteId);
        }

        public override void Deserialize(IDataReader reader)
        {
            EmoteId = reader.ReadByte();
        }
    }
}
