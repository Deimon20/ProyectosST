using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Autenticacion
{
    internal class Conexion
    {
        SqlConnection cn;

        public Conexion()
        {
            try
            {
                //muestra si estamos conectados a la bd o no.
                cn = new SqlConnection("Data Source = LOCALHOST\\SQLEXPRESS; Initial Catalog = validar; Integrated Security = True;");
                MessageBox.Show("Se ha conectado correctamente a la BD", "Conexion Establecida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("No se puede conectar a la BD \n Error: " + ex.ToString(), "Error al Conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int Login(string usuario, string pass )
        {
            //procedimiento almacenado para autenticar el llamado desde SQL
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_Login", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", pass);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ejecutar el comando \n Error: " + ex.ToString(), "Error de Comando SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }

            return -1;
        }
    }
}
