//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Inventory.Items
{
    using Cookie.API.Protocol.Network.Types.Game.Inventory.Preset;
    using Cookie.API.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class InventoryContentAndPresetMessage : InventoryContentMessage
    {
        
        public new const uint ProtocolId = 6162;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<Preset> m_presets;
        
        public virtual List<Preset> Presets
        {
            get
            {
                return m_presets;
            }
            set
            {
                m_presets = value;
            }
        }
        
        private List<IdolsPreset> m_idolsPresets;
        
        public virtual List<IdolsPreset> IdolsPresets
        {
            get
            {
                return m_idolsPresets;
            }
            set
            {
                m_idolsPresets = value;
            }
        }
        
        public InventoryContentAndPresetMessage(List<Preset> presets, List<IdolsPreset> idolsPresets)
        {
            m_presets = presets;
            m_idolsPresets = idolsPresets;
        }
        
        public InventoryContentAndPresetMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_presets.Count)));
            int presetsIndex;
            for (presetsIndex = 0; (presetsIndex < m_presets.Count); presetsIndex = (presetsIndex + 1))
            {
                Preset objectToSend = m_presets[presetsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_idolsPresets.Count)));
            int idolsPresetsIndex;
            for (idolsPresetsIndex = 0; (idolsPresetsIndex < m_idolsPresets.Count); idolsPresetsIndex = (idolsPresetsIndex + 1))
            {
                IdolsPreset objectToSend = m_idolsPresets[idolsPresetsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            int presetsCount = reader.ReadUShort();
            int presetsIndex;
            m_presets = new System.Collections.Generic.List<Preset>();
            for (presetsIndex = 0; (presetsIndex < presetsCount); presetsIndex = (presetsIndex + 1))
            {
                Preset objectToAdd = new Preset();
                objectToAdd.Deserialize(reader);
                m_presets.Add(objectToAdd);
            }
            int idolsPresetsCount = reader.ReadUShort();
            int idolsPresetsIndex;
            m_idolsPresets = new System.Collections.Generic.List<IdolsPreset>();
            for (idolsPresetsIndex = 0; (idolsPresetsIndex < idolsPresetsCount); idolsPresetsIndex = (idolsPresetsIndex + 1))
            {
                IdolsPreset objectToAdd = new IdolsPreset();
                objectToAdd.Deserialize(reader);
                m_idolsPresets.Add(objectToAdd);
            }
        }
    }
}
