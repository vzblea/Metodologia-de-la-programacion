using System;
using MetodologíasDeProgramaciónI;

namespace Practica_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// EJERCICIO 8
			
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
			
			
			
			
			
			/* EJERCICIO 4
			FabricaDeAlumnos fabricaAlumnos = new FabricaDeAlumnos();
			
			Teacher teacher = new Teacher();
			
		 	// Crear 10 alumnos normales		
		    for (int i = 0; i < 10; i++)		
		    {		
		        Alumno alumno = (Alumno)fabricaAlumnos.crearAleatorio();		
		        Student student = new AlumnoAdapter(alumno);		
		        teacher.goToClass(student);		
		    }				    
		    FabricaAlumnosMuyEstudiosos f = new FabricaAlumnosMuyEstudiosos();
		    // Crear 10 alumnos muy estudiosos		
		    for (int i = 0; i < 10; i++)		
		    {		
		    	AlumnoMuyEstudioso alumnoEstudioso = (AlumnoMuyEstudioso)f.crearAleatorio();
		        Student student = new AlumnoAdapter(alumnoEstudioso);		
		        teacher.goToClass(student);		
		    }
			
			teacher.teachingAClass();
			
			*/
			
			
			
			Console.ReadKey(true);
		}
	}
}