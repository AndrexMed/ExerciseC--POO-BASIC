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

        public void actualizarProducto()
        {
            Console.WriteLine("\n==== Actualizar Producto ====\n");

            Console.WriteLine("Ingrese el Id del producto a actualizar");
            var id = int.Parse(Console.ReadLine());

            productoDAO.actualizarProducto(id);
        }

        public void eliminarProducto()
        {
            Console.WriteLine("\n==== Eliminar Producto ====\n");

            Console.WriteLine("Ingrese el Id del producto a eliminar");
            var id = int.Parse(Console.ReadLine());

            productoDAO.eliminarProducto(id);
        }
    }
}
