using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase ProduccionDeTropas que corresponde a la categoría de Edificios y hereda de la interfaz IEdificio.
    /// </summary>
    public class ProduccionDeTropas : IEdificio
    {
        /// <summary>
        /// Atributos de ProduccionDeTropas
        /// </summary>
        
        private Int32 precioOro;
        private Int32 precioElixir;
        private Int32 precioElixirN;

        /// <summary>
        /// Propiedades de ProduccionDeTropas.
        /// </summary>
        
        public Int32 Nivel { get; }
        public String Nombre { get; set; }
        public Int32 Vida { get; }
        public Int32 Capacidad { get; private set; }

        /// <summary>
        /// Metodos Get y Set para los atributos de ProduccionDeTropas que cumplen con el principio de encapsulación.
        /// </summary>
        
        public Int32 PrecioOro
        {
            get { return precioOro; }
            set { precioOro = value; }
        }
        public Int32 PrecioElixir
        {
            get { return precioElixir; }
            set { precioElixir = value; }
        }
        public Int32 PrecioElixirN
        {
            get { return precioElixirN; }
            set { precioElixirN = value; }
        }
    }
}
