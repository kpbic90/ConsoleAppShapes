using System;
using ConsoleAppShapes.Services.IO;

namespace ConsoleAppShapes.Models.Shapes.Strategies
{
    public sealed class TriangleInputStrategy : IShapeInputStrategy
    {
        public void GetShapeDimensions(IInputManager inputManager, IShape shape)
        {
            var sideA = inputManager.GetFloat("Input side A:");
            var sideB = inputManager.GetFloat("Input side B:");
            var sideC = inputManager.GetFloat("Input side C:");

            if(Math.Abs(sideA) < 0.01f || Math.Abs(sideB) < 0.01f || Math.Abs(sideC) < 0.01f || sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideA + sideB)
            {
                GetShapeDimensions(inputManager, shape);
                return;
            }

            var triangle = (Triangle) shape;
            triangle.SideA = sideA;
            triangle.SideB = sideB;
            triangle.SideC = sideC;
        }
    }
}