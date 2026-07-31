Public Class frmConversor

    Private Sub frmConversor_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        cboConversion.Items.Clear()
        cboConversion.Items.Add("Kilómetros a millas")
        cboConversion.Items.Add("Millas a kilómetros")
        cboConversion.Items.Add("Celsius a Fahrenheit")
        cboConversion.Items.Add("Fahrenheit a Celsius")

        cboConversion.DropDownStyle =
            ComboBoxStyle.DropDownList

        lblResultado.Text = "Resultado:"
        txtValor.Focus()

    End Sub

    Private Sub btnConvertir_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnConvertir.Click

        Dim valor As Double
        Dim resultado As Double

        'Validar el número introducido
        If Not Double.TryParse(txtValor.Text, valor) Then

            MessageBox.Show(
                "Introduzca un número válido.",
                "Dato incorrecto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtValor.Focus()
            Exit Sub

        End If

        'Validar el tipo de conversión
        If cboConversion.SelectedIndex = -1 Then

            MessageBox.Show(
                "Seleccione un tipo de conversión.",
                "Falta seleccionar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            cboConversion.Focus()
            Exit Sub

        End If

        'Realizar la conversión seleccionada
        Select Case cboConversion.SelectedIndex

            Case 0
                'Kilómetros a millas
                resultado = valor * 0.621371

                lblResultado.Text =
                    "Resultado: " &
                    resultado.ToString("0.00") &
                    " millas"

            Case 1
                'Millas a kilómetros
                resultado = valor * 1.60934

                lblResultado.Text =
                    "Resultado: " &
                    resultado.ToString("0.00") &
                    " kilómetros"

            Case 2
                'Celsius a Fahrenheit
                resultado = (valor * 9 / 5) + 32

                lblResultado.Text =
                    "Resultado: " &
                    resultado.ToString("0.00") &
                    " °F"

            Case 3
                'Fahrenheit a Celsius
                resultado = (valor - 32) * 5 / 9

                lblResultado.Text =
                    "Resultado: " &
                    resultado.ToString("0.00") &
                    " °C"

        End Select

    End Sub

    Private Sub btnLimpiar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLimpiar.Click

        txtValor.Clear()
        cboConversion.SelectedIndex = -1
        lblResultado.Text = "Resultado:"
        txtValor.Focus()

    End Sub

    Private Sub btnSalir_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSalir.Click

        Dim respuesta As DialogResult

        respuesta = MessageBox.Show(
            "¿Desea cerrar el programa?",
            "Confirmar salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

End Class