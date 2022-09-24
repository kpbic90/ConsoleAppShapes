using ConsoleAppShapes.Services;
using ConsoleAppShapes.Services.IO;

namespace ConsoleAppShapes
{
    class Program
    {
        static void Main()
        {
            var inputManager = new ConsoleInputManager();
            var outputManager = new ConsoleOutputManager();

            while (true)
            {
                var type = inputManager.GetShapeType();
                var shape = ShapeFactory.CreateShape(type);
                if (shape == null)
                {
                    outputManager.OutputString("Cant create that shape");
                    continue;
                }

                inputManager.GetShapeDimensions(shape);
                outputManager.OutputShape(shape);
            }
        }
    }
}
