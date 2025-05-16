using System;

namespace Practica_4
{

	public class ComparacionPorLegajo : IComparador
	{
	    public bool sosIgual(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getLegajo().sosIgual(alumnoB.getLegajo());
	    }
	
	    public bool sosMenor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getLegajo().sosMayor(alumnoB.getLegajo());
	    }
	
	    public bool sosMayor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getLegajo().sosMayor(alumnoB.getLegajo());
	    }
	
	}
	
}