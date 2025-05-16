using System;

namespace Practica_4
{

	public class AlumnoMuyEstudioso : Alumno
	{
		
		public AlumnoMuyEstudioso(String nombre, Numero dni, Numero legajo, double promedio, int calificacion):base(nombre, dni, legajo, promedio, calificacion)
		{
		}
		
		public override int responderPregunta(int pregunta)
        {
            return pregunta % 3; // Modulo
        }
		
	}
}