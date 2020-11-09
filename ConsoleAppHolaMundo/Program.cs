using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo C#");
            Console.WriteLine("Integracopn de VS con GIT");
            

            //imprimir la suma de 2 numeros
            Console.WriteLine("La suma de 10 + 20:{0} ", (10 + 20));
            

            //Welcome
            Console.WriteLine("Bienvenido");
            Console.WriteLine("2-semestre");

            //End-class
            Console.WriteLine("class finish");

            Console.WriteLine("LA suma de 10 + 20 {0}", funcionSuma(10, 20));
                       
            Console.ReadKey();
        }
        public static int funcionSuma(int a, int b)
        {
            return (a+b);
        }
    }
}
