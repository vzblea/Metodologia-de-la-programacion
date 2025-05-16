using MetodologíasDeProgramaciónI;
using System;

namespace Practica_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hola mundo");
			
			
			
			Teacher teacher = new Teacher();
			
		 	// Crear 10 alumnos normales		
		    for (int i = 0; i < 10; i++)		
		    {		
				IAlumno alumnoDecorado = (IAlumno)FabricaDeComparables.crearAleatorio(5);	        
		        Student student = new AlumnoAdapter(alumnoDecorado);
		        teacher.goToClass(student);		
		    }				    
		    
		    // 10 alumnos muy estudiosos
		    for (int i = 0; i < 10; i++)		
		    {		
				IAlumno alumnoEstudiosoDecorado = (IAlumno)FabricaDeComparables.crearAleatorio(6);
		        Student student = new AlumnoAdapter(alumnoEstudiosoDecorado);		
		        teacher.goToClass(student);		
		    }
	
			teacher.teachingAClass();
			
				
			
			Cola cola = new Cola();
			Aula aula = new Aula();
			cola.setOrdenInicio(new OrdendeInicio(aula));
			cola.setOrdenLlegada(new OrdenLlegada(aula));
			cola.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			llenarAlumnos(cola, 5);
			llenarAlumnos(cola, 6);
			
			
			Console.ReadKey(true);
		}
		
		
		
	    public static void llenarAlumnos(Coleccionable coleccionable, int opcion)
	    {
	        
	    	for(int i = 0; i < 20; i++)
	        {
	    		Comparable elemento = FabricaDeComparables.crearAleatorio(opcion);
	    		coleccionable.agregar(elemento);
	        }
	    	
	    }
		
	}
}