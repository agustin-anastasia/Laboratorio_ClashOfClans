using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Minero correspondiente a la categoría de Tropas y hereda de la clase TropaNormal.
    /// </summary>
    class Minero : TropaNormal
    {
        /// <summary>
        /// Constructor de Minero.
        /// </summary>
        public Minero()
        {
            Velocidad = 24;
            Vida = 550;
            Daño = 80;
            Nivel = 1;
            Nombre = "Minero";
            PrecioElixir = 4200;
        }
    }
}
