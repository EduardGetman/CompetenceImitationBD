using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompetenceMatrix.entity;

namespace CompetenceMatrix.ImplementationLogic
{
    //TODO: Реализовать метод постраения матрицы компетенций возвращающий DataTable
    public class MatrixCompetence
    {
        Position position;
        Employee[] suitableEmployees;
        Employee[] unsuitableEmployees;
        Employee mostSuitableEmployees;
        ModelCompetence bestIndicators;
        ModelCompetence averageIndicators;

        public string[] Heders;
        public List<object[]> Cells;
        string[] getHeders()
        {
            List<string> result = new List<string>();
            result.Add(position.Name);
            result.Add(mostSuitableEmployees.FullName + "(Лучший кандидат)");
            foreach (var item in suitableEmployees)
            {
                result.Add(item.FullName + "(Подходит)");
            }
            foreach (var item in unsuitableEmployees)
            {
                result.Add(item.FullName + "(Не подходит)");
            }
            result.Add(bestIndicators.Name);
            result.Add(averageIndicators.Name);
            return result.ToArray();
        }

        private object[] GetRowValuesByRequirements(Requirement requirement)
        {
            List<object> result = new List<object>();
            result.Add(requirement.Level);
            result.Add(mostSuitableEmployees.GetKnowledgeByCompetence(requirement.Competence).Level);
            foreach (var item in suitableEmployees)
            {
                Knowledge knowledge = item.GetKnowledgeByCompetence(requirement.Competence);
                result.Add(knowledge is null ? 0 : knowledge.Level);
            }
            foreach (var item in unsuitableEmployees)
            {
                Knowledge knowledge = item.GetKnowledgeByCompetence(requirement.Competence);
                result.Add(knowledge is null ? 0 : knowledge.Level);
            }
            result.Add(bestIndicators.Skills[bestIndicators.getIndexSkilsByName(requirement.Competence.Name)].Level);
            result.Add(averageIndicators.Skills[averageIndicators.getIndexSkilsByName(requirement.Competence.Name)].Level);
            return result.ToArray();
        }
        public MatrixCompetence(Position position, Employee[] employees)
        {
            this.position = position;
            suitableEmployees = getSuitableEmployees(position, employees);
            unsuitableEmployees = getUnsuitableEmployees(position, employees);
            mostSuitableEmployees = getMostSuitableEmployees(position, employees);
            bestIndicators = getBestIndicators(position, employees);
            averageIndicators = getAverageIndicators(position, employees);

            Heders = getHeders();
            Cells = new List<object[]>();
            foreach (var item in position.Requirements)
            {
                Cells.Add(GetRowValuesByRequirements(item));
            }
        }
        private Employee[] getSuitableEmployees(Position position, Employee[] employees)
        {
            List<Employee> result = new List<Employee>();
            foreach (var item in employees)
            {
                if (position.IsEmployeeSuitable(item))
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
        private Employee getMostSuitableEmployees(Position position, Employee[] employees)
        {
            Employee result = employees[0];
            foreach (var item in employees)
            {
                if (position.IsEmployeeSuitable(item) && getSummSkils(position, result) > getSummSkils(position, item))
                {
                    result = item;
                }
            }
            return result;
        }

        private int getSummSkils(Position position, Employee employee)
        {
            int result = 0;
            foreach (var item in employee.Knowledges)
            {
                if (position.CompetenceIsIncluded(item.Competence))
                {
                    result += item.Level;
                }
            }
            return result;
        }

        private Employee[] getUnsuitableEmployees(Position position, Employee[] employees)
        {
            List<Employee> result = new List<Employee>();
            foreach (var item in employees)
            {
                if (!position.IsEmployeeSuitable(item))
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
        private ModelCompetence getBestIndicators(Position position, Employee[] employees)
        {
            ModelCompetence result = new ModelCompetence("Лучшие показатели", position);
            foreach (var item in position.Requirements)
            {
                int index = result.getIndexSkilsByName(item.Competence.Name);
                result.Skills[index].Level = getBestIndicatorByCompetence(employees,item.Competence);
            }
            return result;
        }
        private int getBestIndicatorByCompetence(Employee[] employee, Competence competence)
        {
            int result = 0;
            foreach (var item in employee)
            {
                Knowledge knowledge = item.GetKnowledgeByCompetence(competence);
                if (!(knowledge is null) && result < knowledge.Level)
                {
                    result = knowledge.Level;
                }
            }
            return result;
        }
        private ModelCompetence getAverageIndicators(Position position, Employee[] employees)
        {
            ModelCompetence result = new ModelCompetence("Средние показатели", position);
            foreach (var item in position.Requirements)
            {
                int index = result.getIndexSkilsByName(item.Competence.Name);
                result.Skills[index].Level = getAverageIndicatorByCompetence(employees, item.Competence);
            }
            return result;
        }
        private int getAverageIndicatorByCompetence(Employee[] employee, Competence competence)
        {
            int result = 0;
            foreach (var item in employee)
            {
                Knowledge knowledge = item.GetKnowledgeByCompetence(competence);
                if (!(knowledge is null) && result < knowledge.Level)
                {
                    result += (knowledge is null) ?  0: knowledge.Level;
                }
            }
            return result/employee.Length;
        }
    }
}
