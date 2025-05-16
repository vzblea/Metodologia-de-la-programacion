using System;

namespace Practica_4
{

	public interface Observado // El profesor
	{
		void agregarObservador(Observador o);
		void quitarObservador(Observador o);
		void notificar();
	}
}