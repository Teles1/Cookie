//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Guild.Tax
{
    using Cookie.API.Utils.IO;
    using Cookie.API.Protocol.Network.Types.Game.Look;
    using System.Collections.Generic;

    public class TaxCollectorInformations : NetworkType
    {
        
        public const short ProtocolId = 167;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private AdditionalTaxCollectorInformations m_additionalInfos;
        
        public virtual AdditionalTaxCollectorInformations AdditionalInfos
        {
            get
            {
                return m_additionalInfos;
            }
            set
            {
                m_additionalInfos = value;
            }
        }
        
        private EntityLook m_look;
        
        public virtual EntityLook Look
        {
            get
            {
                return m_look;
            }
            set
            {
                m_look = value;
            }
        }
        
        private List<TaxCollectorComplementaryInformations> m_complements;
        
        public virtual List<TaxCollectorComplementaryInformations> Complements
        {
            get
            {
                return m_complements;
            }
            set
            {
                m_complements = value;
            }
        }
        
        private int m_uniqueId;
        
        public virtual int UniqueId
        {
            get
            {
                return m_uniqueId;
            }
            set
            {
                m_uniqueId = value;
            }
        }
        
        private ushort m_firtNameId;
        
        public virtual ushort FirtNameId
        {
            get
            {
                return m_firtNameId;
            }
            set
            {
                m_firtNameId = value;
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
        
        private short m_worldX;
        
        public virtual short WorldX
        {
            get
            {
                return m_worldX;
            }
            set
            {
                m_worldX = value;
            }
        }
        
        private short m_worldY;
        
        public virtual short WorldY
        {
            get
            {
                return m_worldY;
            }
            set
            {
                m_worldY = value;
            }
        }
        
        private ushort m_subAreaId;
        
        public virtual ushort SubAreaId
        {
            get
            {
                return m_subAreaId;
            }
            set
            {
                m_subAreaId = value;
            }
        }
        
        private byte m_state;
        
        public virtual byte State
        {
            get
            {
                return m_state;
            }
            set
            {
                m_state = value;
            }
        }
        
        public TaxCollectorInformations(AdditionalTaxCollectorInformations additionalInfos, EntityLook look, List<TaxCollectorComplementaryInformations> complements, int uniqueId, ushort firtNameId, ushort lastNameId, short worldX, short worldY, ushort subAreaId, byte state)
        {
            m_additionalInfos = additionalInfos;
            m_look = look;
            m_complements = complements;
            m_uniqueId = uniqueId;
            m_firtNameId = firtNameId;
            m_lastNameId = lastNameId;
            m_worldX = worldX;
            m_worldY = worldY;
            m_subAreaId = subAreaId;
            m_state = state;
        }
        
        public TaxCollectorInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_additionalInfos.Serialize(writer);
            m_look.Serialize(writer);
            writer.WriteShort(((short)(m_complements.Count)));
            int complementsIndex;
            for (complementsIndex = 0; (complementsIndex < m_complements.Count); complementsIndex = (complementsIndex + 1))
            {
                TaxCollectorComplementaryInformations objectToSend = m_complements[complementsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteInt(m_uniqueId);
            writer.WriteVarUhShort(m_firtNameId);
            writer.WriteVarUhShort(m_lastNameId);
            writer.WriteShort(m_worldX);
            writer.WriteShort(m_worldY);
            writer.WriteVarUhShort(m_subAreaId);
            writer.WriteByte(m_state);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_additionalInfos = new AdditionalTaxCollectorInformations();
            m_additionalInfos.Deserialize(reader);
            m_look = new EntityLook();
            m_look.Deserialize(reader);
            int complementsCount = reader.ReadUShort();
            int complementsIndex;
            m_complements = new System.Collections.Generic.List<TaxCollectorComplementaryInformations>();
            for (complementsIndex = 0; (complementsIndex < complementsCount); complementsIndex = (complementsIndex + 1))
            {
                TaxCollectorComplementaryInformations objectToAdd = ProtocolTypeManager.GetInstance<TaxCollectorComplementaryInformations>((short)reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_complements.Add(objectToAdd);
            }
            m_uniqueId = reader.ReadInt();
            m_firtNameId = reader.ReadVarUhShort();
            m_lastNameId = reader.ReadVarUhShort();
            m_worldX = reader.ReadShort();
            m_worldY = reader.ReadShort();
            m_subAreaId = reader.ReadVarUhShort();
            m_state = reader.ReadByte();
        }
    }
}
