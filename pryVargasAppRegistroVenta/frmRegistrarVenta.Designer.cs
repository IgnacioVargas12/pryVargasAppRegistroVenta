namespace pryVargasAppRegistroVenta
{
    partial class frmRegistrarVenta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarVenta));
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            dtpFecha = new DateTimePicker();
            lstProducto = new ComboBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            nudCantidad = new NumericUpDown();
            mtbPrecioUnitario = new MaskedTextBox();
            lblResultadoRegistro = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F);
            lblFecha.Location = new Point(11, 14);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 21);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 12F);
            lblProducto.Location = new Point(11, 62);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(73, 21);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F);
            lblCantidad.Location = new Point(11, 121);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 21);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI", 12F);
            lblPrecioUnitario.Location = new Point(11, 170);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(111, 21);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio unitario";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(128, 14);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 29);
            dtpFecha.TabIndex = 6;
            // 
            // lstProducto
            // 
            lstProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            lstProducto.Font = new Font("Segoe UI", 12F);
            lstProducto.FormattingEnabled = true;
            lstProducto.Location = new Point(128, 62);
            lstProducto.Name = "lstProducto";
            lstProducto.Size = new Size(200, 29);
            lstProducto.TabIndex = 7;
            lstProducto.TextChanged += lstProducto_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Font = new Font("Segoe UI", 12F);
            btnRegistrar.Location = new Point(318, 303);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(82, 30);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(219, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 30);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Font = new Font("Segoe UI", 12F);
            nudCantidad.Location = new Point(128, 121);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(50, 29);
            nudCantidad.TabIndex = 10;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Enabled = false;
            mtbPrecioUnitario.Font = new Font("Segoe UI", 12F);
            mtbPrecioUnitario.Location = new Point(128, 170);
            mtbPrecioUnitario.Mask = "00000000";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(100, 29);
            mtbPrecioUnitario.TabIndex = 11;
            mtbPrecioUnitario.TextChanged += mtbPrecioUnitario_TextChanged;
            // 
            // lblResultadoRegistro
            // 
            lblResultadoRegistro.AutoSize = true;
            lblResultadoRegistro.BorderStyle = BorderStyle.Fixed3D;
            lblResultadoRegistro.Font = new Font("Segoe UI", 12F);
            lblResultadoRegistro.Location = new Point(11, 223);
            lblResultadoRegistro.Name = "lblResultadoRegistro";
            lblResultadoRegistro.Size = new Size(30, 23);
            lblResultadoRegistro.TabIndex = 12;
            lblResultadoRegistro.Text = "---";
            // 
            // frmRegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 345);
            Controls.Add(lblResultadoRegistro);
            Controls.Add(mtbPrecioUnitario);
            Controls.Add(nudCantidad);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(lstProducto);
            Controls.Add(dtpFecha);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegistrarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar venta";
            Load += frmRegistrarVenta_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private DateTimePicker dtpFecha;
        private ComboBox lstProducto;
        private Button btnRegistrar;
        private Button btnCancelar;
        private NumericUpDown nudCantidad;
        private MaskedTextBox mtbPrecioUnitario;
        private Label lblResultadoRegistro;
    }
}
