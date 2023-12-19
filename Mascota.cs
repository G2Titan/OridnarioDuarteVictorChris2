using System;
using System.Collections.Generic;


class Mascota
{
    // Propiedades
    public string Id { get; }
    public string Nombre { get; }
    public int Edad { get; set; }
    public string Temperamento { get; set; }
    public string Dueño { get; set; }

    // Lista de especies
    private static List<string> especies = new List<string>();

    // Constructor
    public Mascota(string especie, string nombre)
    {
        if (!especies.Contains(especie))
        {
            especies.Add(especie);
        }

        Id = GenerarIdUnico(especie);
        Nombre = nombre;
        Edad = 0;
        Temperamento = string.Empty;
        Dueño = string.Empty;
    }

    // Método para hacer ruido
    public void HacerRuido()
    {
        string sonidoGato = ObtenerSonidoPorEspecie(EspecieMascota.Gato);
        string sonidoPerro = ObtenerSonidoPorEspecie(EspecieMascota.Perro);
        string sonidoCapibara = ObtenerSonidoPorEspecie(EspecieMascota.capibara);
        
        Console.WriteLine($"{Nombre} hace ruido: {sonidoGato}");
    }

    private string ObtenerSonidoPorEspecie(EspecieMascota especie)
    {
        switch (especie)
        {
            case EspecieMascota.Perro:
                return "Guau Guau";
            case EspecieMascota.Gato:
                return "Miau Miau";
            case EspecieMascota.capibara:
                return "KU KU KUKU";
            default:
                return "Sonido desconocido";
        }
    }
    // Método para cambiar el dueño
    public void CambiarDueño(string nuevoDueño)
    {
        Dueño = nuevoDueño;
        Console.WriteLine($"La mascota {Id} ahora tiene como dueño a {Dueño}");
    }

    // Método privado para generar un Id único
    private string GenerarIdUnico(string especie)
    {
        int contador = ObtenerContadorEspecie(especie);
        contador++;

        return $"{especie}-{contador}";
    }

   //Contador 
    private int ObtenerContadorEspecie(string especie)
    {
        if (!contadoresPorEspecie.ContainsKey(especie))
        {
            contadoresPorEspecie[especie] = 0;
        }

        return contadoresPorEspecie[especie];
    }

    // Diccionario para almacenar contadores por especie
    private static readonly Dictionary<string, int> contadoresPorEspecie = new Dictionary<string, int>();

    public enum EspecieMascota
    {
        Perro,
        Gato,
        capibara 
    }


}

