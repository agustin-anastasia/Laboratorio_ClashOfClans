using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Golem correspondiente a la categoría de Tropas y hereda de la clase TropaOscura.
    /// </summary>
    class Golem : TropaOscura
    {
        /// <summary>
        /// Constructor de Golem.
        /// </summary>
        public Golem()
        {
            Vida = 4500;
            Nombre = "Golem";
            Daño = 38;
            PrecioElixirN = 450;
            Nivel = 1;
            Velocidad = 12;
            PrecioElixir = 0;
            PrecioOro = 0;
            Poblacion = 10;
        }
    }
}
