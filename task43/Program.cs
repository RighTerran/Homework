/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/
while (true) // в качестве доп. опции использовал try and catch для проверки значений
{
    Console.Clear(); // очищаю консоль после ввода
    Console.WriteLine("Заданы следующие уравнения для поиска точки пересечения двух прямых:\ny = k1 * x + b1\ny = k2 * x + b2");
    double k1, b1, k2, b2;
    try
    {
        Console.Write("Введите значение k1: ");
        k1 = double.Parse(Console.ReadLine());
        Console.Write("Введите значение b1: ");
        b1 = double.Parse(Console.ReadLine());
        Console.Write("Введите значение k2: ");
        k2 = double.Parse(Console.ReadLine());
        Console.Write("Введите значение b2: ");
        b2 = double.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Ошибка! Введите числовые значения!");
        Console.ReadLine();
        continue;
    }

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"Пересечение двух прямых в точке: ({Math.Round(x, 2)};{Math.Round(y, 2)})");
    break;
}