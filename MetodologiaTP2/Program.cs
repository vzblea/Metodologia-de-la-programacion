using System;
using Practica_1;

namespace Practica_2
{
    class Program
    {
        private static Random random = new Random();

        public static void Main(string[] args)
        {
            Console.WriteLine("Comparación dinámica de alumnos en una pila\n");

            Pila pila = new Pila();
            llenarAlumnos(pila);

            aplicarEstrategia("Orden por nombre:", pila, new CompararPorNombre());
            aplicarEstrategia("Orden por legajo:", pila, new CompararPorLegajo());
            aplicarEstrategia("Orden por promedio:", pila, new CompararPorPromedio());
            aplicarEstrategia("Orden por DNI:", pila, new CompararPorDNI());

            /*
            // necesario para la implementacion ejercicio 7: 
            Cola cola = new Cola();
            Conjunto conjunto = new Conjunto();

            llenarAlumnos(cola);
            llenarAlumnos(conjunto);

            Console.WriteLine("\n--- Elementos de la PILA ---");
            imprimirElementos(pila);

            Console.WriteLine("\n--- Elementos de la COLA ---");
            imprimirElementos(cola);

            Console.WriteLine("\n--- Elementos del CONJUNTO ---");
            imprimirElementos(conjunto);
            */

            Console.ReadKey();
        }

        // Aplicar estrategia, mostrar título e información
        public static void aplicarEstrategia(string titulo, Coleccionable coleccion, IComparador estrategia)
        {
            cambiarEstrategia(coleccion, estrategia);
            Console.WriteLine("\n" + titulo);
            informar(coleccion);
        }

        // Cargar alumnos aleatorios en la colección
        public static void llenarAlumnos(Coleccionable coleccionable)
        {
            for (int i = 0; i < 20; i++)
            {
                string nombre = generarNombre();
                Numero dni = new Numero(random.Next(10000000, 99999999));
                Numero legajo = new Numero(random.Next(10000, 99999));
                Numero promedio = new Numero(random.Next(1, 11));

                Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
                alumno.setEstrategia(new CompararPorDNI()); // Estrategia inicial
                coleccionable.agregar(alumno);
            }
        }

        public static string generarNombre()
        {
            string[] nombres = { "Mateo", "Camila", "Thiago", "Valeria", "Juan", "Emilia", "Facundo", "Martina", "Lucas", "Abril" };
            string[] apellidos = { "Torres", "Benítez", "Muñoz", "Rivas", "Campos", "Leiva", "Acosta", "Cabrera", "Gutiérrez", "Herrera" };

            return nombres[random.Next(nombres.Length)] + " " + apellidos[random.Next(apellidos.Length)];
        }

        public static void informar(Coleccionable coleccionable)
        {
            Console.WriteLine("Cantidad: " + coleccionable.cuantos());
            Console.WriteLine("Mínimo: " + coleccionable.minimo());
            Console.WriteLine("Máximo: " + coleccionable.maximo());
        }

        public static void imprimirElementos(Coleccionable coleccionable)
        {
            if (coleccionable is Iterable)
            {
                Iterador iterador = ((Iterable)coleccionable).crearIterador();
                while (!iterador.fin())
                {
                    Console.WriteLine(iterador.actual());
                    iterador.siguiente();
                }
            }
            else
            {
                Console.WriteLine("Esta colección no se puede recorrer con iterador.");
            }
        }

        public static void cambiarEstrategia(Coleccionable coleccionable, IComparador estrategia)
        {
            if (coleccionable is Iterable)
            {
                Iterador iterador = ((Iterable)coleccionable).crearIterador();
                while (!iterador.fin())
                {
                    Comparable actual = iterador.actual();
                    if (actual is Alumno)
                    {
                        ((Alumno)actual).setEstrategia(estrategia);
                    }
                    iterador.siguiente();
                }
            }
        }
    }
}
