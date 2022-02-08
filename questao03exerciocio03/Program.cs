using System;

namespace questao03exerciocio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int soma = 0;
            for (int numero = 1; numero <= 500; numero++) 
            {
                if (numero % 2 != 0) 
                {
                    if (numero % 3 == 0) 
                    {

                        soma = soma + numero;

                    }


                }



            }
            Console.WriteLine("O resultado da soma é {0}", soma);
            Console.ReadKey();
            Console.WriteLine("Aperte alguma tecla para finalizar");
;


        
        
        
        
        }
    }
}
