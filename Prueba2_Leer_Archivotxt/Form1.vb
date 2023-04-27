Public Class Form1


    'C:\DATOS\ARTICULOS.TXT
    ' leer cada linea y separar los datos en los listboxs codigo, nombre, price

    '1001|COCACOLA|1.35
    '1002|FANTA|1.45
    '1003|TONICA|1.55
    '1004|NESTEA|1.65
    '1005|SPRITE|1.75


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fileReader As String
        Dim i, j As Integer
        Dim linea() As String

        Dim splitLinea() As String
        'PUEDO PONER UNA RUTINA DE CADA VEZ QUE EMPIECE ELIMINE TODO Y EJECUTE LO DEMÁS

        Try
                fileReader = My.Computer.FileSystem.ReadAllText(TextBox1.Text) 'textbox1.text

                'el trim para juntar todo y comprobar si está vacío
                If fileReader.Trim IsNot "" Then

                    linea = fileReader.Split(CChar(vbCrLf))


                    For i = 0 To linea.Count - 1
                        If linea(i).Trim <> "" Then

                            splitLinea = linea(i).Split("|")


                            ListBox1.Items.Add(splitLinea(0))
                            ListBox2.Items.Add(splitLinea(1))
                            ListBox3.Items.Add(splitLinea(2))

                        End If

                    Next

                Else MsgBox("Archivo vacío")
                End If

            Catch
                MsgBox("Error, ruta incorrecta o el archivo no existe.")
            End Try



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
