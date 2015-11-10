Imports Microsoft.VisualBasic

Public Class DAOContact
    Property _contacts As Collection

    Public Sub New()
        Me._contacts = New Collection
    End Sub

    Public Sub reAllContacts(ByRef p As Contact) 'returns an OleDBDataReader data structure
        Dim readerAux As OleDb.OleDbDataReader = DBBroker.getInstance().read("SELECT * FROM Contacts ORDER BY Telephone;")

        While readerAux.Read()
            Console.Write(readerAux.GetString(0) + " " + readerAux.GetString(1) + "\n\n")
            p.dao._contacts.Add(New Contact(readerAux.GetString(0), readerAux.GetString(1)))
        End While
    End Sub

End Class
