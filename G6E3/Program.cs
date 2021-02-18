using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6E3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * PROGRAMACION ESTRUCTURADA 07L
             * GUIA 6 EJERCICIO 3
             * 
             * OSCAR ROLANDO CAÑAS VALDIZON
             */

            //VARIABLES
            bool error1 = true, error2 = true;
            string lados, l1_leght, l2_leght, l3_leght;
            int numTriang = 0, l1 = 0, l2 = 0, l3 = 0, equi = 0, iso = 0, esca = 0;
            //CICLO PARA OBTENER LOS DATOS
            while(error1 == true)
            {
                try
                {
                    Console.WriteLine("Ingrese el numero de triangulos a comparar...");
                    numTriang = int.Parse(Console.ReadLine());
                    Console.WriteLine(numTriang);
                    error1 = false;
                }
                catch
                {
                    error1 = true;
                    Console.WriteLine("Error, el numero ingresado no es valido...\nPRESIONE CUALQUIER TECLA y vuelvalo a intentar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            //CICLOS PARA OBTENER DATOS DE CADA TRIANGULO
            for (int i = 0; i < numTriang; i++)
            {
                while(error2 == true)
                {
                    try
                    {
                        error2 = false;
                        Console.WriteLine("Bien, ahora ingrese el valor de cada lado separados con comas 'l1,l2,l3' o '1,2,3' (sin comilla simple)");
                        lados = Console.ReadLine();
                        l1_leght = lados.Substring(0, lados.IndexOf(','));
                        l2_leght = lados.Substring(l1_leght.Length + 1, lados.IndexOf(','));
                        l3_leght = lados.Substring(l1_leght.Length + l2_leght.Length + 2, lados.IndexOf(','));
                        l1 = int.Parse(l1_leght);
                        l2 = int.Parse(l2_leght);
                        l3 = int.Parse(l3_leght);
                    }
                    catch
                    {
                        error2 = true;
                        Console.WriteLine("Error, el numero ingresado no es valido...\nPRESIONE CUALQUIER TECLA y vuelvalo a intentar");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    bool cond1 = l1 != l2 && l1 == l3 && l2 != l3;
                    bool cond2 = l1 != l2 && l1 != l3 && l2 == l3;
                    bool cond3 = l1 == l2 && l1 != l3 && l2 != l3;

                    if (l1 == l2 && l1 == l3 && l2 == l3)
                    {
                        equi++;
                        error2 = true;
                    }
                    else if (cond1 == true || cond2 == true || cond3 == true)
                    {
                        iso++;
                        error2 = true;
                    }
                    else if (l1 != l2 && l1 != l3 && l2 != l3)
                    {
                        esca++;
                        error2 = true;
                    }
                    Console.WriteLine("\nTRIANGULOS CONTADOS:");
                    Console.WriteLine("Equilateros: " + equi + "\nIsoceles: " + iso + "\nEscaleno: " + esca);
                }
                error2 = true;
                Console.WriteLine('\n');
            }
            Console.ReadKey();
        }
    }
}
