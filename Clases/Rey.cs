using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Rey correspondiente a la categoría de Héroes. Hereda de la clase Héroe.
    /// Los héroes son tropas especiales ya que no consumen ningún recurso y tienen un poder especial que incrementa su poder.
    /// </summary>
    class Rey : Heroe
    {
        /// <summary>
        /// Constructor de Rey.
        /// </summary>
        public Rey()
        {
            Nombre = "Rey";
            Nivel = 1;
            Vida = 1000;
            Daño = 50;
            Velocidad = 30;
            PrecioElixir = 0;
            PrecioElixirN = 0;
            PrecioOro = 0;
            Poblacion = 1;
        }
    }
}
