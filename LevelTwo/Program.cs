using Spectre.Console;
using SoGoodLib;
using System;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Mensagem da biblioteca externa
            Console.WriteLine(SoGoodClass.SoGoodMethod());

            // Definir valores padrão
            string imagePath = "tux.jpg";
            int maxWidth = 24;

            // Processar argumentos da linha de comando
            if (args.Length >= 1)
            {
                imagePath = args[0]; // Primeiro argumento é o caminho da imagem
            }
            if (args.Length >= 2 && int.TryParse(args[1], out int parsedWidth))
            {
                maxWidth = parsedWidth; // Segundo argumento define o tamanho
            }

            // Criar a imagem e definir o tamanho
            try
            {
                CanvasImage image = new CanvasImage(imagePath);
                image.MaxWidth(maxWidth);
                AnsiConsole.Write(image);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar a imagem: {ex.Message}");
            }
        }
    }
}
