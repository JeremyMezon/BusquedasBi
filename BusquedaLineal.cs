using System;
using System.Collections.Generic;
using System.Text;

namespace Busquedas
{
    class BusquedaLineal : ITermino
    {

        private ContenidoMultimedia[] Lista { get; set; }

        public BusquedaLineal(ContenidoMultimedia[] lista)
        {
            Lista = lista;
        }

        public void BuscarPorGenero(string genero)
        {
            if(Lista.Length > 0)
            {
                for(int i = 0; i < Lista.Length; i++)
                {
                    
                    if(Lista[i].Genero == genero && Lista[i].Tipo == "Pelicula")
                    {
                        Lista[i].imprimirContenido();
                    }
                }
                
                return;
            }

            Console.WriteLine("Lista vacia");

        }

        public void VerPreciosProductos()
        {
            if(Lista.Length > 0)
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
