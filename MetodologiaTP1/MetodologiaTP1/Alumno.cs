using System;

public class Alumno : Persona {
        private Numero legajo;
        private Numero promedio;

        public Alumno(string nombre, Numero dni, Numero legajo, Numero promedio)
            : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public Numero getLegajo()
        {
            return this.legajo;
        }

        public Numero getPromedio()
        {
            return this.promedio;
        }

        public override bool sosIgual(Comparable comp)
        {
            Alumno otro = (Alumno)comp;
            return this.legajo.sosIgual(otro.getLegajo());
        }

        public override bool sosMenor(Comparable comp)
        {
            Alumno otro = (Alumno)comp;
            return this.legajo.sosMenor(otro.getLegajo());
        }

        public override bool sosMayor(Comparable comp)
        {
            Alumno otro = (Alumno)comp;
            return this.legajo.sosMayor(otro.getLegajo());
        }

        public override string ToString()
        {
            return base.ToString() + " - Legajo: " + legajo.ToString() + " - Promedio: " + promedio.ToString();
        }
    }

