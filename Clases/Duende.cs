using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Duende correspondiente a la categoría de Tropas y hereda de la clase TropaNormal.
    /// </summary>
    class Duende : TropaNormal
    {
        /// <summary>
        /// Constructor de Duende.
        /// </summary>
        public Duende()
        {
            PrecioElixir = 25;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Velocidad = 32;
            Vida = 25;
            Daño = 11;
            Nivel = 1;
            Nombre = "Duende";
            Poblacion = 5;
        }
    }
}
