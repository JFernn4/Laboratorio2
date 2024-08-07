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
                    Console.WriteLine($"Número de habitación: {suite.Numero}. Precio por noche: Q.{suite.PrecioPorNoche}. Estado: {estado}. Cliente asignado: {suite.ClienteAsignado} Número de habitaciones: {suite.NumeroDeHabitaciones}. {estado}.");
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
                    Console.WriteLine($"Número de habitación: {habitacionDeluxe.Numero}. Precio por noche: Q.{habitacionDeluxe.PrecioPorNoche}. Estado: {estado}. Cliente asignado: {habitacionDeluxe.ClienteAsignado} Servicios extras: {habitacionDeluxe.ServiciosExtras}");
                }
            }
            Console.ReadKey();
        }
    }
}
