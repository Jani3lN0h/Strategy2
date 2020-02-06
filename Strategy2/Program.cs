using Strategy2.Services.Factory;
using Strategy2.Services.Factory.Interfaces;
using Strategy2.Services.Interfaces;
using System;

namespace Strategy2
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepositoryImages repositoryImage = null;
            IRepositoryImagesFactory repositoryImages = new RepositoryImagesFactory();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Captura el nombre de la imagen: ");
            Console.ResetColor();
            string cName = Convert.ToString(Console.ReadLine());
            ShowTypesExtension();
            int iTypeExtension = Convert.ToInt32(Console.ReadLine());
            repositoryImage = repositoryImages.GetStrategy(iTypeExtension);
            string cTypeExtension = GetNameExtension(iTypeExtension);
            string cResult = repositoryImage.SaveImage(cName, cTypeExtension);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(cResult);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nPresione una tecla para salir.");
            Console.ReadKey();
        }

        static void ShowTypesExtension()
        {
           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Elige el formato de la imagen: ");
            Console.WriteLine("1 - JPEG");
            Console.WriteLine("2 - PNG");
            Console.WriteLine("3 - BMP");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************************");
            Console.ResetColor();
        }

        static string GetNameExtension(int iTypeExtension)
        {
            string cReturn = string.Empty;
            switch (iTypeExtension)
            {
                case 1:
                    cReturn = "JPEG";
                    break;
                case 2:
                    cReturn = "PNG";
                    break;
                case 3:
                    cReturn = "BMP";
                    break;
            }
            return cReturn;
        }
    }
}
