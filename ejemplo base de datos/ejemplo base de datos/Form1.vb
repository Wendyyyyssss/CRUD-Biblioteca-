Imports MySql.Data.MySqlClient
Public Class Form1
    Dim bandera As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Sub cargardatagrid()
        Dim cString As String
        cString = "server=localhost;user=root;database=biblioteca;port=3306;password=CVO2023;"
        'crear conexión 
        Dim conn As New MySqlConnection(cString)
        Try
            'abrimos la conexión
            conn.Open()
            'Crear cadena de Consulta
            Dim sQuery As String
            sQuery = "SELECT a.idautor, CONCAT(a.nombre, '  ', a.apellidos) as 'Nombre', a.fecha_nac, a.fecha_muerte, a.pais FROM autor a;" 'consulta SQL
            'crear un data adapter
            Dim da As New MySqlDataAdapter(sQuery, conn)
            'crear un DataTable
            Dim dt As New DataTable
            'llenamos el dataTable con el adaptador
            da.Fill(dt)
            'llenamos el data grid con el dataTable
            DataGridView1.DataSource = dt
            'cerrar la conexión
            conn.Close()
            DataGridView1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargardatagrid()
    End Sub

    Private Sub bttguardar_Click(sender As Object, e As EventArgs) Handles bttguardar.Click
        Dim nombre, apellidos, pais As String
        Dim fecha_nac, fecha_muerte As Date
        Dim sQuery As String
        nombre = tbnombre.Text
        apellidos = tbapellidos.Text
        pais = tbpais.Text
        fecha_nac = dtpnac.Value.Date
        fecha_muerte = dtpmuerte.Value.Date
        Dim cstring As String 'creo la cadena de conexión
        cstring = "server=localhost;user=root;database=biblioteca;port=3306;password=CVO2023"
        'crear conexión
        Dim conn As New MySqlConnection(cstring)
        Try
            conn.Open()
            Dim cm As New MySqlCommand
            sQuery = "INSERT INTO autor(nombre, apellidos, fecha_nac, fecha_muerte, pais) VALUES(@nombre, @apellidos, @fecha_nac, @fecha_muerte, @pais);"
            cm.Connection() = conn
            cm.CommandText() = sQuery
            cm.Parameters.AddWithValue("@nombre", nombre)
            cm.Parameters.AddWithValue("@apellidos", apellidos)
            cm.Parameters.AddWithValue("@fecha_nac", fecha_nac)
            cm.Parameters.AddWithValue("@fecha_muerte", fecha_muerte)
            cm.Parameters.AddWithValue("@pais", pais)
            cm.ExecuteNonQuery()
            MessageBox.Show("¡Se ha guardado con éxito!")
            cargardatagrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try





    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim idautor As Integer
        idautor = DataGridView1.CurrentRow.Cells(0).Value
        Dim sQuery As String
        sQuery = "SELECT * FROM autor WHERE idautor=" & idautor & ";"
        Dim cstring As String
        cstring = "server
=localhost;user=root;database=biblioteca;port=3306;password=CVO2023"
        bandera = idautor
        Try
            Dim conn As New MySqlConnection(cstring)
            Dim da As New MySqlDataAdapter(sQuery, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim fila As DataRow = dt.Rows(0)
                tbnombre.Text = fila("nombre").ToString
                tbapellidos.Text = fila("apellidos").ToString
                tbpais.Text = fila("pais").ToString()
                dtpnac.Value = Convert.ToDateTime(fila("fecha_nac")).Date
                dtpmuerte.Value = Convert.ToDateTime(fila("fecha_muerte")).Date
            Else
                MessageBox.Show("No existe el autor:(")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub
End Class
