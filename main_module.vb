﻿Imports MySql.Data.MySqlClient

Module main_module
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;PORT=3306;Database=db_scep;User=root;Password=123456")
            MsgBox("Conexão com a base de dados executado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao conectar! | Conexão base de dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
End Module
