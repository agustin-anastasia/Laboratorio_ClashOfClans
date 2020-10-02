using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Arquera correspondiente a la categoría de Tropas y hereda de la clase TropaNormal.
    /// </summary>
    class Arquera :TropaNormal
    {
        public Arquera()
        {
            /// <summary>
            /// Constructor de Arquera.
            /// </summary>
            
            Daño = 7;
            Nivel = 1;
            Nombre = "Arquera";
            Velocidad = 50;
            Vida = 20;
            PrecioElixir = 40;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Poblacion = 1;
        }
    }
}
