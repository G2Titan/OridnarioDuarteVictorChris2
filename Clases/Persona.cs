
using OridnarioDuarteVictorChris.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;
using static OridnarioDuarteVictorChris.Interfaces.IPersona;

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
        }
    }
}

