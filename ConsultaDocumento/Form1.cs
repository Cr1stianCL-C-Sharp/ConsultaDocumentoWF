using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaDocumento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            ConsultaDocumento Cdocument = new ConsultaDocumento();
            ConsultaTipoDocumento Ctipo = new ConsultaTipoDocumento();

            //var checkedButton = container.Controls.OfType<RadioButton>()
            //                          .FirstOrDefault(r => r.Checked);


            if (cboxTipoDocumento.SelectedValue == "")
            {




            }else if (cboxTipoDocumento.SelectedValue == "")
            {



            }else if (cboxTipoDocumento.SelectedValue == "")
            {



            }




        }
    }
}
