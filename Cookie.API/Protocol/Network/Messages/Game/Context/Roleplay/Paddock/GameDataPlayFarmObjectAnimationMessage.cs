//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Paddock
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GameDataPlayFarmObjectAnimationMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6026;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_cellId;
        
        public virtual List<System.UInt16> CellId
        {
            get
            {
                return m_cellId;
            }
            set
            {
                m_cellId = value;
            }
        }
        
        public GameDataPlayFarmObjectAnimationMessage(List<System.UInt16> cellId)
        {
            m_cellId = cellId;
        }
        
        public GameDataPlayFarmObjectAnimationMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_cellId.Count)));
            int cellIdIndex;
            for (cellIdIndex = 0; (cellIdIndex < m_cellId.Count); cellIdIndex = (cellIdIndex + 1))
            {
                writer.WriteVarUhShort(m_cellId[cellIdIndex]);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int cellIdCount = reader.ReadUShort();
            int cellIdIndex;
            m_cellId = new System.Collections.Generic.List<ushort>();
            for (cellIdIndex = 0; (cellIdIndex < cellIdCount); cellIdIndex = (cellIdIndex + 1))
            {
                m_cellId.Add(reader.ReadVarUhShort());
            }
        }
    }
}
