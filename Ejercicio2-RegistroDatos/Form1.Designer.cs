namespace Control_de_asistencia
{
    partial class frmAsistencia
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
            lblEstudiantes = new Label();
            lblResumen = new Label();
            lstEstudiantes = new ListBox();
            chkPresente = new CheckBox();
            btnRegistrar = new Button();
            btnGenerarResumen = new Button();
            txtResumen = new TextBox();
            SuspendLayout();
            // 
            // lblEstudiantes
            // 
            lblEstudiantes.AutoSize = true;
            lblEstudiantes.Location = new Point(91, 47);
            lblEstudiantes.Name = "lblEstudiantes";
            lblEstudiantes.Size = new Size(106, 25);
            lblEstudiantes.TabIndex = 0;
            lblEstudiantes.Text = "Estudiantes:";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(61, 121);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(193, 25);
            lblResumen.TabIndex = 1;
            lblResumen.Text = "Resumen de asistencia:";
            lblResumen.Click += lblResumen_Click;
            // 
            // lstEstudiantes
            // 
            lstEstudiantes.FormattingEnabled = true;
            lstEstudiantes.Items.AddRange(new object[] { "Carlos Manuel", "Ana Rodríguez", "José Martínez", "María González", "Luis Rosario", "Claudia Pérez" });
            lstEstudiantes.Location = new Point(272, 8);
            lstEstudiantes.Name = "lstEstudiantes";
            lstEstudiantes.Size = new Size(180, 129);
            lstEstudiantes.TabIndex = 2;
            // 
            // chkPresente
            // 
            chkPresente.AutoSize = true;
            chkPresente.Location = new Point(372, 203);
            chkPresente.Name = "chkPresente";
            chkPresente.Size = new Size(105, 29);
            chkPresente.TabIndex = 3;
            chkPresente.Text = "Presente";
            chkPresente.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(184, 293);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar asistencia";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnGenerarResumen
            // 
            btnGenerarResumen.Location = new Point(184, 370);
            btnGenerarResumen.Name = "btnGenerarResumen";
            btnGenerarResumen.Size = new Size(112, 34);
            btnGenerarResumen.TabIndex = 5;
            btnGenerarResumen.Text = "Generar resumen";
            btnGenerarResumen.UseVisualStyleBackColor = true;
            btnGenerarResumen.Click += btnGenerarResumen_Click;
            // 
            // txtResumen
            // 
            txtResumen.Location = new Point(503, 118);
            txtResumen.Multiline = true;
            txtResumen.Name = "txtResumen";
            txtResumen.ReadOnly = true;
            txtResumen.ScrollBars = ScrollBars.Vertical;
            txtResumen.Size = new Size(816, 315);
            txtResumen.TabIndex = 6;
            // 
            // frmAsistencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1627, 450);
            Controls.Add(txtResumen);
            Controls.Add(btnGenerarResumen);
            Controls.Add(btnRegistrar);
            Controls.Add(chkPresente);
            Controls.Add(lstEstudiantes);
            Controls.Add(lblResumen);
            Controls.Add(lblEstudiantes);
            Name = "frmAsistencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de asistencia";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstudiantes;
        private Label lblResumen;
        private ListBox lstEstudiantes;
        private CheckBox chkPresente;
        private Button btnRegistrar;
        private Button btnGenerarResumen;
        private TextBox txtResumen;
    }
}
