﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OridnarioDuarteVictorChris.Interfaces
{
    public interface IPersona
    {
        string Nombre { get; set; }     
        
        string Id { get; set; }

        public void AcariciarMascotas();

    }
}
