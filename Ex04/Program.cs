using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, resulatado;
            Console.Write("Digite um numero: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outronumer: ");
            resulatado = x + y;

            Console.Write("A soma dos números " + resulatado );

                       

        }
    }
}
