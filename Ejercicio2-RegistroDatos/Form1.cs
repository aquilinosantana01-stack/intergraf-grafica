namespace Control_de_asistencia
{
    public partial class frmAsistencia : Form
    {
        private List<string> presentes = new List<string>();
        private List<string> ausentes = new List<string>();

        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            
                if (lstEstudiantes.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Selecciona un estudiante.",
                        "Estudiante no seleccionado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string estudiante = lstEstudiantes.SelectedItem.ToString();

                presentes.Remove(estudiante);
                ausentes.Remove(estudiante);

                if (chkPresente.Checked)
                {
                    presentes.Add(estudiante);

                    MessageBox.Show(
                        estudiante + " fue registrado como presente.",
                        "Asistencia registrada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    ausentes.Add(estudiante);

                    MessageBox.Show(
                        estudiante + " fue registrado como ausente.",
                        "Asistencia registrada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                chkPresente.Checked = false;
                lstEstudiantes.ClearSelected();
            }
        

        private void lblResumen_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarResumen_Click(object sender, EventArgs e)
        {
            
        
            txtResumen.Clear();

            txtResumen.AppendText("ESTUDIANTES PRESENTES");
            txtResumen.AppendText(Environment.NewLine);
            txtResumen.AppendText("-----------------------------");
            txtResumen.AppendText(Environment.NewLine);

            if (presentes.Count == 0)
            {
                txtResumen.AppendText("Ningún estudiante.");
                txtResumen.AppendText(Environment.NewLine);
            }
            else
            {
                foreach (string estudiante in presentes)
                {
                    txtResumen.AppendText("• " + estudiante);
                    txtResumen.AppendText(Environment.NewLine);
                }
            }

            txtResumen.AppendText(Environment.NewLine);
            txtResumen.AppendText("ESTUDIANTES AUSENTES");
            txtResumen.AppendText(Environment.NewLine);
            txtResumen.AppendText("-----------------------------");
            txtResumen.AppendText(Environment.NewLine);

            if (ausentes.Count == 0)
            {
                txtResumen.AppendText("Ningún estudiante.");
                txtResumen.AppendText(Environment.NewLine);
            }
            else
            {
                foreach (string estudiante in ausentes)
                {
                    txtResumen.AppendText("• " + estudiante);
                    txtResumen.AppendText(Environment.NewLine);
                }
            }

            txtResumen.AppendText(Environment.NewLine);
            txtResumen.AppendText(
                $"Total presentes: {presentes.Count}");

            txtResumen.AppendText(Environment.NewLine);

            txtResumen.AppendText(
                $"Total ausentes: {ausentes.Count}");
        }
    }
    }

