using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Bruja correspondiente a la categoría de Tropas y hereda de la clase TropaOscura.
    /// </summary>
    class Bruja : TropaOscura
    {
        /// <summary>
        /// Constructor de Bruja.
        /// </summary>
        public Bruja()
        {
            Vida = 270;
            Nombre = "Brujas";
            Daño = 50;
            Nivel = 1;
            Velocidad = 12;
            PrecioElixirN = 250;
            PrecioElixir = 0;
            PrecioOro = 0;
            Poblacion = 3;
        }
    }
}
