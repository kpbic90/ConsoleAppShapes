using ConsoleAppShapes.Models.Shapes.Strategies;

namespace ConsoleAppShapes.Models.Shapes
{
    public sealed class Round : Shape
    {
        public Round()
        {
            ShapeInputStrategy = new RoundInputStrategy();
            ShapeOutputStrategy = new RoundOutputStrategy();
        }

        public float Radius { get; set; }
    }
}