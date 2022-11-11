using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreAlumno, primerApellido, segundoApellido, matriculaAlumno; 
            double calificacionUnidad1, calificacionUnidad2, calificacionUnidad3, calificacionUnidad4, calificacionUnidad5, calificacionFinal;


            Console.WriteLine("Escriba solo su nombre");//preguntar nombre
            nombreAlumno = Console.ReadLine();

            Console.WriteLine("Escriba su primer apellido");//preguntar primer apellido
            primerApellido = Console.ReadLine();

            Console.WriteLine("Escriba su segundo apellido");//preguntar segundo apellido
            segundoApellido = Console.ReadLine();

            Console.WriteLine("Escriba su matricula");//preguntar la matricula
            matriculaAlumno = Console.ReadLine();

            Console.WriteLine("Ingrese su calificación en la unidad 1");//preguntar la calificacion de la unidad 1
            calificacionUnidad1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su calficación en la unidad 2");//preguntar la calificacion de la unidad 2
            calificacionUnidad2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su calificacion en la unidad 3");//preguntar la calificacion de la unidad 3
            calificacionUnidad3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese su calificacion en la unidad 4");//preguntar la calificacion de la unidad 4
            calificacionUnidad4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su calificación en la unidad 5");//preguntar la calificacion de la unidad 5
            calificacionUnidad5 = Convert.ToDouble(Console.ReadLine());


            calificacionFinal = (calificacionUnidad1 + calificacionUnidad2 + calificacionUnidad3 + calificacionUnidad4 + calificacionUnidad5) / 5;
            //Hacer la operacion para poder sacar la calificacion final
            if (calificacionFinal >= 7)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;//cambiar de color la consola
                Console.Clear();

                Console.WriteLine("Aprobaste!!!");
                Console.WriteLine("Nombre: {0}, Primer apellido: {1}, Segundo apellido: {2}, Matricula: {3}, Calificación final: {4} ",
                    nombreAlumno, primerApellido, segundoApellido, matriculaAlumno, calificacionFinal);
                //mostra la informacion en una nueva consola
                Console.ReadKey();    
             }

            else
            {
                Console.WriteLine("Disculpe, no promedio la materia, tendrá que recursar");//en dado caso de no cumplir con lo minimo de la calificacion se ejecutara este bloque de comando
            }


            Console.WriteLine("Saliendo del sistema.");
            Thread.Sleep(800);
            Console.WriteLine("Saliendo del sistema..");
            Thread.Sleep(800);
            Console.WriteLine("Saliendo del sistema...");
            Thread.Sleep(800);
            Console.WriteLine("Saliendo del sistema....");
            Thread.Sleep(800);
        }//mensaje parea mostrar que esta saliendo de la consola
    }
}
