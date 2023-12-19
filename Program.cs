using OridnarioDuarteVictorChris.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace OridnarioDuarteVictorChris.Clases
{
    class Program
    {
        static void Main()
        {
            CentroMascotas centroMascotas = new CentroMascotas();
            centroMascotas.MenuPrincipal();
        }
    }

    public class CentroMascotas
    {
        private List<IPersona> personas = new List<IPersona>();
        private List<IMascota> mascotasDisponibles = new List<IMascota>();

        public void MenuPrincipal()
        {
            int opcion;

            do
            {
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1 - Administración del centro");
                Console.WriteLine("2 - Administración de adopciones");
                Console.WriteLine("3 - Administración de bienestar animal");
                Console.WriteLine("4 - Simulación de interacciones");
                Console.WriteLine("5 - Finalizar programa");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            MenuAdministracionCentro();
                            break;
                        case 2:
                            // Implementar lógica para Administración de adopciones
                            break;
                        case 3:
                            // Implementar lógica para Administración de bienestar animal
                            break;
                        case 4:
                            SimulacionInteracciones();
                            break;
                        case 5:
                            Console.WriteLine("Programa finalizado.");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Inténtelo de nuevo.");
                }

            } while (opcion != 5);
        }

        private void MenuAdministracionCentro()
        {
            int opcion;

            do
            {
                Console.WriteLine("Administración del centro");
                Console.WriteLine("1 - Administración de personas");
                Console.WriteLine("2 - Administración de mascotas");
                Console.WriteLine("3 - Regresar a menú anterior");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            MenuAdministracionPersonas();
                            break;
                        case 2:
                            // Implementar lógica para Administración de mascotas
                            break;
                        case 3:
                            Console.WriteLine("Regresando al menú anterior...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Inténtelo de nuevo.");
                }

            } while (opcion != 3);
        }

        private void MenuAdministracionPersonas()
        {
            int opcion;

            do
            {
                Console.WriteLine("Administración de personas");
                Console.WriteLine("1 - Mostrar todas las personas registradas");
                Console.WriteLine("2 - Registrar persona nueva");
                Console.WriteLine("3 - Buscar personas por nombre");
                Console.WriteLine("4 - Examinar persona");
                Console.WriteLine("5 - Regresar al menú anterior");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            MostrarPersonasRegistradas();
                            break;
                        case 2:
                            RegistrarPersonaNueva();
                            break;
                        case 3:
                            BuscarPersonasPorNombre();
                            break;
                        case 4:
                            ExaminarPersona();
                            break;
                        case 5:
                            Console.WriteLine("Regresando al menú anterior...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Inténtelo de nuevo.");
                }

            } while (opcion != 5);
        }

        private void MostrarPersonasRegistradas()
        {
            Console.WriteLine("Lista de personas registradas:");
            foreach (var persona in personas)
            {
                Console.WriteLine($"ID: {persona.Id}, Nombre: {persona.Nombre}");
            }
        }

        private void RegistrarPersonaNueva()
        {
            Console.Write("Ingrese el nombre de la nueva persona: ");
            string nombre = Console.ReadLine();
            IPersona nuevaPersona = new Persona(nombre, mascotasDisponibles);
            personas.Add(nuevaPersona);
            Console.WriteLine($"Persona registrada con éxito. ID: {nuevaPersona.Id}, Nombre: {nuevaPersona.Nombre}");
        }

        private void BuscarPersonasPorNombre()
        {
            Console.Write("Ingrese el nombre a buscar: ");
            string nombreBuscar = Console.ReadLine();
            var personasEncontradas = personas.FindAll(p => p.Nombre.Contains(nombreBuscar, StringComparison.OrdinalIgnoreCase));

            if (personasEncontradas.Count > 0)
            {
                Console.WriteLine("Personas encontradas:");
                foreach (var persona in personasEncontradas)
                {
                    Console.WriteLine($"ID: {persona.Id}, Nombre: {persona.Nombre}");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron personas con ese nombre.");
            }
        }

        private void ExaminarPersona()
        {
            Console.Write("Ingrese el ID de la persona a examinar: ");
            if (int.TryParse(Console.ReadLine(), out int idPersona))
            {
                var persona = personas.Find(p => p.Id.Equals(idPersona));




                if (persona != null)
                {
                    Console.WriteLine($"Información de la persona:");
                    Console.WriteLine($"ID: {persona.Id}, Nombre: {persona.Nombre}");
                   
                }
                else
                {
                    Console.WriteLine($"No se encontró ninguna persona con el ID {idPersona}.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. El ID debe ser un número entero.");
            }
        }

        private void SimulacionInteracciones()
        {
            Console.WriteLine("Simulación de interacciones");
            Console.Write("Ingrese el ID de la persona que desea acariciar a sus mascotas: ");
            if (int.TryParse(Console.ReadLine(), out int idPersona))
            {
                var persona = personas.Find(p => p.Id.Equals(idPersona));

                if (persona != null)
                {
                    Console.WriteLine($"Acariciando a las mascotas de {persona.Nombre}");
                    persona.AcariciarMascotas();
                }
                else
                {
                    Console.WriteLine($"No se encontró ninguna persona con el ID {idPersona}.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. El ID debe ser un número entero.");
            }
        }

        private void MenuAdministracionMascotas()
        {
            int opcion;

            do
            {
                Console.WriteLine("Administración de mascotas");
                Console.WriteLine("1 - Mostrar todas las mascotas registradas");
                Console.WriteLine("2 - Registrar mascota nueva");
                Console.WriteLine("3 - Buscar mascotas por especie");
                Console.WriteLine("4 - Buscar mascotas por nombre");
                Console.WriteLine("5 - Examinar mascota");
                Console.WriteLine("6 - Volver al menú anterior");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            MostrarMascotasRegistradas();
                            break;
                        case 2:
                           // RegistrarMascotaNueva();
                            break;
                        case 3:
                            BuscarMascotasPorEspecie();
                            break;
                        case 4:
                            BuscarMascotasPorNombre();
                            break;
                        case 5:
                            ExaminarMascota();
                            break;
                        case 6:
                            Console.WriteLine("Regresando al menú anterior...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Inténtelo de nuevo.");
                }

            } while (opcion != 6);
        }

        private void MostrarMascotasRegistradas()
        {
            Console.WriteLine("Lista de mascotas registradas:");
            foreach (var mascota in mascotasDisponibles)
            {
                Console.WriteLine($"ID: {mascota.id}, Nombre: {mascota.Nombre}, Especie: {mascota.Especie}");
            }
        }


        private void BuscarMascotasPorEspecie()
        {
            Console.Write("Ingrese la especie de las mascotas a buscar: ");
            string especieBuscar = Console.ReadLine();
            var mascotasEncontradas = mascotasDisponibles.FindAll(m => m.Especie.Contains(especieBuscar, StringComparison.OrdinalIgnoreCase));

            if (mascotasEncontradas.Count > 0)
            {
                Console.WriteLine("Mascotas encontradas:");
                foreach (var mascota in mascotasEncontradas)
                {
                    Console.WriteLine($"ID: {mascota.id}, Nombre: {mascota.Nombre}, Especie: {mascota.Especie}");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron mascotas con esa especie.");
            }
        }

        private void BuscarMascotasPorNombre()
        {
            Console.Write("Ingrese el nombre a buscar: ");
            string nombreBuscar = Console.ReadLine();
            var mascotasEncontradas = mascotasDisponibles.FindAll(m => m.Nombre.Contains(nombreBuscar, StringComparison.OrdinalIgnoreCase));

            if (mascotasEncontradas.Count > 0)
            {
                Console.WriteLine("Mascotas encontradas:");
                foreach (var mascota in mascotasEncontradas)
                {
                    Console.WriteLine($"ID: {mascota.id}, Nombre: {mascota.Nombre}, Especie: {mascota.Especie}");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron mascotas con ese nombre.");
            }
        }

        private void ExaminarMascota()
        {
            Console.Write("Ingrese el ID de la mascota a examinar: ");
            if (int.TryParse(Console.ReadLine(), out int idMascota))
            {
                var mascota = mascotasDisponibles.Find(m => m.id.Equals(idMascota));

                if (mascota != null)
                {
                    Console.WriteLine($"Información de la mascota:");
                    Console.WriteLine($"ID: {mascota.id}, Nombre: {mascota.Nombre}, Especie: {mascota.Especie}");
                }
                else
                {
                    Console.WriteLine($"No se encontró ninguna mascota con el ID {idMascota}.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. El ID debe ser un número entero.");
            }
        }



    }
}

