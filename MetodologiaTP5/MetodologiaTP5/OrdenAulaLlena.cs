using System;
namespace Practica_4
	
{

	public class OrdenAulaLlena : OrdenAula1
	{
		private Aula aula;
		public OrdenAulaLlena(Aula aula)
		{
			this.aula = aula;
		}
		
		// interfaz
		public void ejecutar()
		{
			this.aula.claseLista();
		}
		
	}
}