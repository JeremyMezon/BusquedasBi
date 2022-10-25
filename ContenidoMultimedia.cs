using System;
using System.Collections.Generic;
using System.Text;

namespace Busquedas
{
    class ContenidoMultimedia
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public double Precio { get; set; }
        public string Tipo { get; set; }

        public ContenidoMultimedia()
        {

        }

        public ContenidoMultimedia(string titulo,string genero,double precio,string tipo)
        {
            Titulo = titulo;
            Genero = genero;
            Precio = precio;
            Tipo = tipo;
        }

        public void imprimirContenido()
        {
            Console.WriteLine("");
            Console.WriteLine($"Titulo: \t{Titulo}");
            Console.WriteLine($"Genero: \t{Genero}");
            Console.WriteLine($"Precio: \t${Precio}");
            Console.WriteLine($"Tipo  : \t{Tipo}");
            Console.WriteLine("");
        }


    }
}
