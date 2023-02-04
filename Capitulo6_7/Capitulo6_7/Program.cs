using System;

namespace Capitulo6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int opcion = 0;
            
            Ejercicios ej = new Ejercicios();


            do
            {
                Console.Write("\n -----------MENU-----------\n\n 1) Capitulo #6 Ejercicios 2) Capitulo #7 Ejercicios  3) Salir\n\n ---Selecciona una opcion: ");
                opcion = Int16.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion) 
                {

                    case 1:
                        Console.Clear();
                        ej.Capitulo_6();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        ej.Capitulo_7();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        break;

                }


            } while (opcion != 3);
        }
    }
}
