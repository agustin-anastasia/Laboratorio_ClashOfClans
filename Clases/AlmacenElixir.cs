using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase AlmacenElixir correspondiente a la categoria de Edificios y hereda de la interfaz IAlmacenamientoElixir.
    /// </summary>
    class AlmacenElixir : IAlmacenamientoElixir
    {
        /// <summary>
        /// Atributos de AlmacenElixir.
        /// </summary>
        
        private String nombre;
        private Int32 vida;
        private Int32 nivel;
        private Int32 cantidadElixir;
        private Int32 precioOro;
        private Int32 precioElixir;
        private Int32 precioElixirN;

        /// <summary>
        /// Constructor AlmacenElixir 
        /// </summary>
        public AlmacenElixir()
        {
            Nombre = "Almacen de Elixir";
            Vida = vida;
            Nivel = 1;
            CantidadElixir = 500;
            PrecioOro = 100;
            PrecioElixir = 100;
            PrecioElixirN = 0;
        }

        /// <summary>
        /// Metodos Get y Set para los atributos de AlmacenElixir que cumplen con el principio de encapsulación.
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
        public Int32 CantidadElixir
        {
            get { return cantidadElixir; }
            set { cantidadElixir = value; }
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
