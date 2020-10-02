using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Montapuercos correspondiente a la categoría de Tropas y hereda de la clase TropaOscura.
    /// </summary>
    class Montapuercos : TropaOscura
    {
        /// <summary>
        /// Constructor de Montapuercos.
        /// </summary>
        public Montapuercos()
        {
            Vida = 270;
            Nombre = "Montapuercos";
            Daño = 60;
            PrecioElixirN = 40;
            PrecioElixir = 0;
            PrecioOro = 0;
            Nivel = 1;
            Velocidad = 24;
            Poblacion = 5;
        }
    }
}
