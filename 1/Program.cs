// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите целое число");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int PrintNum(int x)
{
    Console.WriteLine(x);
    if (x > 1) return PrintNum(x - 1);
    else return 1;
}

Console.WriteLine(PrintNum(n));