using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        public static ML.Result Add(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "INSERT INTO Usuario (Nombres, Apellidos, FNacimiento) VALUES (@Nombres, @Apellidos, @FNacimiento)";
                    
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;

                        SqlParameter[] collection = new SqlParameter[3];

                        collection[0] = new SqlParameter("Nombres", SqlDbType.VarChar);
                        collection[0].Value = usuario.Nombres;

                        collection[1] = new SqlParameter("Apellidos", SqlDbType.VarChar);
                        collection[1].Value = usuario.Apellidos;

                        collection[2] = new SqlParameter("FNacimiento", SqlDbType.DateTime);
                        collection[2].Value = usuario.FNacimiento;

                        cmd.Parameters.AddRange(collection);

                        cmd.Connection.Open();

                        int RowsAffected = cmd.ExecuteNonQuery();

                        if (RowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "Ocurrió un error al insertar el registro en la tabla";
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                result.Ex = Ex;
                throw;
            }

            return result;
        }

        public static ML.Result Update(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
            {
                string query = "UPDATE Usuario SET Nombres = @Nombres, Apellidos = @Apellidos, FNacimiento = @FNacimiento WHERE IdUsuario = @IdUsuario";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = context;
                    cmd.CommandText = query;

                    SqlParameter[] collection = new SqlParameter[4];

                    collection[0] = new SqlParameter("Nombres", SqlDbType.VarChar);
                    collection[0].Value = usuario.Nombres;

                    collection[1] = new SqlParameter("Apellidos", SqlDbType.VarChar);
                    collection[1].Value = usuario.Apellidos;

                    collection[2] = new SqlParameter("FNacimiento", SqlDbType.DateTime);
                    collection[2].Value = usuario.FNacimiento;

                    collection[3] = new SqlParameter("IdUsuario", SqlDbType.Int);
                    collection[3].Value = usuario.IdUsuario;

                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();

                    int RowsAffected = cmd.ExecuteNonQuery();

                    if (RowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un error al actualizar el registro en la tabla";
                    }

                }
            }
            return result;
        }

        public static ML.Result Delete(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
            {
                string query = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = context;
                    cmd.CommandText = query;

                    SqlParameter[] collection = new SqlParameter[1];

                    collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
                    collection[0].Value = usuario.IdUsuario;

                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();

                    int RowsAffected = cmd.ExecuteNonQuery();

                    if (RowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrió un eliminar al actualizar el registro en la tabla";
                    }

                }
            }
            return result;
        }

        public static ML.Result GetAllSP()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string querySP = "UsuarioGetAll";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = querySP;
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataTable tablaUsuario = new DataTable();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(tablaUsuario);

                        if(tablaUsuario.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            foreach (DataRow row in tablaUsuario.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();
                                usuario.IdUsuario = int.Parse(row[0].ToString());
                                usuario.Nombres = row[1].ToString();
                                usuario.Apellidos = row[2].ToString();
                                usuario.FNacimiento = DateTime.Parse(row[3].ToString());

                                result.Objects.Add(usuario);
                            }
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "Ocurrió un error al seleccionar los registros en la tabla Usuario";
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public static ML.Result GetByIdSP(int id)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string querySP = "UsuarioGetById";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = querySP;
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        SqlParameter[] collection = new SqlParameter[1];
                        collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
                        collection[0].Value = id;

                        cmd.Parameters.AddRange(collection);

                        DataTable tablaUsuario = new DataTable();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(tablaUsuario);

                        if (tablaUsuario.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            DataRow row = tablaUsuario.Rows[0];
                            
                                ML.Usuario usuario = new ML.Usuario();
                                usuario.IdUsuario = int.Parse(row[0].ToString());
                                usuario.Nombres = row[1].ToString();
                                usuario.Apellidos = row[2].ToString();
                                usuario.FNacimiento = DateTime.Parse(row[3].ToString());

                                result.Object = usuario;
                            
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "Ocurrió un error al seleccionar los registros en la tabla Usuario";
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }


    }
}
