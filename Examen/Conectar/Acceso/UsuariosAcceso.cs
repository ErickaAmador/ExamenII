using Conectar.ClasesBD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conectar.Acceso
{
    public class UsuariosAcceso
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen; Uid=root; Pwd=ErickaAmador26@;";

        MySqlConnection conexion;
        MySqlCommand cmd;

        public Usuarios  Login(string codigoUsuarios, string clave)
        {
            Usuarios user = null;


            try
            {
                string sql = "SELECT * FROM usuarios WHERE CodigoUsuarios = @CodigoUsuarios AND Clave = @Clave;";

                conexion = new MySqlConnection(cadena);
                conexion.Open();

                cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@CodigoUsuarios", codigoUsuarios);
                cmd.Parameters.AddWithValue("@Clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuarios();
                    user.CodigoUsuarios = reader[0].ToString();
                    user.Nombre = reader[1].ToString();
                    user.Clave = reader[2].ToString();
                }
                reader.Close();
                conexion.Close();

            }
            catch (Exception ex)
            {
            }
            return user;

        }

    }
}
