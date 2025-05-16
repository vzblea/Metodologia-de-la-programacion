using System;

namespace Practica_4
{

	public class ComparacionPorPromedio : IComparador
	{
	    public bool sosIgual(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getPromedio() == alumnoB.getPromedio();
	    }
	
	    public bool sosMenor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getPromedio() < alumnoB.getPromedio();
	    }
	
	    public bool sosMayor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getPromedio() > alumnoB.getPromedio();
	    }
	
	}
	
}