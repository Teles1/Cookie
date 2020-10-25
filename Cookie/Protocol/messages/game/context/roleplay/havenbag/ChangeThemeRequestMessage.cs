using Cookie.IO;
using System;

namespace Cookie.Protocol.Network.Messages
{
    public class ChangeThemeRequestMessage : NetworkMessage
    {
        public const uint ProtocolId = 6639;
        public override uint MessageID { get { return ProtocolId; } }

        public byte Theme = 0;

        public ChangeThemeRequestMessage()
        {
        }

        public ChangeThemeRequestMessage(
            byte theme
        )
        {
            Theme = theme;
        }

        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(Theme);
        }

        public override void Deserialize(ICustomDataInput reader)
        {
            Theme = reader.ReadByte();
        }
    }
}