namespace pryVargasAppRegistroVenta
{
    partial class RegistrarVenta
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
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            txtCantidad = new TextBox();
            txtPrecioUnitario = new TextBox();
            dtpFecha = new DateTimePicker();
            lstProducto = new ComboBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F);
            lblFecha.Location = new Point(69, 47);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 21);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 12F);
            lblProducto.Location = new Point(69, 95);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(73, 21);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F);
            lblCantidad.Location = new Point(69, 154);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 21);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI", 12F);
            lblPrecioUnitario.Location = new Point(69, 203);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(111, 21);
            lblPrecioUnitario.TabIndex = 3;
            lblPrecioUnitario.Text = "Precio unitario";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 12F);
            txtCantidad.Location = new Point(147, 154);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(76, 29);
            txtCantidad.TabIndex = 4;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Font = new Font("Segoe UI", 12F);
            txtPrecioUnitario.Location = new Point(186, 203);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(92, 29);
            txtPrecioUnitario.TabIndex = 5;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Location = new Point(125, 47);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 29);
            dtpFecha.TabIndex = 6;
            // 
            // lstProducto
            // 
            lstProducto.Font = new Font("Segoe UI", 12F);
            lstProducto.FormattingEnabled = true;
            lstProducto.Location = new Point(148, 95);
            lstProducto.Name = "lstProducto";
            lstProducto.Size = new Size(130, 29);
            lstProducto.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 12F);
            btnRegistrar.Location = new Point(420, 219);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(83, 30);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // RegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 316);
            Controls.Add(btnRegistrar);
            Controls.Add(lstProducto);
            Controls.Add(dtpFecha);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtCantidad);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Name = "RegistrarVenta";
            Text = "Registrar venta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private TextBox txtCantidad;
        private TextBox txtPrecioUnitario;
        private DateTimePicker dtpFecha;
        private ComboBox lstProducto;
        private Button btnRegistrar;
    }
}
