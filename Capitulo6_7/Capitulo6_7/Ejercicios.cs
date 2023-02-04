using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6_7
{
    class Ejercicios
    {
        public void Capitulo_6()
        {

            int cantidad = 0;
            int salones = 0;
            int n = 0;
            int m = 0;
            string valor = "";


            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f;


            Console.WriteLine("Ingresar la cantidad de salones");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);

            float[][] calif = new float[salones][];

            for (n = 0; n < salones; n++)
            {
                Console.WriteLine($"Ingresar la cantidad de alumnos para el salon {0}", n);
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);
                calif[n] = new float[cantidad];
            }


            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("\nSalon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.Write("Ingresar calificación ");
                    valor = Console.ReadLine();
                    calif[n][m] = Convert.ToSingle(valor);

                    suma += calif[n][m];

                    if (calif[n][m] > maxima)

                        maxima = calif[n][m];

                    else if (calif[n][m] < minima)

                        minima = calif[n][m];
                }

                promedio = suma / calif[n].GetLength(0);
                Console.WriteLine($"El promedio de calificaciones es: {promedio}");

            }

            datos(calif, salones, m, maxima, minima);

        }

        public static void datos(float[][] calif, int salones, int m, float maxima, float minima)
        {

            Console.WriteLine("—— Datos ——");
            for (int n = 0; n < salones; n++)
            {
                Console.WriteLine("\nSalon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.WriteLine("El alumno {0} tiene {1}", m, calif[n][m]);
                }
                Console.Write($"\nLa mayor venta es: {maxima}");
                Console.Write($"\nLa menor venta es: {minima}");
            }
        }

        public void Capitulo_7()
        {


            int sumatoria = 0;

            int[] calificaciones = new int[15];
            int v, max = calificaciones[0], min = calificaciones[0];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese las calificaciones: ");
                v = int.Parse(Console.ReadLine());
                calificaciones[i] = v;
            }


            foreach (int i in calificaciones)
            {

                sumatoria += i;
            }

            int promedio = sumatoria / calificaciones.Length;
            Console.WriteLine("Promedio: " + promedio);
            Console.Write("\n\nLa mayor venta es: " + calificaciones.Max());
            Console.Write("\n\nLa menor venta es: " + calificaciones.Min() + "\n\n");
        }
    }
}
