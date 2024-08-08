using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class GestorHabitaciones
    {
        public static void EliminarHabitacion(List<Habitacion> listaHabitaciones)
        {
            try
            {
                Console.WriteLine("Ingrese el número de habitación que desea eliminar.");
                int habitacionEliminar = Convert.ToInt32(Console.ReadLine());
                Habitacion eliminar = listaHabitaciones.Find(p => p.Numero == habitacionEliminar);
                if (eliminar == null)
                {
                    Console.WriteLine("No se ha encontrado la habitación.");
                    Console.ReadKey();
                }
                else
                {
                    listaHabitaciones.Remove(eliminar);
                    Console.WriteLine("Se ha eliminado la habitación.");
                    Console.ReadKey();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); Console.ReadKey(); }
        }
    }
}
