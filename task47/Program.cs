/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.WriteLine("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int col = int.Parse(Console.ReadLine());

double[,] myArray = new double[row, col];
Random random = new Random();
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        myArray[i, j] = Math.Round((random.Next(-10, 100) + random.NextDouble()), 2); // вариант №2 (менее оптимальный): myArray[i, j] = Math.Round(((random.NextDouble() * 10)-1),2); 
        if (myArray[i, j] == 0) myArray[i, j] = 0; // если будет вывод 0, для обхода некорретного вывода "-0"
    }
}

for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        Console.Write(myArray[i, j] + "\t");
    }
    System.Console.WriteLine();
}
