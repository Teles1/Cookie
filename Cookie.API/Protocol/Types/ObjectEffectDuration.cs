using Cookie.API.Utils.IO;
using Cookie.API.Protocol.Enums;
using System.Collections.Generic;
using Cookie.API.Protocol.Network.Messages;
using Cookie.API.Protocol.Network.Types;

namespace Cookie.API.Protocol.Network.Types
{

    public class ObjectEffectDuration : ObjectEffect
    {
        public new const ushort ProtocolId = 75;

        public override ushort TypeID => ProtocolId;

        public ushort Days { get; set; }
        public sbyte Hours { get; set; }
        public sbyte Minutes { get; set; }
        public ObjectEffectDuration() { }

        public ObjectEffectDuration( ushort Days, sbyte Hours, sbyte Minutes ){
            this.Days = Days;
            this.Hours = Hours;
            this.Minutes = Minutes;
        }

        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhShort(Days);
            writer.WriteSByte(Hours);
            writer.WriteSByte(Minutes);
        }

        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            Days = reader.ReadVarUhShort();
            Hours = reader.ReadSByte();
            Minutes = reader.ReadSByte();
        }
    }
}
