﻿Public Class frmThanks

    Private Sub frmThanks_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim path As String = "2Acknowledgment.rtf"
            rtxt1.LoadFile(path, RichTextBoxStreamType.RichText)
            Me.Size = New System.Drawing.Size(900, 663)

        Catch ex As Exception
            MsgBox("Error in loading the page.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class