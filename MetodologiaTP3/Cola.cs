using System;
using System.Collections.Generic;


namespace Practica_3
{
    public class Cola : Coleccionable, Iterable
    {
        private List<Comparable> elementosComparables;

        public Cola()
        {
            this.elementosComparables = new List<Comparable>();
        }

        public void encolar(Comparable comp)
        {
            this.elementosComparables.Add(comp);
        }

        public Comparable desencolar()
        {
            if (elementosComparables.Count == 0)
                throw new Exception("La cola se encuentra vacía");

            Comparable primerElemento = this.elementosComparables[0];
            this.elementosComparables.RemoveAt(0);
            return primerElemento;
        }

        //  Coleccionable
        public void agregar(Comparable comp)
        {
            this.encolar(comp);
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

        // Implementación de Iterable
        public Iterador crearIterador()
        {
            return new IteradorDeLista(this.elementosComparables);
        }
    }
}
