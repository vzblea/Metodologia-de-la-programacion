using System;

namespace Practica_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			// Ejercicio 14 - Patrón Observer con Profesor
			Profesor profe = (Profesor)FabricaDeComparables.crearAleatorio(3); // tipo 3 = Profesor

			Coleccionable col = new Pila();
			llenar(col, 2); // tipo 2 = Alumnos

			Iterador iterador = col.crearIterador();
			for (iterador.actual(); !iterador.fin(); iterador.siguiente())
			{
				profe.agregarObservador((Observador)iterador.actual());
			}

			Console.WriteLine("Profesor: " + profe.getNombre());
			dictadoDeClase(profe);

			Console.ReadKey();
		}

		// ---------------- FUNCIONES AUXILIARES ----------------

		public static void llenar(Coleccionable coleccionable, int opcion)
		{
			for (int i = 0; i < 20; i++)
			{
				Comparable elemento = FabricaDeComparables.crearAleatorio(opcion);
				coleccionable.agregar(elemento);
			}
		}

		public static void informar(Coleccionable coleccionable, int opcion)
		{
			Console.WriteLine("Cantidad: " + coleccionable.cuantos());
			Console.WriteLine("Mínimo: " + coleccionable.minimo());
			Console.WriteLine("Máximo: " + coleccionable.maximo());

			Comparable elemento = FabricaDeComparables.crearPorTeclado(opcion);

			if (coleccionable.contiene(elemento))
				Console.WriteLine("El elemento leído está en la colección.");
			else
				Console.WriteLine("El elemento leído no está en la colección.");
		}

		public static void llenarAlumnos(Coleccionable coleccionable)
		{
			for (int i = 0; i < 20; i++)
			{
				Comparable elemento = FabricaDeComparables.crearAleatorio(2);
				coleccionable.agregar(elemento);
			}
		}

		public static void imprimirElementos(Coleccionable coleccionable)
		{
			Iterador iterador = coleccionable.crearIterador();
			for (iterador.actual(); !iterador.fin(); iterador.siguiente())
			{
				Console.WriteLine(iterador.actual());
			}
		}

		public static void cambiarEstrategia(Coleccionable coleccionable, IComparador estrategia)
		{
			Iterador iterador = coleccionable.crearIterador();
			for (iterador.actual(); !iterador.fin(); iterador.siguiente())
			{
				Alumno alumno = (Alumno)iterador.actual();
				alumno.setEstrategia(estrategia);
			}
		}

		public static void dictadoDeClase(Profesor profe)
		{
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine();
				profe.hablarEnClase();
				Console.WriteLine();
				profe.escribirEnElPizarron();
			}
		}
	}
}
