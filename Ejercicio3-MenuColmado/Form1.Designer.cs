namespace menu_del_colmado
{
    partial class Form1
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
            cmbProducto = new ComboBox();
            txtCantidad = new TextBox();
            rdbEfectivo = new RadioButton();
            btnCalcular = new Button();
            lblTotal = new Label();
            rdbTarjeta = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Items.AddRange(new object[] { "Arroz - RD$40", "Aceite - RD$150", "Leche - RD$75", "Pan - RD$10", "Huevos - RD$12", "Refresco - RD$60" });
            cmbProducto.Location = new Point(209, 137);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(182, 33);
            cmbProducto.TabIndex = 0;
            cmbProducto.SelectedIndexChanged += cmbproducto_SelectedIndexChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(209, 208);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(150, 31);
            txtCantidad.TabIndex = 1;
            // 
            // rdbEfectivo
            // 
            rdbEfectivo.AutoSize = true;
            rdbEfectivo.Location = new Point(89, 383);
            rdbEfectivo.Name = "rdbEfectivo";
            rdbEfectivo.Size = new Size(99, 29);
            rdbEfectivo.TabIndex = 2;
            rdbEfectivo.TabStop = true;
            rdbEfectivo.Text = "Efectivo";
            rdbEfectivo.UseVisualStyleBackColor = true;
            rdbEfectivo.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(839, 361);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(554, 359);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(126, 25);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: RD$0.00";
            // 
            // rdbTarjeta
            // 
            rdbTarjeta.AutoSize = true;
            rdbTarjeta.Location = new Point(229, 383);
            rdbTarjeta.Name = "rdbTarjeta";
            rdbTarjeta.Size = new Size(87, 29);
            rdbTarjeta.TabIndex = 5;
            rdbTarjeta.TabStop = true;
            rdbTarjeta.Text = "Tarjeta";
            rdbTarjeta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(390, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 6;
            label1.Text = "MENÚ DEL COLMADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 137);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 7;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 210);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 8;
            label3.Text = "cantidad";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 309);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 9;
            label4.Text = "forma de pago";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rdbTarjeta);
            Controls.Add(lblTotal);
            Controls.Add(btnCalcular);
            Controls.Add(rdbEfectivo);
            Controls.Add(txtCantidad);
            Controls.Add(cmbProducto);
            Name = "Form1";
            Text = "menu de colmado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProducto;
        private TextBox txtCantidad;
        private RadioButton rdbEfectivo;
        private Button btnCalcular;
        private Label lblTotal;
        private RadioButton rdbTarjeta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
