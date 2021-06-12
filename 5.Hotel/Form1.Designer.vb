<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hotel
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
        Me.rdbtnA = New System.Windows.Forms.RadioButton()
        Me.txtbxTotal = New System.Windows.Forms.TextBox()
        Me.btnPro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbtnB = New System.Windows.Forms.RadioButton()
        Me.rdbtnC = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtbx1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdbtnA
        '
        Me.rdbtnA.AutoSize = True
        Me.rdbtnA.Location = New System.Drawing.Point(18, 19)
        Me.rdbtnA.Name = "rdbtnA"
        Me.rdbtnA.Size = New System.Drawing.Size(32, 17)
        Me.rdbtnA.TabIndex = 0
        Me.rdbtnA.TabStop = True
        Me.rdbtnA.Text = "A"
        Me.rdbtnA.UseVisualStyleBackColor = True
        '
        'txtbxTotal
        '
        Me.txtbxTotal.Location = New System.Drawing.Point(482, 59)
        Me.txtbxTotal.Name = "txtbxTotal"
        Me.txtbxTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtbxTotal.TabIndex = 1
        '
        'btnPro
        '
        Me.btnPro.Location = New System.Drawing.Point(387, 57)
        Me.btnPro.Name = "btnPro"
        Me.btnPro.Size = New System.Drawing.Size(75, 23)
        Me.btnPro.TabIndex = 2
        Me.btnPro.Text = "Procesar"
        Me.btnPro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(481, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "El total a pagar será"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbtnB)
        Me.GroupBox1.Controls.Add(Me.rdbtnC)
        Me.GroupBox1.Controls.Add(Me.rdbtnA)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Habitación"
        '
        'rdbtnB
        '
        Me.rdbtnB.AutoSize = True
        Me.rdbtnB.Location = New System.Drawing.Point(18, 42)
        Me.rdbtnB.Name = "rdbtnB"
        Me.rdbtnB.Size = New System.Drawing.Size(32, 17)
        Me.rdbtnB.TabIndex = 5
        Me.rdbtnB.TabStop = True
        Me.rdbtnB.Text = "B"
        Me.rdbtnB.UseVisualStyleBackColor = True
        '
        'rdbtnC
        '
        Me.rdbtnC.AutoSize = True
        Me.rdbtnC.Location = New System.Drawing.Point(18, 65)
        Me.rdbtnC.Name = "rdbtnC"
        Me.rdbtnC.Size = New System.Drawing.Size(32, 17)
        Me.rdbtnC.TabIndex = 6
        Me.rdbtnC.TabStop = True
        Me.rdbtnC.Text = "C"
        Me.rdbtnC.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ingrese el número de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "días que se quedará"
        '
        'Txtbx1
        '
        Me.Txtbx1.Location = New System.Drawing.Point(260, 59)
        Me.Txtbx1.Name = "Txtbx1"
        Me.Txtbx1.Size = New System.Drawing.Size(100, 20)
        Me.Txtbx1.TabIndex = 5
        '
        'Hotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 206)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtbx1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPro)
        Me.Controls.Add(Me.txtbxTotal)
        Me.Name = "Hotel"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbtnA As System.Windows.Forms.RadioButton
    Friend WithEvents txtbxTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnPro As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtnB As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnC As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtbx1 As System.Windows.Forms.TextBox

End Class
