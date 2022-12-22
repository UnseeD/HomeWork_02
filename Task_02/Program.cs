// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n < 100)
{
    System.Console.WriteLine("Третьей цифры нет.");
}
else if (n > 100 $$ n <1000)
{
    int b = n % 10;
    System.Console.WriteLine($"Третья цифра вашего числа - {b}");
}
