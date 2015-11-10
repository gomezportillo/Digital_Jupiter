﻿Imports Microsoft.VisualBasic

Public Class DBBroker
    Public Shared FILE_PATH As String = "C:\Users\pedroma\Documents\Visual Studio 2013\Projects\Iteration2_MonolithicAgenda\MonolithicAgenda\databases\ContactsDDBB.accdb"
    Private Shared _connection_driver As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared _connection As OleDb.OleDbConnection
    Private Shared _instance As DBBroker


    Private Sub New()
        DBBroker._connection = New OleDb.OleDbConnection(_connection_driver & FILE_PATH)
        DBBroker._connection.Open()
    End Sub


    Public Shared Function getInstance() As DBBroker 'Shared == Static
        If _instance Is Nothing Then
            _instance = New DBBroker()
        End If
        Return _instance
    End Function

    Public Function change(ByVal sql As String) As Integer
        Dim command As New OleDb.OleDbCommand(sql, _connection)
        Return command.ExecuteNonQuery 'number of changed rows
    End Function

End Class
