using System;
using ConsoleAppShapes.Services.IO;

namespace ConsoleAppShapes.Models.Shapes.Strategies
{
    public sealed class RectangleInputStrategy : IShapeInputStrategy
    {
        public void GetShapeDimensions(IInputManager inputManager, IShape shape)
        {
            var sideA = inputManager.GetFloat("Input side A:");
            var sideB = inputManager.GetFloat("Input side B:");

            if (Math.Abs(sideA) < 0.01f || Math.Abs(sideB) < 0.01f)
            {
                GetShapeDimensions(inputManager, shape);
                return;
            }

            var rectangle = (Rectangle) shape;
            rectangle.SideA = sideA;
            rectangle.SideB = sideB;
        }
    }
}