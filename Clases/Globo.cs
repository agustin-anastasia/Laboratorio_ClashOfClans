using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Globo correspondiente a la categoría de Tropas y hereda de la clase TropaNormal.
    /// </summary>
    class Globo : TropaNormal
    {
        /// <summary>
        /// Constructor de Globo.
        /// </summary>
        public Globo()
        {
            Velocidad = 10;
            Vida = 120;
            Daño = 75;
            PrecioElixir = 2000;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Nivel = 1;
            Nombre = "Globo";
            Poblacion = 10;
        }
    }
}
