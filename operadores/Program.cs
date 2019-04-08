using System;

namespace operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            miFuncion();
        }
        public static void miFuncion()
        {
            var password = 1234;
            var passwordAnidada = 4567;
            string login = "Pedro",loginAnidado="Sebastian";
            int contra=0,edad=0,contraTwo;
            string logueo, gustos="", other=" ",logueoTwo;
            var change = " ";
            int count = 0,recorder;          
            for (count = 1; count <= 3; count++)
            {
                Console.WriteLine("Ingrese su password");
                contra = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su Correo");
                logueo = Convert.ToString(Console.ReadLine());
                if (contra == password & logueo == login)
                {
                    Console.WriteLine(" su contraseña esta correcta: {0} y su contraseña :{1} ", password,logueo);
                    break;
                }
                else
                {
                    Console.WriteLine("Acceso denegado");
                }
                if (count == 3)
                {
                    Console.WriteLine("Numero de intentos elevado");
                    Console.WriteLine("No recuerda su contraseña oprima 1");
                    recorder= Convert.ToInt32(Console.ReadLine());
                    if (recorder == 1)
                    {
                        Console.WriteLine("Ingrese su Correo");
                        logueo = Console.ReadLine();
                        while (logueo != login)
                        {
                            Console.WriteLine("Ingrese su Correo");
                            logueo = Console.ReadLine();
                        }
                        Console.WriteLine("Su password es {0}: ", password);                   
                    }
                }
            }
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Deseas rellenar tus datos personales escribe si");
            change = Convert.ToString(Console.ReadLine());
            if (change == "si")
            {
                Console.WriteLine("Cuantos años tienes");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Que es lo que mas te gusta hacer");
                gustos = Convert.ToString(Console.ReadLine());

                if (edad<18)
                {
                    Console.WriteLine("Eres menor de edad no puedes adquirir un perfil aun");
                 
                }
                else
                {
                    Console.WriteLine("Acceso denegado");

                }
                Console.WriteLine("Deseas acceder con otra cuenta escribe si");
                other = Convert.ToString(Console.ReadLine());
                if (other== "si")
                {
                   
                    for (count = 1; count <= 3; count++)
                    {
                        Console.WriteLine("Ingrese su password");
                        contraTwo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese su Correo");
                        logueoTwo = Convert.ToString(Console.ReadLine());
                        if (contraTwo == passwordAnidada & logueoTwo == loginAnidado)
                        {
                            Console.WriteLine(" su contraseña esta correcta: {0} y su contraseña :{1} ", passwordAnidada, loginAnidado);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Acceso denegado");
                        }
                        if (count == 3)
                        {
                            Console.WriteLine("Numero de intentos elevado");
                            Console.WriteLine("No recuerda su contraseña oprima 1");
                            recorder = Convert.ToInt32(Console.ReadLine());
                            if (recorder == 1)
                            {
                                Console.WriteLine("Ingrese su Correo");
                                logueoTwo = Console.ReadLine();
                                while (logueoTwo != loginAnidado)
                                {
                                    Console.WriteLine("Ingrese su Correo");
                                    logueoTwo = Console.ReadLine();
                                }
                                Console.WriteLine("Su password es {0}: ", passwordAnidada);
                                break;
                            }



                        }

                    }

                }

                Console.WriteLine("Informacion de perfil de: {0} " ,login);
                Console.WriteLine("Tu edad es: {0}", edad);

                Console.WriteLine("lo que mas te gusta hacer es: {0}", gustos);

            }


            Console.ReadLine();
        }
    }
}
