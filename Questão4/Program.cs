using System;

namespace Questão4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero de 1 a 10");
            string numero = Console.ReadLine();
            int numeroA = Convert.ToInt32(numero);
            int vezes1 = numeroA * 1;
            int vezes2 = numeroA * 2;
            int vezes3 = numeroA * 3;
            int vezes4 = numeroA * 4;
            int vezes5 = numeroA * 5;
            int vezes6 = numeroA * 6;
            int vezes7 = numeroA * 7;
            int vezes8 = numeroA * 8;
            int vezes9 = numeroA * 9;
            int vezes10 = numeroA * 10;


            if (numeroA < 10 && numeroA > 1) 
            {
                Console.WriteLine("{0} x 1 = {1}", numeroA, vezes1);
                Console.WriteLine("{0} x 2 = {1}", numeroA, vezes2);
                Console.WriteLine("{0} x 3 = {1}", numeroA, vezes3);
                Console.WriteLine("{0} x 4 = {1}", numeroA, vezes4);
                Console.WriteLine("{0} x 5 = {1}", numeroA, vezes5);
                Console.WriteLine("{0} x 6 = {1}", numeroA, vezes6);
                Console.WriteLine("{0} x 7 = {1}", numeroA, vezes7);
                Console.WriteLine("{0} x 8 = {1}", numeroA, vezes8);
                Console.WriteLine("{0} x 9 = {1}", numeroA, vezes9);
                Console.WriteLine("{0} x 10 = {1}", numeroA, vezes10);

                Console.ReadKey();
                Console.WriteLine("DIGITE ALGO PARA FINALIZAR");

            }
            else
            {
                Console.WriteLine("Digite um numero de 1 a 10");
                string numero2 = Console.ReadLine();
                int numeroA2 = Convert.ToInt32(numero);
                int vezes12 = numeroA * 1;
                int vezes22 = numeroA * 2;
                int vezes32 = numeroA * 3;
                int vezes42 = numeroA * 4;
                int vezes52 = numeroA * 5;
                int vezes62 = numeroA * 6;
                int vezes72 = numeroA * 7;
                int vezes82 = numeroA * 8;
                int vezes92 = numeroA * 9;
                int vezes102 = numeroA * 10;

                Console.WriteLine("{0} x 1 = {1}", numeroA2, vezes12);
                Console.WriteLine("{0} x 2 = {1}", numeroA2, vezes22);
                Console.WriteLine("{0} x 3 = {1}", numeroA2, vezes32);
                Console.WriteLine("{0} x 4 = {1}", numeroA2, vezes42);
                Console.WriteLine("{0} x 5 = {1}", numeroA2, vezes52);
                Console.WriteLine("{0} x 6 = {1}", numeroA2, vezes62);
                Console.WriteLine("{0} x 7 = {1}", numeroA2, vezes72);
                Console.WriteLine("{0} x 8 = {1}", numeroA2, vezes82);
                Console.WriteLine("{0} x 9 = {1}", numeroA2, vezes92);
                Console.WriteLine("{0} x 10 = {1}", numeroA2, vezes102);

                Console.ReadKey();
                Console.WriteLine("DIGITE ALGO PARA FINALIZAR");


            }
            Console.ReadKey();
            Console.WriteLine("DIGITE ALGO PARA FINALIZAR");

       
        
        
        }
    }
}
