using CompetenceMatrix.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetenceMatrix
{
    static class ModelKeeper
    {

        static Random Random;
        public static List<Competence> competences;
        static public void inisializeCompetence()
        {
            Random = new Random(DateTime.Now.Millisecond);
            if (competences is null)
            {
                competences = new List<Competence>();
                competences.Add(new Competence("Английский"));
                competences.Add(new Competence("Git"));
                competences.Add(new Competence("C#"));
                competences.Add(new Competence("ASP.NET"));
                competences.Add(new Competence("CSS"));
                competences.Add(new Competence(".NET Core"));
                competences.Add(new Competence("MS SQL Server"));
                competences.Add(new Competence("Transact-SQL"));
                competences.Add(new Competence("Паттерны проектирования"));
                competences.Add(new Competence("jQuery"));
                competences.Add(new Competence("JavaScript"));
                competences.Add(new Competence("MySQL"));
                competences.Add(new Competence("CSS3"));
                competences.Add(new Competence("HTML5"));
                competences.Add(new Competence("PHP"));
                competences.Add(new Competence("Bitrix"));
                competences.Add(new Competence("PostgreSQL"));
                competences.Add(new Competence("ООП"));
                competences.Add(new Competence("MVC"));
                competences.Add(new Competence("Symfony"));
            }
        }
        static string getFullName()
        {
            List<string> LastNames = new List<string>();
            LastNames.Add("Климов ");
            LastNames.Add("Воробьев ");
            LastNames.Add("Петров ");
            LastNames.Add("Ермаков ");
            LastNames.Add("Шевелев ");
            LastNames.Add("Иванов ");
            LastNames.Add("Соколов ");
            LastNames.Add("Горбачев ");
            LastNames.Add("Лебедев ");
            LastNames.Add("Гаврилов ");
            LastNames.Add("Нестеров ");
            LastNames.Add("Архипов ");
            LastNames.Add("Волков ");
            LastNames.Add("Измайлов ");
            LastNames.Add("Степанов ");
            LastNames.Add("Филимонов ");
            LastNames.Add("Соловьев ");
            LastNames.Add("Соколов ");
            LastNames.Add("Сазонов ");
            LastNames.Add("Краснов ");
            LastNames.Add("Иванов ");
            List<string> FerstNames = new List<string>();
            FerstNames.Add("Андрей ");
            FerstNames.Add("Иван ");
            FerstNames.Add("Роман ");
            FerstNames.Add("Дмитрий ");
            FerstNames.Add("Роман ");
            FerstNames.Add("Тимур ");
            FerstNames.Add("Максим ");
            FerstNames.Add("Леонид ");
            FerstNames.Add("Ярослав ");
            FerstNames.Add("Михаил ");
            FerstNames.Add("Роман ");
            FerstNames.Add("Илья ");
            FerstNames.Add("Дмитрий ");
            FerstNames.Add("Илья ");
            FerstNames.Add("Аркадий ");
            FerstNames.Add("Лев ");
            FerstNames.Add("Борис ");
            List<string> MiddleName = new List<string>();
            MiddleName.Add("Иванович ");
            MiddleName.Add("Владиславович ");
            MiddleName.Add("Тимофеевич ");
            MiddleName.Add("Камильевич ");
            MiddleName.Add("Максимович ");
            MiddleName.Add("Александрович ");
            MiddleName.Add("Максимович ");
            MiddleName.Add("Михайлович ");
            MiddleName.Add("Вячеславович ");
            MiddleName.Add("Александрович ");
            MiddleName.Add("Романович ");
            MiddleName.Add("Сергеевич ");
            MiddleName.Add("Даниилович ");
            return LastNames[Random.Next(0, LastNames.Count - 1)] +
                FerstNames[Random.Next(0, FerstNames.Count - 1)] +
                MiddleName[Random.Next(0, MiddleName.Count - 1)];
        }
        static public Employee GetEmployee()
        {
            List<Knowledge> knowledges = new List<Knowledge>();
            int ComepetnceIndex = Random.Next(0, competences.Count - 1);
            for (int i = 0; i < Random.Next(7,15); i++)
            {
                ComepetnceIndex = ComepetnceIndex < competences.Count - 1 ? ComepetnceIndex + 1 : 0;
                knowledges.Add(new Knowledge(Random.Next(2, 5), competences[ComepetnceIndex]));
            }
            return new Employee(getFullName(), knowledges.ToArray());
        }
        static int PositionIterator = 0;
        static string getPositionName()
        {
            List<string> PosionsName = new List<string>();
            PosionsName.Add("Junior .Net Developer");
            PosionsName.Add("Junior Java Developer");
            PosionsName.Add("Middle .Net Developer");
            PosionsName.Add("Middle Java Developer");
            PositionIterator = PositionIterator < 3 ? PositionIterator+1 : 0;
            return PosionsName[PositionIterator];
        }
        static public Position GetPosition()
        {
            List<Requirement> requirements  = new List<Requirement>();
            int ComepetnceIndex = Random.Next(0, competences.Count - 1);
            for (int i = 0; i < Random.Next(4, 6); i++)
            {
                ComepetnceIndex = ComepetnceIndex < competences.Count-1 ? ComepetnceIndex+1 : 0;
                requirements.Add(new Requirement(Random.Next(1, 3), competences[ComepetnceIndex]));
            }
            return new Position(getPositionName(), requirements.ToArray());
        }
    }
}
