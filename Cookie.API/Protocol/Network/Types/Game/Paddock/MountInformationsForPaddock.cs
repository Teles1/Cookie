//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Paddock
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class MountInformationsForPaddock : NetworkType
    {
        
        public const short ProtocolId = 184;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_modelId;
        
        public virtual ushort ModelId
        {
            get
            {
                return m_modelId;
            }
            set
            {
                m_modelId = value;
            }
        }
        
        private string m_name;
        
        public virtual string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }
        
        private string m_ownerName;
        
        public virtual string OwnerName
        {
            get
            {
                return m_ownerName;
            }
            set
            {
                m_ownerName = value;
            }
        }
        
        public MountInformationsForPaddock(ushort modelId, string name, string ownerName)
        {
            m_modelId = modelId;
            m_name = name;
            m_ownerName = ownerName;
        }
        
        public MountInformationsForPaddock()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_modelId);
            writer.WriteUTF(m_name);
            writer.WriteUTF(m_ownerName);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_modelId = reader.ReadVarUhShort();
            m_name = reader.ReadUTF();
            m_ownerName = reader.ReadUTF();
        }
    }
}
