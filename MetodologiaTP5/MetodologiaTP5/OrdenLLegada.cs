using System;
namespace Practica_4
	
{

	public class OrdenLlegada : OrdenAula2
	{
		private Aula aula;
		public OrdenLlegada(Aula aula)
		{
			this.aula = aula;
		}
		
		// Implemento interfaz
		public void ejecutar(Comparable comp)
		{
			this.aula.nuevoAlumno((IAlumno)comp);
		}
		
	}
}