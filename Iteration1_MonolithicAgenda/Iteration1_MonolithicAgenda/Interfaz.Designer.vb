<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interfaz
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Add_Name = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Telephone = New System.Windows.Forms.TextBox()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox_Add_Name)
        Me.GroupBox2.Controls.Add(Me.TextBox_Add_Telephone)
        Me.GroupBox2.Controls.Add(Me.Button_Add)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 119)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Create new contact"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Telephone"
        '
        'TextBox_Add_Name
        '
        Me.TextBox_Add_Name.Location = New System.Drawing.Point(82, 55)
        Me.TextBox_Add_Name.Name = "TextBox_Add_Name"
        Me.TextBox_Add_Name.Size = New System.Drawing.Size(163, 20)
        Me.TextBox_Add_Name.TabIndex = 2
        '
        'TextBox_Add_Telephone
        '
        Me.TextBox_Add_Telephone.Location = New System.Drawing.Point(82, 19)
        Me.TextBox_Add_Telephone.MaxLength = 8
        Me.TextBox_Add_Telephone.Name = "TextBox_Add_Telephone"
        Me.TextBox_Add_Telephone.Size = New System.Drawing.Size(163, 20)
        Me.TextBox_Add_Telephone.TabIndex = 1
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(170, 81)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add.TabIndex = 0
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Interfaz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 146)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Interfaz"
        Me.Text = "Iteration 1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Add_Name As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Add_Telephone As System.Windows.Forms.TextBox
    Friend WithEvents Button_Add As System.Windows.Forms.Button

End Class
