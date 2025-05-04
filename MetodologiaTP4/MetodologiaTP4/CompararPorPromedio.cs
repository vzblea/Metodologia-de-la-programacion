using System;

namespace Practica_4
{
    public class CompararPorPromedio : IComparador
    {
        public bool SosIgual(Comparable a, Comparable b)
        {
            Alumno alumno1 = (Alumno)a;
            Alumno alumno2 = (Alumno)b;
            return alumno1.getPromedio() == alumno2.getPromedio(); 
        }

        public bool SosMayor(Comparable a, Comparable b)
        {
            Alumno alumno1 = (Alumno)a;
            Alumno alumno2 = (Alumno)b;
            return alumno1.getPromedio() > alumno2.getPromedio(); 
        }

        public bool SosMenor(Comparable a, Comparable b)
        {
            Alumno alumno1 = (Alumno)a;
            Alumno alumno2 = (Alumno)b;
            return alumno1.getPromedio() < alumno2.getPromedio();
        }
    }
}
