using OridnarioDuarteVictorChris.Interfaces;
using System;
using System.Collections.Generic;
using OridnarioDuarteVictorChris.Clases;
class Capibara : IMascota
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
            if (value >= 12) 
            {
                throw new ArgumentException("La capibara no puede tener más de 11 años");
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
            _temperamento = value; 
            if (_temperamento != value) 
            {
                throw new ArgumentException("Es de lo más tranquilo, aunque no quieras");
            }
        }
    }
    public IPersona Dueño { get; set; }

    public string Especie => throw new NotImplementedException();

    public void CambiarDueño(IPersona newDueño)
    {
        Dueño = newDueño;
        Console.WriteLine($"El dueño de {Nombre} ha sido cambiado a {newDueño.Nombre}");
    }

    public void HacerRuido()
    {
        Console.WriteLine("cui cui");
    }
    public void SaludarAlProfe()
    {
        Console.WriteLine("Hola profesor Duarte, tenga compasión de estas pobres almas:(");
    }

    void IMascota.Temperamento()
    {
        throw new NotImplementedException();
    }
}

