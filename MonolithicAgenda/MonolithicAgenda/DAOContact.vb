Imports Microsoft.VisualBasic

Public Class DAOContact
    Property _contacts As Collection

    Public Sub New()
        Me._contacts = New Collection
    End Sub

    Public Sub reContact(ByRef p As Contact)
        Dim reader As OleDb.OleDbDataReader = DBBroker.getInstance.read("SELECT * FROM Clientes WHERE Telefono='" & p.telephone & "';")
        reader.Read()
        p.telephone = reader.GetString(1)
        p.name = reader.GetString(2)
    End Sub


    Public Function delContact(ByVal p As Contact) As Integer 'returns # of changed rows (should be 1)
        Return DBBroker.getInstance().change("DELETE FROM Contacts WHERE Telephone='" & p.telephone & "';")
    End Function


    Public Function upContact(ByVal p As Contact) As Integer 'returns # of changed rows (should be 1)
        Return DBBroker.getInstance().change("UPDATE Contacts SET  Name_contact='" & p.name & "' WHERE Telephone='" & p.telephone & "';")
    End Function


    Public Function creContact(ByVal p As Contact) As Integer 'returns # of changed rows (should be 1)
        Return DBBroker.getInstance().change("INSERT INTO Contacts VALUES ('" & p.telephone & "','" & p.name & "');")
    End Function


    Public Sub reAllContacts(ByRef p As Contact) 'returns an OleDBDataReader data structure
        Dim readerAux As OleDb.OleDbDataReader = DBBroker.getInstance().read("SELECT * FROM Contacts ORDER BY Telephone;")

        While readerAux.Read()
            Console.Write(readerAux.GetString(0) + " " + readerAux.GetString(1) + "\n\n")
            p.dao._contacts.Add(New Contact(readerAux.GetString(0), readerAux.GetString(1)))
        End While
    End Sub

End Class
