using System;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pegando o resto de uma divisao

            int numero, resto;
            
            Console.Write("Digite um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            resto = numero % 2;

            Console.WriteLine("O resto da divisao de "  + numero + " por 2 é: " + resto );
        }
    }
}
