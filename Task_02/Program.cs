﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
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
else if (n <=999)
{
    n = n % 10;
    Console.Write($"Искомая цифра: {n}, ");
}
while (n > 100)
{
    n = n / 10;
    {
      n = n % 10;
    Console.Write($"Искомая цифра: {n}, ");  
    }
}
