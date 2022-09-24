using ConsoleAppShapes.Services.IO;

namespace ConsoleAppShapes.Models.Shapes.Strategies
{
    public interface IShapeOutputStrategy
    {
        void OutputShape(IOutputManager outputManager, IShape shape);
    }
}