using ConsoleAppShapes.Models.Shapes.Strategies;
using ConsoleAppShapes.Services.IO;

namespace ConsoleAppShapes.Models.Shapes
{
    public abstract class Shape : IShape
    {
        public IShapeInputStrategy ShapeInputStrategy { get; protected set; }
        public IShapeOutputStrategy ShapeOutputStrategy { get; protected set; }

        public void InputDimensions(IInputManager inputManager)
        {
            ShapeInputStrategy.GetShapeDimensions(inputManager, this);
        }

        public void OutputShape(IOutputManager outputManager)
        {
            ShapeOutputStrategy.OutputShape(outputManager, this);
        }
    }
}