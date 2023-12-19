using OridnarioDuarteVictorChris.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OridnarioDuarteVictorChris.Interfaces.IMascota;

namespace OridnarioDuarteVictorChris.Clases
{
    internal class Pajaro : IMascota
    {
        private string _nombre;
        private int _edad;
        private string _temperamento;
        private static int _id = 1;
        public int id { get; }
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
                    throw new ArgumentException("No puede tener un nombre vacio");
                }

            }
        }
        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
                if (value >= 9)
                {
                    throw new ArgumentException("No puede tener más de 8 años");
                }
            }
        }
        public string Temperamento
        {
            get
            {
                return _temperamento;
            }
            set
            {
                _temperamento = null;
            }
        }
        public IPersona Dueño { get; set; }

        public void CambiarDueño(IPersona newDueño)
        {
            Dueño = newDueño;
            Console.WriteLine($"El dueño de {Nombre} ha sido cambiado a {newDueño.Nombre}");
        }

        public void HacerRuido()
        {
            Console.WriteLine("Pio pio");
        }
        public void Aletear()
        {
            Console.WriteLine("-Aleteo de miedo imparable");
        }
        public void Bailar()
        {
            Console.WriteLine($"{Nombre} esta agitando las plumas");
        }
    }
}
