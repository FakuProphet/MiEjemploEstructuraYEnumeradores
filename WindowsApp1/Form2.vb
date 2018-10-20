Public Class Form2

    Public miNuevoVector(4) As Integer


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo()
    End Sub

    'Metodo cargar comboBox con los elementos de la clase
    Private Sub cargarCombo()
        cboConsultas.Items.Add(Consulta.compra)
        cboConsultas.Items.Add(Consulta.venta)
        'Para que no pueda editarse el contenido del combo.
        cboConsultas.DropDownStyle = ComboBoxStyle.DropDownList
        cboConsultas.SelectedIndex = 1
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        Dim seleccion As Consulta = cboConsultas.SelectedItem


        If seleccion = Consulta.compra Then
            MessageBox.Show("la cantidad de COMPRAS realizadas es " + miNuevoVector(0).ToString)
        End If

        If seleccion = Consulta.venta Then
            MessageBox.Show("la cantidad de VENTAS realizadas es " + miNuevoVector(1).ToString)
        End If

    End Sub
End Class