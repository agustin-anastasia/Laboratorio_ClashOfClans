using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{

    /// <summary>
    /// Clase Curandera correspondiente a la categoría de Tropas y hereda de la clase TropaNormal.
    /// </summary>
    class Curandera : TropaNormal
    {
        /// <summary>
        /// Constructor de Curandera.
        /// </summary>
        public Curandera()
        {
            Velocidad = 50;
            Vida = 500;
            Daño = 24;
            Nivel = 1;
            Nombre = "Curandera";
            PrecioElixir = 5000;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Poblacion = 4;
        }
    }
}
