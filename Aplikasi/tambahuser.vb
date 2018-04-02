Imports MySql.Data.MySqlClient
Public Class tambahuser

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Harap isi! ", MsgBoxStyle.Information, "Information")
        Else
            Try
                Call koneksivb()
                Dim str As String
                str = "INSERT INTO login(username, password, status) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil di simpan")
                Formbarangmasuk.datagrinview()
            Catch ex As Exception
                MsgBox("ERROR")
            End Try

        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

    End Sub
End Class