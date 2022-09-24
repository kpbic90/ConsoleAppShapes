using System;
using System.Text;
using ConsoleAppShapes.Data;
using ConsoleAppShapes.Models.Shapes;

namespace ConsoleAppShapes.Services.IO
{
    public sealed class ConsoleInputManager : IInputManager
    {
        public string GetString(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (input != null)
                return input;

            Console.WriteLine("Null value! Try again");
            return GetString(message);
        }

        public int GetInt(string message)
        {
            var input = GetString(message);
            if (int.TryParse(input, out var result))
                return result;

            Console.WriteLine("Cant parse that! Try Again");
            return GetInt(message);
        }

        public float GetFloat(string message)
        {
            var input = GetString(message);
            if (float.TryParse(input, out var result))
                return result;

            Console.WriteLine("Cant parse that! Try Again");
            return GetFloat(message);
        }

        public ShapeType GetShapeType()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Choose shape type (input number):");
            foreach (var shapeType in Enum.GetValues<ShapeType>())
                sb.AppendLine($"{(int) shapeType}. {shapeType}");

            var input = GetInt(sb.ToString());
            if (Enum.IsDefined(typeof(ShapeType), input))
                return (ShapeType) input;

            Console.WriteLine("Wrong type number! Try again");
            return GetShapeType();
        }

        public void GetShapeDimensions(IShape shape)
        {
            shape.InputDimensions(this);
        }
    }
}