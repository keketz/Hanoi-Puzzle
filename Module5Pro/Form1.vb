Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function NumberOfMoves(disk As Integer, F As Char, T As Char, A As Char, moves As Integer) As Integer
        'Once the disk is equal to 1, the result is printed and the function ends
        If (disk = 1) Then
            moves += 1
            lblResult.Text = moves
            Return moves
        End If

        'The Program Lags behind after 20, so this function does the math.
        If (disk > 12) Then
            moves = Math.Pow(2, disk) - 1
            lblResult.Text = moves
            Return moves
        End If

        'Recursion
        moves = NumberOfMoves(disk - 1, F, A, T, moves)
        moves += 1
        moves = NumberOfMoves(disk - 1, A, T, F, moves)
        Return moves
    End Function

    'Submit Button, Passes the input to the function and solves the result
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim disks As Integer = CInt(numberOfDisks.Text)
        Dim moves As Integer = 0
        NumberOfMoves(disks, "A", "C", "B", 0)
    End Sub
End Class

