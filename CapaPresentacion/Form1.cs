using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using System.Collections;
using System.Text.RegularExpressions;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //ConsultaDocumento oConsulta = new ConsultaDocumento();
            //oConsulta.ConsultaTipoDocumento()

            cboxTDoc.Items.Add("Seleccione...");
            cboxTDoc.SelectedIndex = cboxTDoc.FindStringExact("Seleccione...");
            txNroDoc.BackColor = System.Drawing.Color.Orange;
            txNroDoc.ForeColor = System.Drawing.Color.Black;
            //MtxRutCliente.BackColor = System.Drawing.Color.Orange;
            //MtxRutCliente.ForeColor = System.Drawing.Color.Black;
            MtxRutDeudor.BackColor = System.Drawing.Color.Orange;
            MtxRutDeudor.ForeColor = System.Drawing.Color.Black;
            cboxTDoc.BackColor = System.Drawing.Color.Orange;
            cboxTDoc.ForeColor = System.Drawing.Color.Black;
            ConsultaDocumento oCon = new ConsultaDocumento();

            lblOperacion.Text = "";
            lblAyudaPA.Text = "";

            lblRutDeudor.Visible = false;
            MtxRutDeudor.Visible = false;

            lblSide.Visible = false;
            lbResultado.Visible= false;

            lblNroDoc.Visible = false;
            txNroDoc.Visible = false;

           // MaskedTextBox DinMaskedtx = new MaskedTextBox();

            try
            {
                DataTable dataTipos = oCon.ConsultaTipoDocumento();

                int max = dataTipos.Rows.Count;
                for (int i = 0; i < max; i++)
                {
                    cboxTDoc.Items.Add(dataTipos.Rows[i]["dc_tipo_documento"].ToString());
                }
                cboxTDoc.Items.Remove("CA"); //removidos porque aun no se han implementado
                cboxTDoc.Items.Remove("CH");
                cboxTDoc.Items.Remove("CL");
                cboxTDoc.Items.Remove("NC");
                cboxTDoc.Items.Remove("ND");
                cboxTDoc.Items.Remove("OC");
                cboxTDoc.Items.Remove("VV");

            }
            catch(Exception e)
            {
                string error =e.Message.ToString();
                MessageBox.Show("Se ha producido un error: "+ error);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaDocumento oConsulta = new ConsultaDocumento();
            StringBuilder sERROR = new StringBuilder();
            String Resultado = String.Empty;
            bool err = false;
            String RutDeudor = MtxRutDeudor.Text;
            int Ndoc = 0;
            String TDoc = String.Empty;


            ////switch (caseSwitch)
            ////{
            ////    case 1:
            ////        Console.WriteLine("Case 1");
            ////        break;
            ////    case 2:
            ////        Console.WriteLine("Case 2");
            ////        break;
            ////    default:
            ////        Console.WriteLine("Default case");
            ////        break;
            ////}
            try
            {
                //String str = MtxRutDeudor.Text;
                RutDeudor = RutDeudor.Replace(",", "");
                //str = str.Replace("-", "");
                RutDeudor = RutDeudor.Replace(" ", "");

                if (string.IsNullOrEmpty(RutDeudor) || RutDeudor == "-")
                {

                    if (cboxTDoc.Text == "PA" || cboxTDoc.Text == "LE")
                    {
                        sERROR.Append("*Debes ingresar el rut del Cliente");
                        sERROR.AppendLine();
                    }
                    else
                    {
                        sERROR.Append("*Debes ingresar el rut del deudor");
                        sERROR.AppendLine();
                    }
                    
                    err = true;
                    MtxRutDeudor.Focus();
                }

                //int number = 0;
                if (string.IsNullOrEmpty(this.txNroDoc.Text))
                {
                    if (cboxTDoc.Text != "LE" && cboxTDoc.Text != "PA")
                    {   
                        
                        sERROR.Append("*Debes ingresar un numero de documento");
                        sERROR.AppendLine();
                        err = true;
                    }                   
                }else
                {                  
                    //String RutDeudor = txRutDeudor.Text;                   
                    if (txNroDoc.Text != "")
                    {
                        Ndoc = int.Parse(txNroDoc.Text);
                    }     
                    ////elimina comas de los rut               
                    //RutDeudor = RutDeudor.Replace(",", "");
                }

                if (cboxTDoc.Text == "Seleccione...")
                {            
                            
                    sERROR.Append("*Debes Seleccionar el tipo de documento");
                    sERROR.AppendLine();
                    err = true;
                }
                else
                {
                     TDoc = cboxTDoc.Text.ToString();
                }

                if (err == true)
                {
                    String Errores = sERROR.ToString();
                    MessageBox.Show(Errores);
                }
                
                
                //int Ndoc = number;
                //String RutCli = txRutCliente.Text;
                //String RutCli = MtxRutCliente.Text;
                
                //RutCli = RutCli.Replace(",", "");

                //valida rut
               

                //bool bCliente = oVal.Rut(RutCli);
               // bool bdeudor = oVal.Rut(RutDeudor);

                //if(bdeudor == true){
                    if ((RutDeudor != "        -") && (Ndoc != 0))
                    {
                        if (TDoc != "Seleccione..." && TDoc!="")
                        {                            
                            if((Ndoc != 0))
                            {
                             
                                if(TDoc == "FA" || TDoc == "FE"){
                                        lblSide.Visible = true;
                                        lbResultado.Visible = true;
                                        //lbResultado.Text = (oConsulta.ConsultaDoc(RutDeudor, Ndoc, RutCli, TDoc)).ToString();
                                        String responseDOC = (oConsulta.ConsultaFactura(RutDeudor, Ndoc, TDoc)).ToString();

                                if (responseDOC == "")
                                {
                                    lbResultado.Text = Ndoc.ToString();
                                }
                                else
                                {
                                    lbResultado.Text = responseDOC;
                                }
                            }                             

                        }
                            
                        }
                    }
                    if (TDoc == "LE" && RutDeudor != "        -")/* || TDoc == "FE")*/
                    {
                    lblSide.Visible = true;
                    lbResultado.Visible = true;
                    //lbResultado.Text = (oConsulta.ConsultaDoc(RutDeudor, Ndoc, RutCli, TDoc)).ToString();
                    String responseLE= (oConsulta.ConsultaLetras(RutDeudor)).ToString(); ///RutDeudor aca funciona cmo rut cliente


                    if (responseLE == "")
                    {                        
                        lbResultado.Text = "1";
                    }
                    else
                    {
                        lbResultado.Text = responseLE;
                    }
                        

                }

                if (TDoc == "PA" && RutDeudor != "        -")
                {

                    if (RutDeudor != "-")
                    {
                        lblSide.Visible = true;
                        lbResultado.Visible = true;
                        //lbResultado.Text = (oConsulta.ConsultaDoc(RutDeudor, Ndoc, RutCli, TDoc)).ToString();
                       String responsePA = (oConsulta.ConsultaPagare(RutDeudor)).ToString();


                        if (responsePA == "")
                        {
                            lbResultado.Text = "1";
                        }
                        else
                        {
                            lbResultado.Text = responsePA;
                            lblAyudaPA.Visible = true;
                            lblAyudaPA.Text = "El valor debe ser: "+ responsePA + "+NumeroCuotas3digitos"+ "\r\n"+ "Ejemplo: "+ responsePA + "001";

                        }
                        

                        ///RutDeudor aca funciona cmo rut cliente
                    }

                }
                    


            }
            catch (Exception p)
            {
                String Error = p.Message.ToString();
                MessageBox.Show("Ha ocurrido un error inesperado: " + Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txNroDoc.Clear();
            lblAyudaPA.Visible = false;
            //MtxRutCliente.Clear();
            MtxRutDeudor.Clear();
            cboxTDoc.SelectedIndex = cboxTDoc.FindStringExact("Seleccione...");
            lblSide.Visible = false;
            lbResultado.Visible = false;

            lblNroDoc.Visible = false;
            txNroDoc.Visible = false;

            lblRutDeudor.Visible = false;
            MtxRutDeudor.Visible = false;
            //lblRutDeudor.Text = "Ingrese Rut Deudor:";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("¿Realmente Deseas Salir?", "Saliendo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
                //System.Environment.Exit(0);
            }
            else if (dialog == DialogResult.No)
            {
                //don't do anything
            }            
        }

        private void txNroDoc_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txNroDoc.Text, out parsedValue))
            {
                //MessageBox.Show("Debes Ingresar Numeros");
                txNroDoc.Clear();
                return;
            }
        }

        private void cboxTDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void MtxRutDeudor_Leave(object sender, EventArgs e)
        {
            Boolean bdeudor = true;
            String RutDeudor=MtxRutDeudor.Text;           
            RutDeudor = RutDeudor.Replace(",", "");

            Valida oVal = new Valida();
            bdeudor = oVal.Rut(RutDeudor);

            if (bdeudor == false && RutDeudor  != "        -")
            {
                MessageBox.Show("No es un rut valido, ingrese nuevamente");
                MtxRutDeudor.Clear();
                MtxRutDeudor.Focus();
            }
            
        }

        private void txNroDoc_Leave(object sender, EventArgs e)
        {
           if (txNroDoc.TextLength > 12)
            {
                MessageBox.Show("NO se puede ingresar un numero tan largo");
                txNroDoc.ClearUndo();

            }
        }

        private void cboxTDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbResultado.Text = "";
            if (cboxTDoc.Text=="FA" || cboxTDoc.Text == "FE")
            {
                
                lblAyudaPA.Visible = false;
                lblNroDoc.Visible = true;
                txNroDoc.Visible = true;
                lblRutDeudor.Visible = true;
                MtxRutDeudor.Visible = true;
                lblRutDeudor.Text = "Ingrese Rut Deudor:";


                if(cboxTDoc.Text == "FA"){
                    lblOperacion.Text = "FACTURA AFECTA";
                }
                if (cboxTDoc.Text == "FE")
                {
                    lblOperacion.Text = "FACTURA ELECTRONICA";
                }

            }
            else if(cboxTDoc.Text == "PA")
            {
                lblRutDeudor.Visible = true;
                MtxRutDeudor.Visible = true;
                lblRutDeudor.Text = "Ingrese Rut Cliente:";
                lblOperacion.Text = "PAGARÉS";
                lblNroDoc.Visible = false;
                txNroDoc.Visible = false;
            }
            else if(cboxTDoc.Text == "LE")
            {
                lblAyudaPA.Visible = false;
                lblRutDeudor.Text = "Ingrese Rut Cliente:";
                MtxRutDeudor.Visible = true;
                lblRutDeudor.Visible = true;
                lblNroDoc.Visible = false;
                txNroDoc.Visible = false;
                lblOperacion.Text = "LETRAS";
            }else
            {
                lblNroDoc.Visible = false;
                txNroDoc.Visible = false;
            }


        }
    }
}
