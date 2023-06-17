using HelloWorld;
using HelloWorld.controller;

ClienteController clienteController = new();
ProductoController productoController = new();

bool flag = true;

while (flag)
{
        Console.WriteLine("==== MENU ====");
        Console.WriteLine("1. Crear cliente");
        Console.WriteLine("11. Listar Clientes");
        Console.WriteLine("2. Crear producto");
        Console.WriteLine("3. Crear pedido");
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
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

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
