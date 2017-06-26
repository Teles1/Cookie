//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.TreasureHunt
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class TreasureHuntRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6488;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_questLevel;
        
        public virtual sbyte QuestLevel
        {
            get
            {
                return m_questLevel;
            }
            set
            {
                m_questLevel = value;
            }
        }
        
        private byte m_questType;
        
        public virtual byte QuestType
        {
            get
            {
                return m_questType;
            }
            set
            {
                m_questType = value;
            }
        }
        
        public TreasureHuntRequestMessage(sbyte questLevel, byte questType)
        {
            m_questLevel = questLevel;
            m_questType = questType;
        }
        
        public TreasureHuntRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteSByte(m_questLevel);
            writer.WriteByte(m_questType);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_questLevel = reader.ReadSByte();
            m_questType = reader.ReadByte();
        }
    }
}
