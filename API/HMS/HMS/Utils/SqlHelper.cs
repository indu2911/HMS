using System.Data;
using System.Data.SqlClient;

namespace HMS.Utils
{
    public class SqlHelper
    {
        private string ConnectionString;

        public SqlHelper(string _conString)
        {
            ConnectionString = _conString;
        }

        public DataTable ExecuteSelectCommand(string CommandName, CommandType cmdType)
        {
            DataTable table = null;

            using (SqlConnection con = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = CommandName;
                    cmd.CommandTimeout = 1800;

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            table = new DataTable();
                            da.Fill(table);
                        }

                    }
                    catch (SqlException sqlex)
                    {
                        throw sqlex;
                    }
                    catch (DataException dataex)
                    {
                        throw dataex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;

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

            return table;
        }

        public DataTable ExecuteParamerizedSelectCommand(string CommandName, CommandType cmdType, IDbDataParameter[] param)
        {
            DataTable table = new DataTable();

            using (SqlConnection con = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = CommandName;
                    cmd.Parameters.AddRange(param);
                    cmd.CommandTimeout = 1800;

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(table);
                        }


                    }
                    catch (SqlException sqlex)
                    {
                        throw sqlex;
                    }
                    catch (DataException dataex)
                    {
                        throw dataex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;

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

            return table;
        }

        public bool ExecuteNonQuery(string CommandName, CommandType cmdType, IDbDataParameter[] pars)
        {
            int result = 0;

            using (SqlConnection con = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = CommandName;
                    cmd.Parameters.AddRange(pars);
                    cmd.CommandTimeout = 1800;

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        result = cmd.ExecuteNonQuery();

                    }
                    catch (SqlException sqlex)
                    {
                        throw sqlex;
                    }
                    catch (DataException dataex)
                    {
                        throw dataex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;

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

            return (result > 0);
        }

        public bool ExecuteNonQuery(string CommandName, CommandType cmdType)
        {
            int result = 0;

            using (SqlConnection con = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = CommandName;
                    cmd.CommandTimeout = 1800;

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        result = cmd.ExecuteNonQuery();

                    }
                    catch (SqlException sqlex)
                    {
                        throw sqlex;
                    }
                    catch (DataException dataex)
                    {
                        throw dataex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;

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

            return (result > 0);
        }

        public string ExecuteScalar(string CommandName, CommandType cmdType, IDbDataParameter[] pars)
        {
            string result = "";

            using (SqlConnection con = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = CommandName;
                    cmd.Parameters.AddRange(pars);
                    cmd.CommandTimeout = 1800;

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        result = cmd.ExecuteScalar().ToString();

                    }
                    catch (SqlException sqlex)
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();

                        }
                        throw sqlex;
                    }
                    catch (DataException dataex)
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();

                        }
                        throw dataex;
                    }
                    catch (Exception ex)
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();

                        }
                        throw ex;

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

            return result;
        }

        public DataSet ExecuteMutipleSelectCommand(string CommandName, CommandType cmdType)
        {
            DataSet dataset = null;
            using (SqlConnection con = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = CommandName;
                    cmd.CommandTimeout = 1800;

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            dataset = new DataSet();
                            da.Fill(dataset);
                        }
                    }
                    catch (SqlException sqlex)
                    {
                        throw sqlex;
                    }
                    catch (DataException dataex)
                    {
                        throw dataex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
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
            return dataset;
        }

        public DataSet ExecuteParamerizedMultipleSelectCommand(string CommandName, CommandType cmdType, IDbDataParameter[] param)
        {
            DataSet dataset = new DataSet();

            using (SqlConnection con = new SqlConnection(this.ConnectionString))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = cmdType;
                    cmd.CommandText = CommandName;
                    cmd.Parameters.AddRange(param);
                    cmd.CommandTimeout = 1800;

                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dataset);
                        }
                    }
                    catch (SqlException sqlex)
                    {
                        throw sqlex;
                    }
                    catch (DataException dataex)
                    {
                        throw dataex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
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
            return dataset;
        }

        public IDbDataParameter GetDataParameter(string parameter, object value)
        {
            throw new NotImplementedException();
        }
    }
}
