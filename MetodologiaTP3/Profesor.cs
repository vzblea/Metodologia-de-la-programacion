using System;
using System.Collections.Generic;

namespace Practica_3
{

	public class Profesor : Persona, Observado
	{
		private int antiguedad;
		
		private List<Observador> observadores; 
		private bool hablando;
		
		public Profesor(string nombre, Numero dni, int antiguedad):base(nombre,dni)
		{
			this.antiguedad=antiguedad;			
			this.observadores = new List<Observador>();
		}
		
		public int getAntiguedad()
		{
			return this.antiguedad;
		}
		
		public bool isHablando()
		{
			return this.hablando;
		}
		
		public void hablarEnClase()
		{
			Console.WriteLine("Hablando de algún tema");
			this.hablando = true;
			this.notificar();
		}
		
		public void escribirEnElPizarron()
		{
			Console.WriteLine("Escribiendo en el pizarrón");
			this.hablando = false;
			this.notificar();
		}
		
		
		// Metodos de Comparable
		public override bool sosIgual(Comparable comp)
		{
			return this.antiguedad == ((Profesor)comp).getAntiguedad();
		}
		
		public override bool sosMenor(Comparable comp)
		{
			return this.antiguedad < ((Profesor)comp).getAntiguedad();
		}
		
		public override bool sosMayor(Comparable comp)
		{
			return this.antiguedad > ((Profesor)comp).getAntiguedad();
		}
		
		public override string ToString()
	    {
			return base.ToString() + "- Antiguedad: " + this.antiguedad.ToString();
	    }
		
		// Implemento Observado
		public void agregarObservador(Observador o)
		{
			this.observadores.Add(o);
		}
		
		public void quitarObservador(Observador o)
		{
			this.observadores.Remove(o);
		}
		
		public void notificar()
		{
			foreach (Observador observador in observadores)
			{				
				observador.actualizar(this);
			}			
		}
		
	}
}