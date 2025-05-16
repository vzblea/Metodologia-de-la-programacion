namespace Practica_4{
	
	public interface Coleccionable: Iterable
{
    int cuantos();
    Comparable minimo();
    Comparable maximo();
    void agregar(Comparable c);
    bool contiene(Comparable c);
}

}