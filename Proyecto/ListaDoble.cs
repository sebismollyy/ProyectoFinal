public class ListaDoble
{
    private Nodo cabeza;
    private Nodo cola;
    public ListaDoble()
    {
        cabeza = null;
        cola = null;
    }
    public void AgregarAlFinal(int Valor)
    {
        Nodo nuevoNodo = new Nodo(Valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
            cola = nuevoNodo;
        }
        else
        {
            cola.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = cola;
            cola = nuevoNodo;
        }
    }
    public void MostrarDesdeInicio()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            System.Console.WriteLine(actual.Valor);
            actual = actual.Siguiente;
        }
    }
    public void MostrarDesdeFinal()
    {
        Nodo actual = cola;
        while (actual != null)
        {
            System.Console.WriteLine(actual.Valor);
            actual = actual.Anterior;
        }
    }
               public void EliminarNodo(int valor)
    {
        Nodo actual = cabeza;

        while (actual != null)
        {
            if (actual.Valor == valor)
            {
                if (actual.Anterior != null)
                    actual.Anterior.Siguiente = actual.Siguiente;
                else
                    cabeza = actual.Siguiente;

                if (actual.Siguiente != null)
                    actual.Siguiente.Anterior = actual.Anterior;
                else
                    cola = actual.Anterior;

                break;
            }

            actual = actual.Siguiente;
        }
    }
}