using System;

namespace laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe dos numeros enteros");
            var enteroone = 0;
            var enterotwo = 0;

            enteroone = Convert.ToInt32(Console.ReadLine());
            enterotwo = Convert.ToInt32(Console.ReadLine());

            if (enteroone < 0 & enterotwo < 0)
            {
                Console.WriteLine("Sus numeros son  negativos");
 
            }
            
            if (enteroone > 0 & enterotwo > 0)
            {
                Console.WriteLine("Sus numeros son  positivos");
            }
            if (enteroone > 0 || enterotwo > 0)
            {
                Console.WriteLine("Su numero es positivo");
            }

            if (enteroone < 0 || enterotwo < 0)
            {
                Console.WriteLine("Su numero es negativo");
              
            }
           
           
            Console.ReadLine();


        }
    }
}
