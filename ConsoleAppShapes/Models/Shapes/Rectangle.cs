using ConsoleAppShapes.Models.Shapes.Strategies;

namespace ConsoleAppShapes.Models.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            ShapeInputStrategy = new RectangleInputStrategy();
            ShapeOutputStrategy = new RectangleOutputStrategy();
        }

        public float SideA { get; set; }
        public float SideB { get; set; }
    }
}