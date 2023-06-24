using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main00(string[] args)
        {
            /*Console.WriteLine("Digite um numero");
            double numero = double.Parse(Console.ReadLine());
            Console.WriteLine(numero);

            //Try Parse
            Console.WriteLine("Digite o segundo numero");
            double numero2;
            double.TryParse(Console.ReadLine(), out numero2 double numero2);

            Console.WriteLine(numero2);*/


            double nota1;
            double nota2;
            double nota3;
            double media;
            double nota4;


            Console.WriteLine("Digite a primeira nota: ");

            double.TryParse(Console.ReadLine(), out nota1);

            Console.WriteLine("Digite a segunda nota: ");
            double.TryParse(Console.ReadLine(), out nota2);

            Console.WriteLine("Digite a terceira nota: ");
            double.TryParse(Console.ReadLine(), out nota3);

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("A media do aluno foi: " + media);
            Math.Round(media);
            Console.ReadKey();

            if (media >= 6)


            {
                Console.WriteLine("Aulno foi APROVADO!!!!");

            }
            else
            {
                Console.WriteLine("Aluno está de recuperação :(");
                Console.WriteLine("Digite a nova nota :");
                double.TryParse(Console.ReadLine(), out nota4);     
                media = (media + nota4) / 2;
                Math.Round(media);

                if (media >= 6)


                {
                    Console.WriteLine("Aulno foi APROVADO!!!!");

                }
                else
                {
                    Console.WriteLine("O ALUNO FOI REPROVADO :(");

                }






            }
            Console.ReadKey();



        }

    }
}













    
