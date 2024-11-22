using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class metodos_datos
    {
        public static DataSet execute_DataSet(string sp, params object[] parametros)
        {
            DataSet ds = new DataSet();
            string cadenaConexion = configuracion.Cadenaconexion;
            SqlConnection con = new SqlConnection(cadenaConexion);
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(sp, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;
                    if (parametros != null && parametros.Length % 2 != 0)
                    {
                        throw new Exception("Los parametros debe estar en pares (clave :valor)");
                    }
                    else
                    {
                        for (int i = 0; i < parametros.Length; i = i + 2)
                        {
                            cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1].ToString());
                        }
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(ds);
                        con.Close();
                    }
                }
                return ds;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
        }
        public static int execute_Scalar(string sp, params object[] parametros)
        {
            int id = 0;
            DataSet ds = new DataSet();
            string cadenaConexion = configuracion.Cadenaconexion;
            SqlConnection con = new SqlConnection(cadenaConexion);
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(sp, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;
                    if (parametros != null && parametros.Length % 2 != 0)
                    {
                        throw new Exception("Los parametros debe estar en pares (clave :valor)");
                    }
                    else
                    {
                        for (int i = 0; i < parametros.Length; i = i + 2)
                        {
                            cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1].ToString());
                        }
                        con.Open();
                        id = int.Parse(cmd.ExecuteScalar().ToString());
                        con.Close();
                    }
                }
                return id;
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
        }
        public static int execute_nonQuery(string sp, params object[] parametros)
        {
            int id = 0;
            DataSet ds = new DataSet();
            string cadenaConexion = configuracion.Cadenaconexion;
            SqlConnection con = new SqlConnection(cadenaConexion);
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(sp, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;
                    if (parametros != null && parametros.Length % 2 != 0)
                    {
                        throw new Exception("Los parametros debe estar en pares (clave :valor)");
                    }
                    else
                    {
                        for (int i = 0; i < parametros.Length; i = i + 2)
                        {
                            cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1].ToString());
                        }
                        con.Open();
                        cmd.ExecuteNonQuery();
                        id = 1;
                        con.Close();
                    }
                }
                return id;
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
        }
    }
}
