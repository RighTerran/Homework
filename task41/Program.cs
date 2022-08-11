/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Write("Введите количество чисел для ввода: ");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write("Введите число № " + (i + 1) + ": ");
    myArray[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
    {
        count++;
    }
}
Console.Write("Количество элементов больше 0: " + count);