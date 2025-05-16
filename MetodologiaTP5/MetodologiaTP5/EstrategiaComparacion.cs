using System;
namespace Practica_4{
	
	public interface IComparador
	{
   		bool sosIgual(IAlumno A, IAlumno B);
	    bool sosMenor(IAlumno A, IAlumno B);
	    bool sosMayor(IAlumno A, IAlumno B);
	}

}
