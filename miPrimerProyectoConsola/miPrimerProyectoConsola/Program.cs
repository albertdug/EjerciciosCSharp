using System;
using System.Collections.Generic;
using System.Text;

namespace miPrimerProyectoConsola
{
    class Program
    {
        int Valor1, Valor2;
        string Nombre, Titulo;
        double resultado;

        public void CapturarDatos() {            

            Console.Write("Digame cual sera el Titulo de la Aplicacion:");
            Titulo = Console.ReadLine();
            Console.Write("Proporcioneme su Nombre:");
            Nombre = Console.ReadLine();
            Console.Write("Proporcioneme el Valor 1:");
            Valor1 = Int32.Parse(Console.ReadLine());
            Console.Write("Proporcioneme el Valor 2:");
            Valor2 = Int32.Parse(Console.ReadLine());
            resultado = Valor1 + Valor2;
        }

        public void MostrarResultados() {
            Console.WriteLine();
            Console.WriteLine(Titulo);
            Console.WriteLine("Felicidades " + Nombre + " a creado su primera aplicacion.");
            Console.WriteLine("El valor de la Suma de los datos Ingresados es:" + resultado);
            Console.Read();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.CapturarDatos();
            p.MostrarResultados();
        }
    }
}
