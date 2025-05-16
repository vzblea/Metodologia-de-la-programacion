namespace Practica_4{
	
	public interface Iterador
{
    bool fin();             // ¿Ya terminó de recorrer?
    Comparable actual();    // Devuelve el elemento actual
    void siguiente();       // Avanza al siguiente
}

}