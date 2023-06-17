using HelloWorld.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.dao
{
    public class ProductoDAO
    {
        static List<Producto> productos = new List<Producto>();
        Producto producto;
        public void crearProducto(string nomProducto, string descProducto, double precioProducto)
        {
            {
                int idNuevoProducto = productos.Count + 1;

                producto = new Producto(idNuevoProducto, nomProducto, descProducto, precioProducto);
            }
        }
    }
}
