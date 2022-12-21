// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число дня недели: ");
int n = int.Parse(Console.ReadLine());
if (n > 7)
{
    System.Console.WriteLine("Вы ввели не день недели!");
}
else if (n >= 1 && n <=5)
    {
        System.Console.WriteLine($" {n} - Это рабочий день!");        
    }
else if (n == 6 || n == 7)
    {
        System.Console.WriteLine($" {n} - Это ВЫХОДНОЙ день!");
    }