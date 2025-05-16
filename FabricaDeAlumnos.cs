﻿using System;

namespace Practica_4
{

	public class FabricaDeAlumnos : FabricaDeComparables
	{
				
		
		// Implemento metodos abstractos
		public override Comparable crearAleatorio()
		{
			return new Alumno(gen.nombreAleatorio(), new Numero(gen.numeroAleatorio(10000000)), new Numero(gen.numeroAleatorio(10000)), (double)(gen.doubleAleatorio(10)), (int)(gen.numeroAleatorio(10)));
		}
		
		
		public override Comparable crearPorTeclado()
		{
			return new Alumno(LectorDeDatos.stringPorTeclado(), new Numero(LectorDeDatos.numeroPorTeclado()), new Numero(LectorDeDatos.numeroPorTeclado()), (double)(LectorDeDatos.doublePorTeclado()), (int)(LectorDeDatos.numeroPorTeclado()));
		}
		
}
	}