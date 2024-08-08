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
        public static void AgregarHabitacionDeluxe(List<Habitacion> listaHabitaciones)
        {
            bool trycatch = true;
            int numero = 0;
            double precioPorNoche = 0;
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
                    Console.WriteLine("Ingrese los servicios extras.");
                    string serviciosExtras = Console.ReadLine();
                    HabitacionDeluxe habitacionDeluxe = new HabitacionDeluxe(numero, precioPorNoche, disponible, clienteAsignado, serviciosExtras);
                    listaHabitaciones.Add(habitacionDeluxe);
                    trycatch = false;
                }
                catch (Exception ex) { Console.Clear(); Console.WriteLine(ex.Message); Console.ReadKey(); }
            }
        }
    }
}
