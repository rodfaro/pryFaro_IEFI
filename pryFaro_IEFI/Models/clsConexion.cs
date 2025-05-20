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

        #region Metodos para Administradores
        public clsUsuariosReg IniciarSesion(clsUsuariosReg usuario)
        {
            string query = "SELECT idUsuario, Usuario, Admin FROM Usuarios WHERE Usuario COLLATE SQL_Latin1_General_CP1_CS_AS = @Usuario AND @Passw COLLATE SQL_Latin1_General_CP1_CS_AS = Passw";
            clsUsuariosReg returnUsuario = new clsUsuariosReg();
            returnUsuario.idUser = -1;
            
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                command.Parameters.AddWithValue("@Passw", usuario.Passw);

                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    returnUsuario.idUser = reader.GetInt32(0);
                    returnUsuario.Usuario = reader.GetString(1);
                    returnUsuario.Admin = reader.GetBoolean(2);
                }

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
            return returnUsuario;
        }
        #endregion

        public void GuardarJornada(clsAuditar auditoria)
        {
            string query = $@"INSERT INTO Auditar(IdUsuario, TiempoTrabajado, Descripcion)
                                VALUES (@IdUsuario, @TiempoTrabajado, @Desc)";

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@IdUsuario", auditoria.IdUsuario);
                    command.Parameters.AddWithValue("@TiempoTrabajado", auditoria.TiempoTrabajado);
                    command.Parameters.AddWithValue("@Desc", auditoria.Descripcion);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
