using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    public class Habitacion
    {
        public int Numero { get; set; }
        public double PrecioPorNoche { get; set; }
        public bool Disponible { get; set; }
        public string ClienteAsignado { get; set; }

        public Habitacion(int numero, double precioPorNoche, bool disponible, string clienteAsignado)
        {
            Numero = numero;
            PrecioPorNoche = precioPorNoche;
            Disponible = disponible;
            ClienteAsignado = clienteAsignado;
        }
        public static void MostrarInformacion (List<Habitacion> listaHabitaciones)
        {
            foreach (Habitacion habitacion in listaHabitaciones)
            {
                if (habitacion is HabitacionSimple habitacionSimple)
                {
                    string estado = "Disponible";
                    if (habitacionSimple.Disponible == true)
                    {
                        estado= "Disponible";
                    }
                    else  if (habitacionSimple.Disponible == false)
                    {
                        estado = "Ocupada";
                    }
                    Console.WriteLine("HABITACIÓN SIMPLE");
                    Console.WriteLine($"Número de habitación: {habitacionSimple.Numero}.  Precio por noche: Q.{habitacionSimple.PrecioPorNoche}. Estado: {estado}. Cliente asignado: {habitacionSimple.ClienteAsignado} Número de camas: {habitacionSimple.NumeroDeCamas}");
                }
                if (habitacion is HabitacionDoble habitacionDoble)
                {
                    string estado = "Disponible";
                    string vistas = "Sin vistas al mar";
                    if (habitacionDoble.VistaAlMar==true)
                    {
                        vistas = "Con vistas al mar";
                    }
                    else if (habitacionDoble.VistaAlMar == false)
                    {
                        vistas = "Sin vistas al mar";
                    }
                    if (habitacionDoble.Disponible==true)
                    {
                        estado = "Disponible";
                    }
                    else if (habitacionDoble.Disponible==false)
                    {
                        estado = "Ocupada";
                    }
                    Console.WriteLine("HABITACIÓN DOBLE");
                    Console.WriteLine($"Número de habitación: {habitacionDoble.Numero}. Precio por noche: Q.{habitacionDoble.PrecioPorNoche}. Estado: {estado}. Cliente asignado: {habitacionDoble.ClienteAsignado} Vistas: {vistas}.");
                }
                if (habitacion is Suite suite)
                {
                    string estado = "Disponible";
                    string jacuzzi = "Tiene jacuzzi";
                    if (suite.TieneJacuzzi == true)
                    {
                        jacuzzi = "Tiene jacuzzi";
                    }
                    else if (suite.TieneJacuzzi==false)
                    {
                        jacuzzi = "No tiene jacuzzi";
                    }
                    if (suite.Disponible == true)
                    {
                        estado = "Disponible";
                    }
                    else if (suite.Disponible==false)
                    {
                        estado = "Ocupada";
                    }
                    Console.WriteLine("SUITE");
                    Console.WriteLine($"Número de habitación: {suite.Numero}. Precio por noche: Q.{suite.PrecioPorNoche}. Estado: {estado}. Cliente asignado: {suite.ClienteAsignado} Número de habitaciones: {suite.NumeroDeHabitaciones}. {jacuzzi}.");
                }
                if (habitacion is HabitacionDeluxe habitacionDeluxe)
                {
                    string estado = "Disponible";
                    if (habitacionDeluxe.Disponible == true)
                    {
                        estado = "Disponible";
                    }
                    else if (habitacionDeluxe.Disponible == false)
                    {
                        estado = "Ocupada";
                    }
                    Console.WriteLine("HABITACIÓN DELUXE");
                    Console.WriteLine($"Número de habitación: {habitacionDeluxe.Numero}. Precio por noche: Q.{habitacionDeluxe.PrecioPorNoche}. Estado: {estado}. Cliente asignado: {habitacionDeluxe.ClienteAsignado} Servicios extras: {habitacionDeluxe.ServiciosExtras}");
                }
            }
            Console.ReadKey();
        }
        public static void CambiarDisponibilidad(Habitacion habitacion)
        {
            habitacion.Disponible = false;
        }
        public static void AsignarHabitacionACliente(List<Habitacion> listaHabitaciones)
        {
            try
            {
            Console.WriteLine("Ingrese el número de habtiación que desea asignar.");
            int habitacionBuscar = Convert.ToInt32(Console.ReadLine());
            Habitacion buscar = listaHabitaciones.Find(p => p.Numero == habitacionBuscar);
                if (buscar == null)
                {
                    Console.WriteLine("No se ha encontrado la habitación.");
                    Console.ReadKey();
                }
                else
                {
                    if (buscar is HabitacionSimple habitacion || buscar is HabitacionDoble habitacionDoble || buscar is Suite suite || buscar is HabitacionDeluxe habitacionDeluxe)
                    {
                        Console.WriteLine("Ingrese el nombre del cliente");
                        string nuevoCliente = Console.ReadLine();
                        buscar.ClienteAsignado = nuevoCliente;
                        Console.WriteLine($"Se ha asignado la habitación {buscar.Numero} al cliente {buscar.ClienteAsignado}.");
                        Habitacion.CambiarDisponibilidad(buscar);
                    }
                    Console.ReadKey();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); Console.ReadKey(); }
        }
        public static void LiberarHabitacionACliente(List<Habitacion> listaHabitaciones)
        {
            try
            {
                Console.WriteLine("Ingrese el número de habtiación que desea liberar.");
                int habitacionBuscar = Convert.ToInt32(Console.ReadLine());
                Habitacion buscar = listaHabitaciones.Find(p => p.Numero == habitacionBuscar);
                if (buscar == null)
                {
                    Console.WriteLine("No se ha encontrado la habitación.");
                    Console.ReadKey();
                }
                else
                {
                    if (buscar is HabitacionSimple habitacion || buscar is HabitacionDoble habitacionDoble || buscar is Suite suite || buscar is HabitacionDeluxe habitacionDeluxe)
                    {
                        buscar.Disponible = true;
                        buscar.ClienteAsignado = "Vacío.";
                    }
                }
                Console.WriteLine("Se ha liberado la habitación.");
                Console.ReadKey();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); Console.ReadKey(); }
        }
    }
}
