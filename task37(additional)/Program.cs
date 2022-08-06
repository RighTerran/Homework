/*
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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
Console.WriteLine();
for (int i = 0; i < myArray.Length / 2; i++) // получаем новые элемента для массива, пары в результате произведения
{
    myArray[i] = myArray[i] * myArray[(myArray.Length - 1) - i];
}
Console.Write("Массив 2: ");
if (myArray.Length % 2 == 0) // если число элементов четное, то центральный элемент не выводим
    for (int i = 0; i < myArray.Length / 2; i++)
    {
        Console.Write(myArray[i] + " ");
    }
else // если число элементов нечетное, то центральный элемент выводим последним в новом массиве
    for (int i = 0; i <= myArray.Length / 2; i++)
    {
        Console.Write(myArray[i] + " ");
    }
