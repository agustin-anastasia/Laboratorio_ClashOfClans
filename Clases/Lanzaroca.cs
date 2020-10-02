using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase LanzaRoca correspondiente a la categoría de Tropas y hereda de la clase TropaOscura.
    /// </summary>
    class LanzaRoca : TropaOscura
    {
        /// <summary>
        /// Constructor de LanzaRoca.
        /// </summary>
        public LanzaRoca()
        {
            Vida = 290;
            Nombre = "Lanzarroca";
            Daño = 65;
            PrecioElixir = 0;
            PrecioOro = 0;
            PrecioElixirN = 130;
            Nivel = 1;
            Velocidad = 14;
            Poblacion = 5;
        }
    }
}
