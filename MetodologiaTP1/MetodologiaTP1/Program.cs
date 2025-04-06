﻿﻿using System;

namespace Practica_1
{
	class Program 
	{
	    // creo un random para usar luego
	    private static Random random = new Random();
	
	    public static void Main(string[] args)
	    {
	        Pila pila = new Pila();
	        Cola cola = new Cola();
	        ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
	
	        //llenar(pila);
	        //llenar(cola);
	
	        llenarAlumnos(pila);
	        llenarAlumnos(cola);
	
	        //Console.WriteLine("Informe Pila: ");
	        //informar(pila);
	        //Console.WriteLine("Informe Cola: ");
	        //informar(cola);
	        //Console.WriteLine("Informe Colección múltiple: ");
	
	        informar(multiple);
	        
	        Console.ReadKey();
	    }
	
	    // Funciones
	    public static void llenar(Coleccionable coleccionable)
	    {
	        for (int i = 0; i < 20; i++){
	            Comparable comparable = new Numero(random.Next(1, 51)); // Aleatorio del 1 al 50
	            coleccionable.agregar(comparable);
	        }
	    }
	
	    public static void informar(Coleccionable coleccionable)
	    {
	        Console.WriteLine("Cantidad: " + coleccionable.cuantos().ToString());
	        Console.WriteLine("Mínimo: " + coleccionable.minimo().ToString());
	        Console.WriteLine("Máximo: " + coleccionable.maximo().ToString());
	        Console.Write("Ingresar número: ");
	        
	        try {
	            
	            int valorBuscado = int.Parse(Console.ReadLine());
	            Numero comparableBuscado = new Numero(valorBuscado);
	
	            if (coleccionable.contiene(comparableBuscado))
	            {
	                Console.WriteLine("El elemento está en la colección");
	            }
	            else 
	            {
	                Console.WriteLine("El elemento leído no está en la colección");
	            }
	        }
	        catch (FormatException)
	        {
	            Console.WriteLine("El valor ingresado no es un número válido.");
	        }
	    }
	
	
	    public static void llenarAlumnos(Coleccionable coleccionable)
	    {
	        for(int i = 0; i < 20; i++)
	        {
	            string nombre = generarNombre(); // Funcion para generar nombres aleatorios.
	            Numero dni = new Numero(random.Next(10000000, 99999999));
	            Numero legajo = new Numero(random.Next(10000, 99999));
	            Numero promedio = new Numero(random.Next(1, 11));
	
	            Comparable alumno = new Alumno(nombre, dni, legajo, promedio);
	            coleccionable.agregar(alumno);
	        }
	    }
	
	    public static String generarNombre()
	    {
	        string[] nombres = { "Valentina", "Mateo", "Lucía", "Thiago", "Camila", "Benjamín", "Mía", "Felipe", "Julieta", "Dante" };
            string[] apellidos = { "Ruiz", "Alvarez", "Sosa", "Medina", "Herrera", "Aguirre", "Ortiz", "Giménez", "Ponce", "Mendoza" };
	
	        return nombres[random.Next(0 , nombres.Length)] + " " + apellidos[random.Next(0, apellidos.Length)];
	    }
	}
}