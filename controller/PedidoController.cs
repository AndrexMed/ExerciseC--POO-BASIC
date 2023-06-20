using HelloWorld.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.controller
{
    internal class PedidoController
    {

        PedidoDAO pedidoDAO = new();

        public void crearPedido()
        {
            Console.WriteLine("\n==== Crear Pedido ====\n");

            Console.WriteLine("Ingrese el Id del Cliente");
            int idCliente = int.Parse(Console.ReadLine());  

            Console.WriteLine("Ingrese el Id del Producto");
            int idProducto = int.Parse(Console.ReadLine());

            pedidoDAO.crearPedido(idCliente, idProducto);
        }

        public void listarPedidos()
        {
            pedidoDAO.listarPedidos();
        }
    }

}
