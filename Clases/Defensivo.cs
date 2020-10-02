using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3___2018
{
    /// <summary>
    /// Clase abstracta Defensivo que tiene todos los atributos que un edificio defensivo debe tener.  
    /// </summary>
    public abstract class Defensivo: IEdificio
    {
        /// <summary>
        /// Atributos de Defensivo.
        /// </summary>
        private String nombre;
        private Int32 vida;
        private Int32 nivel;
        private Double daño;
        private Int32 precioOro;
        private Int32 precioElixir;
        private Int32 precioElixirN;

        /// <summary>
        /// Metodos Get y Set para los atributos de Defensivo que cumplen con el principio de encapsulación.
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
        public Double Daño
        {
            get { return daño; }
            set { daño = value; }
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
