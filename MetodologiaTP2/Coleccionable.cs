namespace Practica_2{
	
	public interface Coleccionable
{
    int cuantos();
    Comparable minimo();
    Comparable maximo();
    void agregar(Comparable c);
    bool contiene(Comparable c);
}

}