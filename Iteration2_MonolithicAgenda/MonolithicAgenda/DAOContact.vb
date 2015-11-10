Imports Microsoft.VisualBasic

Public Class DAOContact
    Property _contacts As Collection

    Public Sub New()
        Me._contacts = New Collection
    End Sub

    Public Function delContact(ByVal p As Contact) As Integer 'returns # of changed rows (should be 1)
        Return DBBroker.getInstance().change("DELETE FROM Contacts WHERE Telephone='" & p.telephone & "';")
    End Function
End Class
