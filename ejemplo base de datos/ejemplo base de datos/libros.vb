Imports MySql.Data.MySqlClient
Public Class libros


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cString As String
        cString = "server=localhost;user=root;database=biblioteca;port=3306;password=CVO2023;"
        Dim conn As New MySqlConnection(cString)
        Try
            conn.Open()
            Dim sQuery As String
            sQuery = "SELECT l.idlibro, l.titulo, l.descripcion, l.idautor, l.fechapub, l.isbn FROM libro l;"
            Dim da As New MySqlDataAdapter(sQuery, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()
            DataGridView1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub


End Class