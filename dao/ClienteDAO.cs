using HelloWorld.model;

namespace HelloWorld.dao
{
    public class ClienteDAO
    {

        public static List<Cliente> clientes = new List<Cliente>();
        private Cliente cliente;
        //static List<Pedido> pedidos = new List<Pedido>();

        public void crearCliente(string nomCliente, string emailCliente)
        {
            
            int idNuevoCliente = clientes.Count + 1;

            cliente = new Cliente(idNuevoCliente, nomCliente, emailCliente);

            clientes.Add(cliente);

            Console.WriteLine("\n*** Cliente creado exitosamente! ***");
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
                Console.WriteLine("\n*** No hay clientes registrados. ***\n");
            }
        }

        public void actualizarCliente(int idClienteToSearch)
        {   
            if( clientes.Count > 0)
            {
                for (int i = 0; i < clientes.Count; i++)
                {
                    var element = clientes[i];
                    if (element.Id == idClienteToSearch)
                    {
                        Console.WriteLine("Se encontro el cliente!");

                        Console.WriteLine("Ingrese el nuevo nombre: ");
                        var nuevoNombre = Console.ReadLine();

                        Console.WriteLine("Ingrese el nuevo email");
                        var nuevoEmail = Console.ReadLine();

                        cliente.Name = nuevoNombre;
                        cliente.Email = nuevoEmail;

                        Console.WriteLine("\n*** El cliente se actualizo! ***\n");

                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("\n*** No hay clientes en la lista! ***\n");
            }

        }

        public void eliminarCliente(int idClienteToDelete)
        {
            if( clientes.Count > 0)
            {
                for(int i = 0;i < clientes.Count; i++)
                {
                    var element = clientes[i];
                    if( element.Id == idClienteToDelete)
                    {
                        clientes.Remove(element);

                        Console.WriteLine("\n***Cliente eliminado Exitosamente!***\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n*** No se encontro el Id! ***\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("\n*** No hay clientes en la lista! ***\n");
            }
        }
    }
}
