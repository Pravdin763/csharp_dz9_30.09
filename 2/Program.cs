//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите целое число M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите целое число N, которое больше М");
int n = int.Parse(Console.ReadLine()!);

int count = 0;
int SumSegment(int first, int second, int count2)
{
    if (first == second) return count2 + first;
    else return SumSegment(first + 1, second, count2 += first);
}

Console.WriteLine($"Сумма натуральный элементов на прмежутке от {m} до {n} = {SumSegment(m, n, count)}");