namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboxTDoc = new System.Windows.Forms.ComboBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.txNroDoc = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRutDeudor = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lblSide = new System.Windows.Forms.Label();
            this.MtxRutDeudor = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lblAyudaPA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxTDoc
            // 
            this.cboxTDoc.FormattingEnabled = true;
            this.cboxTDoc.Location = new System.Drawing.Point(15, 59);
            this.cboxTDoc.Name = "cboxTDoc";
            this.cboxTDoc.Size = new System.Drawing.Size(168, 21);
            this.cboxTDoc.TabIndex = 2;
            this.cboxTDoc.SelectedIndexChanged += new System.EventHandler(this.cboxTDoc_SelectedIndexChanged);
            this.cboxTDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxTDoc_KeyPress);
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(12, 127);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(123, 13);
            this.lblNroDoc.TabIndex = 15;
            this.lblNroDoc.Text = "Ingrese Nro Documento:";
            // 
            // txNroDoc
            // 
            this.txNroDoc.Location = new System.Drawing.Point(15, 143);
            this.txNroDoc.Name = "txNroDoc";
            this.txNroDoc.Size = new System.Drawing.Size(168, 20);
            this.txNroDoc.TabIndex = 1;
            this.txNroDoc.TextChanged += new System.EventHandler(this.txNroDoc_TextChanged);
            this.txNroDoc.Leave += new System.EventHandler(this.txNroDoc_Leave);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(46, 222);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRutDeudor
            // 
            this.lblRutDeudor.AutoSize = true;
            this.lblRutDeudor.Location = new System.Drawing.Point(12, 88);
            this.lblRutDeudor.Name = "lblRutDeudor";
            this.lblRutDeudor.Size = new System.Drawing.Size(103, 13);
            this.lblRutDeudor.TabIndex = 11;
            this.lblRutDeudor.Text = "Ingrese Rut Deudor:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(145, 222);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(197, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(125, 182);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(123, 25);
            this.lbResultado.TabIndex = 20;
            this.lbResultado.Text = "CONSULTA";
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSide.Location = new System.Drawing.Point(11, 186);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(86, 20);
            this.lblSide.TabIndex = 21;
            this.lblSide.Text = "Resultado:";
            // 
            // MtxRutDeudor
            // 
            this.MtxRutDeudor.Location = new System.Drawing.Point(15, 104);
            this.MtxRutDeudor.Mask = "##.###.###-C";
            this.MtxRutDeudor.Name = "MtxRutDeudor";
            this.MtxRutDeudor.Size = new System.Drawing.Size(168, 20);
            this.MtxRutDeudor.TabIndex = 0;
            this.MtxRutDeudor.Leave += new System.EventHandler(this.MtxRutDeudor_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Selecione Tipo Documento:";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(12, 9);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(131, 25);
            this.lblOperacion.TabIndex = 23;
            this.lblOperacion.Text = "OPERACION";
            // 
            // lblAyudaPA
            // 
            this.lblAyudaPA.AutoSize = true;
            this.lblAyudaPA.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyudaPA.Location = new System.Drawing.Point(13, 259);
            this.lblAyudaPA.Name = "lblAyudaPA";
            this.lblAyudaPA.Size = new System.Drawing.Size(96, 20);
            this.lblAyudaPA.TabIndex = 24;
            this.lblAyudaPA.Text = "Ayuda Pagare:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 310);
            this.Controls.Add(this.lblAyudaPA);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MtxRutDeudor);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.cboxTDoc);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.txNroDoc);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRutDeudor);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Consulta Documento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxTDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.TextBox txNroDoc;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRutDeudor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.MaskedTextBox MtxRutDeudor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Label lblAyudaPA;
    }
}

