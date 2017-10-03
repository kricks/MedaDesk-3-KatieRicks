using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_KatieRicks
{
    class Desk
    {
        public int deskWdith { get; set; }
        public int deskDepth { get; set; }
        public int numOfDrawers { get; set; }

    
        //enum
        public enum deskMaterial
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }
        public deskMaterial material { get; set; }
    }
}
