using System;

namespace Questão5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = 1;
            Console.Write("Digite um Numero");
            int numero = int.Parse(Console.ReadLine());

            for (int i = numero; i > 0; i--) 
            {

                Console.Write(i + "*");
                resultado = i * resultado;

            }
            Console.Write("=");
            Console.WriteLine("{0}", resultado);
            Console.ReadKey();
            Console.WriteLine("Digite ");
       
        
        
        }
    }
}
