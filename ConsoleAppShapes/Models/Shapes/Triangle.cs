using ConsoleAppShapes.Models.Shapes.Strategies;

namespace ConsoleAppShapes.Models.Shapes
{
    public sealed class Triangle : Shape
    {
        public Triangle()
        {
            ShapeInputStrategy = new TriangleInputStrategy();
            ShapeOutputStrategy = new TriangleOutputStrategy();
        }

        public float SideA { get; set; }
        public float SideB { get; set; }
        public float SideC { get; set; }
    }
}