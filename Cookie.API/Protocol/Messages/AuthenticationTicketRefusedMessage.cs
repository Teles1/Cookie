using Cookie.API.Utils.IO;
using Cookie.API.Protocol.Enums;
using System.Collections.Generic;
using Cookie.API.Protocol.Network.Messages;
using Cookie.API.Protocol.Network.Types;

namespace Cookie.API.Protocol.Network.Messages
{

    public class AuthenticationTicketRefusedMessage : NetworkMessage
    {
        public const ushort ProtocolId = 112;

        public override ushort MessageID => ProtocolId;

        public AuthenticationTicketRefusedMessage() { }

        public override void Serialize(IDataWriter writer)
        {
        }

        public override void Deserialize(IDataReader reader)
        {
        }
    }
}
