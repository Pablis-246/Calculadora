Public Class UserControl1
    Dim Operacion As String
    Dim Valor_Resultado As Nullable(Of Double) = Nothing
    Dim Valor_2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Concatenacion()
        TxtResultado.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Concatenacion()
        TxtResultado.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Concatenacion()
        TxtResultado.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Concatenacion()
        TxtResultado.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Concatenacion()
        TxtResultado.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Concatenacion()
        TxtResultado.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Concatenacion()
        TxtResultado.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Concatenacion()
        TxtResultado.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Concatenacion()
        TxtResultado.Text &= "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Concatenacion()
        TxtResultado.Text &= "0"
    End Sub

    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles ButtonPunto.Click
        Concatenacion()
        If InStr(TxtResultado.Text, ".", CompareMethod.Text) = 0 Then
            TxtResultado.Text &= "."
        End If
    End Sub

    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
        Tipo_Operacion()
        Operacion = "+"
    End Sub

    Private Sub ButtonResta_Click(sender As Object, e As EventArgs) Handles ButtonResta.Click
        Tipo_Operacion()
        Operacion = "-"
    End Sub

    Private Sub ButtonMultiplicacion_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicacion.Click
        Tipo_Operacion()
        Operacion = "*"
    End Sub

    Private Sub ButtonDivision_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click
        Tipo_Operacion()
        Operacion = "/"
    End Sub

    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        Tipo_Operacion()
        Operacion = ""
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        TxtResultado.Text = "0"
        Valor_2 = Nothing
        Valor_Resultado = Nothing
    End Sub

    Public Sub Tipo_Operacion()
        SePresionaOperador = True
        Valor_2 = Val(TxtResultado.Text)
        If Valor_Resultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    Valor_Resultado = Valor_Resultado + Valor_2
                Case "-"
                    Valor_Resultado = Valor_Resultado - Valor_2
                Case "*"
                    Valor_Resultado = Valor_Resultado * Valor_2
                Case "/"
                    Valor_Resultado = Valor_Resultado / Valor_2
            End Select
            TxtResultado.Text = Valor_Resultado
        Else
            Valor_Resultado = Valor_2
        End If
    End Sub

    Public Sub Concatenacion()
        If SePresionaOperador = True Then
            TxtResultado.Text = ""
            SePresionaOperador = False
        ElseIf TxtResultado.Text = "0" Then
            TxtResultado.Text = ""
        End If
    End Sub
End Class
