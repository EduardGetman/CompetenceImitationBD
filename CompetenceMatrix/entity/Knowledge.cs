
using System;
using System.Collections.Generic;

namespace CompetenceMatrix.entity
{
    public class Knowledge
    {
        public Knowledge(int level, Competence competence)
        {
            Id = IDManager.KnowledgeId;
            Level = level;
            Competence = competence;
        }

        public int Id { get;private set; }
        public int Level { get; set; }
        public Competence Competence { get; set; }
    }
}