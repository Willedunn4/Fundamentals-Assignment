using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundementals_Assignment
{
    public class GameInfo
    {
        public GameInfo()
        {
            MetaData = new List<Info>();
            Info info1 = new Info();
            info1.Id = 0;
            info1.Name = "Monkey Island";
            info1.Genre = "Point & Click";
            info1.MapNames = new string[] { "Guybrush Mansion", "LeChuck Hideout", "Melee Island", "SCUMM Bar" };
            MetaData.Add(info1);
            Info info2 = new Info();
            info2.Id = 1;
            info2.Name = "Mario Odyssey";
            info2.Genre = "Adventure";
            info2.MapNames = new string[] { "Mushroom Kingdom", "Cap Kingdom", "Cloud Kingdom", "Snow Kingdom" };
            MetaData.Add(info2);
            Info info3 = new Info();
            info3.Id = 2;
            info3.Name = "Final Fantasy 10";
            info3.Genre = "Adventure";
            info3.MapNames = new string[] { "Besaid Island", "Bevelle", "Calm Lands", "Baaj Temple" };
            MetaData.Add(info3);
            Info info4 = new Info();
            info4.Id = 3;
            info4.Name = "Valkyra 4";
            info4.Genre = "Tactical RPG";
            info4.MapNames = new string[] { "Battle of Siegval", "Other Kai", "Azure Flame", "Midnight Run" };
            MetaData.Add(info4);
        }

        public List<Info> MetaData { get; set; }
    }


}
