using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Gigante correspondiente a la categoría de Tropas y hereda de la clase TropaNormal.
    /// </summary>
    class Gigante : TropaNormal
    {
        /// <summary>
        /// Constructor de Gigante.
        /// </summary>
        public Gigante()
        {
            Vida = 300;
            Daño = 22;
            Nivel = 1;
            Nombre = "Gigante";
            Velocidad = 16;
            PrecioElixir = 250;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Poblacion = 6;
        }
    }
}
