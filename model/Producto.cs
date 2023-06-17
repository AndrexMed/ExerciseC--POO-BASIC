namespace HelloWorld.model
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public string descripcionProducto { get; set; }
        public double precioProducto { get; set; }

        public Producto(int idProducto, string nomProducto, string descProducto, double precioPro)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nomProducto;
            this.descripcionProducto = descProducto;
            this.precioProducto = precioPro;
        }
    }
}
