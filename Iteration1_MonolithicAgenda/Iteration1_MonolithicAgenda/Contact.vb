﻿Imports Microsoft.VisualBasic

Public Class Contact
    Property telephone As String
    Property name As String
    Property dao As DAOContact

    Public Sub New(ByVal tlpn As String, ByVal name As String)
        Me.telephone = tlpn
        Me.name = name
        dao = New DAOContact()
    End Sub

    Public Function createContact() As Integer
        Return Me.dao.creContact(Me)
    End Function
End Class
