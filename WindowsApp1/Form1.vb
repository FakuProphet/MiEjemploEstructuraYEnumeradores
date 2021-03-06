﻿
'Ejemplo de chino

'compra y venta vehiculos
Public Enum Elemento As Byte
    auto = 1
    moto = 2
End Enum

Enum Consulta As Byte
    venta = 1
    compra = 2
End Enum


Structure Servicio
    Public elementoID As Byte 'guardo el valor numerico del id
    Public consultaID As Byte
    Public persona As String
    Public telefono As String
    Public fecha As String
    Public hora As String
End Structure


Public Class Form1


    Private elementoSeleccionado As Elemento
    Private consultaSeleccionada As Consulta
    Public _Archivo
    Dim miVector(4) As Servicio
    '   Dim posicion As Integer
    Dim bandera As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fechaYHora()
        CrearArchivo()
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

    Public Sub CrearArchivo()
        Dim NUMERO As Integer = 0
        _Archivo = "Rodado.txt"
        NUMERO = FreeFile()
        FileOpen(NUMERO, _Archivo, OpenMode.Append)
        FileClose(NUMERO)
    End Sub

    Private Sub Grabar(ByVal servicio As Servicio)
        Dim NUMERO As Integer = 0
        NUMERO = FreeFile()
        FileOpen(NUMERO, _Archivo, OpenMode.Append)
        WriteLine(NUMERO, servicio.consultaID, servicio.elementoID, servicio.persona, servicio.fecha, servicio.hora, servicio.telefono)
        FileClose(NUMERO)
    End Sub


    Private Sub fechaYHora()
        txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
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
        If contador >= 0 Then
            btnConsultar.Enabled = True
        Else
            btnConsultar.Enabled = False
        End If
    End Sub


    'inicializar en uno o cero es igual
    Private contador As Integer
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        'a modo de prueba, mostramos en las labels, los valores que se estan guardando
        'ejemplo consultaSeleccionada.ToString nos devuelve la cadena que haya sido seleccionada(auto,moto)
        'sin ToString, nos devuelve el valor numerico asignado.
        lblOperacion.Text = consultaSeleccionada
        lblVehiculo.Text = elementoSeleccionado
        lblContador.Text = contador

        'declaras una variable u objeto del tipo servicio
        Dim miServicio As Servicio


        If validar() Then
            If contador <= 4 Then

                'COMO SE SOLICITA GUARDAR LA ID O VALOR NUMERICO 
                'EN EL ENUMERADOR, GUARDAMOS EN LA ESTRUCTURA miServicio, EN LOS MIEMBROS
                'consultaID y elementoID EL VALOR ASIGNADO

                miServicio.consultaID = consultaSeleccionada
                miServicio.elementoID = elementoSeleccionado
                miServicio.persona = txtClienteNombre.Text
                miServicio.fecha = txtFecha.Text
                miServicio.hora = txtHora.Text
                miServicio.telefono = txtTeleContacto.Text



                cargarVector(miServicio, contador)
                Grabar(miServicio)
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

    'SOLO GUARDA LO Q CONTENGA EL VECTOR EN MEMORIA
    Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click
        ListBox1.Items.Clear()

        For Each item As Servicio In miVector
            If item.persona IsNot Nothing Then
                ListBox1.Items.Add(item.persona.ToUpper)
            End If
        Next
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        lblContador.Text = "Hola mundo..."
    End Sub
End Class





