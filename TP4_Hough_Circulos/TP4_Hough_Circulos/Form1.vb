Public Class Form1
    Dim Valx, Valy As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGImagen.RowCount = 30
        DGImagen.ColumnCount = 30
        DGImagen.RowHeadersVisible = False
        DGImagen.ColumnHeadersVisible = False

        DGTransformada.RowCount = 30
        DGTransformada.ColumnCount = 30
        DGTransformada.RowHeadersVisible = False
        DGTransformada.ColumnHeadersVisible = False

        For x = 0 To DGImagen.RowCount - 1
            DGImagen.Columns(x).Width = 15
            DGImagen.Rows(x).Height = 15
        Next x


        For x = 0 To DGTransformada.RowCount - 1
            DGTransformada.Rows(x).Height = 14
        Next x

        For j = 0 To DGTransformada.ColumnCount - 1
            DGTransformada.Columns(j).Width = 14
        Next j

        Dim width = DGImagen.Columns.GetColumnsWidth(DataGridViewElementStates.None)
        Dim height = DGImagen.Rows.GetRowsHeight(DataGridViewElementStates.None)
        Dim widthT = DGImagen.Columns.GetColumnsWidth(DataGridViewElementStates.None)
        Dim heightT = DGImagen.Rows.GetRowsHeight(DataGridViewElementStates.None)

        DGImagen.ClientSize = New Size(width + 5, height + 20)
        DGTransformada.ClientSize = New Size(widthT + 5, heightT + 20)
        DGImagen.AllowUserToResizeRows = False
        DGImagen.AllowUserToResizeColumns = False
        DGTransformada.AllowUserToResizeRows = False
        DGTransformada.AllowUserToResizeColumns = False

        Me.Size = New Size(width + width + 150, 720)

    End Sub

    Private Sub DGImagen_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGImagen.CellMouseClick
        If DGImagen.CurrentCell.Value = "*" Then
            DGImagen.CurrentCell.Value = ""
        Else
            DGImagen.CurrentCell.Value = "*"
        End If

        If DGImagen.CurrentCell.Value = "X" Then
            Valx = 0
            Valy = 0
        Else
            Valx = DGImagen.CurrentCell.ColumnIndex
            Valy = Math.Abs(DGImagen.CurrentCell.RowIndex - 29)
        End If

        lblX.Text = Valx
        lblY.Text = Valy

        CalculoHought()
    End Sub

    Private Function CalculoHought()
        Dim Y1, Y2 As Double
        Dim YV As Integer
        Dim o, i, h, valintinf, valintsup As Integer
        Dim maxValor As Integer
        Dim xx, yy, xFuncion, yFuncion As Integer

        maxValor = 0
        'o => X
        'P = Y
        For x = 0 To 29
            valintinf = (9) - Math.Pow(x - Valx, 2)
            valintsup = (9) - Math.Pow(x - Valx, 2)


            If valintinf >= 0 Then
                Y1 = 29 - Valy + Math.Sqrt(valintinf)
                Y2 = 29 - Valy - Math.Sqrt(valintsup)

                'Desfazo 20 cuadros para que salga completa la figura sinoidal (sino se van al eje negativo de y)
                Y1 = Math.Round(Y1)
                Y2 = Math.Round(Y2)

                'Imprimo si entra en la grilla
                If Y1 >= 0 And Y1 <= 29 And Y2 >= 0 And Y2 <= 29 Then
                    'sumo 1 al valor actual, logrando asi que en las intersecciones se den los mayores valores
                    DGTransformada.Rows(Y1).Cells(x).Value = 1 + IIf(valintinf <> 0, DGTransformada.Rows(Y1).Cells(x).Value, 0)
                    DGTransformada.Rows(Y2).Cells(x).Value = 1 + IIf(valintinf <> 0, DGTransformada.Rows(Y2).Cells(x).Value, 0)

                End If
            End If
        Next x


        For xx = 0 To 29
            For yy = 0 To 29
                If DGTransformada.Rows(yy).Cells(xx).Value > maxValor Then
                    maxValor = DGTransformada.Rows(yy).Cells(xx).Value
                End If
            Next yy
        Next xx

        For xx = 0 To 29
            For yy = 0 To 29
                If DGTransformada.Rows(yy).Cells(xx).Value = maxValor Then

                    DGTransformada.Rows(yy).Cells(xx).Style.BackColor = Color.Salmon
                    If maxValor > 1 Then
                        xFuncion = xx
                        yFuncion = yy
                    End If
                Else
                    DGTransformada.Rows(yy).Cells(xx).Style.BackColor = Color.White
                End If
            Next yy
        Next xx

        DGTransformada.Refresh()

        If xFuncion > 0 And yFuncion > 0 Then
            lblCentro.Text = "El circulo se detecto aproximadamente con centro en: Y=" + CStr(29 - yFuncion) + " ; X=" + CStr(xFuncion) + ")"
        End If


    End Function



    Private Sub DGImagen_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGImagen.CellContentClick

    End Sub
End Class

