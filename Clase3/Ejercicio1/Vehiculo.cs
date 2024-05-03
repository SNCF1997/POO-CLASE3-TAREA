using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1
{
    public class Vehiculo
    {
        public string Marca{ get; set; }
        public string Modelo { get; set; }

        public virtual void tipoDeVehiculo() { Console.WriteLine("No se que vehiculo usas"); }
    }
}
