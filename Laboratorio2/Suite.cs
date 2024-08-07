using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class Suite : Habitacion
    {
        public int NumeroDeHabitaciones {  get; set; }
        public bool TieneJacuzzi {  get; set; }

        public Suite(int numero, double precioPorNoche, bool disponible, string clienteAsignado, int numeroDeHabitaciones, bool tieneJacuzzi) : base (numero, precioPorNoche, disponible, clienteAsignado)
        {
            NumeroDeHabitaciones = numeroDeHabitaciones;
            TieneJacuzzi = tieneJacuzzi;
        }
    }
}
