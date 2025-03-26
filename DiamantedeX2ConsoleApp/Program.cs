using DiamantedeX2ConsoleApp;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace DiamanteDeX2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Exibicao.DiamondDisplay(Exibicao.MenuDisplay());

                Console.WriteLine("Você deseja continuar? [Y/N]");
                string opcao = Console.ReadLine().ToUpper();

                if (opcao != "Y")
                {
                    break;
                }

            }
            Console.ReadLine();

        }

      
    }
}


