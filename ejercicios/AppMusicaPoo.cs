
using System;

/*App de Streaming de Música: Crea una interfaz IReproductorcon métodos Play()y Stop(). 
 * Implementa esta interfaz en clases como Canciony Podcast. 
 * El usuario debe poder "darle play" a cualquiera de los dos.
 */

namespace ejercicios
{
    interface IReproductor
    {
        void Play();
    }

    class Cancion : IReproductor
    {
        public string Titulo { get; set; }
        public void Play() => Console.WriteLine($"Reproduciendo canción: {Titulo} ");
    }

    class Podcast : IReproductor
    {
        public string Tema { get; set; }
        public void Play() => Console.WriteLine($"Escuchando podcast sobre: {Tema} ");
    }
}
// Uso: Ambas pueden tratarse como 'IReproductor'