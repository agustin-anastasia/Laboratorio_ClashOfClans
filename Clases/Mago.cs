using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Mago correspondiente a la categoría de Tropas y hereda de la clase TropaNormal.
    /// </summary>
    class Mago : TropaNormal
    {
        /// <summary>
        /// Constructor de Mago.
        /// </summary>
        public Mago()
        {
            Velocidad = 16;
            PrecioElixir = 1500;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Vida = 75;
            Daño = 75;
            Nivel = 1;
            Nombre = "Mago";
            Poblacion = 5;
        }
    }
}
