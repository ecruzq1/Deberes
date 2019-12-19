Public Class eliminar
    REM Public Property listbox As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REM ListBox1.Items.Add(TextBox1.Text)
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Dim ArchivoBorrar As String

        ArchivoBorrar = "C:\Users\ITQ\Desktop\prueba.txt"
        REM "C:\Users\epcqa\OneDrive\Escritorio\prueba.txt"
        'comprobamos que el archivo existe
        If System.IO.File.Exists(ArchivoBorrar) = True Then
            System.IO.File.Delete(ArchivoBorrar)
        End If
    End Sub

    Private Sub eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REM Me.ListBox1.Items.Add(listbox)
        ListBox1.Items.Clear()

        REM ListBox1.Items.AddRange(eliminar.ListBox1.Items)

        Dim rutafichero As String
        Dim i As Integer
        rutafichero = "C:\Users\epcqa\OneDrive\Escritorio\prueba.txt"
        REM "C:\Users\epcqa\OneDrive\Escritorio\prueba.txt"
        REM "C:\Users\ITQ\Desktop\prueba.txt"

        If IO.File.Exists(rutafichero) = True Then
            Dim fichero As New IO.StreamReader(rutafichero)

            While (fichero.Peek() > -1)
                ListBox1.Items.Add(fichero.ReadLine)
            End While
            fichero.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rutafichero As String
        Dim i As Integer
        rutafichero = "C:\Users\epcqa\OneDrive\Escritorio\prueba.txt"
        REM "C:\Users\epcqa\OneDrive\Escritorio\prueba.txt"
        REM "C:\Users\ITQ\Desktop\prueba.txt"

        Dim fichero As New IO.StreamWriter(rutafichero)

        For i = 0 To ListBox1.Items.Count - 1
            fichero.WriteLine(ListBox1.Items(i))

        Next
        fichero.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim indice As Integer = ListBox1.SelectedIndex
        ListBox1.Items.RemoveAt(indice)
        ListBox1.Items.Insert(indice, agregar.TextBox1.Text + " " + agregar.TextBox2.Text + " " + agregar.Label3.Text)
    End Sub
End Class