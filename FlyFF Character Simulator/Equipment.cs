using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFF_Character_Simulator
{
    class Equipment
    {
        public enum Type { 
            IK3_SHIELD,
            IK3_HELMET, 
            IK3_SUIT,
            IK3_GAUNTLET,
            IK3_BOOTS,
            IK3_HAT,
            IK3_MASK,
            IK3_SHOES,
            IK3_CLOAK,
            IK3_CLOTH,
            IK3_GLOVE,
            IK3_SWD,
            IK3_AXE,
            IK3_CHEERSTICK,
            IK3_KNUCKLEHAMMER,
            IK3_WAND,
            IK3_STAFF,
            IK3_THSWD,
            IK3_THAXE,
            IK3_YOYO,
            IK3_BOW,
            IK3_YOBO,
            IK3_CROSSBOW,
            IK3_EARRING,
            IK3_NECKLACE,
            IK3_RING
        };

        public static Dictionary<string, Equipment> allGear;

        public Type type;
        public Dictionary<string, int> effects;
        public Dictionary<string, int> awakenings;
        public FClass.Job job;
        public Character.Sex sex;
        public Boolean ultimate;
        public string id;
        public string sid;
        public Equipment()
        {
            effects = new Dictionary<string, int>();
            awakenings = new Dictionary<string, int>();
        }
    }
}
