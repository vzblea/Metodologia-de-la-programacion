using System.Collections.Generic;

namespace Practica_4
{
    public class IteradorDeLista : Iterador
    {
        private List<Comparable> lista;
        private int indice;

        public IteradorDeLista(List<Comparable> lista)
        {
            this.lista = lista;
            this.indice = 0;
        }

        public void primero()
        {
            indice = 0;
        }

        public void siguiente()
        {
            indice++;
        }

        public bool fin()
        {
            return indice >= lista.Count;
        }

        public Comparable actual()
        {
            return lista[indice];
        }
    }
}
