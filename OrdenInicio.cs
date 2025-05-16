using System;
namespace Practica_4
	
{

	public class OrdendeInicio : OrdenAula1
	{
		private Aula aula;
		
		public OrdendeInicio(Aula aula)
		{
			this.aula = aula;
		}
		
		// Implemento interfaz
		public void ejecutar()
		{
			this.aula.comenzar();
		}
	}
}