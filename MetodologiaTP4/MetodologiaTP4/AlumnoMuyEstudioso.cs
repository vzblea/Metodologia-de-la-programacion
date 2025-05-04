using System;

namespace Practica_4
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, Numero dni, Numero legajo, Numero promedio, int calificacion)
            : base(nombre, dni, legajo, promedio) 
        {
           
        }

        public override int responderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
