Imports MySql.Data.MySqlClient
Public Class tambahbarang
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Harap isi! ", MsgBoxStyle.Information, "Information")
        Else
            Try
                Call koneksivb()
                Dim str As String
                str = "INSERT INTO barang_masuk(kodebarang, namabarang, stokbarang) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil di simpan")
                Formbarangmasuk.datagrinview()
            Catch ex As Exception
                MsgBox("ERROR")
            End Try

        End If
    End Sub

End Class