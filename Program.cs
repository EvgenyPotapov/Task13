// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 99)
{
    while (number > 999)
    {
        number /= 10; 
    }
    int res = number % 10;
    Console.WriteLine(res);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}

