Imports MySql.Data.MySqlClient
Module koneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public rd As MySqlDataReader
    Public ds As DataSet
    Dim str As String
    Public status As String

    Sub koneksivb()
        Try
            Dim str As String = "Server=localhost;user id=root; password=;database=inventorybarang"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



End Module
