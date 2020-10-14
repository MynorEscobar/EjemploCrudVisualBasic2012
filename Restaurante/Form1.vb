Public Class Form1


    
    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        abrirConexion()

        Dim codigob As String
        codigob = "select * from clientes where nit='" & txtNit.Text & "'"

        Dim ejecodigob As New OleDb.OleDbCommand
        ejecodigob.CommandType = CommandType.Text
        ejecodigob.Connection = conec
        ejecodigob.CommandText = codigob

        Dim guardareje As OleDb.OleDbDataReader
        guardareje = ejecodigob.ExecuteReader
        guardareje.Read()
        If guardareje.HasRows Then
            txtNombre.Text = guardareje!nombre
            txtDireccion.Text = guardareje!nit
        Else
            MsgBox("codigo no existe")
        End If
        guardareje.Close()

        cerrarConexion()

    End Sub
End Class
