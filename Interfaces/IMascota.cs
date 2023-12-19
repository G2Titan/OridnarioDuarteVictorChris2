using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OridnarioDuarteVictorChris.Interfaces;

namespace OridnarioDuarteVictorChris.Interfaces
{
    public interface IMascota
    {
        public int id { get; }
        public string Nombre { get; set; } 
        public int Edad {  get; set; }
        public string Temperamento {  get; set; }
        public IPersona Dueño { get; set; }
       void HacerRuido();
      void CambiarDueño(IPersona newDueño);

    }
}