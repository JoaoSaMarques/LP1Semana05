using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CanvasImage image = new CanvasImage("../tux.jpg"); 

            // Set the max width of the image
            image.MaxWidth(24);

            // Render the image to the console
            AnsiConsole.Write(image);
        }
    }
}
