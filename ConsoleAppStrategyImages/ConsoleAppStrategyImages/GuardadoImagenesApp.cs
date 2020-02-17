using System;

namespace ConsoleAppStrategyImages
{
    class GuardadoImagenesApp
    {
        static void Main(string[] args)
        {
            while (true) // Loop indefinitely
            {
                Console.WriteLine(); 
                Console.WriteLine("Introduzca exit o quit para salir"); 
                Console.WriteLine("1. bmp"); 
                Console.WriteLine("2. jpg"); 
                Console.WriteLine("3. jp2"); 
                Console.Write("Seleccionar formato:"); // Prompt
                string line = Console.ReadLine(); 
                
                if (line.ToLower() == "exit" || line.ToLower() == "quit")
                {
                    break;
                }

                bool parsed = int.TryParse(line, out int option);
                if (parsed && (option > 0 && option < 4))
                {
                    Console.Write("Introducir nombre de archivo:"); 
                    string fileName = Console.ReadLine(); 
                    if (!string.IsNullOrWhiteSpace(fileName))
                    {
                        ContextoImagen contextoImagen = new ContextoImagen();
                        
                        switch (option)
                        {
                            case 1:
                                contextoImagen.SetEstrategiaImagen(new EstrategiaBmp(fileName));
                                break;
                            case 2:
                                contextoImagen.SetEstrategiaImagen(new EstrategiaJpg(fileName));
                                break;
                            default:
                                contextoImagen.SetEstrategiaImagen(new EstrategiaJp2(fileName));
                                break;
                        }
                        contextoImagen.SaveImage();
                    }
                    else
                    {
                        Console.WriteLine("Favor de proporcionar un nombre de archivo valida. Iniciemos de nuevo.");
                    }
                }
                else
                {
                    Console.Write("Seleccione sólo alguna de las opciones disponibles");
                }
            }
        }
    }
}
