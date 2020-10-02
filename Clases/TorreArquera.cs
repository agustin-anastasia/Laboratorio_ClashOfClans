using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase TorreArquera que corresponde a la categoría de Edificios defensivos y hereda de la clase Mixto.
    /// </summary>
    public class TorreArquera : Mixto
    {
        /// <summary>
        /// Constructor de TorreArquera.
        /// </summary>
        public TorreArquera()
        {
            Vida = 380;
            Nombre = "Torre de Arqueras";
            PrecioOro = 250;
            PrecioElixir = 0;
            PrecioElixirN = 0;
        }
    }
}
