using System;
public class ColeccionMultiple : Coleccionable
	{
	    private Pila pila;
	    private Cola cola;
	
	    public ColeccionMultiple(Pila pila, Cola cola)
	    {
	        this.pila = pila;
	        this.cola = cola;   
	    }
	
	
	    // interfaz Coleccionable
	    public int cuantos()
	    {
	        return this.pila.cuantos() + this.cola.cuantos();
	    }
	
	    public Comparable minimo()
	    {
	         if (pila.cuantos() == 0 || cola.cuantos() == 0)
	        {
	            throw new Exception("Las colecciones no están completamente inicializadas, compruebe el contenido.");
	        }
	
	        Comparable minPila = this.pila.minimo();
	        Comparable minCola = this.cola.minimo();
	
	        if (minPila.sosMenor(minCola))
	        {
	            return minPila;
	        }
	        else
	        {
	            return minCola;
	        }
	    }
	
	    public Comparable maximo()
	    {
	        if (pila.cuantos() == 0 || cola.cuantos() == 0)
	        {
	            throw new Exception("Las colecciones no están completamente inicializadas, compruebe el contenido.");
	        }
	
	        Comparable maxPila = this.pila.maximo();
	        Comparable maxCola = this.cola.maximo();
	
	        if (maxPila.sosMayor(maxCola))
	        {
	            return maxPila;
	        }
	        else
	        {
	            return maxCola;
	        }
	    }
	
	    public void agregar(Comparable comp)
	    {
	        // Está implícito en la guía que el ejercicio agregar no debe hacer nada.
	    }
	
	    public bool contiene(Comparable comp)
	    {
	        return this.pila.contiene(comp) || this.cola.contiene(comp);
	    }
	
	}