
using System;
using System.Collections.Generic;

namespace CompetenceMatrix.entity
{
    public class Position
    {
        public Position(string name, Requirement[] requirements)
        {
            Id = IDManager.PositionId;
            Name = name;
            Requirements = new List<Requirement>();
            Requirements.AddRange(requirements);
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public List<Requirement> Requirements { get; set; }

        // Возвращает true если работник подходит по требованиям
        public bool IsEmployeeSuitable(Employee employee)
        {
            foreach (var item in Requirements)
            {
                if (!employee.MeetRequirement(item))
                {
                    return false;
                }
            }
            return true;
        }
        public bool CompetenceIsIncluded(Competence competence)
        {
            foreach (var item in Requirements)
            {
                if (item.Competence.Id == competence.Id)
                {
                    return false;
                }
            }
            return true;
        }

        //Создаёт новый окземпляр должности и возвращает его. Добавляет новоую должность в базу данных
        //Не уверен что в возвращаемом объекте будут инициализированы все поля, например id
        
        //TODO
        public static Position UpdatePosition(string name, Requirement[] knowledges)
        {
            throw new NotImplementedException();
        }
        public static bool DeletePosition(int id)
        {
            throw new NotImplementedException();
        }
    }
}