using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFF_Character_Simulator
{
    class Character
    {
        public enum Sex { Male, Female };

        private Sex sex;
        public FClass fclass;
        public Dictionary<string, int> stats;
        public Dictionary<Equipment.Type, Equipment> gear;
        public Character()
        {
            stats = new Dictionary<string, int>();
            gear = new Dictionary<Equipment.Type, Equipment>();
            sex = Sex.Female;
        }
        public void LoadDefaultStats(string rf)
        {
            
        }
    }
}
