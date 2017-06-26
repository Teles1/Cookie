﻿using Cookie.API.Utils.IO;

namespace Cookie.API.Protocol.Network.Messages.Game.Initialization
{
    public class CharacterLoadingCompleteMessage : NetworkMessage
    {
        public const uint ProtocolId = 6471;

        public override uint MessageID => ProtocolId;

        public override void Serialize(ICustomDataOutput writer)
        {
            //
        }

        public override void Deserialize(ICustomDataInput reader)
        {
            //
        }
    }
}