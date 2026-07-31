<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConversor

    Inherits System.Windows.Forms.Form

    'El formulario elimina los componentes cuando se cierra.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)

        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

        Finally
            MyBase.Dispose(disposing)
        End Try

    End Sub

    'Componentes utilizados por el diseñador.
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        lblTitulo = New Label()
        lblValor = New Label()
        txtValor = New TextBox()
        lblTipoConversion = New Label()
        cboConversion = New ComboBox()
        lblResultado = New Label()
        btnConvertir = New Button()
        btnLimpiar = New Button()
        btnSalir = New Button()

        SuspendLayout()

        '
        ' lblTitulo
        '
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font(
            "Segoe UI",
            16.0F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            CByte(0)
        )
        lblTitulo.ForeColor = Color.MidnightBlue
        lblTitulo.Location = New Point(180, 30)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(434, 45)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "CONVERSOR DE UNIDADES"

        '
        ' lblValor
        '
        lblValor.AutoSize = True
        lblValor.Font = New Font(
            "Segoe UI",
            10.0F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            CByte(0)
        )
        lblValor.Location = New Point(80, 120)
        lblValor.Name = "lblValor"
        lblValor.Size = New Size(194, 28)
        lblValor.TabIndex = 1
        lblValor.Text = "Introduzca el valor:"

        '
        ' txtValor
        '
        txtValor.Font = New Font(
            "Segoe UI",
            11.0F,
            FontStyle.Regular,
            GraphicsUnit.Point,
            CByte(0)
        )
        txtValor.Location = New Point(320, 115)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(330, 37)
        txtValor.TabIndex = 2

        '
        ' lblTipoConversion
        '
        lblTipoConversion.AutoSize = True
        lblTipoConversion.Font = New Font(
            "Segoe UI",
            10.0F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            CByte(0)
        )
        lblTipoConversion.Location = New Point(80, 190)
        lblTipoConversion.Name = "lblTipoConversion"
        lblTipoConversion.Size = New Size(190, 28)
        lblTipoConversion.TabIndex = 3
        lblTipoConversion.Text = "Tipo de conversión:"

        '
        ' cboConversion
        '
        cboConversion.DropDownStyle = ComboBoxStyle.DropDownList
        cboConversion.Font = New Font(
            "Segoe UI",
            10.0F,
            FontStyle.Regular,
            GraphicsUnit.Point,
            CByte(0)
        )
        cboConversion.FormattingEnabled = True
        cboConversion.Items.AddRange(
            New Object() {
                "Kilómetros a millas",
                "Millas a kilómetros",
                "Celsius a Fahrenheit",
                "Fahrenheit a Celsius"
            }
        )
        cboConversion.Location = New Point(320, 185)
        cboConversion.Name = "cboConversion"
        cboConversion.Size = New Size(330, 36)
        cboConversion.TabIndex = 4

        '
        ' lblResultado
        '
        lblResultado.BackColor = Color.AliceBlue
        lblResultado.BorderStyle = BorderStyle.FixedSingle
        lblResultado.Font = New Font(
            "Segoe UI",
            12.0F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            CByte(0)
        )
        lblResultado.ForeColor = Color.MidnightBlue
        lblResultado.Location = New Point(80, 260)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(570, 70)
        lblResultado.TabIndex = 5
        lblResultado.Text = "Resultado:"
        lblResultado.TextAlign = ContentAlignment.MiddleCenter

        '
        ' btnConvertir
        '
        btnConvertir.BackColor = Color.RoyalBlue
        btnConvertir.FlatStyle = FlatStyle.Flat
        btnConvertir.Font = New Font(
            "Segoe UI",
            10.0F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            CByte(0)
        )
        btnConvertir.ForeColor = Color.White
        btnConvertir.Location = New Point(80, 370)
        btnConvertir.Name = "btnConvertir"
        btnConvertir.Size = New Size(170, 55)
        btnConvertir.TabIndex = 6
        btnConvertir.Text = "Convertir"
        btnConvertir.UseVisualStyleBackColor = False

        '
        ' btnLimpiar
        '
        btnLimpiar.BackColor = Color.LightGray
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.Font = New Font(
            "Segoe UI",
            10.0F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            CByte(0)
        )
        btnLimpiar.ForeColor = Color.Black
        btnLimpiar.Location = New Point(280, 370)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(170, 55)
        btnLimpiar.TabIndex = 7
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False

        '
        ' btnSalir
        '
        btnSalir.BackColor = Color.Crimson
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font(
            "Segoe UI",
            10.0F,
            FontStyle.Bold,
            GraphicsUnit.Point,
            CByte(0)
        )
        btnSalir.ForeColor = Color.White
        btnSalir.Location = New Point(480, 370)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(170, 55)
        btnSalir.TabIndex = 8
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False

        '
        ' frmConversor
        '
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(740, 480)

        Controls.Add(btnSalir)
        Controls.Add(btnLimpiar)
        Controls.Add(btnConvertir)
        Controls.Add(lblResultado)
        Controls.Add(cboConversion)
        Controls.Add(lblTipoConversion)
        Controls.Add(txtValor)
        Controls.Add(lblValor)
        Controls.Add(lblTitulo)

        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmConversor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Conversor de unidades"

        ResumeLayout(False)
        PerformLayout()

    End Sub


    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblTipoConversion As Label
    Friend WithEvents cboConversion As ComboBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnConvertir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button

End Class
