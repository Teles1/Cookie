using Cookie.API.Utils.IO;
using Cookie.API.Protocol.Enums;
using System.Collections.Generic;
using Cookie.API.Protocol.Network.Messages;
using Cookie.API.Protocol.Network.Types;

namespace Cookie.API.Protocol.Network.Messages
{

    public class BasicPingMessage : NetworkMessage
    {
        public const ushort ProtocolId = 182;

        public override ushort MessageID => ProtocolId;

        public bool Quiet { get; set; }
        public BasicPingMessage() { }

        public BasicPingMessage( bool Quiet ){
            this.Quiet = Quiet;
        }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(Quiet);
        }

        public override void Deserialize(IDataReader reader)
        {
            Quiet = reader.ReadBoolean();
        }
    }
}
