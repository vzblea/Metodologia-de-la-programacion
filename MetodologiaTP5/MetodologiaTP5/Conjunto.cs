using System;
using System.Collections.Generic;

namespace Practica_4
{

    public class Conjunto : Coleccionable
    {
        private List<Comparable> elementos;

        public Conjunto()
        {
            this.elementos = new List<Comparable>();
        }

        public void agregar(Comparable c)
        {
            if (!pertenece(c))
            {
                elementos.Add(c);
            }
        }

        public bool pertenece(Comparable c)
        {
            foreach (Comparable elemento in elementos)
            {
                if (elemento.sosIgual(c))
                    return true;
            }
            return false;
        }

        public bool contiene(Comparable c)
        {
            return pertenece(c);
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public Comparable minimo()
        {
            Comparable min = elementos[0];
            foreach (Comparable elem in elementos)
            {
                if (elem.sosMenor(min))
                    min = elem;
            }
            return min;
        }

        public Comparable maximo()
        {
            Comparable max = elementos[0];
            foreach (Comparable elem in elementos)
            {
                if (elem.sosMayor(max))
                    max = elem;
            }
            return max;
        }
        	    // Implemento interfaz Iterable
	    public Iterador crearIterador()
	    {
	        return new IteradorDeLista(this.elementos);
	    }
	
    }
}
