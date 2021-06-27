using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetenceMatrix
{
    static class IDManager
    {
        private static int competenceId = 0;
        private static int employeeId = 0;
        private static int knowledgeId = 0;
        private static int positionId = 0;
        private static int requirementId = 0;

        static public int CompetenceId { get => competenceId++;}
        public static int EmployeeId { get => employeeId++;}
        public static int KnowledgeId { get => knowledgeId++;}
        public static int PositionId { get => positionId++;}
        public static int RequirementId { get => requirementId++;}
    }
}
