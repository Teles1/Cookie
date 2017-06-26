//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Data.Items.Effects
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ObjectEffectDice : ObjectEffect
    {
        
        public new const short ProtocolId = 73;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_diceNum;
        
        public virtual ushort DiceNum
        {
            get
            {
                return m_diceNum;
            }
            set
            {
                m_diceNum = value;
            }
        }
        
        private ushort m_diceSide;
        
        public virtual ushort DiceSide
        {
            get
            {
                return m_diceSide;
            }
            set
            {
                m_diceSide = value;
            }
        }
        
        private ushort m_diceConst;
        
        public virtual ushort DiceConst
        {
            get
            {
                return m_diceConst;
            }
            set
            {
                m_diceConst = value;
            }
        }
        
        public ObjectEffectDice(ushort diceNum, ushort diceSide, ushort diceConst)
        {
            m_diceNum = diceNum;
            m_diceSide = diceSide;
            m_diceConst = diceConst;
        }
        
        public ObjectEffectDice()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhShort(m_diceNum);
            writer.WriteVarUhShort(m_diceSide);
            writer.WriteVarUhShort(m_diceConst);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_diceNum = reader.ReadVarUhShort();
            m_diceSide = reader.ReadVarUhShort();
            m_diceConst = reader.ReadVarUhShort();
        }
    }
}
