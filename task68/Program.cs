/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/
int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AckermannFunction(m - 1, 1);
    else if (m > 0 && n > 0)
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    else
        return n + 1;
}

Console.Write("Введите первое неотрицательное число №1: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите второе неотрицательное число №2: ");
int n = int.Parse(Console.ReadLine());
int result = AckermannFunction(m, n);
Console.Write($"Результат вычисления функции Аккермана с помощью рекурсии двух неотрицательных чисел {m} и {n}: {result}");