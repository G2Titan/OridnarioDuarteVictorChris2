using OridnarioDuarteVictorChris.Clases;
using OridnarioDuarteVictorChris.Interfaces;

internal class Program
{

    public static void MenuDeOpciones(string Opcion)
    {

        switch (Opcion)
        {
            case "1":
                {                }
                break;
            case "2": break;
            case "3": break;
            case "4": break;
            case "5":
                Console.Clear();
                Console.WriteLine("Muchas gracias por usar el programa :)");
                Thread.Sleep(1000);
                break;

        }
    }
    static void Main(string[] args)
    {  

        Console.WriteLine($"Bienvenido al examen Ordinario:)");
        Thread.Sleep(1500);
        Console.WriteLine($"Selecciona la opcion deseada");
        Thread.Sleep(500);
        while (true)
        {

            Console.WriteLine($"1-Administracion del Centro\n2-Administracion de adopciones\n3-Administracion de bienestar animal\n4-Simulacion de interacciones\n5-Finalizar Programa");
            string opcion = Console.ReadLine();

            if (int.TryParse(opcion, out _))//Valida que solo sea uun string 
            {
                MenuDeOpciones(Opcion: opcion);
                break; // Sale del bucle si la opción es válida.
            }
            else
            {
                Console.WriteLine("La opción ingresada no es un número válido.");
                Console.WriteLine("Ingrese uno nuevamente");
                Thread.Sleep(2000);// espera dos segundos
                Console.Clear();// limpia la consola
            }
        }
    }
}
