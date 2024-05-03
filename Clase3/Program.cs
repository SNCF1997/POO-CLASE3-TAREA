using Clase3.Ejercicio1;
using Clase3.Ejercicio_2;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            #region Ejercicio 1


            // Crear clase Vehiculo con las siguientes propiedades: Marca, Modelo
            // Crear clase Moto que herede de Vehiculo  
            // Crear clase Auto que herede de 
            //Modificar el metodo "ImprimirDatosVehiculo" para que pueda imprimir los datos del Vehiculo independientemente de que si es una moto o un 
            //Uso
            //ImprimirDatosVehiculo(moto);
            //ImprimirDatosVehiculo(auto);
            Vehiculo auto1 = new Auto() { Marca = "Suzuki", Modelo = "Fun" };
            Vehiculo moto1 = new Moto() { Marca = "Kawasaki", Modelo = "Ninja" };
            static void ImprimirDatosVehiculo(Vehiculo vehiculo)
            {
                Console.WriteLine("Su vehiculo es un: {0}", vehiculo.Marca);
                Console.WriteLine("Y tiene el modelo: {0}", vehiculo.Modelo);
                Console.WriteLine(" ");
            }
            auto1.tipoDeVehiculo();
            ImprimirDatosVehiculo(auto1);
            moto1.tipoDeVehiculo();
            ImprimirDatosVehiculo(moto1);

            #endregion


            #region Ejercicio 2
            // Crear una interfaz que se llame IBiblioteca
            // Definir en la interfaz con una sola firma que indique que se va a obtener todos los libros
            // Implementar la interfaz en la clase biblioteca para que devuelva los libros
            // Instanciar y utilizar la clase biblioteca
            Libro libro2 = new Libro();
            libro2.Listado("Akira");
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Accept(libro2 as Libro);
            #endregion
        
        
        }
    }
}