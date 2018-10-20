<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbtAutomovil = New System.Windows.Forms.RadioButton()
        Me.rbtMotocicleta = New System.Windows.Forms.RadioButton()
        Me.rbtCompra = New System.Windows.Forms.RadioButton()
        Me.rbtVenta = New System.Windows.Forms.RadioButton()
        Me.txtClienteNombre = New System.Windows.Forms.TextBox()
        Me.txtTeleContacto = New System.Windows.Forms.TextBox()
        Me.txtFechaHora = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblVehiculo = New System.Windows.Forms.Label()
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tel de contacto"
        '
        'rbtAutomovil
        '
        Me.rbtAutomovil.AutoSize = True
        Me.rbtAutomovil.Checked = True
        Me.rbtAutomovil.Location = New System.Drawing.Point(36, 35)
        Me.rbtAutomovil.Name = "rbtAutomovil"
        Me.rbtAutomovil.Size = New System.Drawing.Size(71, 17)
        Me.rbtAutomovil.TabIndex = 5
        Me.rbtAutomovil.TabStop = True
        Me.rbtAutomovil.Text = "Automovil"
        Me.rbtAutomovil.UseVisualStyleBackColor = True
        '
        'rbtMotocicleta
        '
        Me.rbtMotocicleta.AutoSize = True
        Me.rbtMotocicleta.Location = New System.Drawing.Point(139, 35)
        Me.rbtMotocicleta.Name = "rbtMotocicleta"
        Me.rbtMotocicleta.Size = New System.Drawing.Size(80, 17)
        Me.rbtMotocicleta.TabIndex = 6
        Me.rbtMotocicleta.TabStop = True
        Me.rbtMotocicleta.Text = "Motocicleta"
        Me.rbtMotocicleta.UseVisualStyleBackColor = True
        '
        'rbtCompra
        '
        Me.rbtCompra.AutoSize = True
        Me.rbtCompra.Checked = True
        Me.rbtCompra.Location = New System.Drawing.Point(86, 35)
        Me.rbtCompra.Name = "rbtCompra"
        Me.rbtCompra.Size = New System.Drawing.Size(61, 17)
        Me.rbtCompra.TabIndex = 7
        Me.rbtCompra.TabStop = True
        Me.rbtCompra.Text = "Compra"
        Me.rbtCompra.UseVisualStyleBackColor = True
        '
        'rbtVenta
        '
        Me.rbtVenta.AutoSize = True
        Me.rbtVenta.Location = New System.Drawing.Point(25, 35)
        Me.rbtVenta.Name = "rbtVenta"
        Me.rbtVenta.Size = New System.Drawing.Size(53, 17)
        Me.rbtVenta.TabIndex = 8
        Me.rbtVenta.TabStop = True
        Me.rbtVenta.Text = "Venta"
        Me.rbtVenta.UseVisualStyleBackColor = True
        '
        'txtClienteNombre
        '
        Me.txtClienteNombre.Location = New System.Drawing.Point(157, 179)
        Me.txtClienteNombre.Name = "txtClienteNombre"
        Me.txtClienteNombre.Size = New System.Drawing.Size(347, 20)
        Me.txtClienteNombre.TabIndex = 9
        '
        'txtTeleContacto
        '
        Me.txtTeleContacto.Location = New System.Drawing.Point(157, 236)
        Me.txtTeleContacto.Name = "txtTeleContacto"
        Me.txtTeleContacto.Size = New System.Drawing.Size(347, 20)
        Me.txtTeleContacto.TabIndex = 10
        '
        'txtFechaHora
        '
        Me.txtFechaHora.Enabled = False
        Me.txtFechaHora.Location = New System.Drawing.Point(157, 207)
        Me.txtFechaHora.Name = "txtFechaHora"
        Me.txtFechaHora.Size = New System.Drawing.Size(133, 20)
        Me.txtFechaHora.TabIndex = 11
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(362, 297)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(142, 23)
        Me.btnConfirmar.TabIndex = 12
        Me.btnConfirmar.Text = "&Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtAutomovil)
        Me.GroupBox1.Controls.Add(Me.rbtMotocicleta)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 83)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehiculo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtCompra)
        Me.GroupBox2.Controls.Add(Me.rbtVenta)
        Me.GroupBox2.Location = New System.Drawing.Point(337, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 83)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operación"
        '
        'lblVehiculo
        '
        Me.lblVehiculo.AutoSize = True
        Me.lblVehiculo.Location = New System.Drawing.Point(101, 29)
        Me.lblVehiculo.Name = "lblVehiculo"
        Me.lblVehiculo.Size = New System.Drawing.Size(16, 13)
        Me.lblVehiculo.TabIndex = 15
        Me.lblVehiculo.Text = "..."
        '
        'lblOperacion
        '
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Location = New System.Drawing.Point(359, 29)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(16, 13)
        Me.lblOperacion.TabIndex = 16
        Me.lblOperacion.Text = "..."
        '
        'txtHora
        '
        Me.txtHora.Enabled = False
        Me.txtHora.Location = New System.Drawing.Point(371, 207)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(133, 20)
        Me.txtHora.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Hora"
        '
        'btnConsultar
        '
        Me.btnConsultar.Enabled = False
        Me.btnConsultar.Location = New System.Drawing.Point(44, 297)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(142, 23)
        Me.btnConsultar.TabIndex = 19
        Me.btnConsultar.Text = "&Formulario Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 355)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.lblOperacion)
        Me.Controls.Add(Me.lblVehiculo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtFechaHora)
        Me.Controls.Add(Me.txtTeleContacto)
        Me.Controls.Add(Me.txtClienteNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taller Mecanico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbtAutomovil As RadioButton
    Friend WithEvents rbtMotocicleta As RadioButton
    Friend WithEvents rbtCompra As RadioButton
    Friend WithEvents rbtVenta As RadioButton
    Friend WithEvents txtClienteNombre As TextBox
    Friend WithEvents txtTeleContacto As TextBox
    Friend WithEvents txtFechaHora As TextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblVehiculo As Label
    Friend WithEvents lblOperacion As Label
    Friend WithEvents txtHora As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConsultar As Button
End Class
