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
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cboConsultas
        '
        Me.cboConsultas.FormattingEnabled = True
        Me.cboConsultas.Location = New System.Drawing.Point(26, 30)
        Me.cboConsultas.Name = "cboConsultas"
        Me.cboConsultas.Size = New System.Drawing.Size(121, 21)
        Me.cboConsultas.TabIndex = 0
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(165, 30)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(122, 23)
        Me.btnMostrar.TabIndex = 1
        Me.btnMostrar.Text = "&Mostrar "
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(499, 195)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(218, 23)
        Me.btnCargar.TabIndex = 2
        Me.btnCargar.Text = "&Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(26, 146)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 20)
        Me.TextBox1.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(26, 71)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(467, 147)
        Me.ListBox1.TabIndex = 4
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 236)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.cboConsultas)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboConsultas As ComboBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
