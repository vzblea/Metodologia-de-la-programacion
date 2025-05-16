using System;

namespace Practica_4
{

	public class ComparacionPorNombre : IComparador
	{
	    public bool sosIgual(IAlumno alumnoA, IAlumno alumnoB)
	    {
	    	return alumnoA.getNombre() == alumnoB.getNombre();
	    }
	
	    public bool sosMenor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	        String nombreA = ((IAlumno)alumnoA).getNombre();
	        String nombreB = ((IAlumno)alumnoB).getNombre();
	        return nombreA.CompareTo(nombreB) < 0; 

	    }
	
	    public bool sosMayor(IAlumno alumnoA, IAlumno alumnoB)
	    {
	        String nombreA = ((IAlumno)alumnoA).getNombre();
	        String nombreB = ((IAlumno)alumnoB).getNombre();
	        return nombreA.CompareTo(nombreB) > 0; 
	    }
		        // Si nombreA es menor que nombreB, devuelve un numero negativo.
	        // Si son iguales devuelve cero. Si es mayor devuelve positivo.
	}

}