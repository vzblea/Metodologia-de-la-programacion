using System;
namespace Practica_4
	
{
	// Ordenable = puede recibir ordenes
	public interface Ordenable
	{
		void setOrdenInicio(OrdenAula1 O);
		void setOrdenLlegada(OrdenAula2 O);
		void setOrdenAulaLlena(OrdenAula1 O);
	}
}