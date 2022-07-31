/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num <= 0)
{
    Console.WriteLine("Введите число больше 0");
}
else
{
    for (int i = 1; i <= num; i++)
    {
        int result = i * i * i;
        Console.Write(result + " ");
    }
}