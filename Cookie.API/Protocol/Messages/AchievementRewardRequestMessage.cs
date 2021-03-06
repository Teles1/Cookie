using Cookie.API.Utils.IO;
using Cookie.API.Protocol.Enums;
using System.Collections.Generic;
using Cookie.API.Protocol.Network.Messages;
using Cookie.API.Protocol.Network.Types;

namespace Cookie.API.Protocol.Network.Messages
{

    public class AchievementRewardRequestMessage : NetworkMessage
    {
        public const ushort ProtocolId = 6377;

        public override ushort MessageID => ProtocolId;

        public short AchievementId { get; set; }
        public AchievementRewardRequestMessage() { }

        public AchievementRewardRequestMessage( short AchievementId ){
            this.AchievementId = AchievementId;
        }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(AchievementId);
        }

        public override void Deserialize(IDataReader reader)
        {
            AchievementId = reader.ReadShort();
        }
    }
}
