﻿Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = "select * from tb_login where username ='" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'"
        RD = objcmd.ExecuteReader()
        If RD.HasRows Then
            MsgBox("Login Berhasil", vbInformation, "Aplikasi input Data siswa")
            Form2.Show()
        Else
            MsgBox("Maaf Username atau Password Salah")
        End If
    End Sub
End Class
