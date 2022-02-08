using System;
using System.Linq;
namespace listasexercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] NUMEROS = new double[15];

            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[1] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[2] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[3] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[4] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[5] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[6] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[7] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[8] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[9] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[10] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[11] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[12] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[13] = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma altura!!!");
            NUMEROS[14] = double.Parse(Console.ReadLine());

            Array.Sort(NUMEROS);
            double maior = NUMEROS.Max();
            double menor = NUMEROS.Min();
            Console.WriteLine("A maior altura é {0}", maior);
            Console.Read();
            Console.WriteLine("A menor altura é {0}", menor);
           

            Console.ReadLine();













        }
    }
}
