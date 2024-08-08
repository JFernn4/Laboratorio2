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
        public static void AgregarHabitacionDoble(List<Habitacion> listaHabitaciones)
        {
            bool trycatch = true;
            int numero = 0;
            double precioPorNoche = 0;
            bool continuar = true;
            bool vistaAlMar = true;
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
                    while (continuar)
                    {
                        Console.Clear();
                        Console.WriteLine("Si tiene vista al mar presione 1. Si no, presione 2.");
                        int opcionVistaAlMar = Convert.ToInt32(Console.ReadLine());
                        if (opcionVistaAlMar == 1)
                        {
                            vistaAlMar = true;
                            continuar = false;
                        }
                        else if (opcionVistaAlMar == 2)
                        {
                            vistaAlMar = false;
                            continuar = false;
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar 1 o 2.");
                            Console.ReadKey();
                        }
                    }
                    HabitacionDoble habitacionDoble = new HabitacionDoble(numero, precioPorNoche, disponible, clienteAsignado, vistaAlMar);
                    listaHabitaciones.Add(habitacionDoble);
                    trycatch = false;
                }
                catch (Exception ex) { Console.Clear(); Console.WriteLine(ex.Message); Console.ReadKey(); }
            }
        }
    }
}
