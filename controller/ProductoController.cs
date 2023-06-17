using HelloWorld.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.controller
{
    public class ProductoController
    {

        private ProductoDAO productoDAO = new();
        public void agregarProducto()
        {
            Console.WriteLine("\n==== Crear Producto ====\n");

            Console.WriteLine("Nombre del producto:");
            string nomProducto = Console.ReadLine();

            Console.WriteLine("Descripcion del producto:");
            string descProducto = Console.ReadLine();

            Console.WriteLine("Precio del producto:");
            double precioProducto = double.Parse(Console.ReadLine());

            productoDAO.crearProducto(nomProducto, descProducto, precioProducto);
        }
    }
}
