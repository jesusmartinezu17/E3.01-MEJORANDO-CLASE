using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEJORANDO_CLASE
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Listas = new ArrayList();
            int NumMaterias=0;
            string NombreMaterias;
            int NumAlumnos=0;
            string NameAlumnos;
            int Calificaciones;
            Console.WriteLine("Calificaciones de alumnos.");
            Console.WriteLine("Ingrese la cantidad de materias");
            NumMaterias = int.Parse(Console.ReadLine());// Ingresa la cantidad de materias
            for (int i=0; i<NumMaterias; i++)
            {
                Console.WriteLine("Ingrese nombre de la materia: ");
                NombreMaterias = Console.ReadLine();//Ingresa el nombre de la materia
                Console.WriteLine("Ingrese la cantidad de alumnos: ");
                NumAlumnos = int.Parse(Console.ReadLine());// Ingresa la cantidad de alumnos
                Listas.Add(NombreMaterias + " Alumnos: " + NumAlumnos);// Los agrega al arreglo de la lista
                for (int j=0; j<NumAlumnos; j++)
                {
                    Console.WriteLine("Ingrese nombre del alumno: ");
                    NameAlumnos = Console.ReadLine();// Ingresa el nombre de cada alumnos
                    Console.WriteLine("Ingrese su calificación: ");
                    Calificaciones = int.Parse(Console.ReadLine());// Ingresa la calificación
                    Listas.Add(NameAlumnos + ": " + Calificaciones);// Lo agrega a la lista de arreglo
                }
                Console.Clear();
            }
            foreach (var item in Listas)// Analiza todo los elementos guardados
            {
                Console.WriteLine(item);// Imprime cada elemento
            }
            Console.ReadKey();
        }
    }
}
