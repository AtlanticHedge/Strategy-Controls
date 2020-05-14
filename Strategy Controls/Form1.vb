Public Class Form1
    Dim DataLoaded As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Strategies1TableAdapter.Fill(Me.DataSet11.Strategies1)
    End Sub

    Private Sub StratList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StratList.SelectedIndexChanged
        Me.StrategiesTableAdapter.Fill(Me.DataSet1.Strategies, StratList.Text)
        Me.BLMDataTableAdapter.Fill(Me.DataSet1.BLMData, StratList.Text)
        GetDirection()
        DataLoaded = True
        Calc_Capital()
        Calc_Targets()
    End Sub

    Private Sub SaveData_Click(sender As Object, e As EventArgs) Handles SaveData.Click
        Try
            Me.StrategiesBindingSource.EndEdit()
            Me.StrategiesTableAdapter.Update(Me.DataSet1.Strategies)
            Me.DataSet1.AcceptChanges()
        Catch ex As Exception
            OutPut("Save Data error: " & ex.Message, True)
        End Try
    End Sub

    Private Sub Calc_Targets()
        Try
            Dim Sname As String = StrategyDG.Rows(0).Cells(0).Value.ToString
            Dim BothDir As Boolean = IIf(StrategyDG.Rows(0).Cells(11).Value.ToString.Contains("B"), True, False)
            Dim r As Integer = 3
            Dim HC As Boolean = IIf(Sname.Contains("HC-"), True, False)

            Dim Last As Double
            Dim H_30D As Double
            Dim H_52w As Double
            Dim L_30D As Double
            Dim L_52w As Double
            Dim MA_10D As Double
            Dim MA_30D As Double
            Dim MA_200D As Double
            Dim Bol_L As Double
            Dim Bol_U As Double

            Dim UpperTgt As Double
            Dim LowerTgt As Double
            Dim UpperEntry As Double
            Dim LowerEntry As Double

            Dim LL As Double
            Dim HH As Double
            Dim LEA As Double
            Dim SEA As Double
            Dim LXA As Double
            Dim SXA As Double

            With BLMDG.Rows(0)
                Last = .Cells(0).Value
                H_30D = .Cells(4).Value
                H_52w = .Cells(5).Value
                L_30D = .Cells(6).Value
                L_52w = .Cells(7).Value
                MA_10D = .Cells(9).Value
                MA_30D = .Cells(10).Value
                MA_200D = .Cells(11).Value
                Bol_L = .Cells(13).Value
                Bol_U = .Cells(14).Value

                UpperTgt = IIf(HC, (Bol_U * 0.1 + H_30D * 0.1 + H_52w * 0.8), (Bol_U * 0.25 + H_30D * 0.75))
                LowerTgt = (Bol_L * 0.25 + L_30D * 0.75)

                UpperTgt = IIf(UpperTgt > 1 And BothDir, 1 - (LowerTgt - 1), UpperTgt)
                LowerTgt = IIf(LowerTgt < 1 And BothDir, 1 + (1 - UpperTgt), LowerTgt)

                LowerEntry = If(HC, (Bol_L * 0.15 + MA_30D * 0.85), (Bol_L * 0.4 + MA_30D * 0.6))
                UpperEntry = (Bol_U * 0.4 + MA_30D * 0.6)

                LowerEntry = IIf(LowerEntry > 1 And BothDir, 1 - (UpperEntry - 1), LowerEntry)
                UpperEntry = IIf(UpperEntry < 1 And BothDir, 1 + (1 - LowerEntry), UpperEntry)

                LL = Math.Min(Bol_L, L_52w)
                HH = Math.Max(Bol_U, H_52w)

                LL = IIf(LL > 1 And BothDir, 1 - (HH - 1), LL)
                HH = IIf(HH < 1 And BothDir, 1 + (1 - LL), HH)

                LEA = (LL - LowerEntry) * 10 / 9 * 2 / 3
                SEA = (HH - UpperEntry) * 10 / 9 * 2 / 3

                LXA = Math.Max(LEA / 2, (LowerEntry - UpperTgt) * 0.75)
                LXA = IIf(HC, Math.Min(LXA, (Bol_U * 0.5 + MA_30D * 0.5) - UpperTgt), LXA)
                SXA = Math.Min(SEA / 2, (UpperEntry - LowerTgt) * 0.75)

            End With

            With TargetDG.Rows(0)

                If LongCB.Checked Then
                    .Cells(2).Value = Math.Round(LowerEntry, r)
                    .Cells(3).Value = Math.Round(LEA, r)
                    .Cells(4).Value = Math.Round(UpperTgt, r)
                    .Cells(5).Value = Math.Round(LXA, r)
                Else
                    .Cells(2).Value = 0
                    .Cells(3).Value = 0
                    .Cells(4).Value = Math.Round(0.0001, r)
                    .Cells(5).Value = 0
                End If

                If ShortCB.Checked Then
                    .Cells(6).Value = Math.Round(UpperEntry, r)
                    .Cells(7).Value = Math.Round(SEA, r)
                    .Cells(8).Value = Math.Round(LowerTgt, r)
                    .Cells(9).Value = Math.Round(SXA, r)
                Else
                    .Cells(6).Value = Math.Round(HH * 2, r)
                    .Cells(7).Value = 0
                    .Cells(8).Value = Math.Round(HH * 2 - 0.0001, r)
                    .Cells(9).Value = 0
                End If
            End With

        Catch ex As Exception
            OutPut("Calc_Targets error: " & ex.Message, True)
        End Try
    End Sub

    Private Sub Calc_Capital()
        Try
            Dim LE As Double
            Dim LEA As Double
            Dim AveLE As Double
            Dim LAE As Double
            Dim LMove As Double
            Dim LSL As Double

            Dim SE As Double
            Dim SEA As Double
            Dim AveSE As Double
            Dim SAE As Double
            Dim SMove As Double
            Dim SSL As Double

            Dim MaxMove As Double
            Dim MaxVAR As Double

            With StrategyDG.Rows(0)
                LE = CDbl(.Cells(2).Value)
                LEA = CDbl(.Cells(3).Value)
                LAE = LE + LEA
                AveLE = (LE + LAE) / 2
                LSL = LE + 1.5 * LEA
                LMove = LSL / AveLE - 1

                SE = CDbl(.Cells(6).Value)
                SEA = CDbl(.Cells(7).Value)
                SAE = SE + SEA
                AveSE = (SE + SAE) / 2
                SSL = SE + SEA * 1.5
                SMove = -(SSL / AveSE - 1)

                MaxMove = Math.Min(LMove, SMove)             ' Set Entry limit at 2/3 of move to Worst level
                MaxVAR = CDbl(MVarTB.Text)
                MaxVARTB.Text = -Math.Round((MaxMove * 100), 1).ToString

                Dim PortAlgo As New List(Of String)(.Cells(1).Value.ToString.Split(","c))
                Dim Leverage As Double = CDbl(PortAlgo(2))

                Dim PosSize As Double = Math.Min(MaxVAR / (-MaxMove * Leverage), CDbl(PosLimTB.Text)) * 2           ' Strategy Exposure not stock
                MaxPosTB.Text = Math.Round(PosSize, 1).ToString

                Dim NewPortAlgo As String = PortAlgo(0) & "," & PortAlgo(1) & "," & PortAlgo(2) & "," & MaxPosTB.Text & "," & PortAlgo(4) & "," & PortAlgo(5)
                .Cells(1).Value = NewPortAlgo

            End With
        Catch ex As Exception
            OutPut("Calcs error: " & ex.Message, True)
        End Try

    End Sub

    Private Sub StrategyDG_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles StrategyDG.CellEndEdit
        Try
            Calc_Capital()
        Catch ex As Exception
            OutPut("Strategy Change Error: " & ex.Message, True)
        End Try
    End Sub

    Private Sub ApplyTgts_Click(sender As Object, e As EventArgs) Handles ApplyTgts.Click
        Try
            For i = 2 To 9
                StrategyDG.Rows(0).Cells(i).Value = TargetDG.Rows(0).Cells(i).Value
            Next
            StrategyDG.Rows(0).Cells(11).Value = TargetDG.Rows(0).Cells(11).Value
            Calc_Capital()
        Catch ex As Exception
            OutPut("Apply levels error: " & ex.Message, True)
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

    Private Sub GetDirection()
        Try
            Select Case TargetDG.Rows(0).Cells(11).Value.ToString
                Case "L"
                    LongCB.Checked = True
                    ShortCB.Checked = False
                Case "S"
                    LongCB.Checked = False
                    ShortCB.Checked = True
                Case "B"
                    LongCB.Checked = True
                    ShortCB.Checked = True
                Case Else
                    LongCB.Checked = False
                    ShortCB.Checked = False
            End Select
        Catch ex As Exception
            OutPut("GetDirection error: " & ex.Message, True)
        End Try
    End Sub

    Private Sub ShortCB_CheckedChanged(sender As Object, e As EventArgs) Handles ShortCB.CheckedChanged
        If DataLoaded Then SetDirection()
    End Sub

    Private Sub LongCB_CheckedChanged(sender As Object, e As EventArgs) Handles LongCB.CheckedChanged
        If DataLoaded Then SetDirection()
    End Sub

    Private Sub SetDirection()
        Try
            Dim setD As String = IIf(LongCB.Checked And ShortCB.Checked, "B", IIf(LongCB.Checked, "L", IIf(ShortCB.Checked, "S", "N")))
            TargetDG.Rows(0).Cells(11).Value = setD
            Calc_Targets()
        Catch ex As Exception
            OutPut("Set Direction Error: " & ex.Message, True)
        End Try
    End Sub
End Class
