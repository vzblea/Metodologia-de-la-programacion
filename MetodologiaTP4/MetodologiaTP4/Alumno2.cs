using System;

namespace Practica_4
{
    public class Alumno : Persona, Observador, IAlumno
    {
        private Numero legajo;
        private Numero promedio;
        private IComparador estrategia;
       	private int calificacion;
	    private Random random;

        public Alumno(string nombre, Numero dni, Numero legajo, Numero promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            this.estrategia = new CompararPorLegajo();

        }

        public Numero getLegajo()
        {
            return this.legajo;
        }

        public double getPromedio()
        {
        	return this.promedio.getValor();
        }

        public void setEstrategia(IComparador estrategia)
        {
            this.estrategia = estrategia;
        }

        public override bool sosIgual(Comparable comp)
        {
            return estrategia.SosIgual(this, comp);
        }

        public override bool sosMenor(Comparable comp)
        {
            return estrategia.SosMenor(this, comp);
        }

        public override bool sosMayor(Comparable comp)
        {
            return estrategia.SosMayor(this, comp);
        }

        public override string ToString()
        {
            return base.ToString() + " - Legajo: " + legajo.ToString() + " - Promedio: " + promedio.ToString();
        }

        // Métodos del patrón Observer
        public void prestarAtencion()
        {
            Console.WriteLine("Alumno: " + this.getNombre() + ", prestando atención.");
        }

        public void distraerse()
        {
            Random rdn = new Random();
            string[] frases = new string[] {
                "Mirando el celular.",
                "Dibujando en el margen de la carpeta.",
                "Tirando aviones de papel."
            };
            int indice = rdn.Next(0, frases.Length);
            Console.WriteLine("Alumno: " + this.getNombre() + ", " + frases[indice]);
        }

        public void actualizar(Observado o)
        {
            Profesor profe = (Profesor)o;
            if (profe.isHablando())
            {
                this.prestarAtencion();
            }
            else
            {
                this.distraerse();
            }
            
        }
        public void setCalificacion(int calificacion)
		{
		    this.calificacion = calificacion;
		}

        public virtual int responderPregunta(int pregunta)
	    {
	    	GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
	    	return gen.numeroAleatorio(3);
	    }
		public int getCalificacion()
		{
			    return this.calificacion;
			}
			
		public IComparador getEstrategia()
		{
			    return this.estrategia;
			}
         
		public string mostrarCalificacion()
		{
		   return this.nombre + ", " + this.calificacion;
		}

	    
    }
}
