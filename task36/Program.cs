/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write("Введите длину массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];
Random random = new Random();
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = random.Next(-100, 100);
}
Console.Write("Массив: ");
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
// Вариант №1
Console.WriteLine();
int sumUnevenIndex = 0; // счетчик для суммы элементов нечетных позиций

for (int i = 1; i < myArray.Length; i++)
{
    sumUnevenIndex += myArray[i];
    i++;
}
Console.Write("Сумма элементов стоящих на нечётных позициях: " + sumUnevenIndex);

/*
Вариант №2
for (int i = 0; i < myArray.Length; i++)
{
    if (i % 2 != 0)
    {
        sumUnevenIndex += myArray[i];
    }
}
Console.Write("Сумма элементов стоящих на нечётных позициях: " + sumUnevenIndex);
*/