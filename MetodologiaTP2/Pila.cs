using System;
using System.Collections.Generic;
namespace Practica_2
{
    public class Pila : Coleccionable, Iterable
    {
        private List<Comparable> elementosComparables;

        public Pila()
        {
            this.elementosComparables = new List<Comparable>();
        }

        public void apilar(Comparable comp)
        {
            this.elementosComparables.Add(comp);
        }

        public Comparable desapilar()
        {
            if (this.elementosComparables.Count == 0)
                throw new Exception("La pila se encuentra vacía");

            Comparable comp = this.elementosComparables[this.elementosComparables.Count - 1];
            this.elementosComparables.RemoveAt(this.elementosComparables.Count - 1);
            return comp;
        }

        //Coleccionable
        public void agregar(Comparable comp)
        {
            this.apilar(comp);
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

        // Implementación de Iterable
        public Iterador crearIterador()
        {
            return new IteradorDeLista(this.elementosComparables);
        }
    }
}
