using System;
using System.Text;
using ConsoleAppShapes.Services.IO;

namespace ConsoleAppShapes.Models.Shapes.Strategies
{
    public sealed class RoundOutputStrategy : IShapeOutputStrategy
    {
        public void OutputShape(IOutputManager outputManager, IShape shape)
        {
            var sb = new StringBuilder();
            var round = (Round) shape;
            for (var y = -round.Radius; y <= round.Radius; y++)
            {
                for (var x = -round.Radius; x <= round.Radius; x++)
                {
                    var flagInRadius = Math.Pow(x, 2) + Math.Pow(y, 2) < Math.Pow(round.Radius, 2);
                    sb.Append(flagInRadius ? '*' : ' ');
                }

                sb.AppendLine();
            }

            outputManager.OutputString(sb.ToString());
        }
    }
}