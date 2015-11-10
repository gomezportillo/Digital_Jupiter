Public Class Interfaz
    Private _c As Contact

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If telephone_to_delete.Text <> String.Empty Then
            Try
                _c = New Contact(telephone_to_delete.Text)
                _c.deleteContact()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
                Exit Sub
            End Try
        Else
        End If
    End Sub

End Class
