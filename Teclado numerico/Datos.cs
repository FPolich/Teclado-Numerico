using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.Linq;

namespace Teclado_numerico
{
    public class Datos
    {
        public string Tecla { get; set; }
        public int Number { get; set; }

        public Datos(){}
    }

    public class Busqueda : Datos
    {      
        public void buscar (string input)
        {
            List<Datos> teclado = new List<Datos>();

        teclado.Add(new Datos() {Tecla = " ", Number=0});
        teclado.Add(new Datos() {Tecla = "abc", Number=2});
        teclado.Add(new Datos() {Tecla = "def", Number=3});
        teclado.Add(new Datos() {Tecla = "ghi", Number=4});
        teclado.Add(new Datos() {Tecla = "jkl", Number=5});
        teclado.Add(new Datos() {Tecla = "mno", Number=6});
        teclado.Add(new Datos() {Tecla = "pqrs", Number=7});
        teclado.Add(new Datos() {Tecla = "tuv", Number=8});
        teclado.Add(new Datos() {Tecla ="wxyz", Number=9});

            //i para guardar cantidad de espacios, j para el numero de la letra, k para repetir lo que sea necesario, l para guardar cuantas veces repite
            int i=0, j=0;
            int k, l=0;
            while (i < input.Length)
            {
                if (input[i] == ' ')
                {
                    i++;
                }
                    //Tomo una letra de la palabra
                    string letraInput = input.Substring(i,1);
                    //Console.WriteLine("letraInput " + letraInput);

                    foreach (var index in teclado)
                    {
                        string tecla = index.Tecla;
                        string letraTecla = "";

                        for (int ind=0; ind<tecla.Length ; ind++)
                            {
                                letraTecla = tecla.Substring(ind,1);
                                if (letraInput == letraTecla)
                                {
                                    j = index.Number;
                                    l = ind;
                                }
                            }

                    //Console.WriteLine("mostrando resultados, tecla:"+tecla+",letraTecla:"+letraTecla+",j:"+j);
                    }
                //muestro el codigo para la palabra
                for (k=0; k <= l; k++)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine(" ");
                i++;
            }
        }
    }
}