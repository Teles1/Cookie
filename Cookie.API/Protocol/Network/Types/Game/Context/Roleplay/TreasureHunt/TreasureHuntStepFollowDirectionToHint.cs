//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Roleplay.TreasureHunt
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class TreasureHuntStepFollowDirectionToHint : TreasureHuntStep
    {
        
        public new const short ProtocolId = 472;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_direction;
        
        public virtual byte Direction
        {
            get
            {
                return m_direction;
            }
            set
            {
                m_direction = value;
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
        
        public TreasureHuntStepFollowDirectionToHint(byte direction, ushort npcId)
        {
            m_direction = direction;
            m_npcId = npcId;
        }
        
        public TreasureHuntStepFollowDirectionToHint()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_direction);
            writer.WriteVarUhShort(m_npcId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_direction = reader.ReadByte();
            m_npcId = reader.ReadVarUhShort();
        }
    }
}
