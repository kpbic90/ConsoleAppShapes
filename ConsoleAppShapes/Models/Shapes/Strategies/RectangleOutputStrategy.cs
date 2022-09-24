using System.Text;
using ConsoleAppShapes.Services.IO;

namespace ConsoleAppShapes.Models.Shapes.Strategies
{
    public sealed class RectangleOutputStrategy : IShapeOutputStrategy
    {
        public void OutputShape(IOutputManager outputManager, IShape shape)
        {
            var sb = new StringBuilder();
            var rectangle = (Rectangle) shape;
            for (var y = 0; y < rectangle.SideA; y++)
            {
                for (var x = 0; x < rectangle.SideB; x++)
                {
                    sb.Append('*');
                }

                sb.AppendLine();
            }

            outputManager.OutputString(sb.ToString());
        }
    }
}