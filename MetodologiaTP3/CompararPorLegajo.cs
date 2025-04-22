using System;
namespace Practica_3{
	
	public class CompararPorLegajo : IComparador
{
    public bool SosIgual(Comparable a, Comparable b)
    {
        Alumno alumno1 = (Alumno)a;
        Alumno alumno2 = (Alumno)b;
        return alumno1.getLegajo().sosIgual(alumno2.getLegajo());
    }

    public bool SosMayor(Comparable a, Comparable b)
    {
        Alumno alumno1 = (Alumno)a;
        Alumno alumno2 = (Alumno)b;
        return alumno1.getLegajo().sosMayor(alumno2.getLegajo());
    }

    public bool SosMenor(Comparable a, Comparable b)
    {
        Alumno alumno1 = (Alumno)a;
        Alumno alumno2 = (Alumno)b;
        return alumno1.getLegajo().sosMenor(alumno2.getLegajo());
    }
}

}