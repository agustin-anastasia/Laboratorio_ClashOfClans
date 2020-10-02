using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Esbirro correspondiente a la categoría de Tropas y hereda de la clase TropaOscura.
    /// </summary>
    class Esbirro : TropaOscura
    {
        /// <summary>
        /// Constructor de Esbirro.
        /// </summary>
        public Esbirro()
        {
            Nombre = "Esbirro";
            Vida = 55;
            Daño = 38;
            Nivel = 1;
            PrecioOro = 0;
            PrecioElixir = 0;
            PrecioElixirN = 6;
            Velocidad = 32;
            Poblacion = 5;
        }
    }
}
