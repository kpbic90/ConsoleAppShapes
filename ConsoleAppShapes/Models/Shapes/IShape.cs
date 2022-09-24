using ConsoleAppShapes.Models.Shapes.Strategies;
using ConsoleAppShapes.Services.IO;

namespace ConsoleAppShapes.Models.Shapes
{
    public interface IShape
    {
        public IShapeInputStrategy ShapeInputStrategy { get; }
        public IShapeOutputStrategy ShapeOutputStrategy { get; }
        public void InputDimensions(IInputManager inputManager);
        public void OutputShape(IOutputManager outputManager);
    }
}