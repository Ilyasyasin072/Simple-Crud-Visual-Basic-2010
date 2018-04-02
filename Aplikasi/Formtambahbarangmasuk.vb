Imports MySql.Data.MySqlClient
Public Class Formtambahbarangmasuk

    Private Sub Formtambahbarangmasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        combo1()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim konf As String
        konf = MsgBox(" Anda Yakin Akan Exit ??", MessageBoxButtons.YesNo, "Confirmation!!!")
        If konf = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Harap isi! ", MsgBoxStyle.Information, "Information")

        Else
            Try
                Call koneksivb()
                Dim str As String
                str = "INSERT INTO barang_masuk(kodebarang, namabarang, stokbarang) VALUES ('" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil di simpan")
                Formbarangkeluar.datagrinview()
            Catch ex As Exception
                MsgBox("ERROR")
            End Try

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
    Sub combo1()
        Dim Str As String
        Call koneksivb()
        Try
            Str = "select * From barang_masuk "
            cmd = New MySqlCommand(Str, conn)
            cmd.ExecuteNonQuery()
            rd = cmd.ExecuteReader()
            While rd.Read()
                ComboBox1.Items.Add(rd("kodebarang"))
            End While
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal !!!, karena " & ex.Message)
        End Try

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

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
                TextBox4.Text = rd.Item(0)
                TextBox1.Text = rd.Item(1)
                TextBox2.Text = rd.Item(2)

            End If
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cari()
    End Sub
End Class