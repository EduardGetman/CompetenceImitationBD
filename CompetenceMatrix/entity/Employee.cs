using System;
using System.Collections.Generic;

namespace CompetenceMatrix.entity
{
    public class Employee
    {
        public Employee(string fullName, Knowledge[] knowledges)
        {
            Id = IDManager.EmployeeId;
            FullName = fullName;
            Knowledges = knowledges;
        }

        public int Id { get; set; }

        public String FullName { get; set; }
        public Position Position { get; set; }
        public Knowledge[] Knowledges { get; set; }
        //Возвращает true, если Position не null TODO: Реализовать свойство get
        //Реализовано
        public bool HoldPosition()
        {
            if (Position != null)
                return true;
            return false;
        }

        //TODO: Когда появиться сылка на должность реализовать.
        //Если должность назначена вернуть название, если отсутсвует вернуть "Должность отсутствует"
        //Реализовано
        public string PositionName()
        {
            if (Position == null)
                return "Должность отсутствует";
            else
                return Position.Name;
        }

        // Проверяет соотвуетсвует ли сотрудник требованию
        public bool MeetRequirement(Requirement requirement)
        {
            Knowledge RequiredKnowledge = GetKnowledgeByCompetence(requirement.Competence);
            if (RequiredKnowledge is null)
            {
                return false;
            }
            return RequiredKnowledge.Level >= requirement.Level;
        }

        //Создаёт новый окземпляр сотрудника и возвращает его. Добавляет нового сотрудника в базу данных
        //Не уверен что в возвращаемом объекте будут инициализированы все поля, например id

        public Knowledge GetKnowledgeByCompetence(Competence competence)
        {
            foreach (var item in Knowledges)
            {
                if (item.Competence.Id == competence.Id)
                {
                    return item;
                }
            }
            return null;
        }
        public static Employee UpdateEmployee(string name, Knowledge[] knowledges, Position position)
        {
            throw new NotImplementedException();
        }
        public static bool DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}