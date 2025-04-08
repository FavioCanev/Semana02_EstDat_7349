using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Random random = new Random();
            string nombre1;
            char aleatorio = ' ';
            for (int i = 0; i < 10; i++)
            {
                aleatorio = (char)random.Next(97, 123);
                Console.Write(aleatorio);
                nombre1 = aleatorio
                aleatorio++;
            }
            */

            ListaSimple ls = new ListaSimple();
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("::: Lista d números :::");
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Mostrar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Ordenar");
                Console.WriteLine("0. Salir");
                Console.Write("INGRESA UNA OPCIÓN: ");
                Console.WriteLine("Prueba de actualización commit github");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;

                    case 1:
                        Console.Clear();
                        Persona nombre = new Persona();

                        Console.Write("Ingresa un nombre a registrar: ");
                        nombre.nombre = Console.ReadLine();

                        Console.Write("Ingresa un teléfono a registrar: ");
                        nombre.telefono = int.Parse(Console.ReadLine());

                        Console.Write("Ingresa un correo a registrar: ");
                        nombre.correo = Console.ReadLine(); 

                        ls.insertar(nombre);
                        Console.WriteLine("Se ha registrado exitosamente!");
                        break;

                    case 2:
                        Console.Clear();
                        ls.mostrar();
                        break;

                    case 3:
                        string buscado;
                        Console.Clear();
                        Console.Write("A quién estás buscando?: ");
                        buscado = Console.ReadLine();
                        ls.buscar(buscado);
                        break;
                    case 4:
                        Console.Clear();
                        ls.ordenarBurbuja();
                        Console.WriteLine("Ordenado: ");
                        ls.mostrar();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.ReadKey();
            }
            while (op != 0);
        }
    }
}
