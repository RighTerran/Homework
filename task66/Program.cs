/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumofNaturalNumbers(int start, int end)
{
    if (start == end)
    {
        return end;
    }
    return start + SumofNaturalNumbers(++start, end);
}

Console.Write("Введите число №1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число №2: ");
int num2 = int.Parse(Console.ReadLine());
int result = SumofNaturalNumbers(num1, num2);
Console.Write($"Сумма натуральных чисел от {num1} до {num2}: {result}");