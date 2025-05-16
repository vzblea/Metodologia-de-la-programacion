using System;
using System.Collections.Generic;

namespace Practica_4
{
    public class Cola : Coleccionable, Iterable, Ordenable
    {
        private List<Comparable> elementosComparables;
        private OrdenAula1 ordenInicio;
        private OrdenAula2 ordenLlegaAlumno;
        private OrdenAula1 ordenAulaLlena;
        private bool inicioEjecutado = false;

        public Cola()
        {
            this.elementosComparables = new List<Comparable>();
        }

        public void encolar(Comparable comp)
        {
            // Ejecutar OrdenInicio solo una vez al agregar el primer elemento
            if (!inicioEjecutado && ordenInicio != null)
            {
                ordenInicio.ejecutar();
                inicioEjecutado = true;
            }

            // Agregar el elemento
            this.elementosComparables.Add(comp);

            // Ejecutar OrdenLlegaAlumno después de OrdenInicio
            if (ordenLlegaAlumno != null)
            {
                ordenLlegaAlumno.ejecutar(comp);
            }

            // Ejecutar OrdenAulaLlena si llega al elemento 40
            if (this.cuantos() == 40 && ordenAulaLlena != null)
            {
                ordenAulaLlena.ejecutar();
            }
        }

        public Comparable desencolar()
        {
            if (elementosComparables.Count == 0)
                throw new Exception("La cola se encuentra vacía");

            Comparable primerElemento = this.elementosComparables[0];
            this.elementosComparables.RemoveAt(0);
            return primerElemento;
        }

        // Coleccionable
        public void agregar(Comparable comp)
        {
            this.encolar(comp); // encolar incluye la lógica de las órdenes
        }

        public int cuantos()
        {
            return this.elementosComparables.Count;
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
                throw new Exception("La cola está vacía");

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
                throw new Exception("La cola está vacía");

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

        // Ordenable (interfaz)
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
