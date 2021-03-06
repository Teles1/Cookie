using Cookie.IO;
using Cookie.Protocol.Network.Types;
using System;

namespace Cookie.Protocol.Network.Messages
{
    public class ExchangeObjectAddedMessage : ExchangeObjectMessage
    {
        public new const uint ProtocolId = 5516;
        public override uint MessageID { get { return ProtocolId; } }

        public ObjectItem Object_;

        public ExchangeObjectAddedMessage(): base()
        {
        }

        public ExchangeObjectAddedMessage(
            bool remote,
            ObjectItem object_
        ): base(
            remote
        )
        {
            Object_ = object_;
        }

        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            Object_.Serialize(writer);
        }

        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            Object_ = new ObjectItem();
            Object_.Deserialize(reader);
        }
    }
}