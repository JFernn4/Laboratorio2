using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class HabitacionDeluxe : Habitacion
    {
        public string ServiciosExtras {  get; set; }

        public HabitacionDeluxe(int numero, double precioPorNoche, bool disponible, string clienteAsignado, string serviciosExtras) : base (numero, precioPorNoche, disponible, clienteAsignado)
        {
            ServiciosExtras = serviciosExtras;
        }
    }
}
