using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetenceMatrix.ImplementationLogic
{
    class Skill
    {
        string name;
        int level;

        public Skill(string name, int level)
        {
            this.name = name;
            this.level = level;
        }


        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
    }
}
