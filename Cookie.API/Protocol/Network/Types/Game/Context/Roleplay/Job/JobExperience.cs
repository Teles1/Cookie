//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Roleplay.Job
{
    using Cookie.API.Utils.IO;


    public class JobExperience : NetworkType
    {
        
        public const short ProtocolId = 98;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_jobId;
        
        public virtual byte JobId
        {
            get
            {
                return m_jobId;
            }
            set
            {
                m_jobId = value;
            }
        }
        
        private byte m_jobLevel;
        
        public virtual byte JobLevel
        {
            get
            {
                return m_jobLevel;
            }
            set
            {
                m_jobLevel = value;
            }
        }
        
        private ulong m_jobXP;
        
        public virtual ulong JobXP
        {
            get
            {
                return m_jobXP;
            }
            set
            {
                m_jobXP = value;
            }
        }
        
        private ulong m_jobXpLevelFloor;
        
        public virtual ulong JobXpLevelFloor
        {
            get
            {
                return m_jobXpLevelFloor;
            }
            set
            {
                m_jobXpLevelFloor = value;
            }
        }
        
        private ulong m_jobXpNextLevelFloor;
        
        public virtual ulong JobXpNextLevelFloor
        {
            get
            {
                return m_jobXpNextLevelFloor;
            }
            set
            {
                m_jobXpNextLevelFloor = value;
            }
        }
        
        public JobExperience(byte jobId, byte jobLevel, ulong jobXP, ulong jobXpLevelFloor, ulong jobXpNextLevelFloor)
        {
            m_jobId = jobId;
            m_jobLevel = jobLevel;
            m_jobXP = jobXP;
            m_jobXpLevelFloor = jobXpLevelFloor;
            m_jobXpNextLevelFloor = jobXpNextLevelFloor;
        }
        
        public JobExperience()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteByte(m_jobId);
            writer.WriteByte(m_jobLevel);
            writer.WriteVarUhLong(m_jobXP);
            writer.WriteVarUhLong(m_jobXpLevelFloor);
            writer.WriteVarUhLong(m_jobXpNextLevelFloor);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_jobId = reader.ReadByte();
            m_jobLevel = reader.ReadByte();
            m_jobXP = reader.ReadVarUhLong();
            m_jobXpLevelFloor = reader.ReadVarUhLong();
            m_jobXpNextLevelFloor = reader.ReadVarUhLong();
        }
    }
}
