using Cookie.API.Utils.IO;
using Cookie.API.Protocol.Enums;
using System.Collections.Generic;
using Cookie.API.Protocol.Network.Messages;
using Cookie.API.Protocol.Network.Types;

namespace Cookie.API.Protocol.Network.Types
{

    public class AchievementStartedObjective : AchievementObjective
    {
        public new const ushort ProtocolId = 402;

        public override ushort TypeID => ProtocolId;

        public uint Value { get; set; }
        public AchievementStartedObjective() { }

        public AchievementStartedObjective( uint Value ){
            this.Value = Value;
        }

        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhInt(Value);
        }

        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            Value = reader.ReadVarUhInt();
        }
    }
}
