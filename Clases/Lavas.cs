using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Lavas correspondiente a la categoría de Tropas y hereda de la clase TropaOscura.
    /// </summary>
    class Lavas : TropaOscura
    {
        /// <summary>
        /// Constructor de Lavas.
        /// </summary>
        public Lavas()
        {
            Vida = 5700;
            Nombre = "Lavas";
            Daño = 10;
            PrecioElixirN = 390;
            PrecioElixir = 0;
            PrecioOro = 0;
            Nivel = 1;
            Velocidad = 12;
            Poblacion = 5;

        }
    }
}
