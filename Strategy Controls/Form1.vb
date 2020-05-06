Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Strategies1TableAdapter.Fill(Me.DataSet11.Strategies1)
    End Sub

    Private Sub StratList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StratList.SelectedIndexChanged
        Me.StrategiesTableAdapter.Fill(Me.DataSet1.Strategies, StratList.Text)
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

#Region "Supporting Subs"

    Private Sub OutPut(msg As String, IsError As Boolean)
        ErrorTB.Text = msg
        If IsError Then
            ErrorTB.BackColor = Color.Orange
        Else
            ErrorTB.BackColor = Color.DimGray
        End If
    End Sub

#End Region

    
End Class
