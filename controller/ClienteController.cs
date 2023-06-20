using HelloWorld.dao;

namespace HelloWorld
{
    public class ClienteController
    {
        ClienteDAO clienteDAO = new ClienteDAO();
        
        public void crearCliente()
        {
            Console.WriteLine("\n==== Crear Cliente ====\n");

            Console.Write("Ingrese el nombre del cliente: ");
            string nombreCliente = Console.ReadLine();

            Console.Write("Ingresa el email del cliente: ");
            string emailCliente = Console.ReadLine();

            clienteDAO.crearCliente(nombreCliente, emailCliente);
        }

        public void listarClientes()
        {
            clienteDAO.listarClientes();
        }

        public void actualizarCliente()
        {
            Console.WriteLine("\n==== Actualizar Cliente ====\n");

            Console.WriteLine("Ingrese el id del Cliente a actualizar...");
            var idClienteToSearch = int.Parse(Console.ReadLine());

            clienteDAO.actualizarCliente(idClienteToSearch);
        }

        public void eliminarCliente()
        {
            Console.WriteLine("\n==== Eliminar Cliente ====\n");

            Console.WriteLine("Ingrese el id del Cliente a eliminar...");
            var idClienteToDelete = int.Parse(Console.ReadLine());

            clienteDAO.eliminarCliente(idClienteToDelete);
        }

    }
}
