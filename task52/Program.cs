/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] myArray =
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};
Console.WriteLine("Массив: ");
for (int row = 0; row < myArray.GetLength(0); row++)
{
    for (int col = 0; col < myArray.GetLength(1); col++)
    {
        Console.Write(myArray[row, col] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int col = 0; col < myArray.GetLength(1); col++)
{
    double averageValue = 0;
    double sum = 0;
    for (int row = 0; row < myArray.GetLength(0); row++)
    {
        sum += myArray[row, col];
    }
    averageValue = sum / myArray.GetLength(0);
    Console.WriteLine($"Среднее значение столбца № {col + 1}: {String.Format("{0:F2}",averageValue)}");
}