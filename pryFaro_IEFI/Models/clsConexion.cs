using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pryFaro_IEFI.Models
{
    internal class clsConexion
    {
        SqlConnection conn = new SqlConnection("Server=localhost;Database=IEFI;Trusted_Connection=True;");

        public int IniciarSesion(clsUsuariosReg usuario)
        {
            string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario COLLATE SQL_Latin1_General_CP1_CS_AS = @Usuario AND @Passw COLLATE SQL_Latin1_General_CP1_CS_AS = Passw";
            int resultado = 0;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                command.Parameters.AddWithValue("@Passw", usuario.Passw);

                resultado = (int)command.ExecuteScalar();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return resultado;
        }

    }
}
