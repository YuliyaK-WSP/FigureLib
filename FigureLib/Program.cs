using FigureLibrary;
 class Program
{
    private static void Main(string[] args)
    {
        CFigure circle = new CFigure(2.0);
        Console.WriteLine($"Создан объект типа {circle.FigureType}");
        Console.WriteLine($"Площадь круга {circle.GetArea()}");

        try
        {
            CFigure triangle = new CFigure(6.0,8.0,10.0);
            Console.WriteLine($"Создан объект типа {triangle.FigureType}");
            Console.WriteLine($"Площадь треугольника {triangle.GetArea()}");
            if (triangle.IsRightAngle())
            {
                Console.WriteLine("Треугольник является прямоугольным");
            }
            else
            {
                Console.WriteLine("Треугольник не является прямоугольным");
            }

        }catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}