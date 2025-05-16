using System;
using MetodologíasDeProgramaciónI;

namespace Practica_4
{

	public class AlumnoAdapter : Comparable, Student
	{
		protected IAlumno alumno;
		
		public AlumnoAdapter(IAlumno alumno)
		{
			this.alumno = alumno;
		}
		
		
		// Implemento los métodos de Student
		public string getName()
		{
			return alumno.getNombre();
		}
		
		public IAlumno getAlumno()
		{
			return this.alumno;
		}
		
		public int yourAnswerIs(int question)
		{
			return alumno.responderPregunta(question);
		}
		
		public void setScore(int score)
		{
			alumno.setCalificacion(score);
		}
		
		public string showResult()
		{
			return alumno.mostrarCalificacion();
		}
		
		public bool equals(Student student)
		{
			Comparable stu = ((AlumnoAdapter)student).getAlumno();
			return alumno.sosIgual(stu);
		}
		
		public bool lessThan(Student student)
		{
			Comparable stu = ((AlumnoAdapter)student).getAlumno();
			return alumno.sosMenor(stu);
		}
		
		public bool greaterThan(Student student)
		{
			Comparable stu = ((AlumnoAdapter)student).getAlumno();
			return alumno.sosMayor(stu);
		}
		public bool sosIgual(Comparable c)
	    {
	        return alumno.sosIgual(c);
	    }
	
	    public bool sosMenor(Comparable c)
	    {
	        return alumno.sosMenor(c);
	    }
	
	    public bool sosMayor(Comparable c)
	    {
	        return alumno.sosMayor(c);
	    }
	}
		
	}
