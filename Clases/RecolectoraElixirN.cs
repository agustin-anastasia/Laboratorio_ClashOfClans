using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase RecolectoraElixirN que corresponde a la categoría de Edificios. Hereda de la interfaz IProduccionRecursos.
    /// </summary>
    class RecolectoraElixirN : IProduccionRecursos
    {
        /// <summary>
        /// Atributos de RecolectoraElixirN.
        /// </summary>
        
        private String nombre;
        private Int32 vida;
        private Int32 nivel;
        private Int32 produccion = 30;
        private Int32 precioOro;
        private Int32 precioElixir;
        private Int32 precioElixirN;

        /// <summary>
        /// Constructor de RecolectoraElixirN.
        /// </summary>
        public RecolectoraElixirN()
        {
            Nombre = "Recolectora de Elixir Negro";
            Vida = 100;
            Nivel = 1;
            Produccion = 30;
            PrecioOro = 50;
            PrecioElixir = 0;
            PrecioElixirN = 0;
        }
        /// <summary>
        /// Metodos Get y Set para los atributos de RecolectoraElixirN que cumplen con el principio de encapsulación.
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
        public Int32 Produccion
        {
            get { return produccion; }
            set { produccion = value; }
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
