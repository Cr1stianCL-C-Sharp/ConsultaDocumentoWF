using System.Data.SqlClient;
using System.Configuration;


namespace ConsultaDocumento
{
    class Conexion
    {

        private string _connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        public string connectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public Conexion(string tcConnectionString)
        {
            this.connectionString = tcConnectionString;
        }

        public SqlCommand CreateCommand()
        {
            SqlCommand loReturnValue = new SqlCommand()
            {
                Connection = new SqlConnection(this.connectionString)
            };
     

            return loReturnValue;
        }

        public void CloseConexion() { }

    }

}