



Public Enum Elemento As Byte
    auto = 1
    moto = 2
End Enum

Enum Consulta As Byte
    venta = 1
    compra = 2
End Enum

Structure Servicio
    Public elementoID As Elemento
    Public consultaID As Consulta
    Public persona As String
    Public telefono As String
    Public fecha As String
    Public hora As String
End Structure


Public Class Form1

    Private elementoSeleccionado As Elemento
    Private consultaSeleccionada As Consulta
    Dim miVector(4) As Servicio
    Dim posicion As Integer
    Dim bandera As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fechaYHora()
    End Sub


    Private Sub setElemento(ByVal e As Elemento)
        Select Case e
            Case Elemento.auto
                elementoSeleccionado = Elemento.auto
            Case Elemento.moto
                elementoSeleccionado = Elemento.moto
        End Select
    End Sub

    Private Sub setConsulta(ByVal c As Consulta)
        Select Case c
            Case Consulta.compra
                consultaSeleccionada = Consulta.compra
            Case Consulta.venta
                consultaSeleccionada = Consulta.venta
        End Select
    End Sub

    Private Sub fechaYHora()
        txtFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtHora.Text = DateTime.Now.ToShortTimeString()
    End Sub


    Private Sub cargarVector(ByVal servicio As Servicio, ByVal posicion As Integer)
        For Each item As Servicio In miVector
            miVector(posicion) = servicio
        Next
    End Sub

    Private Function validar()

        Dim bandera As Boolean = True
        If String.IsNullOrEmpty(txtClienteNombre.Text) Then
            MessageBox.Show("Campo nombre vacio.", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bandera = False
        End If

        If String.IsNullOrEmpty(txtTeleContacto.Text) Then
            MessageBox.Show("Campo telefono vacio.", "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bandera = False
        End If

        Return bandera
    End Function

    Private Sub habilitarBotonConcultar()
        If contador > 0 Then
            btnConsultar.Enabled = True
        Else
            btnConsultar.Enabled = False
        End If
    End Sub



    Private contador As Integer
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        lblOperacion.Text = consultaSeleccionada
        lblVehiculo.Text = elementoSeleccionado

        Dim miServicio As Servicio


        If validar() Then
            If contador <= 4 Then


                miServicio.consultaID = consultaSeleccionada
                miServicio.elementoID = elementoSeleccionado
                miServicio.persona = txtClienteNombre.Text
                miServicio.fecha = txtFechaHora.Text
                miServicio.telefono = txtTeleContacto.Text



                cargarVector(miServicio, contador)

                'solo para emitir un mensaje con los datos del vector q no sean nulos.
                'For Each item As Servicio In miVector
                '    If Not String.IsNullOrEmpty(item.persona) Then
                '        MessageBox.Show(item.persona)
                '    End If
                'Next


            Else
                MessageBox.Show("El vector se completo.")
            End If
            contador = contador + 1
            habilitarBotonConcultar()
        End If

    End Sub

    Private Sub rbtMotocicleta_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMotocicleta.CheckedChanged
        setElemento(Elemento.moto)
    End Sub

    Private Sub rbtAutomovil_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAutomovil.CheckedChanged
        setElemento(Elemento.auto)
    End Sub

    Private Sub rbtVenta_CheckedChanged(sender As Object, e As EventArgs) Handles rbtVenta.CheckedChanged
        setConsulta(Consulta.venta)
    End Sub

    Private Sub rbtCompra_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCompra.CheckedChanged
        setConsulta(Consulta.compra)
    End Sub

    'contador 
    Private Function CantidadOperaciones()
        Dim salida(1) As Integer
        For Each item As Servicio In miVector
            If item.consultaID = Consulta.compra Then
                salida(0) = salida(0) + 1
            End If
            If item.consultaID = Consulta.venta Then
                salida(1) = salida(1) + 1
            End If
        Next
        Return salida
    End Function


    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim instancia As New Form2
        instancia.miNuevoVector = CantidadOperaciones()
        instancia.ShowDialog()
    End Sub
End Class





