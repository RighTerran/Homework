/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Write("Введите длину массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];
Random random = new Random();
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = random.Next(100, 1000);
}
Console.Write("Массив: ");
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
Console.WriteLine();
int countPositiveNumber = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0)
    {
        countPositiveNumber++;
    }
}
Console.Write("Количество четных чисел: " + countPositiveNumber);
