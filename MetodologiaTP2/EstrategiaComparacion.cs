using System;
namespace Practica_2{
	
	public interface IComparador
	{
   		bool SosIgual(Comparable a, Comparable b);
    	bool SosMayor(Comparable a, Comparable b);
    	bool SosMenor(Comparable a, Comparable b);
	}

}
