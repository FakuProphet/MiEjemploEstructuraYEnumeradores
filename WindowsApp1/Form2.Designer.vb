<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cboConsultas = New System.Windows.Forms.ComboBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboConsultas
        '
        Me.cboConsultas.FormattingEnabled = True
        Me.cboConsultas.Location = New System.Drawing.Point(139, 91)
        Me.cboConsultas.Name = "cboConsultas"
        Me.cboConsultas.Size = New System.Drawing.Size(121, 21)
        Me.cboConsultas.TabIndex = 0
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(300, 91)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(122, 23)
        Me.btnMostrar.TabIndex = 1
        Me.btnMostrar.Text = "&Mostrar Cantidad"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 209)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.cboConsultas)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboConsultas As ComboBox
    Friend WithEvents btnMostrar As Button
End Class
