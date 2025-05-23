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

        public void EditarUsuario(clsUsuariosReg usuario)
        {
            string query = $@"UPDATE Usuarios
                                SET Usuario = @Usuario,
                                    Passw = @Passw,
                                    Admin =  @Admin
                                WHERE idUsuario = @Id";

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                    command.Parameters.AddWithValue("@Passw", usuario.Passw);
                    command.Parameters.AddWithValue("@Admin", usuario.Admin);
                    command.Parameters.AddWithValue("@Id", usuario.idUser);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message); ;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void CrearUsuario(clsUsuariosReg usuario)
        {
            string query = $@"INSERT INTO Usuarios(Usuario, Passw, Admin)
                                VALUES (@Usuario, @Passw, @Admin)";

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                    command.Parameters.AddWithValue("@Passw", usuario.Passw);
                    command.Parameters.AddWithValue("@Admin", usuario.Admin);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message); ;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }


        }

        public void EliminarUsuario(clsUsuariosReg usuario)
        {
            string query = $@"DELETE FROM Usuarios WHERE idUsuario = @Id";

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Id", usuario.idUser);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message); ;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }


        }

        public void EliminarAuditorias(clsUsuariosReg usuario)
        {
            string query = $@"DELETE FROM Auditar WHERE IdUsuario = @Id";

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Id", usuario.idUser);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message); ;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }


        }

        public bool VerificarUsuarioExistente(clsUsuariosReg usuario)
        {
            string query = $@"SELECT COUNT(*) FROM Usuarios WHERE Usuario COLLATE SQL_Latin1_General_CP1_CS_AS = @Usuario";
            bool usuarioExistente = false;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario.Usuario);

                    int resultado = (int)command.ExecuteScalar();

                    if (resultado > 0)
                        usuarioExistente = true;
                    else usuarioExistente = false;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message); ;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return usuarioExistente;
        }

        public bool VerificarUsuarioConAuditorias(clsUsuariosReg usuario)
        {
            string query = "SELECT COUNT(*) FROM Auditar WHERE IdUsuario = @idUsuario";
            bool usuarioConAuditorias = false;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@idUsuario", usuario.idUser);

                    int resultado = (int)command.ExecuteScalar();

                    if (resultado > 0)
                        usuarioConAuditorias = true;
                    else usuarioConAuditorias = false;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message); ;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return usuarioConAuditorias;
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

        public DataTable Listar()
        {
            string query = $@"SELECT a.Id, u.Usuario, a.Fecha, a.TiempoTrabajado, a.Descripcion
                                FROM Auditar a
                                JOIN Usuarios u ON a.IdUsuario = u.idUsuario
                                ORDER BY a.Id ASC";

            DataTable dt = new DataTable();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                };
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}"); ;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }
        public DataTable Listar(string tabla)
        {

            string query = $@"SELECT * FROM {tabla}";

            DataTable dt = new DataTable();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
                ;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}"); ;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }
    }
}
