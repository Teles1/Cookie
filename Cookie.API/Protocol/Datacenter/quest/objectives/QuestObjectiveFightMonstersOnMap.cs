using Cookie.API.Gamedata.D2o;
using System.Collections.Generic;
using Cookie.API.Gamedata.D2o.other;

namespace Cookie.API.Datacenter
{
    [D2oClass("QuestObjectiveFightMonstersOnMap")]
    public class QuestObjectiveFightMonstersOnMap : IDataObject
    {
		private const string MODULE = "QuestObjectiveFightMonstersOnMap";
		public int StepId;
		public int TypeId;
		public int MapId;
		public int Id;
		public int DialogId;
		public QuestObjectiveParameters Parameters;
		public Point Coords;
    }
}
