Imports MySql.Data.MySqlClient
Public Class Form1
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Dim conf As String

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        conf = "Server=" + tserver.Text + "; user id=" + tuser.Text + "; password=" + tpass.Text + "; database=" + tdb.Text + ""
        Try
            conn = New MySqlConnection(conf)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                PictureBox1.BackColor = Color.Green
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            PictureBox1.BackColor = Color.Red
        End Try
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        conn.Close()
        PictureBox1.BackColor = Color.Red
    End Sub
End Class
