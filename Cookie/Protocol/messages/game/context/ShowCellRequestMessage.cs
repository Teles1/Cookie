using Cookie.IO;
using System;

namespace Cookie.Protocol.Network.Messages
{
    public class ShowCellRequestMessage : NetworkMessage
    {
        public const uint ProtocolId = 5611;
        public override uint MessageID { get { return ProtocolId; } }

        public short CellId = 0;

        public ShowCellRequestMessage()
        {
        }

        public ShowCellRequestMessage(
            short cellId
        )
        {
            CellId = cellId;
        }

        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarShort(CellId);
        }

        public override void Deserialize(ICustomDataInput reader)
        {
            CellId = reader.ReadVarShort();
        }
    }
}