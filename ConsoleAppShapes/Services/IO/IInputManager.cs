using ConsoleAppShapes.Data;
using ConsoleAppShapes.Models.Shapes;

namespace ConsoleAppShapes.Services.IO
{
    public interface IInputManager
    {
        public string GetString(string message);
        public int GetInt(string message);
        public float GetFloat(string message);
        public ShapeType GetShapeType();
        public void GetShapeDimensions(IShape shape);
    }
}