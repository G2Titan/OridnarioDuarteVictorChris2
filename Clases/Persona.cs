using OridnarioDuarteVictorChris.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace OridnarioDuarteVictorChris.Clases
{
    public class Persona : IPersona
    {
        private static int contadorId = 1;
        public int Id { get; }
        public string Nombre { get; }
        private List<Mascota> mascotas;

        public Persona(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la persona no puede estar en blanco.");

            Id = contadorId++;
            Nombre = nombre;
            mascotas = new List<Mascota>();
        }

        public List<Mascota> ObtenerMascotas()
        {
            return mascotas;
        }

        public Mascota ObtenerMascotaPorId(int id)
        {
            return mascotas.Find(m => m.Id == id);
        }

        public void AgregarMascota(Mascota mascota)
        {
            mascotas.Add(mascota);
            Console.WriteLine($"{Nombre} agrega a {mascota.Nombre} a sus mascotas.");
            mascota.HacerRuido();
        }

        public void Acariciar(Mascota mascota)
        {
            Console.WriteLine($"{Nombre} acaricia a {mascota.Nombre}: {mascota.Acariciar()}");
        }

        public void AcariciarMascotas()
        {
            foreach (var mascota in mascotas)
            {
                if (mascota is IAcariciable)
                {
                    Acariciar(mascota);
                }
                else
                {
                    Console.WriteLine($"{Nombre} intenta acariciar a {mascota.Nombre}, pero no es posible.");
                }
            }
         if (MascotasDePersonas.Count == 0)
            {
                Console.WriteLine($"{this.Nombre}, No tienes ninguna mascota:( ");
            }
        }
    }
}

