using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Figures
{
    public class Triangle : IFigure
    {
        private readonly double SideA;
        private readonly double SideB;
        private readonly double SideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
                throw new Exception("Значение не может быть меньше 0.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            var semiperimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
        }

        /// <summary>
        /// Checking if the triangle is rectangular
        /// </summary>
        /// <returns></returns>
        public bool IsTriangleRectangular()
        {
            var sidesArray = new[] { SideA, SideB, SideC };
            Array.Sort(sidesArray);
            return Math.Pow(sidesArray[0], 2) + Math.Pow(sidesArray[1], 2) == Math.Pow(sidesArray[2], 2);
        }
    }
}
