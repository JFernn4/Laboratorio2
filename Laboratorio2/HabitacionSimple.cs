using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    public class HabitacionSimple : Habitacion
    {
        public int NumeroDeCamas { get; set; }

        public HabitacionSimple(int numero, double precioPorNoche, bool disponible, string clienteAsignado, int numeroDeCamas) :base (numero, precioPorNoche, disponible, clienteAsignado)
        {
            NumeroDeCamas = numeroDeCamas;
        }
    }
}
