using Cookie.IO;
using System;

namespace Cookie.Protocol.Network.Messages
{
    public class PartyLocateMembersRequestMessage : AbstractPartyMessage
    {
        public new const uint ProtocolId = 5587;
        public override uint MessageID { get { return ProtocolId; } }

        public PartyLocateMembersRequestMessage(): base()
        {
        }

        public PartyLocateMembersRequestMessage(
            int partyId
        ): base(
            partyId
        )
        {
        }

        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
        }

        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
        }
    }
}