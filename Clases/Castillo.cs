using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Castillo que corresponde a la categoria de Edificios, su mision es almacenar tropas y recursos. Hereda de las interfaces IAlmacenamientoElixir, IAlmacenamientoOro y IAlmacenamientoTropa.
    /// </summary>
    class Castillo : IAlmacenamientoElixir, IAlmacenamientoOro, IAlmacenamientoTropa
    {
        /// <summary>
        /// Atributos de Castillo.
        /// </summary>
        
        private String nombre;
        private Int32 vida;
        private Int32 nivel;
        private Int32 cantidadOro;
        private Int32 cantidadElixir;
        private Int32 cantidadTropas;
        private Int32 precioOro;
        private Int32 precioElixir;
        private Int32 precioElixirN;

        /// <summary>
        /// Constructor de Castillo.
        /// </summary>
        public Castillo()
        {
            Nombre = "Castillo del Clan";
            Vida = 800;
            Nivel = 1;
            CantidadOro = 500;
            CantidadElixir = 500;
            CantidadTropas = 10;
            PrecioOro = 100;
            PrecioElixir = 0;
            PrecioElixirN = 0;
        }

        /// <summary>
        /// Metodos Get y Set para los atributos de Castillo que cumplen con el principio de encapsulación.
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
        public Int32 CantidadOro
        {
            get { return cantidadOro; }
            set { cantidadOro = value; }
        }
        public Int32 CantidadElixir
        {
            get { return cantidadElixir; }
            set { cantidadElixir = value; }
        }
        public Int32 CantidadTropas
        {
            get { return cantidadTropas; }
            set { cantidadTropas = value; }
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
