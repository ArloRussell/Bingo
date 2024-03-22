Public Class host
    Private possible As New List(Of Integer)
    Private Sub host_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetGame()
    End Sub

    Private Sub ResetNums()
        possible.Clear()
        lblNum.Text = ""
        For i As Integer = 0 To 4
            Dim startpoint = (15 * i)
            For k As Integer = 1 To 15
                possible.Add(startpoint + k)
            Next
        Next
    End Sub

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        If possible.Count = 0 Then

            ResetNums()
        End If
        Dim rand As New Random
        Dim num As Integer = rand.Next(0, possible.Count)
        possible.RemoveAt(num)
        lblNum.Text = GetLetterWithNum(possible(num))
        lstPrevious.Items.Insert(0, lblNum.Text)
    End Sub
    Private Function GetLetterWithNum(num As Integer) As String
        Dim str As String = "?"
        Select Case num
            Case Is <= 15
                str = $"B{num}"
            Case Is <= 30
                str = $"I{num}"
            Case Is <= 45
                str = $"N{num}"
            Case Is <= 60
                str = $"G{num}"
            Case Is <= 75
                str = $"O{num}"
        End Select
        Return str
    End Function

    Private Sub ResetGame()
        ResetNums()
        lstPrevious.Items.Clear()

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetRToolStripMenuItem.Click
        ResetGame()
    End Sub

    Private Sub ReturnToMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToMenuToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
        board.Close()
    End Sub
End Class