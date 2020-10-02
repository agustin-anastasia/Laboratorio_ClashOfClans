using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase Campamento que corresponde a la categoría de Edificios. Se encarga de almacenar tropas generadas en los cuarteles. Hereda de la Interfaz IAlmacenamientoTropa.
    /// </summary>
    class Campamento : IAlmacenamientoTropa
    {
        /// <summary>
        /// Atributos de Campamento.
        /// </summary>
        
        private String nombre;
        private Int32 vida;
        private Int32 nivel;
        private Int32 cantidadTropas;
        private Int32 precioOro;
        private Int32 precioElixir;
        private Int32 precioElixirN;

        /// <summary>
        /// Constructor de Campamento.
        /// </summary>
        public Campamento()
        {
            Nombre = "Campamento";
            Vida = 800;
            Nivel = 1;
            CantidadTropas = 10;
            PrecioOro = 100;
            PrecioElixir = 200;
            PrecioElixirN = 0;
        }

        /// <summary>
        /// Metodos Get y Set para los atributos de Campamento que cumplen con el principio de encapsulación.
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
