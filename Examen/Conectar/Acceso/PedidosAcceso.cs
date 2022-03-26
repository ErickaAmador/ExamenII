using Conectar.ClasesBD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conectar.Acceso
{
    public class PedidosAcceso
    {

        readonly string cadena = "Server=localhost; Port=3306; Database=examen; Uid=root; Pwd=ErickaAmador26@;";

        MySqlConnection conexion;
        MySqlCommand cmd;

        public int InsertarPedido(Pedido pedido)
        {
            int idPedido = 0;

            try
            {

                //INSERT INTO productos VALUES
                string sql = "INSERT INTO pedidos (IdCliente, Fecha, Subtotal, Impuesto, Total) VALUES (@IdCliente, @Fecha, @Subtotal, @Impuesto, @Total); select last_insert_id();";

                conexion = new MySqlConnection(cadena);
                conexion.Open();

                cmd = new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@IdCliente", pedido.IdCliente); ///////////////////////
                cmd.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                cmd.Parameters.AddWithValue("@Subtotal", pedido.Subtotal);
                cmd.Parameters.AddWithValue("@Impuesto", pedido.Impuesto);
                cmd.Parameters.AddWithValue("@Total", pedido.Total);

                idPedido = Convert.ToInt32(cmd.ExecuteScalar());   
                conexion.Close();



            }
            catch (Exception ex)
            {

            }
            return idPedido; 
        }


        public bool DetallePedido(DetallePedido detallePedido)
        {
            bool inserto = false;

            try
            {


                string sql = "INSERT INTO detallepedido (IdPedido, CodigoProducto, Nombre, Cantidad, Precio, Total) VALUES (@IdPedido, @CodigoProducto, @Nombre, @Cantidad, @Precio, @Total);";

                conexion = new MySqlConnection(cadena);
                conexion.Open();

                cmd = new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@IdPedido", detallePedido.IdPedido);
                cmd.Parameters.AddWithValue("@CodigoProducto", detallePedido.CodigoProducto);
                cmd.Parameters.AddWithValue("@Nombre", detallePedido.Nombre);
                cmd.Parameters.AddWithValue("@Cantidad", detallePedido.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", detallePedido.Precio);
                cmd.Parameters.AddWithValue("@Total", detallePedido.Total);

                cmd.ExecuteNonQuery();



                inserto = true;
                conexion.Close();
            }
            catch (Exception ex)
            {

            }
            return inserto;
        }

    }
}
