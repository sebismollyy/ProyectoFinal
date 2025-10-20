class Program
{
    static void Main(string[] args)
    {
        ListaDoble lista = new ListaDoble();
        lista.AgregarAlFinal(10);
        lista.AgregarAlFinal(20);
        lista.AgregarAlFinal(30);



        Console.WriteLine("Mostrar desde el inicio:");
        lista.MostrarDesdeInicio();
        
        Console.WriteLine();

        Console.WriteLine("Mostrar desde el final:");
        lista.MostrarDesdeFinal();

        Console.WriteLine();

        lista.EliminarNodo(30); 
        Console.WriteLine("Lista desde el inicio después de eliminar 30:");
        lista.MostrarDesdeInicio();

        Console.WriteLine();

        Console.WriteLine("Lista desde el final después de eliminar 30:");
        lista.MostrarDesdeFinal();



    }

}