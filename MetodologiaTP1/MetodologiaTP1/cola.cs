using System;
using System.Collections;
using System.Collections.Generic;


	public class Cola : Coleccionable
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
	        {
	            throw new Exception("La cola se encuentra vacía");
	        }
	        
	        Comparable primerElemento = this.elementosComparables[0];
	        this.elementosComparables.RemoveAt(0);
	
	        return primerElemento;
	    }
	
	
	    // Implementamos la interfaz Coleccionable
	    public int cuantos()
	    {
	        return this.elementosComparables.Count;
	    }
	
	    public Comparable minimo()
	    {
	        if (elementosComparables.Count == 0)
	        {
	            throw new Exception("La lista se encuentra vacia");
	        }
	
	        Comparable minimo = this.elementosComparables[0];
	
	        for(int i = 1; i < this.cuantos(); i++)
	        {
	            if (this.elementosComparables[i].sosMenor(minimo))
	            {
	                minimo = this.elementosComparables[i];
	            }
	        }
	
	        return minimo;
	    }
	
	    public Comparable maximo()
	    {
	        if (elementosComparables.Count == 0)
	        {
	            throw new Exception("La lista se encuentra vacia");
	        }
	
	        Comparable maximo = this.elementosComparables[0];
	
	        for(int i = 1; i < this.cuantos(); i++)
	        {
	            if (this.elementosComparables[i].sosMayor(maximo))
	            {
	                maximo = this.elementosComparables[i];
	            }
	        }
	
	        return maximo;
	    }
	
	    public void agregar(Comparable comp)
	    {
	        this.elementosComparables.Add(comp);
	    }
	
	    public bool contiene(Comparable comp)
	    {
	        for(int i = 0; i < this.cuantos(); i++)
	        {
	            if (this.elementosComparables[i].sosIgual(comp))
	            {
	                return true;
	            }
	        }
	        return false;
	    }
	
	}
	
