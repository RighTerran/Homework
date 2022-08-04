/* 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите первое число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int degree = int.Parse(Console.ReadLine());
int result = 1;
for (int i = 1; i <= degree; i++)
{
    result *= num;
}
Console.Write("Число " + num + " в степени " + degree + " = " + result);