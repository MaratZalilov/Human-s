using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_s
{
    internal class Driver : Human
    {
        private string _workPlace;
        private string _workExp;


        public Driver(string name, string surName)
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
                    _workPlace = "RedTaxi";
                    break;
                case 2:
                    _workPlace = "Pilot";
                    break;
                case 3:
                    _workPlace = "YandexTaxi";
                    break;
                case 4:
                    _workPlace = "Uber";
                    break;
            }

            Random Random1 = new Random();
            int RandomExp = Random1.Next(1, 4);
            switch (RandomExp)
            {
                case 1:
                    _workExp = "3,5 года";
                    break;
                case 2:
                    _workExp = "8 лет";
                    break;
                case 3:
                    _workExp = "5 лет";
                    break;
                case 4:
                    _workExp = "4 года";
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
