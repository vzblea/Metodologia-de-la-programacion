using System;
namespace Practica_4{
	
	public class CompararPorDNI : IComparador
{
    public bool SosIgual(Comparable a, Comparable b)
    {
        Alumno alumno1 = (Alumno)a;
        Alumno alumno2 = (Alumno)b;
        return alumno1.getDNI().sosIgual(alumno2.getDNI());
    }

    public bool SosMayor(Comparable a, Comparable b)
    {
        Alumno alumno1 = (Alumno)a;
        Alumno alumno2 = (Alumno)b;
        return alumno1.getDNI().sosMayor(alumno2.getDNI());
    }

    public bool SosMenor(Comparable a, Comparable b)
    {
        Alumno alumno1 = (Alumno)a;
        Alumno alumno2 = (Alumno)b;
        return alumno1.getDNI().sosMenor(alumno2.getDNI());
    }
}

}
