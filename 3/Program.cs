// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите целое неотрицательное число M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите целое неотрицательное число N");
int n = int.Parse(Console.ReadLine()!);

int Akkerman(int x, int y)
{
    if (x == 0) return y + 1;
    else
    {
        if ((x != 0) && (y == 0)) return Akkerman(x - 1, 1);
        else return Akkerman(x - 1, Akkerman(x, y - 1));
    }
}

Console.WriteLine("= " + Akkerman(m, n));