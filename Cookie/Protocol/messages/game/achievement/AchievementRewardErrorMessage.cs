using Cookie.IO;
using System;

namespace Cookie.Protocol.Network.Messages
{
    public class AchievementRewardErrorMessage : NetworkMessage
    {
        public const uint ProtocolId = 6375;
        public override uint MessageID { get { return ProtocolId; } }

        public short AchievementId = 0;

        public AchievementRewardErrorMessage()
        {
        }

        public AchievementRewardErrorMessage(
            short achievementId
        )
        {
            AchievementId = achievementId;
        }

        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(AchievementId);
        }

        public override void Deserialize(ICustomDataInput reader)
        {
            AchievementId = reader.ReadShort();
        }
    }
}