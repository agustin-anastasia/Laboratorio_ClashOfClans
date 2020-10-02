using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Dragon correspondiente a la categoría de Tropas y hereda de la clase TropaNormal.
    /// </summary>
    class Dragon :TropaNormal
    {
        /// <summary>
        /// Constructor de Dragon.
        /// </summary>
        public Dragon()
        {
            Velocidad = 16;
            Vida = 1900;
            Daño = 140;
            Nivel = 1;
            Nombre = "Dragon";
            PrecioElixir = 25000;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Poblacion = 5;
        }
    }
}
