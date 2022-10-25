using System;
using System.Collections.Generic;
using System.Text;

namespace Busquedas
{
    class BusquedaBinaria
    {
        private ContenidoMultimedia[] Lista { get; set; }

        public BusquedaBinaria(ContenidoMultimedia[] lista)
        {
            Lista = lista;
        }

        public void BuscarPorGenero(string genero)
        {
            if (Lista.Length > 0)
            {
                int n = Lista.Length;
                int inferior = 0;
                int medio = 0;
                int superior = n - 1;

                int indiceEncontrado = 0;
                while ( inferior <= superior && medio != indiceEncontrado )
                {
                    medio = Convert.ToInt32(Math.Floor(Convert.ToDouble((superior + inferior) / 2)));
                    if (Lista[medio].Genero == genero && Lista[medio].Tipo == "Pelicula")
                    {
                        Lista[medio].imprimirContenido();
                        indiceEncontrado = medio;

                    }
                    else if (Lista[inferior].Genero != genero && Lista[inferior].Tipo != "Pelicula")
                    {
                        inferior = medio + 1;
                    }
                    else
                    {
                        superior = medio - 1;
                    }
                }

                return;
            }

            Console.WriteLine("Lista vacia");

        }

        public void VerPreciosProductos()
        {
            if (Lista.Length > 0)
            {
                Console.WriteLine("Precios de los productos");
                for (int i = 0; i < Lista.Length; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Titulo: \t{Lista[i].Titulo}");
                    Console.WriteLine($"Precio: \t${Lista[i].Precio}");
                    Console.WriteLine("");
                }
                return;
            }

            Console.WriteLine($"Lista vacia");
            return;
        }
    }
}
