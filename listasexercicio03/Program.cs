using System;
using System.Linq;
namespace listasexercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NUMEROS = new int[15];

            Console.WriteLine("Digite o Primeiro numero");
            NUMEROS[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero");
            NUMEROS[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Terceiro numero");
            NUMEROS[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Quarto numero");
            NUMEROS[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Quinto numero");
            NUMEROS[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Sexto numero");
            NUMEROS[5] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Sétimo numero");
            NUMEROS[6] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Oitavo numero");
            NUMEROS[7] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nono numero");
            NUMEROS[8] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Decimo numero");
            NUMEROS[9] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Decimo Primeiro numero");
            NUMEROS[10] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Decimo Segundo numero");
            NUMEROS[11] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Decimo Terceiro numero");
            NUMEROS[12] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Decimo Quarto numero");
            NUMEROS[13] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Decimo Quinto numero");
            NUMEROS[14] = int.Parse(Console.ReadLine());

            Array.Sort(NUMEROS);
            int maior = NUMEROS.Max();
            int menor = NUMEROS.Min();
            Console.WriteLine("O maior numero é {0}", maior);
            Console.Read();
            Console.WriteLine("O menor numero é {0}", menor);
           

            Console.ReadLine();













        }
    }
}
