// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите целое неотрицательное число M");
uint m = uint.Parse(Console.ReadLine()!);
Console.WriteLine("Введите целое неотрицательное число N");
uint n = uint.Parse(Console.ReadLine()!);

static uint A(uint x, uint y)
{
    if (x == 0) return y + 1;
    else
    {
        if ((x != 0) && (y == 0)) return A(x - 1, 1);
        else return A(x - 1, A(x, y - 1));
    }
}

Console.WriteLine(A(m, n));