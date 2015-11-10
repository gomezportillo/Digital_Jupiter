Public Class Interfaz
    Private _c As Contact

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If TextBox_Add_Telephone.Text <> String.Empty And TextBox_Add_Name.Text <> String.Empty Then

            _c = New Contact(TextBox_Add_Telephone.Text, TextBox_Add_Name.Text)

            Try
                _c.createContact()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub Interfaz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
