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
        Me.ListViewContacts = New System.Windows.Forms.ListView()
        Me.Telephone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Name_a = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label_Information = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Search = New System.Windows.Forms.Button()
        Me.TextBox_Search_Name = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Add_Name = New System.Windows.Forms.TextBox()
        Me.TextBox_Add_Telephone = New System.Windows.Forms.TextBox()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewContacts
        '
        Me.ListViewContacts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Telephone, Me.Name_a})
        Me.ListViewContacts.FullRowSelect = True
        Me.ListViewContacts.GridLines = True
        Me.ListViewContacts.Location = New System.Drawing.Point(6, 19)
        Me.ListViewContacts.Name = "ListViewContacts"
        Me.ListViewContacts.Size = New System.Drawing.Size(254, 311)
        Me.ListViewContacts.TabIndex = 0
        Me.ListViewContacts.UseCompatibleStateImageBehavior = False
        Me.ListViewContacts.View = System.Windows.Forms.View.Details
        '
        'Telephone
        '
        Me.Telephone.Text = "Telephone"
        Me.Telephone.Width = 120
        '
        'Name_a
        '
        Me.Name_a.Text = "Name"
        Me.Name_a.Width = 127
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label_Information)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ListViewContacts)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 336)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact list"
        '
        'Label_Information
        '
        Me.Label_Information.AutoSize = True
        Me.Label_Information.Location = New System.Drawing.Point(266, 305)
        Me.Label_Information.Name = "Label_Information"
        Me.Label_Information.Size = New System.Drawing.Size(59, 13)
        Me.Label_Information.TabIndex = 3
        Me.Label_Information.Text = "Information"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Button_Search)
        Me.GroupBox4.Controls.Add(Me.TextBox_Search_Name)
        Me.GroupBox4.Location = New System.Drawing.Point(266, 144)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(260, 80)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search contact"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telephone"
        '
        'Button_Search
        '
        Me.Button_Search.Location = New System.Drawing.Point(170, 45)
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(75, 23)
        Me.Button_Search.TabIndex = 3
        Me.Button_Search.Text = "Search"
        Me.Button_Search.UseVisualStyleBackColor = True
        '
        'TextBox_Search_Name
        '
        Me.TextBox_Search_Name.Location = New System.Drawing.Point(82, 19)
        Me.TextBox_Search_Name.Name = "TextBox_Search_Name"
        Me.TextBox_Search_Name.Size = New System.Drawing.Size(163, 20)
        Me.TextBox_Search_Name.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button_Delete)
        Me.GroupBox3.Location = New System.Drawing.Point(266, 230)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(260, 58)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Delete existing contact"
        '
        'Button_Delete
        '
        Me.Button_Delete.Location = New System.Drawing.Point(170, 19)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(75, 23)
        Me.Button_Delete.TabIndex = 2
        Me.Button_Delete.Text = "Delete"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox_Add_Name)
        Me.GroupBox2.Controls.Add(Me.TextBox_Add_Telephone)
        Me.GroupBox2.Controls.Add(Me.Button_Add)
        Me.GroupBox2.Location = New System.Drawing.Point(266, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 119)
        Me.GroupBox2.TabIndex = 1
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
        Me.ClientSize = New System.Drawing.Size(556, 360)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Interfaz"
        Me.Text = "Digital Agenda"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListViewContacts As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Telephone As System.Windows.Forms.ColumnHeader
    Friend WithEvents Name_a As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Search_Name As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Delete As System.Windows.Forms.Button
    Friend WithEvents TextBox_Add_Name As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Add_Telephone As System.Windows.Forms.TextBox
    Friend WithEvents Button_Add As System.Windows.Forms.Button
    Friend WithEvents Button_Search As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label_Information As System.Windows.Forms.Label

End Class
