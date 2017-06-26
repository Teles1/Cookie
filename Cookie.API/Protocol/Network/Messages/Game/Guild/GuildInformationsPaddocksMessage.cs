//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Guild
{
    using Cookie.API.Protocol.Network.Types.Game.Paddock;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GuildInformationsPaddocksMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5959;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<PaddockContentInformations> m_paddocksInformations;
        
        public virtual List<PaddockContentInformations> PaddocksInformations
        {
            get
            {
                return m_paddocksInformations;
            }
            set
            {
                m_paddocksInformations = value;
            }
        }
        
        private byte m_nbPaddockMax;
        
        public virtual byte NbPaddockMax
        {
            get
            {
                return m_nbPaddockMax;
            }
            set
            {
                m_nbPaddockMax = value;
            }
        }
        
        public GuildInformationsPaddocksMessage(List<PaddockContentInformations> paddocksInformations, byte nbPaddockMax)
        {
            m_paddocksInformations = paddocksInformations;
            m_nbPaddockMax = nbPaddockMax;
        }
        
        public GuildInformationsPaddocksMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_paddocksInformations.Count)));
            int paddocksInformationsIndex;
            for (paddocksInformationsIndex = 0; (paddocksInformationsIndex < m_paddocksInformations.Count); paddocksInformationsIndex = (paddocksInformationsIndex + 1))
            {
                PaddockContentInformations objectToSend = m_paddocksInformations[paddocksInformationsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteByte(m_nbPaddockMax);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int paddocksInformationsCount = reader.ReadUShort();
            int paddocksInformationsIndex;
            m_paddocksInformations = new System.Collections.Generic.List<PaddockContentInformations>();
            for (paddocksInformationsIndex = 0; (paddocksInformationsIndex < paddocksInformationsCount); paddocksInformationsIndex = (paddocksInformationsIndex + 1))
            {
                PaddockContentInformations objectToAdd = new PaddockContentInformations();
                objectToAdd.Deserialize(reader);
                m_paddocksInformations.Add(objectToAdd);
            }
            m_nbPaddockMax = reader.ReadByte();
        }
    }
}
