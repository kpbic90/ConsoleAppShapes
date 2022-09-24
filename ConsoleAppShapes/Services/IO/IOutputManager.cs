using ConsoleAppShapes.Models.Shapes;

namespace ConsoleAppShapes.Services.IO
{
    public interface IOutputManager
    {
        public void OutputString(string text);
        public void OutputShape(IShape shape);
    }
}