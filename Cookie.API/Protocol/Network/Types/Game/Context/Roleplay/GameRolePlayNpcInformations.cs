//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Roleplay
{
    using Cookie.API.Protocol.Network.Types.Game.Look;
    using Cookie.API.Protocol.Network.Types.Game.Context;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GameRolePlayNpcInformations : GameRolePlayActorInformations
    {
        
        public new const short ProtocolId = 156;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_npcId;
        
        public virtual ushort NpcId
        {
            get
            {
                return m_npcId;
            }
            set
            {
                m_npcId = value;
            }
        }
        
        private bool m_sex;
        
        public virtual bool Sex
        {
            get
            {
                return m_sex;
            }
            set
            {
                m_sex = value;
            }
        }
        
        private ushort m_specialArtworkId;
        
        public virtual ushort SpecialArtworkId
        {
            get
            {
                return m_specialArtworkId;
            }
            set
            {
                m_specialArtworkId = value;
            }
        }
        
        public GameRolePlayNpcInformations(ushort npcId, bool sex, ushort specialArtworkId)
        {
            m_npcId = npcId;
            m_sex = sex;
            m_specialArtworkId = specialArtworkId;
        }
        
        public GameRolePlayNpcInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhShort(m_npcId);
            writer.WriteBoolean(m_sex);
            writer.WriteVarUhShort(m_specialArtworkId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_npcId = reader.ReadVarUhShort();
            m_sex = reader.ReadBoolean();
            m_specialArtworkId = reader.ReadVarUhShort();
        }
    }
}
