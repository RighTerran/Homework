/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
*/

Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int col = int.Parse(Console.ReadLine());

int[,] myArray = new int[row, col];
Random random = new Random();
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        myArray[i, j] = random.Next(-100, 100);
    }
}
Console.WriteLine("Массив: ");
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        Console.Write(myArray[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.Write("Введите номер строки и столбца через пробел: ");
string[] input = Console.ReadLine().Split(' ');
int findRow = int.Parse(input[0]);
int findCol = int.Parse(input[1]);

if (findRow <= row && findCol <= col)
{
    Console.WriteLine("Значение под адресом " + "[" + findRow + "," + findCol + "]: " + myArray[findRow, findCol]);
}
else
{
    Console.WriteLine("Нет, этого числа нет в массиве");
}

