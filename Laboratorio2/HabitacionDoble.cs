using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class HabitacionDoble : Habitacion
    {
        public bool VistaAlMar {  get; set; }

        public HabitacionDoble(int numero, double precioPorNoche, bool disponible, string clienteAsignado, bool vistaAlMar) : base(numero, precioPorNoche, disponible, clienteAsignado)
        {
            VistaAlMar = vistaAlMar;
        }
    }
}
