Public Class Form1
    Dim Valx, Valy As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGImagen.RowCount = 30
        DGImagen.ColumnCount = 30
        DGImagen.RowHeadersVisible = False
        DGImagen.ColumnHeadersVisible = False
        
        DGTransformada.RowCount = 60
        DGTransformada.ColumnCount = 90
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
        DGTransformada.ClientSize = New Size(widthT, heightT + 30)
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
        Dim P As Double
        Dim PV As Integer
        Dim o, i, h As Integer
        Dim maxValor As Integer
        Dim xx, yy, xFuncion(180), yFuncion(180) As Integer

        maxValor = 0
        'o => X
        'P = Y
        For o = 0 To 89

            P = Valx * Math.Cos(o) + Valy * Math.Sin(o)
            'Desfazo 20 cuadros para que salga completa la figura sinoidal (sino se van al eje negativo de y)
            PV = Math.Round(P)

            'Imprimo si entra en la grilla
            If PV >= 0 And PV <= 59 Then
                'sumo 1 al valor actual, logrando asi que en las intersecciones se den los mayores valores
                DGTransformada.Rows(PV).Cells(o).Value = 1 + DGTransformada.Rows(PV).Cells(o).Value

            End If

        Next o

        For xx = 0 To 89
            For yy = 0 To 59
                If DGTransformada.Rows(yy).Cells(xx).Value > maxValor Then
                    maxValor = DGTransformada.Rows(yy).Cells(xx).Value
                End If
            Next yy
        Next xx

        For xx = 0 To 89
            For yy = 0 To 59
                If DGTransformada.Rows(yy).Cells(xx).Value = maxValor Then

                    DGTransformada.Rows(yy).Cells(xx).Style.BackColor = Color.Salmon
                    If maxValor > 1 Then
                        xFuncion(i) = xx
                        yFuncion(i) = yy
                        i = i + 1
                    End If
                Else
                    DGTransformada.Rows(yy).Cells(xx).Style.BackColor = Color.White
                End If
            Next yy
        Next xx

        DGTransformada.Refresh()
        ListBox1.Items.Clear()
        'lblFuncionFinal.Text = CStr(yFuncion) + "= x * cos(" + CStr(xFuncion) + ") + y * sen (" + CStr(xFuncion) + ")"

        For h = 0 To i - 1
            'lblFuncionFinal.Text = lblFuncionFinal.Text & "P=" & CStr(yFuncion(i)) & " O:" & CStr(xFuncion(1)) & " grados" & vbCrLf
            ListBox1.Items.Add("P=" & CStr(yFuncion(h)) & " O:" & CStr(xFuncion(h)) & " grados")
        Next


    End Function

   

    Private Sub DGImagen_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGImagen.CellContentClick

    End Sub
End Class

