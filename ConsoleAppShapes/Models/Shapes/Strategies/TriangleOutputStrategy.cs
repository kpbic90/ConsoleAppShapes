using System;
using System.Text;
using ConsoleAppShapes.Services.IO;

namespace ConsoleAppShapes.Models.Shapes.Strategies
{
    public sealed class TriangleOutputStrategy : IShapeOutputStrategy
    {
        public void OutputShape(IOutputManager outputManager, IShape shape)
        {
            var sb = new StringBuilder();
            var triangle = (Triangle) shape;

            var p = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            var S = Math.Sqrt(p * (p - triangle.SideA) * (p - triangle.SideB) * (p - triangle.SideC));
            var SinA = 2 * S / (triangle.SideA * triangle.SideB);
            var alpha = Math.Asin(SinA);

            var px = triangle.SideB * Math.Cos(alpha);
            var py = triangle.SideB * Math.Sin(alpha);

            for (var y = 0; y <= py; y++)
            {
                for (var x = 0; x <= Math.Max( triangle.SideA, px); x++)
                {
                    var a = (0 - x) * (0 - 0) - (triangle.SideA - 0) * (0 - y);
                    var b = (triangle.SideA - x) * (py - 0) - (px - triangle.SideA) * (0 - y);
                    var c = (px - x) * (0 - py) - (0 - px) * (py - y);

                    var flagInTriangle = (a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0);
                    sb.Append(flagInTriangle ? "*" : " ");
                }

                sb.AppendLine();
            }

            outputManager.OutputString(sb.ToString());
        }
    }
}