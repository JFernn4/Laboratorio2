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
        public static void AgregarHabitacionSimple(List<Habitacion> listaHabitaciones)
        {
            bool trycatch = true;
            int numero = 0;
            double precioPorNoche = 0;
            int numeroDeCamas = 0;
            while (trycatch)
            {
                try
                { 
                    if (numero == 0)
                    {
                        Console.WriteLine("Ingrese el número de la habitación.");
                        numero = Convert.ToInt32(Console.ReadLine());
                    }
                    if (precioPorNoche == 0)
                    {
                        Console.WriteLine("Ingrese el precio por noche de la habitación.");
                        precioPorNoche = Convert.ToDouble(Console.ReadLine());
                    }
                    bool disponible = true; //Al agregar una nueva habitación se asume que está vacía
                    string clienteAsignado = "Vacío."; //Si está vacía significa que no tiene cliente asignado por defecto.
                    if (numeroDeCamas == 0)
                    {
                        Console.WriteLine("Ingrese el número de camas.");
                        numeroDeCamas = Convert.ToInt32(Console.ReadLine());
                    }
                    HabitacionSimple habitacionSimple = new HabitacionSimple(numero, precioPorNoche, disponible, clienteAsignado, numeroDeCamas);
                    listaHabitaciones.Add(habitacionSimple);
                    trycatch = false;
                }
                catch (Exception ex) { Console.Clear(); Console.WriteLine(ex.Message); Console.ReadKey(); }
            }
        }
    }
}
