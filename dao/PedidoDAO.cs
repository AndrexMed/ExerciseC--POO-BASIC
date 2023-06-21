using HelloWorld.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.dao
{
    public class PedidoDAO
    {

        static List<Pedido> pedidos = new List<Pedido>();
        Pedido pedido;

        public void crearPedido(int idCliente, int idProducto)
        {
            int idNuevoPedido = pedidos.Count + 1;
            pedido = new Pedido(idNuevoPedido, idCliente, idProducto);

            pedidos.Add(pedido);

            Console.WriteLine("\nSe agrego el pedido!\n");
           
        }

        public void listarPedidos()
        {
            Console.WriteLine("\n==== Lista de Pedidos ====\n");

            if(pedidos.Count > 0)
            {
                foreach(Pedido pedido in pedidos)
                {
                    Console.WriteLine("Id del pedido : {0} " , pedido.idPedido);
                    Console.WriteLine("Id del cliente : {0} " , pedido.idCliente);
                    Console.WriteLine("Id del producto : {0} " , pedido.idProducto);
                }
            }
            else
            {
                Console.WriteLine("\n*** No se encontraron pedidos!! ***\n");
            }
        }

        public void eliminarPedido(int idPedidoToSearch)
        {
            if (pedidos.Count > 0)
            {
                for (int i = 0; i < pedidos.Count ; i++)
                {
                    var item = pedidos[i];
                    if (item.idPedido == idPedidoToSearch)
                    {
                        pedidos.Remove(item);

                        Console.WriteLine("\n *** Pedido eliminado correctamente! ***\n");
                    }
                    else
                    {
                        Console.WriteLine("\n*** No se encontro el ID !! *** \n");
                    }
                }
            }
            else
            {
                Console.WriteLine("\n*** No hay items en la lista! ***\n");
            }
        }
    }
}
