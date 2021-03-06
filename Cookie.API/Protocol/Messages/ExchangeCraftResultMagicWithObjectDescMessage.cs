using Cookie.API.Utils.IO;
using Cookie.API.Protocol.Enums;
using System.Collections.Generic;
using Cookie.API.Protocol.Network.Messages;
using Cookie.API.Protocol.Network.Types;

namespace Cookie.API.Protocol.Network.Messages
{

    public class ExchangeCraftResultMagicWithObjectDescMessage : ExchangeCraftResultWithObjectDescMessage
    {
        public new const ushort ProtocolId = 6188;

        public override ushort MessageID => ProtocolId;

        public sbyte MagicPoolStatus { get; set; }
        public ExchangeCraftResultMagicWithObjectDescMessage() { }

        public ExchangeCraftResultMagicWithObjectDescMessage( sbyte MagicPoolStatus ){
            this.MagicPoolStatus = MagicPoolStatus;
        }

        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(MagicPoolStatus);
        }

        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            MagicPoolStatus = reader.ReadSByte();
        }
    }
}
