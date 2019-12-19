Public Class lista
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rutafichero As String
        ListBox1.Items.Clear()
        rutafichero = "C:\Users\epcqa\OneDrive\Escritorio\prueba.txt"

        Dim sr As New System.IO.StreamReader(
                    rutafichero,
                    System.Text.Encoding.Default,
                    True)

        ' Leer el contenido mientras no se llegue al final
        While sr.Peek() <> -1
            ' Leer una líena del fichero
            Dim s As String = sr.ReadLine()
            ' Si no está vacía, añadirla al control
            ' Si está vacía, continuar el bucle
            If String.IsNullOrEmpty(s) Then
                Continue While
            End If

            Me.ListView1.Items.Add(s)
            Me.ListBox1.Items.Add(s)
        End While
        ' Cerrar el fichero
        sr.Close()


    End Sub


End Class