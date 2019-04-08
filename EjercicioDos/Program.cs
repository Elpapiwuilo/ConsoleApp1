using System;

namespace EjercicioDos
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicioTwo();

        }

        public static void ejercicioTwo()
        {
          

            Console.WriteLine("Escribe un numero entero");
            var enteroone = 0;
            enteroone = Convert.ToInt32(Console.ReadLine());

            if (enteroone > 0 )
            {
                Console.WriteLine("Es un número positivo");

            }else if (enteroone<0)
            {
                Console.WriteLine($"Es un número positivo: {enteroone * -1}");
            }

            Console.ReadLine();
        }
        
    }
}
