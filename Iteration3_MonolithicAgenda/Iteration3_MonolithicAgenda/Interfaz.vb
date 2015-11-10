Public Class Interfaz
    Private _c As Contact
    Private _telephone_to_delete As String = String.Empty

    Private Sub LoadForm(sender As Object, e As EventArgs) Handles Me.Load
        LoadDB()
    End Sub

    Private Sub LoadDB()
        ListViewContacts.Items.Clear()

        _c = New Contact()
        Try
            _c.readAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Dim item As ListViewItem
        For Each cAux As Contact In _c.dao._contacts
            item = New ListViewItem(System.Convert.ToString(cAux.telephone))
            item.SubItems.Add(cAux.name)
            ListViewContacts.Items.Add(item)
        Next
    End Sub
End Class
