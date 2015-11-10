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
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        If TextBox_Add_Telephone.Text <> String.Empty And TextBox_Add_Name.Text <> String.Empty Then

            _c = New Contact(TextBox_Add_Telephone.Text, TextBox_Add_Name.Text)

            Try
                _c.createContact()
            Catch ex As Exception
                Label_Information.ForeColor = Color.Red
                Label_Information.Text = "Error registrating new contact."
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            Label_Information.Text = "Success registrating new client."
            Label_Information.ForeColor = Color.Green
            LoadDB()

        Else
            Label_Information.ForeColor = Color.Red
            Label_Information.Text = "Please fill all gaps."
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Search.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        If _telephone_to_delete <> String.Empty Then
            Try
                _c = New Contact(_telephone_to_delete)
                _c.deleteContact()
                Label_Information.Text = "Success deleting client."
                Label_Information.ForeColor = Color.Green
                LoadDB()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
                Exit Sub
            End Try

        Else
            MessageBox.Show("Please introduce all the values")
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox_Search_Name_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Search_Name.TextChanged

    End Sub

    Private Sub ListViewContacts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewContacts.SelectedIndexChanged
        If ListViewContacts.SelectedItems.Count > 0 Then 'just in case u (accidentaly) click on an empty row
            _telephone_to_delete = ListViewContacts.SelectedItems(0).SubItems(0).Text
        End If
    End Sub
End Class
