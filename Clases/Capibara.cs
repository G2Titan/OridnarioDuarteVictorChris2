using OridnarioDuarteVictorChris.Interfaces;
using System;
using System.Collections.Generic;
class Capibara : IMascota
{
    private string _nombre;
    private int _edad;
    private string _temperamento;
    public int id => throw new NotImplementedException();
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
    public IPersona Dueño { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void CambiarDueño(IPersona newDueño)
    {
        throw new NotImplementedException();
    }

    public void HacerRuido()
    {
        Console.WriteLine("cui cui");
    }
}

