using ConsoleAppShapes.Data;
using ConsoleAppShapes.Models.Shapes;

namespace ConsoleAppShapes.Services
{
    public static class ShapeFactory
    {
        public static IShape CreateShape(ShapeType type)
        {
            return type switch
            {
                ShapeType.Round => new Round(),
                ShapeType.Triangle => new Triangle(),
                ShapeType.Rectangle => new Rectangle(),
                ShapeType.Square => new Square(),
                _ => null
            };
        }
    }
}