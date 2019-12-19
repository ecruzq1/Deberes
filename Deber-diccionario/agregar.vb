
Imports System.Windows.Forms

Public Class agregar
    Public Property ListBox1 As Object

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Button1.Enabled = False
        If TextBox1.Text.Equals("acatar") Then
            TextBox2.Text = "Respetar, obedecer. Venerar, someterse."
        ElseIf TextBox1.Text.Equals("acceder") Then
            TextBox2.Text = "Consentir en lo que otro quiere."

        ElseIf TextBox1.Text.Equals("adecuación") Then
            TextBox2.Text = "Propósito para algo."


        ElseIf TextBox1.Text.Equals("aferrarse") Then
            TextBox2.Text = "Agarrar fuertemente."


        ElseIf TextBox1.Text.Equals("albergar") Then
            TextBox2.Text = "Hospedar. Dar alojamiento."


        ElseIf TextBox1.Text.Equals("amnesia") Then
            TextBox2.Text = "Trastornos de la memoria. Olvido total o parcial."


        ElseIf TextBox1.Text.Equals("analfabeta") Then
            TextBox2.Text = "Que no sabe leer ni escribir."



        ElseIf TextBox1.Text.Equals("aplazar") Then
            TextBox2.Text = "Demorar, posponer, suspender."


        ElseIf TextBox1.Text.Equals("ataque") Then
            TextBox2.Text = "Acometida, impugnación, disputa."


        ElseIf TextBox1.Text.Equals("¡Ay!") Then
            TextBox2.Text = "Expresión de dolor. Lamento."


        ElseIf TextBox1.Text.Equals("biologia") Then
            TextBox2.Text = "Ciencia que se ocupa del estudio de los seres vivos."


        ElseIf TextBox1.Text.Equals("Caja negra") Then
            TextBox2.Text = "Artefacto en el que se graba la conversación entre el capitán de un avión y la torre de control."

        ElseIf TextBox1.Text.Equals("carisma") Then
            TextBox2.Text = "Agradar. Hacer favores."

        ElseIf TextBox1.Text.Equals("certeza") Then
            TextBox2.Text = "Conocimiento seguro y claro de alguna cosa."

        ElseIf TextBox1.Text.Equals("codificar") Then
            TextBox2.Text = "Guardar información en clave."

        ElseIf TextBox1.Text.Equals("conciencia") Then
            TextBox2.Text = "Conocimiento exacto y reflexivo de las cosas."


        ElseIf TextBox1.Text.Equals("concretar") Then
            TextBox2.Text = "Especificar. Limitar."


        ElseIf TextBox1.Text.Equals("soledad") Then
            TextBox2.Text = "Estado ailamiento."

        ElseIf TextBox1.Text.Equals("olvido") Then
            TextBox2.Text = "Accion voluntaria o no de dejar de recordar."

        ElseIf TextBox1.Text.Equals("sonambulo") Then
            TextBox2.Text = "Persona camina dormida."

        ElseIf TextBox1.Text.Equals("desenlace") Then
            TextBox2.Text = "Resolucion de una historia."

        ElseIf TextBox1.Text.Equals("gestion") Then
            TextBox2.Text = "Conjunto tramites que se llevan a cabo."


        ElseIf TextBox1.Text.Equals("mercadeo") Then
            TextBox2.Text = "Conjunto operaciones para una mercancia"


        ElseIf TextBox1.Text.Equals("tendencia") Then
            TextBox2.Text = "Movimiento religioso,economico"

        ElseIf TextBox1.Text.Equals("futbol") Then
            TextBox2.Text = "Deporte que se practica entre dos equipos de once jugadores"


        ElseIf TextBox1.Text.Equals("deporte") Then
            TextBox2.Text = "Actividad o ejercicio físico"

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Respuesta As Integer
        Respuesta = MsgBox("¿ Deseas Ingresar Datos ?", vbYesNo)
        Select Case Respuesta
            Case vbYes
                Ingresar()
                Limpiar()
            Case vbNo
                Guardar()

        End Select




    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Respuesta As Integer
        Respuesta = MsgBox("¿ Deseas Ingresar Imagen ?", vbYesNo)
        Select Case Respuesta
            Case vbYes
                validar1()
            Case vbNo
                MsgBox("Has Indicado que no Deseas Continuar")
        End Select


    End Sub
    Function validar()
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Label3.Text = OpenFileDialog1.FileName
            PictureBox1.ImageLocation = Label3.Text
            MsgBox(" Imagen Insertada de Manera Correcta ")
            MsgBox(" Habilitando Boton Ingresar")


            Button1.Enabled = True

        End If

    End Function
    Function Ingresar()
        If TextBox1.Text.Equals("") Or TextBox2.Text.Equals("") Or Label3.Text.Equals("") Then
            MsgBox("No se Puede Ingresar Campos Vacios")
        Else
            Dim Items As System.Windows.Forms.ListViewItem
            Items = ListView1.Items.Add(TextBox1.Text, 0)
            Items.SubItems.Add(TextBox2.Text)
            Items.SubItems.Add(Label3.Text)
            eliminar.ListBox1.Items.Add("Palabra " + TextBox1.Text + " , " + " Significado " + TextBox2.Text)

        End If
    End Function
    Function validar1()
        OpenFileDialog1.InitialDirectory = "C:\Users\ITQ\Pictures"
        If TextBox1.Text.Equals("") Or TextBox2.Text.Equals("") Then
            MsgBox(" Ingrese Campos Vacios ")
        Else
            validar()


        End If

    End Function
    Function Guardar()
        Dim filepath As String = "C:\Users\ITQ\Desktop\prueba.txt"
        REM Dim filepath As String = "C:\Users\epcqa\OneDrive\Escritorio\prueba.txt"

        Using file As New IO.StreamWriter(filepath, True)
            Dim line As String = ""
            For Each item As ListViewItem In Me.ListView1.Items
                line = ""
                For Each subitem As ListViewItem.ListViewSubItem In item.SubItems
                    line += subitem.Text + vbTab
                Next
                file.WriteLine(line)
            Next
            file.Flush()
            file.Close()
        End Using

        REM Process.Start(filepath)
        REM dbeaver, lucidchart, github desktop, overleaf editor latex,ionic,nestjs,framework apache,note,react,angular,vuejs,nativescrip,capacitor ionic,node,typescrpit
        REM string de conexion de mysql mongodb acces consulta
        REM api datos de postman,invision 
    End Function

    Function Limpiar()
        PictureBox1.Image.Dispose()
        PictureBox1.Image = Nothing
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Guardar()

    End Sub

    Private Sub Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        ListView1.Columns.Add("Palabra", 150)
        ListView1.Columns.Add("Significado", 200)
        ListView1.Columns.Add("Ubicacion Imagen", 150)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged


        Dim lista As ListViewItem = New ListViewItem()
        For Each lista In ListView1.SelectedItems
            TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
            TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
            Label3.Text = ListView1.SelectedItems(0).SubItems(2).Text
            REM eliminar.ListBox1.Items.Clear()

            lista.Remove()

        Next


    End Sub


End Class