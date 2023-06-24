using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Array
    {
        public static void Main11 ()
        {

            /*int[] numeros = new int[4] { 5, 6, 7, 8 };
            Console.WriteLine($"Acessando os numeros {numeros[1]}");

            string[] salaAula = new string[] { "bala", "bala2" };*/

            string[] linguagem = new string[5] {"Java", "Pynton", "JavaScript", "Cshap", "PHP"};
            Console.WriteLine($"Acessando as linguagens {linguagem [3]}" );

            linguagem[0] = "Java";
            linguagem[1] = "PHP";
            linguagem[2] = "JavaScript";

            Console.WriteLine($"Linguagem: {linguagem[2]}");

            
            
            
            








        }




    }
}
