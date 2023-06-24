using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main33(string[] args)
        {
             Console.WriteLine("Digite o numero de 0 a 10");
             int.TryParse(Console.ReadLine(), out int NumUsuario);
             int numerosorteado = 7;

             while (NumUsuario != numerosorteado)

             {
                 Console.WriteLine("Você errou");
                 NumUsuario = int.Parse(Console.ReadLine());

             }

             Console.WriteLine("Você acerto"); 

           //// for (int i = 0; i <= 100; i += 20) ;
           // // {
           //      Console.WriteLine($"Valor do contador {i}");
           //  }



            Console.WriteLine("Digite um numero:");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i ++) 
            {
                Console.WriteLine($"{numero}X{i} = {numero * i}");
            }







        }
    }
}
