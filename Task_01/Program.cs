System.Console.WriteLine("Введите трехзначное число: ");
int A = int.Parse(Console.ReadLine());
if (A >= 100 && A < 1000)
    {
        int X = (A / 10) % 10;
        Console.WriteLine($"Искомая цифра вашего числа {X}");
    }
    else
    {
        System.Console.WriteLine("Вы ввели не трехзначное число");
    }
