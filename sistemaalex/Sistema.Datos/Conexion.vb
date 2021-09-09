Imports System.Data.SqlClient
Public Class Conexion

    Public conn As SqlConnection

    Public Sub New()

        Me.conn = New SqlConnection("Data Source=DESKTOP-A0LTNSD;Initial Catalog=db2;Persist Security Info=True;User ID=sa;Password=alex.com12")
    End Sub


End Class
