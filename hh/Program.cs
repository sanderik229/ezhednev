using hh;
while (true)
{
    DateTime data = DateTime.Now;
    Console.WriteLine(data);
    Console.WriteLine("Что сегодня будешь делать?");
    int pos = 2;
    ConsoleKeyInfo key;

    do
    {
        if (data.Date == new DateTime(2023, 10, 17))
        {
            Console.Clear();
            Console.WriteLine(data);
            Console.WriteLine("Что сегодня будешь делать?");
            Console.WriteLine("   1.Помыться");
            Console.WriteLine("   2.покушать");
            Console.WriteLine("   3.поиграть в майнкрафт");
            Console.WriteLine("   4.Попить пиво с Матвеем");
        }
        else if (data.Date == new DateTime(2023, 10, 20))
        {
            Console.Clear();
            Console.WriteLine(data);
            Console.WriteLine("Что сегодня будешь делать?");
            Console.WriteLine("   1.Пойти в шарагу");
            Console.WriteLine("   2.Купить дошик");
            Console.WriteLine("   3.Поспать");
            Console.WriteLine("   4.Отдыхать");
        }
        else if (data.Date != new DateTime(2023, 10, 20))
        {
            Console.Clear();
            Console.WriteLine(data);
        }
        else if (data.Date != new DateTime(2023, 10, 17))
        {
            Console.Clear();
            Console.WriteLine(data);
        }

        Console.SetCursorPosition(0, pos);
        Console.WriteLine("->");
        key = Console.ReadKey();
        Console.SetCursorPosition(0, pos);
        Console.WriteLine("  ");
        if (key.Key == ConsoleKey.UpArrow && pos != 2)
        {
            pos--;
        }
        else if (key.Key == ConsoleKey.DownArrow && pos != 5)
        {
            pos++;
        }
        else if (key.Key == ConsoleKey.RightArrow)
        {
            data = data.AddDays(-1);

            Console.SetCursorPosition(0, 0);
            Console.WriteLine(data);

        }
        else if (key.Key == ConsoleKey.LeftArrow)
        {
            data = data.AddDays(1);

            Console.SetCursorPosition(0, 0);
            Console.WriteLine(data);
        }
    } while (key.Key != ConsoleKey.Enter) ;

    if (pos == 2 && data.Date == new DateTime(2023, 10, 17))

    {
        Console.Clear();
        Den1 pomitsa = new Den1();
        Console.WriteLine("Помыться");
        Console.WriteLine("--------------------------------------------");
        pomitsa.name = "Описание: надо помыться, чтобы вкусно пахнуть";
        DateTime vremya = DateTime.Now;
        Console.WriteLine(pomitsa.name);
        Console.WriteLine("Дата: " + vremya);
    }
    else if (pos == 2 && data.Date == new DateTime(2023, 10, 20))
    {
        Console.Clear();
        Den1 pomitsa = new Den1();
        Console.WriteLine("Пойти в шарагу");
        Console.WriteLine("--------------------------------------------");
        pomitsa.name = "Описание: Отсидеть с 1-5 пару(";
        DateTime vremya = DateTime.Now;
        Console.WriteLine(pomitsa.name);
        Console.WriteLine("Дата: " + vremya);
    }
    else if (pos == 3 && data.Date == new DateTime(2023, 10, 17))
    {
        Console.Clear();
        Den1 pomitsa = new Den1();
        Console.WriteLine("Покушать");
        Console.WriteLine("--------------------------------------------");
        pomitsa.name = "Описание: Вкусно покушать домашней еды";
        DateTime vremya = DateTime.Now;
        Console.WriteLine(pomitsa.name);
        Console.WriteLine("Дата: " + vremya);
    }
    else if (pos == 3 && data.Date == new DateTime(2023, 10, 20))
    {
        Console.Clear();
        Den1 pomitsa = new Den1();
        Console.WriteLine("Купить дошик");
        Console.WriteLine("--------------------------------------------");
        pomitsa.name = "Описание: Купить красный дошик и вкусно покушать :)";
        DateTime vremya = DateTime.Now;
        Console.WriteLine(pomitsa.name);
        Console.WriteLine("Дата: " + vremya);
    }
    else if (pos == 4 && data.Date == new DateTime(2023, 10, 17))
    {
        Console.Clear();
        Den1 pomitsa = new Den1();
        Console.WriteLine("Поиграть в майнкрафт");
        Console.WriteLine("--------------------------------------------");
        pomitsa.name = "Описание: Пройти майнкрафт 1003201203403 раз";
        DateTime vremya = DateTime.Now;
        Console.WriteLine(pomitsa.name);
        Console.WriteLine("Дата: " + vremya);
    }
    else if (pos == 4 && data.Date == new DateTime(2023, 10, 20))
    {
        Console.Clear();
        Den1 pomitsa = new Den1();
        Console.WriteLine("Поспать");
        Console.WriteLine("--------------------------------------------");
        pomitsa.name = "Описание: После плотного обеда надо поспать :)";
        DateTime vremya = DateTime.Now;
        Console.WriteLine(pomitsa.name);
        Console.WriteLine("Дата: " + vremya);
    }
    else if (pos == 5 && data.Date == new DateTime(2023, 10, 17))
    {
        Console.Clear();
        Den1 pomitsa = new Den1();
        Console.WriteLine("Попить пиво с матвеем");
        Console.WriteLine("--------------------------------------------");
        pomitsa.name = "Описание: Выйти на улицу и купить Балтику 0 со вкусом грейпфрута и попить с Матвеем";
        DateTime vremya = DateTime.Now;
        Console.WriteLine(pomitsa.name);
        Console.WriteLine("Дата: " + vremya);
    }
    else if (pos == 5 && data.Date == new DateTime(2023, 10, 20))
    {
        Console.Clear();
        Den1 pomitsa = new Den1();
        Console.WriteLine("Отдыхать");
        Console.WriteLine("--------------------------------------------");
        pomitsa.name = "Описание: Ну просто отдохнуть ёмае";
        DateTime vremya = DateTime.Now;
        Console.WriteLine(pomitsa.name);
        Console.WriteLine("Дата: " + vremya);
    }

    Console.ReadKey();
        Console.Clear();

    
}