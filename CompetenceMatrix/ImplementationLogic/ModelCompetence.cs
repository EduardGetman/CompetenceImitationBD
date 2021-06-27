using CompetenceMatrix.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetenceMatrix.ImplementationLogic
{
    class ModelCompetence
    {
        string name;
        List<Skill> skills;

        public ModelCompetence(string name)
        {
            this.name = name;
            skills = new List<Skill>();
        }

        public ModelCompetence(string name, List<Skill> skills)
        {
            this.name = name;
            this.skills = skills;
        }
        public ModelCompetence(string name, Position position)
        {
            this.name = name;
            skills = new List<Skill>();
            foreach (var item in position.Requirements)
            {
                skills.Add(new Skill(item.Competence.Name, 0));
            }
        }
        public int getIndexSkilsByName(string Name)
        {
            for (int i = 0; i < skills.Count; i++)
            {
                if (String.Equals(skills[i].Name, Name))
                {
                    return i;
                }                
            }
            return -1;
        }

        public string Name { get => name; set => name = value; }
        internal List<Skill> Skills { get => skills; set => skills = value; }
    }
}
