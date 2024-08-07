using Laboratorio2;

int opcion;
bool menu = true;
List <Habitacion>listaHabitaciones = new List <Habitacion> ();
while (menu)
{
    Console.Clear();
    ShowMenu();
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
                    opcionAgregar = Convert.ToInt32(Console.ReadLine());
                    switch (opcionAgregar)
                    {
                        case 1:
                            {
                                Console.Clear();
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
                                break;
                            }
                        case 4:
                            {
                                Console.Clear();
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

                Console.Clear();
                break;
            }
    }
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