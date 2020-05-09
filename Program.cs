using System;

namespace gritador
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Digite qualquer palavra ");
            string textoDigitado = Console.ReadLine();

            Console.WriteLine(textoDigitado.ToUpper());
            
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }
    }
}
