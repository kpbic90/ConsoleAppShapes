using System;
using ConsoleAppShapes.Services.IO;

namespace ConsoleAppShapes.Models.Shapes.Strategies
{
    public sealed class RoundInputStrategy : IShapeInputStrategy
    {
        public void GetShapeDimensions(IInputManager inputManager, IShape shape)
        {
            var radius = inputManager.GetFloat("Input range:");
            if (Math.Abs(radius) < 0.01f)
            {
                GetShapeDimensions(inputManager, shape);
                return;
            }

            var round = (Round) shape;
            round.Radius = radius;
        }
    }
}