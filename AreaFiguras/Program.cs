using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFiguras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figura;
            double bas, alt, basm, basM, diam, diaM;

            Console.WriteLine("Escolha uma figura: Quadrado(Q), Retângulo(R), Trapézio(T), Losango(L)");
            figura = Console.ReadLine().ToLower();

            switch (figura)
            {
                case "q":
                    Console.WriteLine("Digite a altura: ");
                    bas = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a base: ");
                    alt = double.Parse(Console.ReadLine());
                    Console.WriteLine("A area do Quadrado é: "+ (bas*alt));
                    break;
                case "r":
                    Console.WriteLine("Digite a altura: ");
                    bas = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a base: ");
                    alt = double.Parse(Console.ReadLine());
                    Console.WriteLine("A area do Retângulo é: " + (bas * alt));
                    break;
                case "t":
                    Console.WriteLine("Digite a altura: ");
                    alt = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a base menor: ");
                    basm = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a base maior: ");
                    basM = double.Parse(Console.ReadLine());
                    Console.WriteLine("A area do Trapézio é: " + ((basm + basM)*alt)/2);
                    break;
                case "l":
                    Console.WriteLine("Digite a diagonal menor: ");
                    diam = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a diagonal maior: ");
                    diaM = double.Parse(Console.ReadLine());
                    Console.WriteLine("A area do Trapézio é: " + (diam * diaM) / 2);
                    break;
                default: Console.WriteLine("Opição invalida");
                    break;
            }

            Console.ReadKey();

        }
    }
}
