using System;
namespace Practica_4{
	
	
    public abstract class Persona : Comparable
    {
        protected string nombre;
        protected Numero dni;

        public Persona(string nombre, Numero dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public Numero getDNI()
        {
            return this.dni;
        }

        // Implementación correcta de la interfaz Comparable
        public virtual bool sosIgual(Comparable comp)
        {
            Persona otra = (Persona)comp;
            return this.dni.sosIgual(otra.getDNI());
        }

        public virtual bool sosMenor(Comparable comp)
        {
            Persona otra = (Persona)comp;
            return this.dni.sosMenor(otra.getDNI());
        }

        public virtual bool sosMayor(Comparable comp)
        {
            Persona otra = (Persona)comp;
            return this.dni.sosMayor(otra.getDNI());
        }

        public override string ToString()
        {
            return this.nombre + " - DNI: " + this.dni.ToString();
        }
    }

}