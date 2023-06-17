using HelloWorld.dao;

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

        public void listarProductos()
        {
            productoDAO.listarProductos();
        }
    }
}
