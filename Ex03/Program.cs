using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string  nome = Console.ReadLine();
            Console.Write("Digite sua idade");
            string idade = Console.ReadLine();
            Console.WriteLine( "Olá" + nome + "sua iade é  " +  idade );


                //Soluçao  2

                string nome;
                int idade;

                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();

                Console.Write("Digitr sua idae: ");
                idade = Convert.ToInt32 (Console.ReadLine());

                Console.Write("O usuario " + nome + " tem " + idade + " anos de idade");




        }
    }
}
