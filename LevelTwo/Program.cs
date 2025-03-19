using Spectre.Console;
using SoGoodLib;  // Adiciona esta linha para importar a biblioteca
using System;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Chamar o método da biblioteca externa
            Console.WriteLine(SoGoodClass.SoGoodMethod());

            CanvasImage image = new CanvasImage("./tux.jpg"); 

            // Set the max width of the image
            image.MaxWidth(24);

            // Render the image to the console
            AnsiConsole.Write(image);
        }
    }
}
