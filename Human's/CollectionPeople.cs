using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_s
{
    internal class CollectionPeople
    {

        private List<Human> humans = new List<Human>();

        public void CreateHuman()
        {
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int RandomHuman = random.Next(1, 3);
                if (RandomHuman == 1)
                {
                    Random random1 = new Random();
                    int RandomHuman1 = random1.Next(1, 2);
                    switch (RandomHuman1)
                    {
                        case 1:
                            Driver driver = new Driver("Петя", "Ждалкин");
                            driver.Work();
                            humans.Add(driver);
                            break;
                        case 2:
                            Driver driver1 = new Driver("Леонид", "Гадалкин");
                            driver1.Work();
                            humans.Add(driver1);
                            break;
                        case 3:
                            Driver driver2 = new Driver("Леонид", "Бровкин");
                            driver2.Work();
                            humans.Add(driver2);
                            break;
                    }
                }
                else if (RandomHuman == 2)
                {
                    Random random1 = new Random();
                    int RandomHuman1 = random1.Next(1, 2);
                    switch (RandomHuman1)
                    {
                        case 1:
                            Student student = new Student("Гена", "Петров");
                            student.Work();
                            humans.Add(student);
                            break;
                        case 2:
                            Student student1 = new Student("Георгий", "Шенгели");
                            student1.Work();
                            humans.Add(student1);
                            break;
                        case 3:
                            Student student2 = new Student("Ганс", "Вегельбург");
                            student2.Work();
                            humans.Add(student2);
                            break;
                    }
                }
                else if (RandomHuman == 3)
                {
                    Random random1 = new Random();
                    int RandomHuman1 = random1.Next(1, 2);
                    switch (RandomHuman1)
                    {
                        case 1:
                            Teacher teacher = new Teacher("Олег", "Сивягин");
                            teacher.Work();
                            humans.Add(teacher);
                            break;
                        case 2:
                            Teacher teacher1 = new Teacher("Дима", "Ларионов");
                            teacher1.Work();
                            humans.Add(teacher1);
                            break;
                        case 3:
                            Student teacher2 = new Student("Георгий", "Иванов");
                            teacher2.Work();
                            humans.Add(teacher2);
                            break;
                    }
                }
            }
        }
        public void GetInfo()
        {
            foreach(Human human in humans)
            {
                if(human is Student student)
                {
                    student.GetInfo();
                }
                else if (human is Teacher teacher)
                {
                    teacher.GetInfo();
                }
                else if (human is Driver driver)
                {
                    driver.GetInfo();
                }
            }
        }
    }
}

