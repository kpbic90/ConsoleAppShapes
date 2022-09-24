using System;
using ConsoleAppShapes.Models.Shapes;

namespace ConsoleAppShapes.Services.IO
{
    public sealed class ConsoleOutputManager : IOutputManager
    {
        public void OutputString(string text)
        {
            Console.WriteLine(text);
        }

        public void OutputShape(IShape shape)
        {
            shape.OutputShape(this);
        }
    }
}