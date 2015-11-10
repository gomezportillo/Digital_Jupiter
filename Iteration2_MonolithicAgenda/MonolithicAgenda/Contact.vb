Imports Microsoft.VisualBasic

Public Class Contact
    Property telephone As String
    Property dao As DAOContact

    Public Sub New(ByVal tlpn As String)
        Me.telephone = tlpn
        dao = New DAOContact()
    End Sub

    Public Function deleteContact() As Integer
        Return Me.dao.delContact(Me)
    End Function
End Class
