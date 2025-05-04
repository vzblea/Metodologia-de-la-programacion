using System;

namespace Practica_4
{
    public class StudentsFactory : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            // Creamos un Alumno base
            IAlumno alumnoBase = new Alumno(
                gen.stringAleatorio(),
                new Numero(gen.numeroAleatorio(10000000)),
                new Numero(gen.numeroAleatorio(10000)),
                new Numero(gen.numeroAleatorio(10))
            );

            alumnoBase.setCalificacion(gen.numeroAleatorio(10));

            // Decoramos al alumno
            IAlumno decorado = new DecoradorEstado(
                                   new DecoradorNotaLetras(
                                   new DecoradorLegajo(
                                   new DecoratorAsteriscos(alumnoBase))));

            // Adaptamos
            return new AlumnoAdapter(decorado);
        }

        public override Comparable crearPorTeclado()
        {
            IAlumno alumnoBase = new Alumno(
                LectorDeDatos.stringPorTeclado(), // nombre
                new Numero(LectorDeDatos.numeroPorTeclado()), // dni
                new Numero(LectorDeDatos.numeroPorTeclado()), // legajo
                new Numero(LectorDeDatos.numeroPorTeclado())  // promedio
            );

            alumnoBase.setCalificacion(LectorDeDatos.numeroPorTeclado());

            IAlumno decorado = new DecoradorEstado(
                                   new DecoradorNotaLetras(
                                   new DecoradorLegajo(
                                   new DecoratorAsteriscos(alumnoBase))));

            return new AlumnoAdapter(decorado);
        }
    }
}
