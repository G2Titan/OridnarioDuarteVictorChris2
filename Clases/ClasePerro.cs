﻿using OridnarioDuarteVictorChris.Interfaces;
using System;

public class Perro : IMascota
{
    private int _edad;

    public int  id { get; set; }

    public string Nombre { get; set; }

    public int Edad
    {
        get { return _edad; }
        set
        {
            // Aseguramos que la edad del perro no supere los 14 años
            _edad = Math.Min(value, 14);
        }
    }
    
    public string Temperamento { get; set; }
    public IPersona Dueño { get; set; }

    public void CambiarDueño(IPersona newDueño)
    {
        Dueño = newDueño;
        Console.WriteLine($"El dueño de {Nombre} ha sido cambiado a {newDueño.Nombre}");
    }

    public void HacerRuido()
    {
        Console.WriteLine("Guau Guau");
    }

    public void MoverCola()
    {
        Console.WriteLine($"{Nombre} mueve la cola felizmente");
    }

    public void Gruñir()
    {
        Console.WriteLine($"{Nombre} está gruñendo");
    }
}
