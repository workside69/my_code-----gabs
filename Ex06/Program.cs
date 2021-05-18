using System;

namespace Ex06

 {

     //Objetivo do progrma calcular a área do retangulo
     //Data....; 18-05-2021
     //Programador: Gabriel-Aguiar
    class Program
    {
        static void Main(string[] args)
        {   
            //Declaraçao de variaveis
            double baseRet, altura, area;
            
           

           Console.Write("Digite a base do retagulo:  ");
            baseRet =  double.Parse( Console.ReadLine());

            Console.Write("Digite a base do retagulo:  ");
            altura =  double.Parse( Console.ReadLine());


            //Formula do Calculo da area: Produto da altura pela base

            area = baseRet * altura;
            Console.Write("A area do retangulo é: " + area);
  

        }
    }
}
