using System;

namespace Practica_4
	
{
	public class Alumno : Persona, Observador, IAlumno
	{
	    private Numero legajo;
	    private double promedio;
	    private int calificacion;
	    private Random rdn;
	
	    private IComparador estrategiaDeComparacion;
	
	    public Alumno(string nombre, Numero dni, Numero legajo, double promedio, int calificacion) : base(nombre, dni)
	    {
	        this.legajo = legajo;
	        this.promedio = promedio;
	        this.estrategiaDeComparacion = new ComparacionPorLegajo();
	        this.calificacion = calificacion;
	        this.rdn = new Random();
	    }
	
	    public Numero getLegajo()
	    {
	        return this.legajo;
	    }
	
	    public double getPromedio()
	    {
	        return this.promedio;
	    }

	    
	    public int getCalificacion()
	    {
	    	return this.calificacion;
	    }
	    
	    public void setCalificacion(int calificacion)
	    {
	    	this.calificacion = calificacion;
	    }
	    
	    public void setEstrategia (IComparador estrategia)
	    {
	        this.estrategiaDeComparacion = estrategia;
	    }    
	    
	    public override bool sosIgual(Comparable comp)
	    {
	    	IAlumno alu = (IAlumno)comp;
	        return this.estrategiaDeComparacion.sosIgual(this, alu);  
	    }
	
	    public override bool sosMenor(Comparable comp)
	    {
	    	IAlumno alu = (IAlumno)comp;
	        return this.estrategiaDeComparacion.sosMenor(this, alu); 
	    }
	
	    public override bool sosMayor(Comparable comp)
	    {
	    	IAlumno alu = (IAlumno)comp;
	        return this.estrategiaDeComparacion.sosMayor(this, alu); 
	    }
	    
	    public IComparador getEstrategia()
	    {
	    	return this.estrategiaDeComparacion;
	    }
	
	    public override string ToString()
	    {
	        return base.ToString() + " - Legajo: " + legajo.ToString() + " - Promedio: " + promedio.ToString();
	    }
	    
	    
	    public void prestarAtencion()
	    {
	    	Console.WriteLine("Alumno:" + this.nombre + ", prestando atencion.");
	    }
	    
	    
	    public void distraerse()
	    {	    	
	    	string[] frases = new String[] {"Mirando el celular.", "Dibujando en el margen de la carpeta.", "Tirando aviones de papel."};
	    	Console.WriteLine("Alumno: " + this.nombre + ", "  + frases[rdn.Next(0, 2)]);
	    }
	    
	    
	    public void actualizar(Observado o)
	    {
	    	if(((Profesor)o).isHablando())
	    	{
	    		this.prestarAtencion();
	    	}
	    	else
	    	{
	    		this.distraerse();
	    	}
	    }
	    
	    
	    public virtual int responderPregunta(int pregunta)
	    {
	    	GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
	    	return gen.numeroAleatorio(3);
	    }
	    
	    
	    public string mostrarCalificacion()
	    {
	    	return this.nombre + ", " + this.calificacion;
	    }
	    
	    
	}

}