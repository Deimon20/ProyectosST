using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlTypes;

namespace Autenticacion
{
    class Registro
    {
        SqlConnection cn;

        //Metodo por prioridad Alta
        public string insertarAlta(string usuario, string tipo, string desc, string prio)
        {
            string salida = "El requerimiento fue ingresado, el plazo para resolver son 3 días";
            try
            {
                int prioridadAlta = 3;
                char estado = 'p';
                cn = new SqlConnection("Data Source = LOCALHOST\\SQLEXPRESS; Initial Catalog = prueba; Integrated Security = True;");
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_RegistroReq", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@tipoReq", tipo);
                cmd.Parameters.AddWithValue("@descripcion", desc);
                cmd.Parameters.AddWithValue("@prioridad", prio);
                cmd.Parameters.AddWithValue("@dias", prioridadAlta);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cn.Close();

            }
            catch (Exception ex)
            {
                salida = ex.ToString();
            }

            return salida;
        }
    }
}
