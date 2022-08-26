using System;
using System.Collections;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Lista = new ArrayList();
            Console.WriteLine("Cantidad: {0}", Lista.Count);
            Console.WriteLine("Cantidad: {0}", Lista.Capacity);
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Lista.Add("Dato" + i);
            }
            Console.WriteLine("Cantidad: {0}", Lista.Count);
            Console.WriteLine("Cantidad: {0}", Lista.Capacity);
            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                Lista.Add("Dato" + i);
            }
            Console.WriteLine("Cantidad: {0}", Lista.Count);
            Console.WriteLine("Cantidad: {0}", Lista.Capacity);
            Console.WriteLine();
            foreach(string row in Lista)
            {
                Console.WriteLine(row);
            }
            Console.WriteLine("=======================Eliminar rango================");
            Lista.RemoveRange(4, 4);
            Lista.RemoveRange(10, 4);
            foreach(string row in Lista)
            {
                Console.WriteLine(row);
            }
            Lista.Clear();
            Console.WriteLine("Cantidad: {0}", Lista.Count);
            Console.WriteLine("Cantidad: {0}", Lista.Capacity);

        }
    }
}
