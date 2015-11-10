Imports Microsoft.VisualBasic

Public Class Contact
    Property telephone As String
    Property name As String
    Property dao As DAOContact

    Public Sub New(ByVal tlpn As String, ByVal name As String)
        Me.telephone = tlpn
        Me.name = name
        dao = New DAOContact()
    End Sub

    Public Sub New(ByVal tlpn As String)
        Me.telephone = tlpn
        dao = New DAOContact()
    End Sub

    Public Sub New()
        dao = New DAOContact()
    End Sub

    Public Sub readContact()
        Me.dao.reContact(Me)
    End Sub

    Public Function deleteContact() As Integer
        Return Me.dao.delContact(Me)
    End Function

    Public Function createContact() As Integer
        Return Me.dao.creContact(Me)
    End Function

    Public Sub readAll()
        Me.dao.reAllContacts(Me)
    End Sub

End Class
