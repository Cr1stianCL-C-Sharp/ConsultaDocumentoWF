using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaDatos;
using System.Collections;

namespace CapaLogica
{
    public class ConsultaDocumento
    {
        #region talvez
        //private String RutDeudor;
        //private int NroDoc;
        //private int TipoDoc;

        //public ConsultaDocumento()
        //{

        //}

        //public String ConsultaTipoDocumento()
        //{

        //    DataAccess oDataAccess = new DataAccess();
        //    StringBuilder sb = new StringBuilder();
        //    IDataReader reader = null;
        //    String Result = String.Empty;         

        //    sb.Append("select dc_tipo_documento  from tb_tipo_documento where dm_vigente='S' ");

        //    String SQuery = sb.ToString();

        //    try
        //    {
        //        oDataAccess.Open();
        //        reader = oDataAccess.ExecuteReader(CommandType.Text, SQuery);

        //        //while (reader.Read())
        //        //{
        //        //    Result = reader["@dg_str_num_prop"].ToString();
        //        //}

        //        reader.Close();
        //        oDataAccess.Close();
        //        return Result;
        //    }
        //    catch
        //    {
        //        throw;
        //    }


        //    //if (Tdoc == 1)
        //    //{
        //    //ConsultaDoc(Rdeudor, Ndoc);

        //    //} else if (Tdoc == 2)
        //    //{
        //    //    ConsultaDoc(Rdeudor, Ndoc);

        //    //} else if (Tdoc == 3)
        //    //{
        //    //    ConsultaDoc(Rdeudor, Ndoc);

        //    //}

        //}
        #endregion
        DataAccess odata = new DataAccess();
        SqlCommand cmd = new SqlCommand();
        //static string connString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        //static string connString = ;
        //SqlConnection Connex = new SqlConnection(odata.ConexString());
        public DataTable ConsultaTipoDocumento()
        {

            DataAccess oDataAccess = new DataAccess();
            //ArrayList listaTDoc = new ArrayList();
           // IDataReader reader = null;
            StringBuilder sb = new StringBuilder();


            //sb.Append("select dc_tipo_documento from tb_tipo_documento where dm_vigente='S'");
            sb.Append("select dc_tipo_documento from tb_tipo_documento");

            try
            { 

            String SQuery = sb.ToString();

                //SqlDataAdapter Adapter = new SqlDataAdapter(SQuery, oDataAccess.Open());
                //DataTable dDocs = new DataTable();

                //string connString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
                //SqlConnection Connex = new SqlConnection(odata.ConexString());
                using (SqlConnection con = new SqlConnection(odata.ConexString()))
            {
                SqlDataAdapter dap = new SqlDataAdapter(SQuery, con);
                DataSet ds = new DataSet();
                dap.Fill(ds);
                return ds.Tables[0];
            }
           
            }
            catch
            {
                throw;
            }
        }


        public String ConsultaFactura(string Rdeudor,int Ndoc,string tdoc)
        {
            SqlConnection Connex = new SqlConnection(odata.ConexString());

            try
            {
                DataAccess oDataAccess = new DataAccess();
                //StringBuilder sb = new StringBuilder();
                //sb.Append("Sps_BuscarDocumento @dc_rut_deudor='" + Rdeudor + "',@dn_numero_documento='" + Ndoc + "',@dc_tipo_documento='" + tdoc + "'");

                //String SQuery = sb.ToString();
                String sResult = String.Empty;
                
                //SqlCommand cmd = new SqlCommand();
                //string connString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
                //SqlConnection Connex = new SqlConnection(connString);

                Connex.Open();
                //oDataAccess.Open();
                cmd = new SqlCommand("Sps_BuscarDocumento");
                cmd.CommandType = CommandType.StoredProcedure;   

                cmd.Parameters.AddWithValue("@dc_rut_deudor", Rdeudor);
                cmd.Parameters.AddWithValue("@dn_numero_documento", Ndoc);
                cmd.Parameters.AddWithValue("@dc_tipo_documento", tdoc);
                cmd.Connection = Connex;
                //int result = cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                // reader = oDataAccess.ExecuteNonQuery(CommandType.StoredProcedure);

                while (reader.Read())
                {
                    sResult = reader["@dg_str_num_prop"].ToString();
                }

                Connex.Close();

                //if (sResult == "")
                //{
                //    sResult = Ndoc.ToString();
                //}

                    return sResult;
            }
            catch
            {
                Connex.Close();
                throw;
            }

        }

        public String ConsultaLetras(string Rcliente)
        {
            SqlConnection Connex = new SqlConnection(odata.ConexString());

            try
            {
                DataAccess oDataAccess = new DataAccess();
                //StringBuilder sb = new StringBuilder();
                //sb.Append("Sps_BuscarDocumento @dc_rut_deudor='" + Rdeudor + "',@dn_numero_documento='" + Ndoc + "',@dc_tipo_documento='" + tdoc + "'");

                //String SQuery = sb.ToString();
                String sResult = String.Empty;

     //           alter procedure SPs_buscaLetra(
     //@dc_rut_deudor varchar(1000),
     //@dc_tipo_documento varchar(1000)
     //) as

                Connex.Open();
                //oDataAccess.Open();
                cmd = new SqlCommand("SPs_buscaLetra");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dc_rut_cliente", Rcliente);
                //cmd.Parameters.AddWithValue("@dc_tipo_documento", tdoc);                
                cmd.Connection = Connex;
                //int result = cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                // reader = oDataAccess.ExecuteNonQuery(CommandType.StoredProcedure);

                while (reader.Read())
                {
                    sResult = reader["@dn_reg_min"].ToString();
                }

                Connex.Close();

                //if (sResult == "")
                //{
                //    sResult = Ndoc.ToString();
                //}

                return sResult;
            }
            catch
            {
                Connex.Close();
                throw;
            }

        }

        public String ConsultaPagare(string Rcliente)
        {
            SqlConnection Connex = new SqlConnection(odata.ConexString());

            try
            {
                DataAccess oDataAccess = new DataAccess();                
                String sResult = String.Empty;
               
                Connex.Open();
                //oDataAccess.Open();
                cmd = new SqlCommand("SPs_ConsultaPagare");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dc_rut_cliente", Rcliente);
                //cmd.Parameters.AddWithValue("@dc_tipo_documento", tdoc);
                cmd.Connection = Connex;
                //int result = cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                // reader = oDataAccess.ExecuteNonQuery(CommandType.StoredProcedure);

                while (reader.Read())
                {
                    sResult = reader["@dg_str_num_prop"].ToString(); //// //@dg_str_num_prop
                }

                Connex.Close();

                //if (sResult == "")
                //{
                //    sResult = Ndoc.ToString();
                //}

                return sResult;
            }
            catch
            {
                Connex.Close();
                throw;
            }

        }

        #region commented
        //public String ConsultaDoc(string Rdeudor, int Ndoct, int Ndoc, string tdoc)
        //{

        //    DataAccess oDataAccess = new DataAccess();
        //    StringBuilder sb = new StringBuilder();
        //    IDataReader reader = null;
        //    //SqlCommand cmd = new SqlCommand();
        //    //SqlDataReader reader;
        //    String RutContrata = "99580240-6";



        //    //string connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        //    //SqlConnection Connex = new SqlConnection(connString);
        //    String app1 = "declare @Strdc_rut_cliente varchar(1000),@dc_usuario varchar(10), @dg_resultado varchar(10), " +
        //            "@dc_rut_deudor varchar(1000), @dc_tipo_documento varchar(1000), @dn_numero_documento varchar(1000), @dn_num_propuesto varchar(1000)" +
        //            "SET NOCOUNT ON ";

        //    String app2 = "CREATE TABLE #tmp_doc_por_cli(dc_rut_cliente varchar(10) collate Modern_Spanish_CI_AS " +
        //        ", dc_rut_deudor varchar(10) collate Modern_Spanish_CI_AS, dc_tipo_documento varchar(2) collate Modern_Spanish_CI_AS " +
        //        ", dn_numero_documento integer) INSERT INTO #tmp_doc_por_cli(dc_rut_cliente, dc_rut_deudor, dc_tipo_documento, dn_numero_documento) " +
        //    " SELECT doc.dc_rut_cliente, doc.dc_rut_deudor, doc.dc_tipo_documento, doc.dn_numero_documento FROM tb_documentos doc ";

        //    String app3 = " AND doc.dc_rut_deudor = @dc_rut_deudor AND doc.dc_tipo_documento = @dc_tipo_documento AND doc.dc_rut_cliente = @Strdc_rut_cliente " +
        //        " AND doc.dn_numero_documento = @dn_numero_documento declare @dn_reg_total integer, @dn_reg integer, @dc_rut_cli varchar(10), @dc_tipo_doc varchar(2) " +
        //        ", @dn_numero_doc integer, @dc_rut_deu varchar(10), @dg_str_num_prop   integer, @dg_numero_multi   integer CREATE TABLE #tmp_doc_existentes " +
        //        "(dc_rut_cli         varchar(10) collate Modern_Spanish_CI_AS, dc_tipo_doc varchar(2) collate Modern_Spanish_CI_AS , dn_numero_doc integer " +
        //        ", dc_rut_deu varchar(10) collate Modern_Spanish_CI_AS, dn_reg integer identity(1, 1)) INSERT INTO #tmp_doc_existentes(dc_rut_cli, dc_tipo_doc, dn_numero_doc, dc_rut_deu) " +
        //        "SELECT tmp.dc_rut_cliente, tmp.dc_tipo_documento, tmp.dn_numero_documento, tmp.dc_rut_deudor FROM   #tmp_doc_por_cli tmp WHERE tmp.dn_numero_documento = @dn_numero_documento " +
        //        "and  dc_rut_deudor = @dc_rut_deudor and tmp.dc_tipo_documento = @dc_tipo_documento and dn_numero_documento = @dn_numero_documento SELECT @dc_rut_deu = dc_rut_deu, @dc_tipo_doc = dc_tipo_doc " +
        //        ", @dn_numero_doc = dn_numero_doc, @dc_rut_cli = dc_rut_cli FROM #tmp_doc_existentes CREATE TABLE #tmp_numeros(dg_str_numero      varchar(10)) SET @dn_reg_total = 10 SET    @dn_reg = 1 " +
        //        " WHILE @dn_reg < = @dn_reg_total BEGIN INSERT INTO #tmp_numeros(dg_str_numero) SELECT 100 * @dn_reg SET @dn_reg = @dn_reg + 1 END SELECT @dn_reg_total = COUNT(1) FROM  #tmp_doc_existentes " +
        //        "SELECT @dg_str_num_prop = min(convert(integer, dg_str_numero + convert(varchar, @dn_numero_doc))) FROM   #tmp_numeros WHERE  Not Exists(Select 1 From   #tmp_doc_por_cli Where  dc_rut_deudor = @dc_rut_deu " +
        //        "AND dc_tipo_documento = @dc_tipo_doc AND dn_numero_documento = dg_str_numero + convert(varchar, @dn_numero_doc)) SELECT '@dg_str_num_prop' = @dg_str_num_prop " +
        //        "DROP TABLE #tmp_doc_existentes DROP TABLE #tmp_numeros DROP TABLE #tmp_doc_por_cli ";


        //    sb.Append(app1);
        //   // sb.Append(" set @Strdc_rut_cliente = '" + RutCliente + "'");
        //    sb.Append(" set @dc_rut_deudor = '" + Rdeudor + "'");
        //    sb.Append(" set @dc_tipo_documento = '" + tdoc + "'");
        //    sb.Append(" set @dn_numero_documento = '" + Ndoc + "'");
        //    sb.Append(app2);
        //    sb.Append("WHERE  doc.dc_rut_contrata = '" + RutContrata + "'");
        //    sb.Append(app3);

        //    String SQuery = sb.ToString();
        //    String sResult = String.Empty;
        //    //String sResult = String.Empty;
        //    //int Result = 0;

        //    try
        //    {
        //        oDataAccess.Open();
        //        reader = oDataAccess.ExecuteReader(CommandType.Text, SQuery);

        //        while (reader.Read())
        //        {
        //            sResult = reader["@dg_str_num_prop"].ToString();
        //        }

        //        reader.Close();

        //        if (sResult == "")
        //        {
        //            sResult = Ndoc.ToString();
        //        }


        //        return sResult;
        //    }
        //    catch
        //    {
        //        throw;
        //    }

        //}


        #endregion

        public SqlDataReader trying()
        {
            try
            {
                                
                
                StringBuilder sb = new StringBuilder();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                string connString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
                //SqlConexion oSql = new SqlConexion(connString);
                SqlConnection Connex = new SqlConnection(connString);

                sb.Append("select dc_tipo_documento from tb_tipo_documento where dm_vigente='S'");
                String query = sb.ToString();
                ArrayList Records = new ArrayList();

                SqlDataAdapter Adapter = new SqlDataAdapter(query, Connex);
                DataTable dDocs = new DataTable();

                Connex.Open();
                if (Connex != null && Connex.State == ConnectionState.Open)
                {
                    
                    cmd.CommandText = query;
                    cmd.Connection = Connex;
                    reader = cmd.ExecuteReader();
                     reader.Read();

                    //while (reader.HasRows)
                    //{
                    //     //Records.Add(reader["dm_vigente"].ToString());

                       
                    //}
                    Adapter.Fill(dDocs);
                    Connex.Close();
                    return null;
                }
                else
                {
                    Connex.Close();
                    return null;
                }
                


            }
            catch (Exception e)
            {
                //Logs.Log("FilterMail.Filter", e.Message.ToString());
                String mensaje = e.Message.ToString();

                return null;
                throw;
            }
            finally
            {
                //Connex.Close();
            }

        }




    }
}
