//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context
{
    using Cookie.API.Protocol.Network.Types.Game.Context.Roleplay;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class TaxCollectorStaticInformations : NetworkType
    {
        
        public const short ProtocolId = 147;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildInformations m_guildIdentity;
        
        public virtual GuildInformations GuildIdentity
        {
            get
            {
                return m_guildIdentity;
            }
            set
            {
                m_guildIdentity = value;
            }
        }
        
        private ushort m_firstNameId;
        
        public virtual ushort FirstNameId
        {
            get
            {
                return m_firstNameId;
            }
            set
            {
                m_firstNameId = value;
            }
        }
        
        private ushort m_lastNameId;
        
        public virtual ushort LastNameId
        {
            get
            {
                return m_lastNameId;
            }
            set
            {
                m_lastNameId = value;
            }
        }
        
        public TaxCollectorStaticInformations(GuildInformations guildIdentity, ushort firstNameId, ushort lastNameId)
        {
            m_guildIdentity = guildIdentity;
            m_firstNameId = firstNameId;
            m_lastNameId = lastNameId;
        }
        
        public TaxCollectorStaticInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_guildIdentity.Serialize(writer);
            writer.WriteVarUhShort(m_firstNameId);
            writer.WriteVarUhShort(m_lastNameId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_guildIdentity = new GuildInformations();
            m_guildIdentity.Deserialize(reader);
            m_firstNameId = reader.ReadVarUhShort();
            m_lastNameId = reader.ReadVarUhShort();
        }
    }
}
