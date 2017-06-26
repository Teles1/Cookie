//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Roleplay.Quest
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class QuestObjectiveInformationsWithCompletion : QuestObjectiveInformations
    {
        
        public new const short ProtocolId = 386;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_curCompletion;
        
        public virtual ushort CurCompletion
        {
            get
            {
                return m_curCompletion;
            }
            set
            {
                m_curCompletion = value;
            }
        }
        
        private ushort m_maxCompletion;
        
        public virtual ushort MaxCompletion
        {
            get
            {
                return m_maxCompletion;
            }
            set
            {
                m_maxCompletion = value;
            }
        }
        
        public QuestObjectiveInformationsWithCompletion(ushort curCompletion, ushort maxCompletion)
        {
            m_curCompletion = curCompletion;
            m_maxCompletion = maxCompletion;
        }
        
        public QuestObjectiveInformationsWithCompletion()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhShort(m_curCompletion);
            writer.WriteVarUhShort(m_maxCompletion);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_curCompletion = reader.ReadVarUhShort();
            m_maxCompletion = reader.ReadVarUhShort();
        }
    }
}
