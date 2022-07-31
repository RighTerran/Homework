Console.Write("Введите координаты x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Длина отрезка равна " + findLength(x1, x2, y1, y2));

double findLength(int x1, int x2, int y1, int y2)
{
    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return distance;
}
