//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Fight.Challenge
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ChallengeTargetsListRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5614;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_challengeId;
        
        public virtual ushort ChallengeId
        {
            get
            {
                return m_challengeId;
            }
            set
            {
                m_challengeId = value;
            }
        }
        
        public ChallengeTargetsListRequestMessage(ushort challengeId)
        {
            m_challengeId = challengeId;
        }
        
        public ChallengeTargetsListRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_challengeId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_challengeId = reader.ReadVarUhShort();
        }
    }
}
