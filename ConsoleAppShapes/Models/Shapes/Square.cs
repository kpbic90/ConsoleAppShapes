using ConsoleAppShapes.Models.Shapes.Strategies;

namespace ConsoleAppShapes.Models.Shapes
{
    public sealed class Square : Rectangle
    {
        public Square()
        {
            ShapeInputStrategy = new SquareInputStrategy();
            ShapeOutputStrategy = new RectangleOutputStrategy();
        }
    }
}