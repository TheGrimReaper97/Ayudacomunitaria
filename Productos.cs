using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ayuda_Comunitaria
{
    class Productos
    {
        private string producto;
        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        private Int32 idproducto;
        public Int32 IdProducto 
        {
            get{ return idproducto; }
            set{ idproducto = value; }
        }

        private Int32 cantidad;
        public Int32 Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

            

    }
}
