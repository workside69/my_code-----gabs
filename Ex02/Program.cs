using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Progrma que exercita tipos de coversao implicita e explicita

            //Type Conversion => Tipos de dados 
            // 2 tipos de conversao
            // IMplicita: Reaalizada peo pproprio C#
            // Explicitaa: Fica a cargo do progrmador

            //Decalarando e inicialiazando a variavel d
            double  d = 1233.345;

            //Declarando a variavel
            int i;

            //Casting
            i = (int)d;

            //Exibe a informaçao na saida padrao
            Console.Write(i);

        }
    }
}
