/* 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int digit = int.Parse(number);
if (digit > 9999 & digit < 100000)
{
    if (number[0] == number[4] & number[1] == number[3])
    {
        Console.WriteLine("Данное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Данное число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Число не является пятизначным");
}


