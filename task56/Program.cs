/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] myArray =
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
};

int minRow = 0;
int sum = 0;
int indexOfMinRow = 0;
for (int i = 0; i < myArray.GetLength(0); i++)
{
    sum = 0;
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        sum += myArray[i, j];
    }
    Console.WriteLine($"Сумма строки № {i + 1}: {sum}");

    if (i == 0)
    {
        minRow = sum;
    }
    if (minRow > sum)
    {
        minRow = sum;
        indexOfMinRow = i;
    }
}
Console.WriteLine($"Наименьшая сумма находиться в строке № {indexOfMinRow + 1}");