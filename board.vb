Imports System.Xml

Public Class board
    Private Sub board_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetBoard()
        PopTitle()
    End Sub

    Private Sub ResetBoard()
        pnlBoard.Controls.Clear()
        Dim btnWidth As Integer = pnlBoard.Width / 5
        Dim btnHeight As Integer = pnlBoard.Height / 5
        Dim rand As New Random()


        For i As Integer = 0 To 4
            Dim startpoint = (15 * i)
            Dim possible As New List(Of Integer)
            For k As Integer = 1 To 15
                possible.Add(startpoint + k)
            Next
            For j As Integer = 0 To 4
                Dim index As Integer = rand.Next(0, possible.Count)
                Dim txt As String = possible(index).ToString
                If i = 2 AndAlso j = 2 Then
                    txt = "Free Space"
                End If
                Dim btn As New Button With {
                    .Text = txt,
                    .Location = New Point(btnWidth * i, btnHeight * j),
                    .Width = btnWidth,
                    .Height = btnHeight,
                    .Font = New Font("Kristen ITC", 12)
                }
                possible.RemoveAt(index)
                If i = 2 AndAlso j = 2 Then
                    btn.BackColor = System.Drawing.Color.FromArgb(250, 255, 243, 104)
                Else
                    AddHandler btn.Click, AddressOf Me.btn_Click
                End If

                pnlBoard.Controls.Add(btn)
            Next
        Next

    End Sub

    Private Sub btn_Click(sender As Button, e As EventArgs)
        If sender.BackColor = System.Drawing.Color.FromArgb(250, 255, 243, 104) Then
            sender.BackColor = Color.White
        Else
            sender.BackColor = System.Drawing.Color.FromArgb(250, 255, 243, 104)
        End If

    End Sub

    Private Sub PopTitle()
        Dim letter As String = "No"
        Dim lblWidth As Integer = pnlTitle.Width / 5
        Dim lblHeight As Integer = pnlTitle.Height
        For i As Integer = 0 To 4
            Select Case True
                Case i = 0
                    letter = "B"
                Case i = 1
                    letter = "I"
                Case i = 2
                    letter = "N"
                Case i = 3
                    letter = "G"
                Case i = 4
                    letter = "O"
            End Select
            Dim lbl As New Label With {
                .Text = letter,
                .Width = lblWidth,
                .Height = lblHeight,
                .Location = New Point(lblWidth * i, 0),
                .AutoSize = False,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Font = New Font("Kristen ITC", 12)
            }
            pnlTitle.Controls.Add(lbl)
        Next
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ResetBoard()
    End Sub

    Private Sub ReturnToMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToMenuToolStripMenuItem.Click
        Form1.Show()
        host.Close()
        Me.Close()
    End Sub
End Class