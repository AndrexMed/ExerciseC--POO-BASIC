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
            clienteDAO.actualizarCliente();
        }

        public void eliminarCliente()
        {
            clienteDAO.eliminarCliente();
        }

    }
}
