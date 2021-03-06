using Cookie.API.Utils.IO;
using Cookie.API.Protocol.Enums;
using System.Collections.Generic;
using Cookie.API.Protocol.Network.Messages;
using Cookie.API.Protocol.Network.Types;

namespace Cookie.API.Protocol.Network.Types
{

    public class ShortcutObjectPreset : ShortcutObject
    {
        public new const ushort ProtocolId = 370;

        public override ushort TypeID => ProtocolId;

        public short PresetId { get; set; }
        public ShortcutObjectPreset() { }

        public ShortcutObjectPreset( short PresetId ){
            this.PresetId = PresetId;
        }

        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(PresetId);
        }

        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            PresetId = reader.ReadShort();
        }
    }
}
