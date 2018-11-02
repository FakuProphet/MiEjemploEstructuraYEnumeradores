Imports System.IO





Public Class Form2


    Dim miCon As New Conexion
    Public miNuevoVector(1) As Integer
    Private vServicios(20) As Servicio
    Private _ruta As String = "C:\Users\Prophet\Desktop\clon ejercicio visual studio\MiEjemploEstructuraYEnumeradores\WindowsApp1\bin\Debug\Rodado.txt"
    'Conexion miConexion As Conexion

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo()
    End Sub

    'Metodo cargar comboBox con los elementos de la clase o 
    Private Sub cargarCombo()
        cboConsultas.Items.Add(Consulta.compra)
        cboConsultas.Items.Add(Consulta.venta)
        'Para que no pueda editarse el contenido del combo.
        cboConsultas.DropDownStyle = ComboBoxStyle.DropDownList
        cboConsultas.SelectedIndex = 1
    End Sub

    Private Sub cargarVector(ByVal servicio As Servicio, ByVal posicion As Integer)
        For Each item As Servicio In vServicios
            vServicios(posicion) = servicio
        Next
    End Sub


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        Dim seleccion As Consulta = cboConsultas.SelectedItem

        'Filtrar por seleccion del comboBox
        If seleccion = Consulta.compra Then
            'MUESTRA POR MESSAGE BOX EL RESULTADO DEL CONTEO, DEL CONTENIDO DEL ARREGLO EN MEMORIA
            'MessageBox.Show("la cantidad de COMPRAS realizadas es " + miNuevoVector(0).ToString)
            ListBox1.Items.Clear()
            For Each item As Servicio In vServicios
                If item.ToString IsNot Nothing Then

                    If item.consultaID = 2 Then 'ID DE COMPRAS
                        ListBox1.Items.Add(item.consultaID.ToString + " " + item.persona.ToUpper + " " + item.fecha + " " + item.hora)
                    End If

                End If
            Next
        End If

		'falta filtrar por las ventas
        If seleccion = Consulta.venta Then
            MessageBox.Show("la cantidad de VENTAS realizadas es " + miNuevoVector(1).ToString)
        End If

    End Sub


    Dim contador As Integer
    Dim cadena(5) As String
    Private Sub convertirCadenaEnServicio(ByVal linea As String)
        Dim miServicio As Servicio

        'Como indica el nombre del metodo se convierte la cadena o linea
        'ingresada por parametro, a un objeto tipo servicio
        'con un split se divide cada elemento de la cadena obtenida del txt
        'para completar cada miembro de la estructura
        cadena = Split(linea, ",")
        miServicio.consultaID = cadena(0)
        miServicio.elementoID = cadena(1)
        miServicio.persona = cadena(2)
        miServicio.fecha = cadena(3)
        miServicio.hora = cadena(4)
        miServicio.telefono = cadena(5)
        contador = contador + 1
        cargarVector(miServicio, contador)

    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try



            miCon.abrirConexion()
            'hago algo
            miCon.cerrarConexion()



            Dim lector As New StreamReader(_ruta)

            Dim Archivo As IO.StreamReader

            Archivo = IO.File.OpenText(_ruta)
            Do Until Archivo.EndOfStream
                TextBox1.Text = Archivo.ReadLine()
                Dim linea As String = TextBox1.Text
                convertirCadenaEnServicio(linea)
                'MessageBox.Show("Leer otra Linea")
                'En pantalla se muestra un msgBox por cada vuelta o linea leida
            Loop
            Archivo.Close()

            ListBox1.Items.Clear()

            For Each item As Servicio In vServicios
                If item.persona IsNot Nothing Then
                    ListBox1.Items.Add(item.consultaID.ToString + " " + item.persona.ToUpper + " " + item.fecha + " " + item.hora)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
        End Try
    End Sub
End Class