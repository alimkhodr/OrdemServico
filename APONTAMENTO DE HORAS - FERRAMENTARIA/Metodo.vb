Imports System.Data.SqlClient
Module Metodo
    Public Verifica As Integer
    Public User As Integer
    Public UserName As String
    Public conexaobd As New SqlConnection()
    Public objDataReader As SqlDataReader
    Public comandoSQL As SqlCommand
    Public id_maquina, id_OS, id_OP As Integer
    Public tela As Integer
    Public Sub conectar()
        Try
            conexaobd.ConnectionString = "sua_conexao"
            comandoSQL = conexaobd.CreateCommand
            conexaobd.Open()

        Catch ex As Exception
            conexaobd.Close()
            conexaobd.ConnectionString = "sua_conexao"
            comandoSQL = conexaobd.CreateCommand
            conexaobd.Open()
        End Try

    End Sub
    Public Sub desconectar()
        Try
            conexaobd.Close()
            objDataReader.Close()
        Catch ex As Exception

        End Try

    End Sub

End Module
