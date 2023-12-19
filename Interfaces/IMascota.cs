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

        string Especie { get; }

      
        

        public int Edad {  get; set; }
        void Temperamento();
        public IPersona Dueño { get; set; }
       void HacerRuido();


     
      public void CambiarDueño(IPersona newDueño);

        


    }
}