using System;

namespace Practica_4
{

	public class DecoradorEstado : AlumnoDecorator
	{
		public DecoradorEstado(IAlumno alumno) : base(alumno)
		{
		}
		
		public override string mostrarCalificacion()
		{	
			if (this.alumnoAdicional.getCalificacion() >= 7)
			{
				return base.mostrarCalificacion() + " (PROMOCIONADO)";
			}
			else if (this.alumnoAdicional.getCalificacion() >= 4)
			{
				return base.mostrarCalificacion() + " (APROBADO)";
			}
			else {
				return base.mostrarCalificacion() + " (DESAPROBADO)";
			}
		}
		
	}
}