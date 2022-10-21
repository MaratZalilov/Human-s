using Human_s;

CollectionPeople collection = new CollectionPeople();
collection.CreateHuman();

while (true)
{
    void Menu()
    {
        Console.WriteLine("1. Уволить человека");
        Console.WriteLine("2. Отчислить студента");
        Console.WriteLine("3. Поменять работу");
        Console.WriteLine("4. Повысить степендию");
        Console.WriteLine("5. Посмотреть информацию о людях");
    }
    void FuncMenu()
    {
        Menu();
        string Enter = Console.ReadLine();
        int select = int.Parse(Enter);
        switch (select)
        {
            case 1:
                Console.WriteLine();
                Console.WriteLine("Пока функция не работает");
                Console.WriteLine();
                break;
            case 2:
                Console.WriteLine();
                Console.WriteLine("Пока функция не работает");
                Console.WriteLine();
                break;
            case 3:
                Console.WriteLine();
                Console.WriteLine("Пока функция не работает");
                Console.WriteLine();
                break;
            case 4:
                Console.WriteLine();
                Console.WriteLine("Пока функция не работает");
                Console.WriteLine();
                break;
            case 5:
                collection.GetInfo();
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("Такого пункта нет");
                Console.WriteLine();
                break;
        }
    }
    FuncMenu();
}