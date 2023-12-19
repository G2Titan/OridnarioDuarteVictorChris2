using OridnarioDuarteVictorChris.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OridnarioDuarteVictorChris.Clases
{
    public class Gato : IMascota
    {
 
        private int _id = 5;
        public int id { get { return _id; } }
        private string _nombre;
        public string Nombre { get { return _nombre; } set {
                if (!string.IsNullOrEmpty(value))
                {
                    _nombre = value;
                }
               
            }
        }
        private int _edad;
        public int Edad { get { return _edad; } set
            {
                if (value > 18&&value<0)
                {
                    Console.WriteLine("La edad maxima es de 18 años");
                }
                _edad = value;
            }
            }
        public void Temperamento()
        {
            Random random = new Random();
            random.Next();
        }
        private IPersona _Dueño;
        public IPersona Dueño { get { return _Dueño; }
            set { _Dueño = value; }
        }

        public string Especie => throw new NotImplementedException();

        public void CambiarDueño(IPersona newDueño)
        {
            _Dueño = newDueño;
            Console.WriteLine($"Añadido ");
        }

        public void HacerRuido()
        {
            Console.WriteLine($"{this.Nombre} dice miau miau");
        }

        public void ResponderCaricia()
        {
            Console.WriteLine("El gato responde a su temperamento");
        }        
    }

}
