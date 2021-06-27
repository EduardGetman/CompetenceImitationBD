using System;
using System.Collections.Generic;

namespace CompetenceMatrix.entity
{
    public class Competence
    {
        public Competence(string name)
        {
            Id = IDManager.CompetenceId;
            Name = name;
        }

        public int Id { get; set; }
        public String Name { get; set; }
    }
}