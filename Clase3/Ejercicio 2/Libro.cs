namespace Clase3.Ejercicio_2
{
    public class Libro : IBiblioteca
    {
        //public void todosLosLibros(List<string>nombreDeLibro)
        public void Listado(string nombreDeLibro)
        {
            Console.WriteLine("El libro de la biblioteca es: {0}",nombreDeLibro);
        }

    }
}
