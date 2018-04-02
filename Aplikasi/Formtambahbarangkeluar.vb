Imports MySql.Data.MySqlClient
Public Class Formtambahbarangkeluar

    Private Sub Formtambahbarangkeluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        combo()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Isi Username Dan Password ! ", MsgBoxStyle.Information, "Information")

        Else
            Try
                Call koneksivb()
                Dim str As String
                str = "INSERT INTO barang_keluar(kodebarang, namabarang, jumlahbarang) VALUES ('" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil di simpan")
                Formbarangkeluar.datagrinview()
                Call hapus()
            Catch ex As Exception
                MsgBox("ERROR")
            End Try

        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim konf As String
        konf = MsgBox(" Anda Yakin Akan Exit ??", MessageBoxButtons.YesNo, "Confirmation!!!")
        If konf = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Str As String
        Call koneksivb()
        Str = "Delete From barang_masuk where kodebarang= '" & TextBox1.Text & "'"
        cmd = New MySqlCommand(Str, conn)
        cmd.ExecuteNonQuery()
        rd = cmd.ExecuteReader()
        MsgBox("Berhasil di hapus")
        TextBox1.Clear()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Tampilhalamanutama.Show()
        Me.Hide()
    End Sub
    Sub combo()
        Dim Str As String
        Call koneksivb()
        Try
            Str = "select * from barang_masuk"
            cmd = New MySqlCommand(Str, conn)
            cmd.ExecuteNonQuery()
            rd = cmd.ExecuteReader()
            Do While rd.Read()
                ComboBox1.Items.Add(rd("kodebarang"))
            Loop
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try

    End Sub
    Sub cari()
        If ComboBox1.Text = "" Then
            MsgBox("Mohon Lengkapi Data ! ", MsgBoxStyle.Information, "Information")
        Else
            Call koneksivb()
            Dim strSQL As String
            strSQL = "Select * From barang_masuk where kodebarang Like '%" & ComboBox1.Text & "%'"
            cmd = New MySqlCommand(strSQL, conn)
            cmd.ExecuteNonQuery()

            rd = cmd.ExecuteReader()
            If rd.HasRows = 0 Then
                MsgBox("Data anda belum terdaftar!", MsgBoxStyle.Exclamation, "Error Login")
            Else
                rd.Read()
                TextBox5.Text = rd.Item(0)
                TextBox1.Text = rd.Item(1)
                TextBox2.Text = rd.Item(2)
                Label7.Text = rd.Item(3)

            End If
        End If
    End Sub
    Sub hapus()
        TextBox1.Clear()
        TextBox5.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.Text = ""
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cari()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class