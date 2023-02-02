namespace FigureLibrary
{
    public class CFigure
    {
       public string FigureType { get; set; }
        double Radius { get; set; }
        double SideA { get; set; }
        double SideB { get; set; }
        double SideC { get; set; }

        // Конструктор круга
        public CFigure(double r)
        {
            Radius = r;
            FigureType = "Круг";
        }
        //Конструктор треугольника

        public CFigure(double sideA, double sideB, double sideC)
        {
            if((sideA + sideB) < sideC ||
                (sideA + sideC) < sideB ||
                (sideB + sideC) < sideA)
            {
                throw new ArgumentException("Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать.");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            FigureType = "Треугольник";
        }
        // Расчет площади фигуры
        public double GetArea()
        {
            switch (FigureType)
            {
                case "Круг":
                    // Вычилсяем площадь круга
                    return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);

                case "Треугольник":
                    // Вычисляем площадь треугольника по формуле Герона
                    double p; // Полупериметр
                    p = (SideA + SideB + SideC) / 2;
                    return Math.Round(Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)), 2);
                default:
                    return 0.00;
            }

            
        }
        // Проверка, является ли трекгольник прямоугольным
        public bool IsRightAngle()
        {
            if (Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
                (Math.Pow(SideA, 2) + Math.Pow(SideC, 2)) == Math.Pow(SideB, 2) ||
                Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2))
                return true;
            else
                return false;
        }
    }
}