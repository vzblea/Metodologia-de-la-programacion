namespace Practica_3{
	
	public class Numero : Comparable
{
    private int valor;

    public Numero(int v)
    {
        this.valor = v;
    }

    public int getValor()
    {
        return valor;
    }

    public bool sosIgual(Comparable c)
    {
        Numero otro = (Numero)c;
        return this.valor == otro.getValor();
    }

    public bool sosMenor(Comparable c)
    {
        Numero otro = (Numero)c;
        return this.valor < otro.getValor();
    }

    public bool sosMayor(Comparable c)
    {
        Numero otro = (Numero)c;
        return this.valor > otro.getValor();
    }
    public override string ToString()
{
    return valor.ToString();
}

    
}

}
