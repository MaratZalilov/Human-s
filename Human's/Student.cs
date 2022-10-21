using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_s
{
    internal class Student:Human
    {
        private string _workPlace;
        private string _workExp;

        public Student(string name, string surName)
        {
            _name = name;
            _surName = surName;
        }
        public override void ChangeWork()
        {

        }

        public override void Work()
        {
            Random Random = new Random();
            int RandomWork = Random.Next(1, 4);
            switch (RandomWork)
            {
                case 1:
                    _workPlace = "НТТ";
                    break;
                case 2:
                    _workPlace = "School 4";
                    break;
                case 3:
                    _workPlace = "61 Technical College";
                    break;
                case 4:
                    _workPlace = "School 1";
                    break;
            }

            Random Random1 = new Random();
            int RandomExp = Random1.Next(1, 4);
            switch (RandomExp)
            {
                case 1:
                    _workExp = "3 года";
                    break;
                case 2:
                    _workExp = "11 лет";
                    break;
                case 3:
                    _workExp = "6 лет";
                    break;
                case 4:
                    _workExp = "9 года";
                    break;
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Место работы - {_workPlace} Опыт работы - {_workExp} Имя и Фамилия - {_name} {_surName}");
            Console.WriteLine();
        }
    }
}
