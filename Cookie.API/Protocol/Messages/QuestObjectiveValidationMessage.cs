using Cookie.API.Utils.IO;
using Cookie.API.Protocol.Enums;
using System.Collections.Generic;
using Cookie.API.Protocol.Network.Messages;
using Cookie.API.Protocol.Network.Types;

namespace Cookie.API.Protocol.Network.Messages
{

    public class QuestObjectiveValidationMessage : NetworkMessage
    {
        public const ushort ProtocolId = 6085;

        public override ushort MessageID => ProtocolId;

        public ushort QuestId { get; set; }
        public ushort ObjectiveId { get; set; }
        public QuestObjectiveValidationMessage() { }

        public QuestObjectiveValidationMessage( ushort QuestId, ushort ObjectiveId ){
            this.QuestId = QuestId;
            this.ObjectiveId = ObjectiveId;
        }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(QuestId);
            writer.WriteVarUhShort(ObjectiveId);
        }

        public override void Deserialize(IDataReader reader)
        {
            QuestId = reader.ReadVarUhShort();
            ObjectiveId = reader.ReadVarUhShort();
        }
    }
}
