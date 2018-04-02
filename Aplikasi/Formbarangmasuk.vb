Imports MySql.Data.MySqlClient
Public Class Formbarangmasuk
    Sub tampilbarang()
        Call koneksivb()
        da = New MySqlDataAdapter("select * from barang_masuk", conn)
        ds = New DataSet
        da.Fill(ds, "barang_masuk")
        DataGridView1.DataSource = ds.Tables("barang_masuk")
    End Sub
    Sub datagrinview()
        Call koneksivb()
        Try
            DataGridView1.Columns(0).Width = 70
            DataGridView1.Columns(1).Width = 130
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(0).HeaderText = "id"
            DataGridView1.Columns(1).HeaderText = "Kode Barang"
            DataGridView1.Columns(2).HeaderText = "Nama Barang"
            DataGridView1.Columns(3).HeaderText = "Stok Barang"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Formbarangmasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilbarang()
        datagrinview()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        tampilbarang()
        datagrinview()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim konf As String
        konf = MsgBox(" Anda Yakin Akan Exit ??", MessageBoxButtons.YesNo, "Confirmation!!!")
        If konf = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Tampilhalamanutama.Show()
        Me.Hide()
    End Sub
End Class