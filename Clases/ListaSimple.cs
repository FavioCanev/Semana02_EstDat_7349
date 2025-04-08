using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaSimple
    {
        public Nodo primero = null;

        //insertar
        public void insertar(Persona nom)
        {
            //1 crear nuevo nodo
            Nodo nuevo = new Nodo();
            nuevo.dato = nom;

            if (primero == null)
            {
                //la lista está vacía
                //el nuevo debe guardarse en el primero
                primero = nuevo;
            }
            else
            {
                //2 buscar el último
                Nodo temp = primero;
                //temp adopta el valor de primero
                while (temp.sig != null) //verificamos si el siguiente del temporal es diferente de nulo
                //creamos un bucle para recorrer la lista y verificar si es que tiene más de un elemento
                {
                    temp = temp.sig;
                    //el temporal adopta el valor de su siguiente
                }
                //temp está ubicado en el último
                //3 último.sig el nuevo
                temp.sig = nuevo;
            }
        }
        //mostrar
        public void mostrar()
        {
            Console.WriteLine("::: Lista de nombres completa:::");
            Nodo temp = primero;
            int i = 1;
            while (temp != null)
            {
                Console.WriteLine(i +". "+ temp.dato);
                temp = temp.sig;
                i++;
            }
        }

        public void buscar(string buscado)
        {
            string b = buscado.ToLower();

            Nodo temp = primero;
            while (temp != null)
            {
                if (buscado == temp.dato.nombre)
                {
                    Console.WriteLine("Persona encontrada!");
                    return;
                }
                temp = temp.sig;
            }
            Console.WriteLine("Persona NO encontrada!!!");
        }

        public void ordenarBurbuja()
        {
            Console.WriteLine("::: Lista ordenada :::");
            Nodo temp = primero;
            while (temp != null)
            {
                Nodo temp2 = primero;
                while (temp2.sig != null)
                {
                    if (temp2.dato.nombre[0] > temp2.sig.dato.nombre[0])
                    {
                        Persona aux = temp2.dato;
                        temp2.dato = temp2.sig.dato;
                        temp2.sig.dato = aux;
                    }
                    temp2 = temp2.sig;
                }
                temp = temp.sig;
            }
        }
    }
}
