namespace menu_del_colmado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Escriba una cantidad válida.");
                txtCantidad.Focus();
                return;
            }

            if (!rdbEfectivo.Checked && !rdbTarjeta.Checked)
            {
                MessageBox.Show("Seleccione una forma de pago.");
                return;
            }

            double precio = 0;

            switch (cmbProducto.SelectedIndex)
            {
                case 0:
                    precio = 40;
                    break;

                case 1:
                    precio = 150;
                    break;

                case 2:
                    precio = 75;
                    break;

                case 3:
                    precio = 10;
                    break;

                case 4:
                    precio = 12;
                    break;

                case 5:
                    precio = 60;
                    break;
            }

            double total = precio * cantidad;
            string formaPago;

            if (rdbEfectivo.Checked)
            {
                formaPago = "Efectivo";
            }
            else
            {
                formaPago = "Tarjeta";
            }

            lblTotal.Text = "Total: RD$" + total.ToString("N2") +
                            " | Pago: " + formaPago;
        }
    }
}
