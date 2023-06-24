using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var nota = 5;
             switch (nota)
             {
                 case 1:
                     Console.WriteLine("Nota foi pessima");
                     break;



                 case 2:
                     Console.WriteLine("Nota foi ruim");
                       break;
                 case 3:
                     Console.WriteLine("Nota foi regular");
                     break;

                 case 4:
                     Console.WriteLine("Nota foi bom");
                     break;

                 case 5:
                     Console.WriteLine("Nota foi ótimo");
                     break;

                 default: Console.WriteLine("Você não foi avaliado");
                     break;
             } */



            
            


            





















            /*double nota = 6;
            double nota2 = 9;

            var res = nota + nota2 / 2 >= 7;
            Console.WriteLine($"O aluno está aprovado");*/



            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu peso em kg:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / altura * altura;

            Console.WriteLine($"Olá {nome}Seu IMC {imc.ToString()} é: ");

            if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("IMC está dentro do intervalo saudável");


            }
            else 
             {
                Console.WriteLine("IMC não está saudável");
            }    

            




        }
    }
}
