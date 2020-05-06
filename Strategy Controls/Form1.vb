Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Strategies1TableAdapter.Fill(Me.DataSet11.Strategies1)
    End Sub

    Private Sub StratList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StratList.SelectedIndexChanged
        Me.StrategiesTableAdapter.Fill(Me.DataSet1.Strategies, StratList.Text)
        Calcs()
    End Sub

    Private Sub Mirror_Click(sender As Object, e As EventArgs) Handles Mirror.Click
        Try
            Dim R As Integer = StrategyDG.Rows.Count

            For i = 1 To R - 1
                For j = 2 To StrategyDG.ColumnCount - 1
                    With StrategyDG
                        .Rows(i).Cells(j).Value = .Rows(0).Cells(j).Value
                    End With
                Next
            Next

        Catch ex As Exception
            OutPut("Mirror error: " & ex.Message, True)
        End Try
    End Sub

    Private Sub SaveData_Click(sender As Object, e As EventArgs) Handles SaveData.Click
        Try
            Me.StrategiesTableAdapter.Update(Me.DataSet1.Strategies)
            Me.DataSet1.AcceptChanges()
        Catch ex As Exception
            OutPut("Save Data error: " & ex.Message, True)
        End Try
    End Sub

    Private Sub Calcs()
        Try
            Dim AveLE As Double
            Dim LAE As Double
            Dim LMove As Double

            Dim AveSE As Double
            Dim SAE As Double
            Dim SMove As Double

            Dim MaxMove As Double
            Dim MaxVAR As Double

            With StrategyDg.rows(0)
                LAE = CDbl(.cells(12).value) + CDbl(.cells(13).value)
                AveLE = (CDbl(.cells(12).value) + LAE) / 2
                LMove = LAE / AveLE - 1

                SAE = CDbl(.cells(16).value) + CDbl(.cells(17).value)
                AveSE = (CDbl(.cells(16).value) + SAE) / 2
                SMove = -(SAE / AveSE - 1)

                MaxMove = Math.Min(LMove, SMove) * 1.5            ' Set Entry limit at 2/3 of move to Worst level
                MaxVAR = CDbl(MVarTB.Text)

                Dim PortAlgo As New List(Of String)(.Cells(3).Value.ToString.Split(","c))

                Dim Leverage As Double = CDbl(PortAlgo(2))

                Dim PosSize As Double = Math.Min(MaxVAR / (-MaxMove * Leverage), CDbl(PosLimTB.Text))

                MaxVARTB.Text = Math.Round((MaxMove * 100), 1).ToString

                MaxPosTB.Text = Math.Round(PosSize, 1).ToString

                Dim NewPortAlgo As String = PortAlgo(0) & "," & PortAlgo(1) & "," & PortAlgo(2) & "," & MaxPosTB.Text & "," & PortAlgo(4)
                .Cells(3).Value = NewPortAlgo

            End With
        Catch ex As Exception
            Output("Calcs error: " & ex.message, True)
        End Try

    End Sub

    Private Sub StrategyDG_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles StrategyDG.CellEndEdit
        Try
            Calcs()
        Catch ex As Exception
            OutPut("Strategy Change Error: " & ex.Message, True)
        End Try
    End Sub

#Region "Supporting Subs"

    Private Sub OutPut(msg As String, IsError As Boolean)
        ErrorTB.Text = msg
        If IsError Then
            ErrorTB.BackColor = Color.Orange
        Else
            ErrorTB.BackColor = Color.DimGray
        End If
    End Sub

    Private Sub StrategyDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

#End Region

    

End Class
