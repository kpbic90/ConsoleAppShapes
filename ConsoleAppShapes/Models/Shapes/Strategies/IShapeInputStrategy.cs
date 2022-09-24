using ConsoleAppShapes.Services.IO;

namespace ConsoleAppShapes.Models.Shapes.Strategies
{
    public interface IShapeInputStrategy
    {
        void GetShapeDimensions(IInputManager inputManager, IShape shape);
    }
}