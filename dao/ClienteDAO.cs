using HelloWorld.model;

namespace HelloWorld.dao
{
    public class ClienteDAO
    {

        static List<Cliente> clientes = new List<Cliente>();
        private Cliente cliente;
        //static List<Pedido> pedidos = new List<Pedido>();

        public void crearCliente(string nomCliente, string emailCliente)
        {
            
            int idNuevoCliente = clientes.Count + 1;

            cliente = new Cliente(idNuevoCliente, nomCliente, emailCliente);

            clientes.Add(cliente);

            Console.WriteLine("\nCliente creado exitosamente!");
        }

        public void listarClientes()
        {
            Console.WriteLine("\n==== Lista de Clientes ====\n");
            if ( clientes.Count > 0)
            {
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {cliente.Id}");
                    Console.WriteLine($"Nombre: {cliente.Name}");
                    Console.WriteLine($"Correo: {cliente.Email}");
                    Console.WriteLine("--------------------");
                }
            }
            else
            {
                Console.WriteLine("No hay clientes registrados.");
            }
        }

        public void actualizarCliente()
        {

        }

        public void eliminarCliente()
        {

        }
    }
}
