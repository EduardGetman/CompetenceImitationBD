using System.Collections.Generic;
namespace CompetenceMatrix.entity
{
    public class Requirement
    {
        public Requirement(int level, Competence competence)
        {
            Id = IDManager.RequirementId;
            Level = level;
            Competence = competence;
        }

        public int Id { get; set; }
        public int Level { get; set; }
        public Competence Competence { get; set; }

        //Создаёт новый экземпляр требования и возвращает его. Добавляет новое требование в базу данных
        //Не уверен что в возвращаемом объекте будут инициализированы все поля, например id

    }
}