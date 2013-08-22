using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace SGSV
{
    public class ClsDal
    {
        private static readonly SqlConnection Conn = new SqlConnection(Properties.Settings.Default.ConnectionString/*ConfigurationManager.AppSettings["ConnectionString"]*/);
        private static SqlTransaction _tran;

        public static T Exec<T>(string sql, bool isSp, params object[] parametros)
        {
            object retObj = null;
            if (_tran != null && _tran.Connection == null)
                _tran = null;
            try
            {
                if (Conn.State == ConnectionState.Closed) Conn.Open();
                var cmd = new SqlCommand(sql, Conn)
                              {CommandType = (isSp) ? CommandType.StoredProcedure : CommandType.Text};
                if (_tran != null)
                    cmd.Transaction = _tran;

                string dbTrace = cmd.CommandText + " ";
                if (parametros != null)
                {
                    for (int i = 0; i < parametros.GetLength(0); i += 2)
                    {
                        cmd.Parameters.AddWithValue((string)parametros[i], (parametros[i + 1] ?? DBNull.Value));
                        dbTrace += cmd.Parameters[cmd.Parameters.Count - 1].ParameterName + "="
                            + (cmd.Parameters[cmd.Parameters.Count - 1].Value == DBNull.Value ? "null" : "'"
                            + cmd.Parameters[cmd.Parameters.Count - 1].Value + "'") + ",";
                    }
                }

                System.Diagnostics.Debug.WriteLine(dbTrace);

                switch (typeof(T).Name)
                {
                    case "DataSet":
                        var ds = new DataSet();
                        var da = new SqlDataAdapter(cmd);
                        da.Fill(ds); retObj = ds; break;
                    case "IDataReader":
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        retObj = dr; dr.Close(); break;
                    case "Int32":
                        retObj = cmd.ExecuteNonQuery(); break;
                    case "String":
                        string respuesta = "";
                        XmlReader xr = cmd.ExecuteXmlReader();
                        while (xr.ReadState != ReadState.EndOfFile)
                            respuesta += xr.ReadOuterXml();
                        xr.Close();
                        retObj = respuesta; break;
                    case "Object":
                        retObj = cmd.ExecuteScalar(); break;
                }

                return (T)retObj;
            }
            catch (Exception ex)
            {
                if (_tran != null)
                {
                    try
                    {
                        _tran.Rollback();
                        _tran = null;
                    }
                    catch (Exception)
                    {
                        _tran = null;
                    }
                }
                throw new DbException("Database Error: " + ex.Message, ex);
            }
            finally
            {
                if (_tran == null && Conn.State == ConnectionState.Open && typeof(T).Name != "IDataReader") Conn.Close();
            }
        }

        public static void TransInit(string nombre)
        {
            if (_tran == null)
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
                _tran = Conn.BeginTransaction(nombre);
            }
        }

        public static void TransCommit()
        {
            if (_tran != null && _tran.Connection != null)
                _tran.Commit();
        }

        public static void TransRollback(string nombre)
        {
            if (_tran != null)
            {
                _tran.Rollback(nombre);
                if (_tran.Connection != null && _tran.Connection.State != ConnectionState.Closed)
                    _tran.Connection.Close();
            }
        }

    }

    public class DbException : ApplicationException
    {
        public DbException(string msg, Exception throwedEx)
            : base(msg, throwedEx)
        {

        }
    }
}
