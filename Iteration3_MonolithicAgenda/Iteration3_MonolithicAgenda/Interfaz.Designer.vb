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
        Me.SuspendLayout()
        '
        'ListViewContacts
        '
        Me.ListViewContacts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Telephone, Me.Name_a})
        Me.ListViewContacts.FullRowSelect = True
        Me.ListViewContacts.GridLines = True
        Me.ListViewContacts.Location = New System.Drawing.Point(12, 12)
        Me.ListViewContacts.Name = "ListViewContacts"
        Me.ListViewContacts.Size = New System.Drawing.Size(254, 311)
        Me.ListViewContacts.TabIndex = 1
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
        'Interfaz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 336)
        Me.Controls.Add(Me.ListViewContacts)
        Me.Name = "Interfaz"
        Me.Text = "Digital Agenda"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListViewContacts As System.Windows.Forms.ListView
    Friend WithEvents Telephone As System.Windows.Forms.ColumnHeader
    Friend WithEvents Name_a As System.Windows.Forms.ColumnHeader

End Class
