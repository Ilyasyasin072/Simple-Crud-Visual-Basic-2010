Imports MySql.Data.MySqlClient
Public Class FormLogin

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        login()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim konf As String
        konf = MsgBox(" Anda Yakin Akan Exit ??", MessageBoxButtons.YesNo, "Confirmation!!!")
        If konf = vbYes Then
            Me.Close()

        End If
    End Sub

    Sub login()
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Isi Username Dan Password ! ", MsgBoxStyle.Information, "Information")

        Else

            Call koneksivb()
            Dim str As String

            str = "SELECT * FROM login WHERE username = '" + TextBox1.Text + "' AND password= '" + TextBox2.Text + "'"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            rd = cmd.ExecuteReader()
            If rd.HasRows = 0 Then
                MsgBox("Username atau Password ada yang salah !", MsgBoxStyle.Exclamation, "Error Login")
                TextBox1.ForeColor = Color.Blue
            Else
                Me.Hide()
                rd.Read()
                status = rd.Item("status")
                MsgBox("Login Berhasil, Selamat Datang " & TextBox1.Text & " ! ", MsgBoxStyle.Information, "Successfull Login")
                If status = "user" Then
                    Tampilhalamanutama.Show()
                    Me.Hide()
                    Tampilhalamanutama.Label1.Text = TextBox1.Text
                    Tampilhalamanutama.MenuStrip1.Show()
                    Tampilhalamanutama.MenuStrip2.Hide()
                Else : status = "admin"
                    Tampilhalamanutama.Show()
                    Me.Hide()
                    Tampilhalamanutama.Label1.Text = TextBox1.Text
                    Tampilhalamanutama.MenuStrip2.Show()
                    Tampilhalamanutama.MenuStrip1.Hide()
                End If
            End If
        End If


    End Sub
End Class
