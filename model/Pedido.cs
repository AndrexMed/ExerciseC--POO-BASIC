using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.model
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public int idCliente { get; set; }
        public int idProducto { get; set; }

        public Pedido(int idPedido, int idCliente, int idProducto) {
            this.idPedido = idPedido;
            this.idCliente = idCliente;
            this.idProducto = idProducto;
        }

    }
}
