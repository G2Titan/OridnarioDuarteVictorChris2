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
    internal class Persona : IPersona
    {
        private string _nombre;
        private int _id;
        static int contador = 0;
        private List<IMascota> MascotasDePersonas;
        private List<IMascota> MascotasDisponibles;
        public Persona(string nombre)
        {
            _nombre = nombre;
            id = contador + 1;
            contador++;
            MascotasDePersonas = new List<IMascota>();
            MascotasDisponibles = new List<IMascota>();
        }
        public int id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set 
            {
                _nombre = value; 
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("El nombre no puede ser un espacio en blanco o ser vacio");
                }
            }
        }
        //public MascotasDePersonas();
        //public MascotasDePersoans ObtenerMascotasId  debe regresar una mascota que este en la colección de la persona y que posea el Id seleccionado.
        //Si la persona no tiene una mascota con ese Id se retornará null.
        /*public MascotasDisponibles AgregarMascota(Persona, MascotasDisponibles)
        {
            Console.WriteLine($"{Persona.Nombre} agrega a {MascotasDisponibles.Nombre} a sus mascotas");
            //Comportamiento del animal
        }
       */
        /*public MascotasDePersonas Acaririciar (Persona, MascotasDePersonas)
        {
            Console.WriteLine($"{Persona.Nombre} acaricia a {MascotasDePersonas.Nombre} a sus mascotas");
            //Comportamiento del animal
        }
       */
    }
}
