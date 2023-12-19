using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OridnarioDuarteVictorChris.Clases
{
    internal class Persona
    {
        private string _nombre;
        private int _id;
        static int contador = 0;
        //List<IMascota> MascotasDePersonas;
        public Persona(string nombre)
        {
            _nombre = nombre;
            id = contador + 1;
            contador++;
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
        public string nombre
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
    }
}
