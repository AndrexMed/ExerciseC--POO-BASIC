using HelloWorld.model;

namespace HelloWorld.dao
{
    public class ProductoDAO
    {
        public static List<Producto> productos = new List<Producto>();
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
                Console.WriteLine("*** No hay productos en la lista! ***");
            }
        }

        public void actualizarProducto(int idEntrante)
        {
            if(productos.Count > 0)
            {
                for(int i = 0; i < productos.Count; i++)
                {
                    var element = productos[i];
                    if(element.idProducto == idEntrante)
                    {
                        Console.WriteLine("\n*** Se encontro el producto!");
                        
                        Console.WriteLine("Ingrese nuevo nombre del producto");
                        var nuevoNombre = Console.ReadLine();

                        Console.WriteLine("Ingrese nueva descripcion");
                        var nuevaDesc = Console.ReadLine();

                        Console.WriteLine("Ingrese nuevo precio");
                        var nuevoPrecio = double.Parse(Console.ReadLine());

                        producto.nombreProducto = nuevoNombre;
                        producto.descripcionProducto = nuevaDesc;
                        producto.precioProducto = nuevoPrecio;

                        Console.WriteLine("\n*** Se actualizo el producto correctamente! ***\n");
                    }
                    else
                    {
                        Console.WriteLine("\n*** No se encontro el producto! ***\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("\n*** No hay productos en la lista! ***\n");
            }
        }

        public void eliminarProducto(int idEntrante)
        {
            if (productos.Count > 0)
            {
                for (int i = 0; i < productos.Count; i++)
                {
                    var element = productos[i];
                    if (element.idProducto == idEntrante)
                    {
                        productos.Remove(element);
                        Console.WriteLine("\n*** Producto eliminado exitosamente! ***\n");
                    }
                    else
                    {
                        Console.WriteLine("\n *** No se encontro el Id especificado! ***\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("\n*** No se encontraron elementos en la lista! ***\n");
            }
        }

       
    }

}
