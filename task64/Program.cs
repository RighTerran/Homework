/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

void Numbers(int start, int end)
{
    if (start > end)
    {
        return;
    }
    Console.Write(start + "\t");
    start++;
    Numbers(start, end);
}

Console.Write("Введите число №1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число №2: ");
int num2 = int.Parse(Console.ReadLine());
Numbers(num1, num2);