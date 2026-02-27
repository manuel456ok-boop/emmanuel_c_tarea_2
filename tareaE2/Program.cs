using System;
namespace tareaE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            int n1, n2, n3, n4;
            double promedio;
            string sentencia;

            Console.Write("Ingrese el numero de alumnos: ");
            numeros = int.Parse(Console.ReadLine());

            // Arreglos para guardar los datos de cada alumno
            string[] nombres = new string[numeros];
            int[] notas1 = new int[numeros];
            int[] notas2 = new int[numeros];
            int[] notas3 = new int[numeros];
            int[] notas4 = new int[numeros];
            double[] promedios = new double[numeros];
            string[] sentencias = new string[numeros];

            // Ingreso de datos
            for (int i = 0; i < numeros; i++)
            {
                Console.Write($"\nIngrese el nombre del alumno {i + 1}: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese la primera nota: ");
                notas1[i] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la segunda nota: ");
                notas2[i] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la tercera nota: ");
                notas3[i] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cuarta nota: ");
                notas4[i] = int.Parse(Console.ReadLine());

                promedios[i] = (notas1[i] + notas2[i] + notas3[i] + notas4[i]) / 4.0;
                sentencias[i] = promedios[i] >= 70 ? "Aprobado" : "Reprobado";
            }

            // Mostrar tabla al final
            Console.WriteLine();
            Console.WriteLine($"{"Estudiante"} {"Nota 1"} {"Nota 2"} {"Nota 3"} {"Nota 4"} {"Promedio"} {"Estatus"}");
            Console.WriteLine(new string('-', 70));

            for (int i = 0; i < numeros; i++)
            {
                Console.WriteLine($"| {nombres[i]}| {notas1[i]} | {notas2[i]} | {notas3[i]} | {notas4[i]} | {promedios[i]:F2} | {sentencias[i]}|");
            }
        }
    }
}