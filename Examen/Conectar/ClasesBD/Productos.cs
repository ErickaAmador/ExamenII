namespace Conectar.ClasesBD
{
    public class Productos
    {
       
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }

        public Productos()
        {
        }

        public Productos(string codigo, string nombre, decimal precio, int existencia)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Existencia = existencia;
        }
    }
}
