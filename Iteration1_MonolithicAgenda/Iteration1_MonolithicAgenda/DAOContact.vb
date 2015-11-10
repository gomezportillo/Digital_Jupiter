Imports Microsoft.VisualBasic

Public Class DAOContact
    Property _contacts As Collection

    Public Sub New()
        Me._contacts = New Collection
    End Sub

    Public Function creContact(ByVal p As Contact) As Integer 'returns # of changed rows (should be 1)
        Return DBBroker.getInstance().change("INSERT INTO Contacts VALUES ('" & p.telephone & "','" & p.name & "');")
    End Function

End Class
