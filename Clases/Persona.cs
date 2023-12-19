
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
        private string _nombre;
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("El nombre no puede ser un espacio en blanco o ser vacio");
                }
                else { _nombre = value; }
            }
        }
        private static int _id = 1;
        public int Id { get; }
        private List<IMascota> MascotasDePersonas;
        private List<IMascota> MascotasDisponibles;
        public Persona()
        {
            MascotasDePersonas = new List<IMascota>();
            Id = _id++;
        }
        public List<IMascota> ObtenerMascotas()
        {
            List<IMascota> TodasLasMascotas = new List<IMascota>(MascotasDisponibles);
            MascotasDisponibles.Clear();
            return TodasLasMascotas;
        }
        public void MascotaPorId(int id)
        {
            IMascota mascota = MascotasDisponibles.Find(p => p.id == id);
            if (mascota != null)
            {
                AgregarMascota(mascota);
            }
            else
            {
                Console.WriteLine($"No existe el id de esa mascota");
            }
        }
        private void AgregarMascota(IMascota newMascota)
        {
            MascotasDePersonas.Add(newMascota);
        }
        public void Acariciar()// Aqui falta implementar como saber que mascota quiere acariciar
        {
            Console.WriteLine("Estoy acarisiando");
        }
        public void AcariciarMascotas()
        {
            if (MascotasDePersonas.Count > 1)
            {
                foreach (var mascota in MascotasDePersonas)
                {
                    Console.WriteLine($"{mascota.Nombre} la estoy acariciando");
                    Thread.Sleep(1500);
                }
            }
            else if (MascotasDePersonas == null)
            {
                Console.WriteLine($"{this.Nombre}, No tienes ninguna mascota:( ");
            }
        }
    }
}
