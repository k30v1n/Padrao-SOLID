using System;

namespace SOLID.PATTERN.LSP.Solucao
{
    public class Program
    {
        private static void ObterAreaRetangulo(Forma forma)
        {
            Console.WriteLine("Calculo da área da forma");
            Console.WriteLine(forma.Altura.ToString() + " * " + forma.Largura.ToString());
            Console.WriteLine(forma.Area);
            Console.ReadKey();
        }

        private static void Main()
        {
            var quad = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRetangulo(quad);
        }
    }
}