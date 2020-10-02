using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Ayuntamiento que corresponde a la categoria de Edificios y hereda de la interfaz IEdificio.
    /// </summary>
    class Ayuntamiento : IEdificio
    {
        /// <summary>
        /// Atributos de Ayuntamiento.
        /// </summary>
        
        private String nombre;
        private Int32 vida;
        private Int32 nivel;
        private Int32 precioOro;
        private Int32 precioElixir;
        private Int32 precioElixirN;

        /// <summary>
        /// Constructor de Ayuntamiento.
        /// </summary>
        
        public Ayuntamiento()
        {
            Nombre = "Ayuntamiento";
            Vida = 500;
            Nivel = 1;
        }

        /// <summary>
        /// Metodos Get y Set para los atributos de Ayuntamiento que cumplen con el principio de encapsulación.
        /// </summary>
        
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Int32 Vida
        {
            get { return vida; }
            set { vida = value; }
        }
        public Int32 Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
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
