using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            string nombre, contraseña;
            int convertir =0;
   
            Console.WriteLine("Escriba su numeron nombre");
            nombre= Console.ReadLine();
            Console.WriteLine("Escriba su contraseña");
            contraseña= Console.ReadLine();
            convertir = Convert.ToInt32(contraseña);
            Console.WriteLine("Hola bienvenido {0} y su contraseña es: {1}",nombre,convertir);
         
            
          
           

               Console.ReadLine();
            
        }
    }
}
