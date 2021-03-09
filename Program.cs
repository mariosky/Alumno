using System;
using System.Collections.Generic;

    class Alumno
      {
        public string nombre;
        public string apellido;
        public int calificación;

    public void ImprimeSaludo()
        {
        Console.WriteLine("Hi {0} {1} my grade is {2}", nombre, apellido, calificación);
        }

    public void Califica(int cal)
      {
        calificación = cal;
      }
    }

class AlumnoPosgrado : Alumno
{


}



class Program
    {

    static void ImprimeSaludo(Alumno a)
    {
        Console.WriteLine("Hola {0} {1} my grade is {2}", a.nombre, a.apellido, a.calificación);
    }

    static void Califica(ref Alumno a, int cal)
    {

        a.calificación = cal;

    }

        static void Main()
        {

        int x = 10;

        Alumno ana = new Alumno();
        ana.nombre = "Ana";
        ana.apellido = "Li";
        //ana.calificación = 90;

        ana.Califica(90);

        //Califica(ref ana, 90);


        Alumno tom = new Alumno();
        tom.nombre = "Tom";
        tom.apellido = "Lee";
        //tom.calificación = 80;
        // Califica(ref tom, 80);
        tom.Califica(80);

        ana.ImprimeSaludo();
        tom.ImprimeSaludo();

        //ImprimeSaludo(ana);
        //ImprimeSaludo(tom);


        //Console.WriteLine("Hola {0} {1}", tom.nombre, tom.apellido);

        Console.ReadKey();

        }
    }
