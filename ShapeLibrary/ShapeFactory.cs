using ShapeLibrary.Figures;
using ShapeLibrary.Interfaces;

namespace ShapeLibrary
{
    public static class ShapeFactory
    {
        public static IFigure? Create(params double[] args)
        {
            return args.Length switch
            {
                1 => new Circle(args[0]),
                3 => new Triangle(args[0], args[1], args[2]),
                _ => null,
            };
        }
    }
}