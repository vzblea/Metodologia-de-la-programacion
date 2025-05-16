using System;
namespace Practica_4
	
{

	public class AlumnoProxy : IAlumno
	{
		
		private Alumno alumnoReal;
		
		private string nombreProxy;
		private int opcion;
		
		public AlumnoProxy(string nombre, int opcion)
		{
			this.nombreProxy = nombre;
			this.opcion = opcion;
		}
		
		// Implemento interface IAlumno
		
		// Lo que puede resolver
		public string getNombre()
		{
			return "Soy proxy: " + this.nombreProxy;
		}
		
		
		// no puede resolver
		public Numero getLegajo()
		{
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

			return alumnoReal.getLegajo();
		}
	    
	    public Numero getDNI()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

			return alumnoReal.getDNI();	    	
	    }
	    
	    public double getPromedio()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

			return alumnoReal.getPromedio();
	    }
	    
	    public int getCalificacion()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

			return alumnoReal.getCalificacion();	    	
	    }
	    
	    public void setCalificacion(int calificacion)
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

			alumnoReal.setCalificacion(calificacion);	    	
	    }
	    
	    public void setEstrategia (IComparador estrategia)  
	    {
	    	if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

	    	alumnoReal.setEstrategia(estrategia);
	    }
	    
	    public IComparador getEstrategia()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

			return alumnoReal.getEstrategia();	    	
	    }
	    	    
	    public void prestarAtencion()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

			alumnoReal.prestarAtencion();	    	
	    }
	    	    
	    public void distraerse()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

			alumnoReal.distraerse();	    	
	    }
	    	    
	    public void actualizar(Observado o)
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

			alumnoReal.actualizar(o);	    	
	    }
	    	  
	    public int responderPregunta(int pregunta)
	    {
	    	if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    		Console.WriteLine("se creó el alumno Real");
	    		alumnoReal.setNombre(this.nombreProxy);
	    	}

	    	return alumnoReal.responderPregunta(pregunta);
	    }
	    	    
	    public string mostrarCalificacion()
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

			return alumnoReal.mostrarCalificacion();	    	
	    }
	    
	    public bool sosIgual(Comparable comp)
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

			return alumnoReal.sosIgual(comp);	   	    	
	    }
	    
	    public bool sosMenor(Comparable comp)
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

			return alumnoReal.sosMenor(comp);	   	    	
	    }
	    	    
	    public bool sosMayor(Comparable comp)
	    {
			if (this.alumnoReal == null)
	    	{
	    		alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
	    	}

			return alumnoReal.sosMayor(comp);	   	    	
	    }	    	    	    
		
	}
}