using HelloWorld.model;

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

                productos.Add(producto);

                Console.WriteLine("\nSe añadio el producto correctamente!\n");
            }
        }

        public void listarProductos()
        {
            Console.WriteLine("\n==== Lista de Productos ====\n");

            if(productos.Count > 0)
            {
                foreach(Producto producto in productos)
                {
                    Console.WriteLine($"Id : {producto.idProducto}");
                    Console.WriteLine($"Nombre : {producto.nombreProducto}");
                    Console.WriteLine($"Descripcion : {producto.descripcionProducto}");
                    Console.WriteLine($"Precio : {producto.precioProducto}\n");
                }
            }
            else
            {
                Console.WriteLine("No hay productos en la lista!");
            }
        }
    }
}
