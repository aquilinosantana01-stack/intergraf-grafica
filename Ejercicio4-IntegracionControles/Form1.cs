namespace registro_de_cliente_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escriba el nombre del cliente.");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Escriba el teléfono del cliente.");
                txtTelefono.Focus();
                return;
            }

            if (!long.TryParse(txtTelefono.Text, out long telefono))
            {
                MessageBox.Show("El teléfono solamente debe contener números.");
                txtTelefono.Focus();
                return;
            }

            if (txtTelefono.Text.Length != 10)
            {
                MessageBox.Show("El teléfono debe contener 10 números.");
                txtTelefono.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Escriba el correo del cliente.");
                txtCorreo.Focus();
                return;
            }

            if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
            {
                MessageBox.Show("Escriba un correo válido.");
                txtCorreo.Focus();
                return;
            }

            string cliente = "Nombre: " + txtNombre.Text +
                             " | Teléfono: " + txtTelefono.Text +
                             " | Correo: " + txtCorreo.Text;

            lstClientes.Items.Add(cliente);

            MessageBox.Show("Cliente registrado correctamente.");

            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            txtNombre.Focus();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
