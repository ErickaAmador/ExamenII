using Conectar.ClasesBD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conectar.Acceso
{
    
    public class ProductosAcceso
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen; Uid=root; Pwd=ErickaAmador26@;";

        MySqlConnection conexion;
        MySqlCommand cmd;


        public DataTable ListarProductos()
        {
            DataTable lista = new DataTable();

            try
            {
                string sql = "SELECT * FROM productos;";
                conexion = new MySqlConnection(cadena);
                conexion.Open();  
                
                cmd = new MySqlCommand(sql, conexion); 

                MySqlDataReader reader = cmd.ExecuteReader();   
                lista.Load(reader);
                reader.Close();
                conexion.Close();   
            }
            catch (Exception)
            {
            }
            return lista;
        }

        public bool InsertarProducto(Productos productos)
        {
            bool insertoP = false;
            try
            {


                string sql = "INSERT INTO productos VALUES (@Codigo, @Nombre, @Precio, @Existencia);";

                conexion = new MySqlConnection(cadena);
                conexion.Open();

                cmd = new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@Codigo", productos.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", productos.Nombre);
                cmd.Parameters.AddWithValue("@Precio", productos.Precio);
                cmd.Parameters.AddWithValue("@Existencia", productos.Existencia);

                cmd.ExecuteNonQuery();
                insertoP = true;

                conexion.Close();
            }
            catch (Exception)
            {

            }
            return insertoP;
        }

        public bool ModificarProducto(Productos productos)
        {
            bool modificoP = false;

            try
            {
                string sql = ("UPDATE productos SET Codigo = @Codigo, Nombre = @Nombre, Precio = @Precio, Existencia = @Existencia WHERE Codigo = @Codigo;");

                conexion = new MySqlConnection(cadena);
                conexion.Open();

                cmd = new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@Codigo", productos.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", productos.Nombre);
                cmd.Parameters.AddWithValue("@Precio", productos.Precio);
                cmd.Parameters.AddWithValue("@Existencia", productos.Existencia);

                cmd.ExecuteNonQuery();
                modificoP = true;
                conexion.Close();

            }
            catch (Exception)
            {

            }
            return modificoP;
        }

        public bool  EliminarProducto(String codigo)
        {
            bool EliminoP = false;

            try
            {
                string sql = "DELETE FROM productos WHERE Codigo = @Codigo;";

                conexion = new MySqlConnection(cadena);
                conexion.Open();

                cmd = new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@Codigo", codigo);

                cmd.ExecuteNonQuery (); 
                EliminoP = true;
                conexion.Close();
            }
            catch (Exception ex)
            {
            }
            return EliminoP;

        }


        public Productos GetProductosCodigo(string codigo)
        {
            Productos productos = new Productos();

            try
            {
                string sql = "Select * from productos  WHERE Codigo = @Codigo;";

                conexion = new MySqlConnection(cadena);
                conexion.Open();

                cmd = new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@Codigo", codigo);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    productos.Codigo = reader["Codigo"].ToString();
                    productos.Nombre = reader["Nombre"].ToString();
                    productos.Precio = Convert.ToDecimal(reader["Precio"].ToString());
                    productos.Existencia = Convert.ToInt32(reader["Existencia"].ToString());
                }
                conexion.Close ();  

            }
            catch (Exception)
            {
            }
            return productos;
        }
    }

}
