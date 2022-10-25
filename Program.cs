using System;

namespace Busquedas
{
    class Program
    {
        static void Main(string[] args)
        {
            ContenidoMultimedia avengers = new ContenidoMultimedia("Avengers", "Accion", 59.99, "Pelicula");
            ContenidoMultimedia capitan = new ContenidoMultimedia("Capitan America", "Accion", 49.99, "Pelicula");
            ContenidoMultimedia bunny = new ContenidoMultimedia("Moscow Mule - Bad Bunny", "Trap", 59.99, "Musica");
            ContenidoMultimedia ginger = new ContenidoMultimedia("Karaoke - Ginger Root", "Indie", 24.99, "Musica");
            ContenidoMultimedia toy = new ContenidoMultimedia("Toy Stoy", "Animada", 59.99, "Pelicula");
            ContenidoMultimedia yellow = new ContenidoMultimedia("Getting Closer - Yellow Days", "Chillwave", 39.99, "Musica");
            ContenidoMultimedia thor = new ContenidoMultimedia("Thor", "Accion", 19.99, "Pelicula");

            ContenidoMultimedia[] listaContenido = { avengers, capitan, bunny, ginger, toy, yellow, thor };

            BusquedaBinaria busqueda = new BusquedaBinaria(listaContenido);
            busqueda.BuscarPorGenero("Accion");
            //busqueda.VerPreciosProductos();
            Console.ReadKey();
        }
    }
}
