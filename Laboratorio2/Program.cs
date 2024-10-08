﻿using Laboratorio2;

int opcion;
bool menu = true;
List <Habitacion>listaHabitaciones = new List <Habitacion> ();
while (menu)
{
    Console.Clear();
    ShowMenu();
    try
    {
        opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                {
                    int opcionAgregar;
                    bool menuAgregar = true;
                    while (menuAgregar)
                    {
                        Console.Clear();
                        Console.WriteLine("¿Qué tipo de habitación desea agregar?");
                        Console.WriteLine("1. Habitación simple.");
                        Console.WriteLine("2. Habitación doble.");
                        Console.WriteLine("3. Suite.");
                        Console.WriteLine("4. Habitación deluxe.");
                        Console.WriteLine("5. Salir.");
                        try
                        {
                            opcionAgregar = Convert.ToInt32(Console.ReadLine());
                            switch (opcionAgregar)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        HabitacionSimple.AgregarHabitacionSimple(listaHabitaciones);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Clear();
                                        HabitacionDoble.AgregarHabitacionDoble(listaHabitaciones);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Clear();
                                        Suite.AgregarSuite(listaHabitaciones);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Clear();
                                        HabitacionDeluxe.AgregarHabitacionDeluxe(listaHabitaciones);
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.Clear();
                                        menuAgregar = false;
                                        break;
                                    }
                            }
                        }
                        catch (Exception ex) { Console.WriteLine("Ingrese un número del 1 al 5. +ex.Message"); Console.ReadKey(); }
                    }

                    Console.Clear();
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    GestorHabitaciones.EliminarHabitacion(listaHabitaciones);
                    break;
                }
            case 3:
                {
                    Console.Clear();
                    Habitacion.MostrarInformacion(listaHabitaciones);
                    break;
                }
            case 4:
                {
                    Console.Clear();
                    Habitacion.AsignarHabitacionACliente(listaHabitaciones);
                    break;
                }
            case 5:
                {
                    Console.Clear();
                    Habitacion.LiberarHabitacionACliente(listaHabitaciones);
                    break;
                }
            case 6:
                {
                    Console.Clear();
                    menu = false;
                    break;
                }
        }
    }
    catch (Exception ex) { Console.WriteLine("Ingrese un número del 1 al 6. +ex.Message"); Console.ReadKey(); }
}
    static void ShowMenu()
    {
        Console.WriteLine("1. Agregar habitación.");
        Console.WriteLine("2. Eliminar habitación.");
        Console.WriteLine("3. Mostrar habitaciones.");
        Console.WriteLine("4. Asignar habitación a cliente.");
        Console.WriteLine("5. Liberar habitación.");
        Console.WriteLine("6. Salir.");
    }