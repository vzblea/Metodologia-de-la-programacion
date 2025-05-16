using System;

namespace Practica_4
{
	public abstract class AlumnoDecorator : IAlumno
	{
		
		protected IAlumno alumnoAdicional;
		
		public AlumnoDecorator(IAlumno alumno)
		{
			this.alumnoAdicional = alumno;
		}
		
		public string getNombre()
		{
			return alumnoAdicional.getNombre();
		}
		
		public Numero getDNI()
		{
			return alumnoAdicional.getDNI();
		}
		
		public bool sosIgual(Comparable comp)
	    {
			return this.alumnoAdicional.sosIgual(comp);
	    }
	
	    public bool sosMenor(Comparable comp)
	    {
	    	return this.alumnoAdicional.sosMenor(comp);
	    }
	
	    public bool sosMayor(Comparable comp)
	    {
	    	return this.alumnoAdicional.sosMayor(comp);
	    }
				
		
		public Numero getLegajo()
		{
			return this.alumnoAdicional.getLegajo();
		}

		public IComparador getEstrategia()
		{
			return this.alumnoAdicional.getEstrategia();
		}
		
	    public double getPromedio()
	    {
	    	return this.alumnoAdicional.getPromedio();
	    }

	    
	    public int getCalificacion()
	    {
	    	return this.alumnoAdicional.getCalificacion();
	    }

	    
	    public void setCalificacion(int calificacion)
	    {
	    	this.alumnoAdicional.setCalificacion(calificacion);
	    }

	    
	    public void setEstrategia (IComparador estrategia)
	    {
	    	this.alumnoAdicional.setEstrategia(estrategia);
	    }
  	
	    	    
	    public void prestarAtencion()
	    {
	    	this.alumnoAdicional.prestarAtencion();
	    }

	    	    
	    public void distraerse()
	    {
	    	this.alumnoAdicional.distraerse();
	    }

	    	    
	    public void actualizar(Observado o)
	    {
	    	this.alumnoAdicional.actualizar(o);
	    }

	    	    
	    public int responderPregunta(int pregunta)
	    {
	    	return this.alumnoAdicional.responderPregunta(pregunta);
	    }

	    	    
	    public virtual string mostrarCalificacion(){
	    	return this.alumnoAdicional.mostrarCalificacion();
	    }
		
		
		
	}
}