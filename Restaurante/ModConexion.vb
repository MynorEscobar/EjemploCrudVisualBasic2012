Module ModConexion
    Public conec As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Restaurante.accdb")
    Public Sub abrirConexion()
        Try
            conec.Open()
            MsgBox("conexion realizada con exito")
        Catch ex As Exception

        End Try
    End Sub
    Public Sub cerrarConexion()
        Try
            conec.Close()
        Catch ex As Exception

        End Try
    End Sub
End Module
