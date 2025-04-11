using System;
using Practica_1;
namespace Practica_2{
	
    public class Alumno : Persona
    {
        private Numero legajo;
        private Numero promedio;
        private IComparador estrategia;  // ← Uso la interfaz de comparación

        public Alumno(string nombre, Numero dni, Numero legajo, Numero promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            this.estrategia = new CompararPorLegajo(); 
        }

        // Getters
        public Numero getLegajo()
        {
            return this.legajo;
        }

        public Numero getPromedio()
        {
            return this.promedio;
        }

        public void setEstrategia(IComparador estrategia)
        {
            this.estrategia = estrategia;
        }

        public override bool sosIgual(Comparable comp)
        {
            return estrategia.SosIgual(this, comp);
        }

        public override bool sosMenor(Comparable comp)
        {
            return estrategia.SosMenor(this, comp);
        }

        public override bool sosMayor(Comparable comp)
        {
            return estrategia.SosMayor(this, comp);
        }

        public override string ToString()
        {
            return base.ToString() + " - Legajo: " + legajo.ToString() + " - Promedio: " + promedio.ToString();
        }
    }
}

