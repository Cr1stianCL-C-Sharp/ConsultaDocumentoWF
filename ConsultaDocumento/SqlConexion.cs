using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Data;

namespace ConsultaDocumento
{
    class SqlConexion
    {

       
        private SqlCommand Cmd;
        private SqlDataAdapter _da;
        private DataTable _dt;
        private static string _connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        private SqlConnection _conn = new SqlConnection(_connectionString);
        public SqlConexion(String _connectionString)
        {           
            _conn.Open();
        }


        public DataTable QuryEx()
        {
            _da = new SqlDataAdapter(Cmd);
            _dt = new DataTable();
            _da.Fill(_dt);
            return _dt;
        }

        public void NonQuery()
        {

            Cmd.ExecuteNonQuery();
        }

    }
}
