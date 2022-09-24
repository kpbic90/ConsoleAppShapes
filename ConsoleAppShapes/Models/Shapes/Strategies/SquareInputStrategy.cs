using System;
using ConsoleAppShapes.Services.IO;

namespace ConsoleAppShapes.Models.Shapes.Strategies
{
    public sealed class SquareInputStrategy : IShapeInputStrategy
    {
        public void GetShapeDimensions(IInputManager inputManager, IShape shape)
        {
            var sideA = inputManager.GetFloat("Input side:");

            if (Math.Abs(sideA) < 0.01f)
            {
                GetShapeDimensions(inputManager, shape);
                return;
            }

            var square = (Square) shape;
            square.SideA = sideA;
            square.SideB = sideA;
        }
    }
}