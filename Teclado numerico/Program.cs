using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.Linq;

namespace Teclado_numerico
{
    class Program
    {
        static void Main(string[] args)
        {
            Busqueda datos = new Busqueda();
            string input = " ";
            Console.WriteLine("Ingrese una palabra para convertir:");
            input = "hola";
            Console.WriteLine("Se creará el codigo para la palabra: " + input);
            datos.buscar(input);
        }
    }
}
