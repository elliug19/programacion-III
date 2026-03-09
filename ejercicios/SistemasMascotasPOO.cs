using System;
using System.Collections.Generic;

// Clase Base
class Mascota
{
    public string Nombre { get; set; }
    public virtual void HacerTruco()
    {
        Console.WriteLine($"{Nombre} está mirando fijamente...");
    }
}

// Clases Derivadas
class Loro : Mascota
{
    public override void HacerTruco() => Console.WriteLine($"{Nombre} dice: ¡Quiero una galleta!");
}

class Gato : Mascota
{
    public override void HacerTruco() => Console.WriteLine($"{Nombre} está amasando pan en la manta.");
}

// Implementación
class Program
{
    static void Main()
    {
        Loro miLoro = new Loro { Nombre = "Paco" };
        Gato miGato = new Gato { Nombre = "Michi" };

        Console.WriteLine("Elige mascota: 1. Loro, 2. Gato");
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            miLoro.HacerTruco();
        }
        else miGato.HacerTruco();
    }
}