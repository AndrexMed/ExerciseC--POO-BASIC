using HelloWorld;
using HelloWorld.controller;

ClienteController clienteController = new();
ProductoController productoController = new();
PedidoController pedidoController = new();

bool flag = true;

while (flag)
{
    Console.WriteLine("==== MENU ====");
    Console.WriteLine("1. Crear cliente");
    Console.WriteLine("11. Listar Clientes");
    Console.WriteLine("2. Crear producto");
    Console.WriteLine("22. Listar productos");
    Console.WriteLine("3. Crear pedido");
    Console.WriteLine("33. Listar pedidos");
    Console.WriteLine("4. Actualizar cliente");
    Console.WriteLine("5. Actualizar producto");
    Console.WriteLine("6. Eliminar cliente");
    Console.WriteLine("7. Eliminar producto");
    Console.WriteLine("8. Eliminar pedido");
    Console.WriteLine("9. Salir");
    Console.WriteLine("==============");
    Console.Write("\nIngrese una opción: \n");

    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            clienteController.crearCliente();
            break;
        case 11:
            clienteController.listarClientes();
            break;
        case 2:
            productoController.agregarProducto();
            break;
        case 22:
            productoController.listarProductos();
            break;
        case 3:
            pedidoController.crearPedido();
            break;
        case 33:
            pedidoController.listarPedidos();
            break;
        case 4:
            clienteController.actualizarCliente();
            break;
        case 5:
            productoController.actualizarProducto();
            break;
        case 6:
            clienteController.eliminarCliente();
            break;
        case 7:
            productoController.eliminarProducto();
            break;
        case 8:
            pedidoController.eliminarPedido();
            break;
        case 9:
            flag = false;
            Console.WriteLine("***** Adios *****");
            break;
        default:
            Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
            break;
    }

    Console.WriteLine("\n");
}
