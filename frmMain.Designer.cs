namespace pryArmaniniSp2Ejer1
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mrcTipo = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lblTipos = new System.Windows.Forms.Label();
            this.mrcAdicionales = new System.Windows.Forms.GroupBox();
            this.chkTele = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.mrcPagos = new System.Windows.Forms.GroupBox();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.cmbTarjetas = new System.Windows.Forms.ComboBox();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.mrcTitular = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mrcTipo.SuspendLayout();
            this.mrcAdicionales.SuspendLayout();
            this.mrcPagos.SuspendLayout();
            this.mrcTitular.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcTipo
            // 
            this.mrcTipo.Controls.Add(this.txtDias);
            this.mrcTipo.Controls.Add(this.cmbPersonas);
            this.mrcTipo.Controls.Add(this.cmbTipos);
            this.mrcTipo.Controls.Add(this.lblDias);
            this.mrcTipo.Controls.Add(this.lblPersonas);
            this.mrcTipo.Controls.Add(this.lblTipos);
            this.mrcTipo.Location = new System.Drawing.Point(40, 30);
            this.mrcTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcTipo.Name = "mrcTipo";
            this.mrcTipo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcTipo.Size = new System.Drawing.Size(731, 95);
            this.mrcTipo.TabIndex = 0;
            this.mrcTipo.TabStop = false;
            this.mrcTipo.Text = "Tipo de Cabania";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(520, 39);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(119, 22);
            this.txtDias.TabIndex = 4;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbPersonas.Location = new System.Drawing.Point(309, 39);
            this.cmbPersonas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(100, 24);
            this.cmbPersonas.TabIndex = 3;
            this.cmbPersonas.SelectedIndexChanged += new System.EventHandler(this.cmbPersonas_SelectedIndexChanged);
            // 
            // cmbTipos
            // 
            this.cmbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbTipos.Location = new System.Drawing.Point(88, 36);
            this.cmbTipos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(100, 24);
            this.cmbTipos.TabIndex = 3;
            this.cmbTipos.SelectedIndexChanged += new System.EventHandler(this.cmbTipos_SelectedIndexChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(475, 43);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(35, 16);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Dias";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(233, 43);
            this.lblPersonas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(65, 16);
            this.lblPersonas.TabIndex = 1;
            this.lblPersonas.Text = "Personas";
            // 
            // lblTipos
            // 
            this.lblTipos.AutoSize = true;
            this.lblTipos.Location = new System.Drawing.Point(36, 39);
            this.lblTipos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(42, 16);
            this.lblTipos.TabIndex = 0;
            this.lblTipos.Text = "Tipos";
            this.lblTipos.Click += new System.EventHandler(this.label1_Click);
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Controls.Add(this.chkTele);
            this.mrcAdicionales.Controls.Add(this.chkHeladera);
            this.mrcAdicionales.Controls.Add(this.chkCocina);
            this.mrcAdicionales.Enabled = false;
            this.mrcAdicionales.Location = new System.Drawing.Point(36, 132);
            this.mrcAdicionales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcAdicionales.Size = new System.Drawing.Size(213, 145);
            this.mrcAdicionales.TabIndex = 1;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Adicionales";
            // 
            // chkTele
            // 
            this.chkTele.AutoSize = true;
            this.chkTele.Location = new System.Drawing.Point(44, 91);
            this.chkTele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTele.Name = "chkTele";
            this.chkTele.Size = new System.Drawing.Size(92, 20);
            this.chkTele.TabIndex = 0;
            this.chkTele.Text = "Television";
            this.chkTele.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(44, 63);
            this.chkHeladera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(86, 20);
            this.chkHeladera.TabIndex = 0;
            this.chkHeladera.Text = "Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(44, 34);
            this.chkCocina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(71, 20);
            this.chkCocina.TabIndex = 0;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // mrcPagos
            // 
            this.mrcPagos.Controls.Add(this.optTarjeta);
            this.mrcPagos.Controls.Add(this.optEfectivo);
            this.mrcPagos.Controls.Add(this.cmbTarjetas);
            this.mrcPagos.Controls.Add(this.lblTarjetas);
            this.mrcPagos.Enabled = false;
            this.mrcPagos.Location = new System.Drawing.Point(277, 132);
            this.mrcPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcPagos.Name = "mrcPagos";
            this.mrcPagos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcPagos.Size = new System.Drawing.Size(493, 145);
            this.mrcPagos.TabIndex = 1;
            this.mrcPagos.TabStop = false;
            this.mrcPagos.Text = "Forma de Pago";
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(220, 43);
            this.optTarjeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(71, 20);
            this.optTarjeta.TabIndex = 0;
            this.optTarjeta.TabStop = true;
            this.optTarjeta.Text = "Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            this.optTarjeta.CheckedChanged += new System.EventHandler(this.optTarjeta_CheckedChanged);
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Location = new System.Drawing.Point(47, 43);
            this.optEfectivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(76, 20);
            this.optEfectivo.TabIndex = 0;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.optEfectivo_CheckedChanged);
            // 
            // cmbTarjetas
            // 
            this.cmbTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarjetas.Enabled = false;
            this.cmbTarjetas.FormattingEnabled = true;
            this.cmbTarjetas.Items.AddRange(new object[] {
            "Card Red",
            "Card Green",
            "Card Blue"});
            this.cmbTarjetas.Location = new System.Drawing.Point(47, 111);
            this.cmbTarjetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTarjetas.Name = "cmbTarjetas";
            this.cmbTarjetas.Size = new System.Drawing.Size(355, 24);
            this.cmbTarjetas.TabIndex = 3;
            this.cmbTarjetas.SelectedIndexChanged += new System.EventHandler(this.cmbTarjetas_SelectedIndexChanged);
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(43, 91);
            this.lblTarjetas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(57, 16);
            this.lblTarjetas.TabIndex = 0;
            this.lblTarjetas.Text = "Tarjetas";
            this.lblTarjetas.Click += new System.EventHandler(this.label1_Click);
            // 
            // mrcTitular
            // 
            this.mrcTitular.Controls.Add(this.txtTelefono);
            this.mrcTitular.Controls.Add(this.txtNombre);
            this.mrcTitular.Controls.Add(this.lblTelefono);
            this.mrcTitular.Controls.Add(this.lblNombre);
            this.mrcTitular.Enabled = false;
            this.mrcTitular.Location = new System.Drawing.Point(36, 284);
            this.mrcTitular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcTitular.Name = "mrcTitular";
            this.mrcTitular.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcTitular.Size = new System.Drawing.Size(735, 145);
            this.mrcTitular.TabIndex = 1;
            this.mrcTitular.TabStop = false;
            this.mrcTitular.Text = "Titular de la Reserva";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(143, 81);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(541, 22);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 43);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(541, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(40, 85);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 16);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Telefonos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 47);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(672, 442);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 32);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 489);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mrcTitular);
            this.Controls.Add(this.mrcPagos);
            this.Controls.Add(this.mrcAdicionales);
            this.Controls.Add(this.mrcTipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de Cabanias";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mrcTipo.ResumeLayout(false);
            this.mrcTipo.PerformLayout();
            this.mrcAdicionales.ResumeLayout(false);
            this.mrcAdicionales.PerformLayout();
            this.mrcPagos.ResumeLayout(false);
            this.mrcPagos.PerformLayout();
            this.mrcTitular.ResumeLayout(false);
            this.mrcTitular.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTipo;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.ComboBox cmbPersonas;
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label lblTipos;
        private System.Windows.Forms.GroupBox mrcAdicionales;
        private System.Windows.Forms.CheckBox chkTele;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.GroupBox mrcPagos;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.GroupBox mrcTitular;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbTarjetas;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
    }
}

