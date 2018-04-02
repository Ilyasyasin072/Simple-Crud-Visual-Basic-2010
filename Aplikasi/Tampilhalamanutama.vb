Public Class Tampilhalamanutama

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub TampilkanDataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TampilkanDataBarangToolStripMenuItem.Click
        Formbarangmasuk.Show()
    End Sub

    Private Sub TampilkanDataBarangToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TampilkanDataBarangToolStripMenuItem1.Click
        Formbarangkeluar.Show()
    End Sub

  

    Private Sub TambahBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahBarangToolStripMenuItem.Click
        Formtambahbarangmasuk.Show()
    End Sub

    Private Sub TambahkanBarangKeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahkanBarangKeluarToolStripMenuItem.Click
        Formtambahbarangkeluar.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem1.Click
        Dim konf As String
        konf = MsgBox(" Anda Yakin Akan Logout ??", MessageBoxButtons.YesNo, "Confirmation!!!")
        If konf = vbYes Then
            Me.Hide()
            FormLogin.Show()
            FormLogin.TextBox1.Clear()
            FormLogin.TextBox2.Clear()
        End If
    End Sub

    Private Sub TambahBarangToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tambahbarang.Show()
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Dim konf As String
        konf = MsgBox(" Anda Yakin Akan Logout ??", MessageBoxButtons.YesNo, "Confirmation!!!")
        If konf = vbYes Then
            Me.Hide()
            FormLogin.Show()
            FormLogin.TextBox1.Clear()
            FormLogin.TextBox2.Clear()
        End If
    End Sub

    Private Sub TambahUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahUserToolStripMenuItem.Click
        tambahuser.Show()
    End Sub
End Class