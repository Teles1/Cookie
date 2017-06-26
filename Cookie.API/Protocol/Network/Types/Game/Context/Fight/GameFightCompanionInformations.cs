//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Fight
{
    using Cookie.API.Protocol.Network.Types.Game.Look;
    using Cookie.API.Protocol.Network.Types.Game.Context;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GameFightCompanionInformations : GameFightFighterInformations
    {
        
        public new const short ProtocolId = 450;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_companionGenericId;
        
        public virtual byte CompanionGenericId
        {
            get
            {
                return m_companionGenericId;
            }
            set
            {
                m_companionGenericId = value;
            }
        }
        
        private sbyte m_level;
        
        public virtual sbyte Level
        {
            get
            {
                return m_level;
            }
            set
            {
                m_level = value;
            }
        }
        
        private double m_masterId;
        
        public virtual double MasterId
        {
            get
            {
                return m_masterId;
            }
            set
            {
                m_masterId = value;
            }
        }
        
        public GameFightCompanionInformations(byte companionGenericId, sbyte level, double masterId)
        {
            m_companionGenericId = companionGenericId;
            m_level = level;
            m_masterId = masterId;
        }
        
        public GameFightCompanionInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_companionGenericId);
            writer.WriteSByte(m_level);
            writer.WriteDouble(m_masterId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_companionGenericId = reader.ReadByte();
            m_level = reader.ReadSByte();
            m_masterId = reader.ReadDouble();
        }
    }
}
