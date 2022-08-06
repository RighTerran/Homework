/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.Write("Введите длину массива: ");
int elementsCount = int.Parse(Console.ReadLine());
double[] myArray = new double[elementsCount];
Random random = new Random();
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = random.Next(0, 100);
}
Console.Write("Массив: ");
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
double minValue = myArray[0];
for (int i = 0; i < myArray.Length; i++)
{
    if (minValue > myArray[i])
    {
        minValue = myArray[i];
    }
}
double maxValue = myArray[0];
for (int i = 0; i < myArray.Length; i++)
{
    if (maxValue < myArray[i])
    {
        maxValue = myArray[i];
    }
}
Console.WriteLine();
Console.Write("Минимальное значение в массиве: " + minValue);
Console.Write("\nМаксимальное значение в массиве: " + maxValue);
Console.Write("\nРазница между максимальным и минимальным элементом массива: " + (maxValue - minValue));