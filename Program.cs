/*A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um
algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
*/



using System;

namespace Dimenção_do_terreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o comprimento do terreno: ");

            double Comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a largura do terreno: ");

            double Largura = Convert.ToDouble(Console.ReadLine());

            if (Comprimento == Largura)
            {
                Console.WriteLine("Dimensão do terreno só pode ser retangular");
            }
            else {
                double Area = Comprimento * Largura;
                Console.WriteLine(Area);
            }
            
        }
    }
}
