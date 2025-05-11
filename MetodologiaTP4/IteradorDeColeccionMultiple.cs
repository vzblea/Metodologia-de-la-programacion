using System;
using System.Collections.Generic;

namespace Practica_4
{
    public class IteradorDeColeccionMultiple : Iterador
    {
        private List<Comparable> elementos;
        private int indice;

        public IteradorDeColeccionMultiple(Pila pila, Cola cola)
        {
            this.elementos = new List<Comparable>();
            this.indice = 0;

            // Agregar elementos de la pila
            Iterador iterPila = pila.crearIterador();
            for (iterPila.actual(); !iterPila.fin(); iterPila.siguiente())
                elementos.Add(iterPila.actual());

            // Agregar elementos de la cola
            Iterador iterCola = cola.crearIterador();
            for (iterCola.actual(); !iterCola.fin(); iterCola.siguiente())
                elementos.Add(iterCola.actual());
        }

        public void primero()
        {
            this.indice = 0;
        }

        public void siguiente()
        {
            this.indice++;
        }

        public bool fin()
        {
            return this.indice >= this.elementos.Count;
        }

        public Comparable actual()
        {
            return this.elementos[this.indice];
        }
    }
}
