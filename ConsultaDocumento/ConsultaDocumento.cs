using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace ConsultaDocumento
{
    class ConsultaDocumento
    {

        private String RutDeudor;
        private int NroDoc;
        private int TipoDoc;

        public ConsultaDocumento()
        {

        }

        public ConsultaDocumento(String RutDeudor,int NrodDoc, int TipoDoc)
        {
            String Rdeudor = RutDeudor;
            int Ndoc = NrodDoc;
            int Tdoc = TipoDoc;



            if (Tdoc == 1)
            {
                ConsultaPagare(Rdeudor, Ndoc);

            } else if (Tdoc == 2)
            {
                ConsultaPagare(Rdeudor, Ndoc);

            } else if (Tdoc == 3)
            {
                ConsultaPagare(Rdeudor, Ndoc);

            }

        }


        protected void ConsultaPagare(string Rdeudor,int Ndoc)
        {
            try
            {             
                
                StringBuilder sb = new StringBuilder();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                string connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
                SqlConnection Connex = new SqlConnection(connString);

                sb.Append("if exists(select dc_mail from tb_filtro_mail where dc_mail = ");
                //sb.Append("if exists(select dc_mail from tb_filtro_mail where dc_mail = ");
                //sb.Append("if exists(select dc_mail from tb_filtro_mail where dc_mail = ");
                //sb.Append("if exists(select dc_mail from tb_filtro_mail where dc_mail = ");
                //sb.Append("if exists(select dc_mail from tb_filtro_mail where dc_mail = ");
                //sb.Append("if exists(select dc_mail from tb_filtro_mail where dc_mail = ");

                //sb.Append("if exists(select dc_mail from tb_filtro_mail where dc_mail = ");
                //sb.Append("'" + xMail + "')");
                //sb.Append("begin select dn_tipo from tb_filtro_mail where dc_mail =");
                //sb.Append("'" + xMail + "'end");

                Connex.Open();
                if (Connex != null && Connex.State == ConnectionState.Open)
                {
                    string query= sb.ToString();
                    cmd.CommandText = query;
                    cmd.Connection = Connex;
                    reader = cmd.ExecuteReader();
                    reader.Read();

                        if (reader.HasRows)
                        {                                
                          // Tipe_Mail = reader["dn_tipo"].ToString();             
                        }
                 }
                 else
                 {
                     //error al log
                 }
                    Connex.Close();

                
            }
            catch (Exception e)
            {
                //Logs.Log("FilterMail.Filter", e.Message.ToString());
            }






        }




    }
}
