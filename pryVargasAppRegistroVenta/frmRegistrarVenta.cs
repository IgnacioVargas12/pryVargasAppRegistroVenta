namespace pryVargasAppRegistroVenta
{
    public partial class frmRegistrarVenta : Form
    {
        public frmRegistrarVenta()
        {
            InitializeComponent();
        }


        //Declaración de Struct
        public struct datoVentas 
        {
        public DateTime Fecha;
        public string Producto;
        public int Cantidad;
        public int Precio;
        }

        //Declaración de array principal
        public datoVentas[] vecDatos = new datoVentas [100];

        //Declaramos variables aqui para que sean globales en el formulario, tambien las inicializamos

        DateTime vFecha = DateTime.Now;
        string vProducto = "";
        int vCantidad = 0;
        int vPrecio = 0;
        int indice = 0;



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
            LimpiarControles();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //otorgamos valores a las variables y despues mostramos en lblRegistro

            vFecha = dtpFecha.Value;
            vProducto = lstProducto.Text;
            //convierte nudCantidad a un numero entero
            vCantidad = Convert.ToInt32 (nudCantidad.Value);
            //convierte mtbPrecioUnitario a un numero entero
            vPrecio = Convert.ToInt32(mtbPrecioUnitario.Text);

            //mostramos en la lbl resultado el pedido
            lblResultadoRegistro.Text += vFecha + " " + vProducto + " " + vCantidad + " " + vPrecio + '\n';

            //Grabamos datos en el array
            vecDatos[indice].Fecha = vFecha;
            vecDatos[indice].Cantidad = vCantidad;
            vecDatos[indice].Producto = vProducto;
            vecDatos[indice].Precio = vPrecio;
            indice++;

            //limpiamos los controles
            LimpiarControles();

        }

        private void frmRegistrarVenta_Load(object sender, EventArgs e)
        {
            //Load indica que ocurre antes que se muestre el formulario
            //este evento agrega nuevos items a lstProducto
            lstProducto.Items.Add("Gabinete");
            lstProducto.Items.Add("CPU");
            lstProducto.Items.Add("RAM");
        }
        private void LimpiarControles ()
        {
            dtpFecha.Value = DateTime.Now;

            lstProducto.Text = "";
            lstProducto.SelectedIndex = -1;

            nudCantidad.Value = 0;

            mtbPrecioUnitario.Text = "";

        }
    }
}
