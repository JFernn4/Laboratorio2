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
        public static void AgregarSuite (List<Habitacion> listaHabitaciones)
        {
            bool trycatch = true;
            int numero = 0;
            double precioPorNoche = 0;
            int numeroDeHabitaciones = 0;
            bool continuar = true;
            bool tieneJacuzzi=true;
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
                    if (numeroDeHabitaciones == 0)
                    {
                        Console.WriteLine("Ingrese el número de habitaciones de la suite.");
                        numeroDeHabitaciones = Convert.ToInt32(Console.ReadLine());
                    }
                    while (continuar)
                    {
                        Console.Clear();
                        Console.WriteLine("Si tiene jacuzzi, presione 1. Si no, presione 2.");
                        int opcionJacuzzi = Convert.ToInt32(Console.ReadLine());
                        if (opcionJacuzzi == 1)
                        {
                            tieneJacuzzi = true;
                            continuar = false;
                        }
                        else if (opcionJacuzzi == 2)
                        {
                            tieneJacuzzi = false;
                            continuar = false;
                        }
                        else
                        {
                            Console.WriteLine("Dedbe ingresar 1 o 2.");
                            Console.ReadKey();
                        }
                    }
                    Suite suite = new Suite(numero, precioPorNoche, disponible, clienteAsignado, numeroDeHabitaciones, tieneJacuzzi);
                    listaHabitaciones.Add(suite);
                    trycatch = false;
                }
                catch (Exception ex) { Console.Clear(); Console.WriteLine(ex.Message); Console.ReadKey(); }
            }
        }
    }
}
