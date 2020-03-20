Imports System.Configuration
Imports System.IO
Imports System.Net

Public Class frmLogin
    Dim PhoneLog As New PhoneLog

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        PhoneLog.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

    End Sub
End Class
