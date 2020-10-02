using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Esqueleto correspondiente a la categoría de Tropas y hereda de la clase TropaNormal.
    /// </summary>
    class Esqueleto : TropaNormal
    {
        /// <summary>
        /// Constructor de Esqueleto.
        /// </summary>
        public Esqueleto()
        {
            Velocidad = 24;
            Vida = 40;
            Daño = 25;
            Nivel = 1;
            Nombre = "Esqueleto";
            PrecioElixir = 3500;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Poblacion = 6;
        }
    }
}
