using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase abstracta Tropa.
    /// </summary>
    public abstract class Tropa
    {
        /// <summary>
        /// Propiedades de todas las tropas.
        /// </summary>
        
        public String Nombre { get; set; }
        public Int32 Vida { get; set; }
        public Int32 Nivel { get; set; }
        public Int32 Velocidad { get; set; }
        public Int32 Daño { get; set; }
        public Int32 PrecioOro { get; set; }
        public Int32 PrecioElixir { get; set; }
        public Int32 PrecioElixirN { get; set; }
        public Int32 Poblacion { get; set; }
        
    }
}
