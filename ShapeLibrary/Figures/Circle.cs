using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Figures
{
    public class Circle : IFigure
    {
        private readonly double Radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new Exception("Значение не может быть меньше 0.");

            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
