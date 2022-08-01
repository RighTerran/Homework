/*
Напишите программу для вычисления площади круга, прямоугольника и треугольника. 
Ввод данных осуществляется в диалоговом режиме. На первом шаге у пользователя запрашивается фигура, площадь которой нужно вычислить. 
На втором шаге пользователь вводит параметры, необходимые для рассчета. 
Затем, выводится результат.
*/
Console.WriteLine("Введите номер фигуры:\n\t круг\n\t прямоугольник\n\t треугольник");
string figure = Console.ReadLine();
if (figure.ToLower() == "круг")
{
    Console.Write("Введите радиус круга: ");
    double radiusOfCircle = double.Parse(Console.ReadLine());
    double squareOfCircle = Math.PI * (radiusOfCircle * radiusOfCircle);
    Console.Write("Площадь круга равна = " + squareOfCircle);
}
else if (figure.ToLower() == "прямоугольник")
{
    Console.Write("Введите сторону №1 прямоугольника: ");
    double sideA = double.Parse(Console.ReadLine());
    Console.Write("Введите сторону №2 прямоугольника: ");
    double sideB = double.Parse(Console.ReadLine());
    Console.Write("Площадь прямоугольника равна = " + (sideA * sideB));
}
else if (figure.ToLower() == "треугольник")
{
    Console.Write("Введите сторону №1 треугольника: ");
    double sideA = double.Parse(Console.ReadLine());
    Console.Write("Введите сторону №2 треугольника: ");
    double sideB = double.Parse(Console.ReadLine());
    Console.Write("Введите основание треугольника: ");
    double baseC = double.Parse(Console.ReadLine());
    if (sideA == sideB)
    {
        double squareOfTriangle = (baseC / 2) * Math.Sqrt((sideA + (baseC / 2)) * (sideA - (baseC / 2)));
        Console.Write("Треугольник является равнобедренным, площадь треугольника равна =  " + squareOfTriangle);
    }
    else if (sideA == sideB && sideA == baseC)
    {
        Console.Write("Треугольник является равносторонним, площадь треугольника равна =  " + ((Math.Sqrt(3)) * (sideA * sideA)) / 4);
    }
    else
    {
        double semiPerimeter = (sideA + sideB + baseC) / 2;
        double squareOfTriangle = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - baseC));
        Console.Write("Треугольник является разносторонним или прямоугольным, площадь треугольника равна =  " + squareOfTriangle);
    }
}
else
{
    Console.WriteLine("Фигура не найдена!");
}