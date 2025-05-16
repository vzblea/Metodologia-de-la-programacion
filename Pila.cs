using System;
using System.Collections.Generic;

namespace Practica_4
{
    public class Pila : Coleccionable, Iterable, Ordenable
    {
        private List<Comparable> elementosComparables;
        private OrdenAula1 ordenInicio;
        private OrdenAula2 ordenLlegaAlumno;
        private OrdenAula1 ordenAulaLlena;
        private bool inicioEjecutado = false;

        public Pila()
        {
            this.elementosComparables = new List<Comparable>();
        }

        public void apilar(Comparable comp)
        {
            // Ejecutar OrdenInicio solo una vez al agregar el primer elemento
            if (!inicioEjecutado && ordenInicio != null)
            {
                ordenInicio.ejecutar();
                inicioEjecutado = true;
            }

            // Agregar el elemento a la colección
            this.elementosComparables.Add(comp);

            // Ejecutar OrdenLlegaAlumno después de OrdenInicio
            if (ordenLlegaAlumno != null)
            {
                ordenLlegaAlumno.ejecutar(comp);
            }

            // Ejecutar OrdenAulaLlena al recibir el elemento número 40
            if (this.cuantos() == 40 && ordenAulaLlena != null)
            {
                ordenAulaLlena.ejecutar();
            }
        }

        public Comparable desapilar()
        {
            if (this.elementosComparables.Count == 0)
                throw new Exception("La pila se encuentra vacía");

            Comparable comp = this.elementosComparables[this.elementosComparables.Count - 1];
            this.elementosComparables.RemoveAt(this.elementosComparables.Count - 1);
            return comp;
        }

        // Coleccionable
        public void agregar(Comparable comp)
        {
            this.apilar(comp); // Usamos apilar porque contiene la lógica de las órdenes
        }

        public int cuantos()
        {
            return elementosComparables.Count;
        }

        public bool contiene(Comparable comp)
        {
            foreach (Comparable elem in elementosComparables)
            {
                if (elem.sosIgual(comp))
                    return true;
            }
            return false;
        }

        public Comparable minimo()
        {
            if (elementosComparables.Count == 0)
                throw new Exception("La pila está vacía");

            Comparable minimo = elementosComparables[0];
            foreach (Comparable elem in elementosComparables)
            {
                if (elem.sosMenor(minimo))
                    minimo = elem;
            }
            return minimo;
        }

        public Comparable maximo()
        {
            if (elementosComparables.Count == 0)
                throw new Exception("La pila está vacía");

            Comparable maximo = elementosComparables[0];
            foreach (Comparable elem in elementosComparables)
            {
                if (elem.sosMayor(maximo))
                    maximo = elem;
            }
            return maximo;
        }

        // Iterable
        public Iterador crearIterador()
        {
            return new IteradorDeLista(this.elementosComparables);
        }

        // Ordenable (implementación de la interfaz)
        public void setOrdenInicio(OrdenAula1 orden)
        {
            this.ordenInicio = orden;
        }

        public void setOrdenLlegada(OrdenAula2 orden)
        {
            this.ordenLlegaAlumno = orden;
        }

        public void setOrdenAulaLlena(OrdenAula1 orden)
        {
            this.ordenAulaLlena = orden;
        }
    }
}
