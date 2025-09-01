namespace pryVargasAppRegistroVenta
{
    public partial class frmRegistrarVenta : Form
    {
        public frmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void lstProducto_TextChanged(object sender, EventArgs e)
        { //este procedimiento valida que primero se elija un producto para habilitar el NumericalUpDown
            if (lstProducto.Text != "")
            {
                nudCantidad.Enabled = true;
            }
            else
            {
                nudCantidad.Enabled = false;
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        { //este procedimiento valida que primero NumericalUpDown tenga un valor para habilitar al MaskTextBox
            if (nudCantidad.Value > 0)
            {
                mtbPrecioUnitario.Enabled = true;
            }
            else
            {
                mtbPrecioUnitario.Enabled = false;
            }
        }

        private void mtbPrecioUnitario_TextChanged(object sender, EventArgs e)
        { //este procedimiento valida que primero se escriba un precio antes de habilitar el boton registrar
            if (mtbPrecioUnitario.Text.Any(char.IsDigit))
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        { //este procedimiento limpia todos elementos de la interfaz grafica
            dtpFecha.Value = DateTime.Now;

            lstProducto.Text = "";
            lstProducto.SelectedIndex = -1;

            nudCantidad.Value = 0;

            mtbPrecioUnitario.Text = "";
        }
    }
}
