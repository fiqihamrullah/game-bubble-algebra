Public Class Board
    Dim size As Integer
    Dim boardbubble(,) As ClassBubble
    Dim barisganti As Integer, kolomganti As Integer
    Dim tipegame As Integer
    Public Sub New(ByVal size As Integer, ByVal tipe As Integer)
        Me.size = size
        ReDim boardbubble(size, size)
        tipegame = tipe
        InitBubble()
    End Sub
    Private Function checkIsVariable(ByVal rowcol As Integer, ByVal n As Integer) As Boolean
        Dim i, j As Integer
        Dim tot As Integer
        Dim complete As Boolean = False
        tot = 0
        For i = 0 To size - 1
            If (rowcol = 0) Then
                If (boardbubble(n, i).IsVariable) Then
                    tot += 1
                End If
            End If

            If (rowcol = 1) Then
                If (boardbubble(i, n).IsVariable) Then
                    tot += 1
                End If
            End If
        Next i
        If (tot = size) Then
            complete = True
        End If
        Return complete
    End Function
    Private Function checkSameCoeff(ByVal rowcol As Integer, ByVal n As Integer, ByVal koef As String) As Boolean
        Dim i, j As Integer
        Dim tot As Integer
        Dim complete As Boolean = False
        tot = 0
        For i = 0 To size - 1
            If (rowcol = 0) Then
                If (boardbubble(n, i).IsCoefficient) And boardbubble(n, i).Value = koef Then
                    tot += 1
                End If
            End If

            If (rowcol = 1) Then
                If (boardbubble(i, n).IsCoefficient) And boardbubble(i, n).Value = koef Then
                    tot += 1
                End If
            End If
        Next i
        If (tot = size) Then
            complete = True
        End If
        Return complete
    End Function
    Private Function checkSamePower(ByVal rowcol As Integer, ByVal n As Integer) As Boolean
        Dim i, j As Integer
        Dim tot As Integer
        Dim complete As Boolean = False
        tot = 0
        'Check Pangkat Satu
        For i = 0 To size - 1
            If (rowcol = 0) Then
                If (boardbubble(n, i).IsCoefficient) Then
                    tot += 1
                End If
            End If

            If (rowcol = 1) Then
                If (boardbubble(i, n).IsCoefficient) Then
                    tot += 1
                End If
            End If
        Next i
        If (tot = size) Then
            complete = True
        End If

        'Check Pangkat PolyNomial
        If (complete = False) Then
            tot = 0
            For i = 0 To size - 2
                If (rowcol = 0) Then
                    If (boardbubble(n, i).Value = boardbubble(n, i + 1).Value) Then
                        tot += 1
                    End If
                End If

                If (rowcol = 1) Then
                    If (boardbubble(i, n).Value = boardbubble(i + 1, n).Value) Then
                        tot += 1
                    End If
                End If
            Next i

            If (tot = size - 1) Then
                complete = True
            End If
        End If


        Return complete
    End Function

    Private Function checkConstant(ByVal rowcol As Integer, ByVal n As Integer) As Boolean
        Dim i, j As Integer
        Dim tot As Integer
        Dim complete As Boolean = False
        tot = 0
        For i = 0 To size - 1
            If (rowcol = 0) Then
                If (boardbubble(n, i).IsConstant) Then
                    tot += 1
                End If
            End If

            If (rowcol = 1) Then
                If (boardbubble(i, n).IsConstant) Then
                    tot += 1
                End If
            End If
        Next i
        If (tot = size) Then
            complete = True
        End If
        Return complete
    End Function
    Private Sub InitBubble()
        Dim ble As New ClassBubble
        Dim rand As New Random
        Dim n As Double
        Dim v As Integer

        Dim i, j As Integer
        For i = 0 To size - 1
            For j = 0 To size - 1
                ble = New ClassBubble()
                'Game 1
                If (tipegame = 1) Then
                    n = rand.NextDouble()
                    If (n < 0.6) Then
                        v = rand.Next(1, 20)
                        ble.IsConstant = True
                        ble.Value = v
                    ElseIf (n < 1) Then
                        v = rand.Next(97, 122)
                        ble.IsVariable = True
                        ble.Value = ChrW(v)
                    End If
                ElseIf (tipegame = 2) Then
                    n = rand.NextDouble()
                    ble.IsCoefficient = True
                    If (n < 0.3) Then
                        ble.Value = "x"
                    ElseIf (n < 0.6) Then
                        ble.Value = "2x"
                    ElseIf (n <= 1) Then
                        ble.Value = "3x"
                    End If
                ElseIf (tipegame = 3) Then
                    n = rand.NextDouble()
                    If (n < 0.5) Then
                        ble.IsCoefficient = True
                        v = rand.Next(1, 20)
                        ble.Value = v.ToString() + "x"
                    ElseIf (n <= 1) Then
                        ble.IsCoefficient = False
                        v = rand.Next(2, 4)
                        ble.Value = "x" + v.ToString()
                    End If

                End If
                boardbubble(i, j) = ble

            Next j
        Next i
        If (tipegame = 1) Then
            CheckGame1Fitness()
        ElseIf (tipegame = 2) Then
            CheckGame2Fitness()
        End If
    End Sub
    Private Sub CheckGame1Fitness()
        Dim n As Double
        Dim v As Integer
        Dim rand As New Random
        Dim i, j As Integer
        Dim ada As Boolean = False
        Dim idx As Integer
        For i = 0 To size - 1
            'Check Vertical
            If (checkConstant(1, i)) Then
                '   System.Diagnostics.Trace.WriteLine("Ada Const di Col " + (i + 1).ToString())
                v = rand.Next(97, 122)
                idx = rand.Next(0, size)
                'System.Diagnostics.Trace.WriteLine("idx : " + (idx + 1).ToString())
                boardbubble(idx, i).IsConstant = False
                boardbubble(idx, i).IsVariable = True
                boardbubble(idx, i).Value = ChrW(v)
                'System.Diagnostics.Trace.WriteLine("v: " + v.ToString())
            End If
            'Check Horizontal
            If (checkConstant(0, i)) Then
                '  System.Diagnostics.Trace.WriteLine("Ada Const di Baris " + (i + 1).ToString())
                v = rand.Next(97, 122)
                idx = rand.Next(0, size)
                'System.Diagnostics.Trace.WriteLine("idx : " + (idx + 1).ToString())
                boardbubble(i, idx).IsConstant = False
                boardbubble(i, idx).IsVariable = True
                boardbubble(i, idx).Value = ChrW(v)
                ' System.Diagnostics.Trace.WriteLine("v: " + v)
            End If
        Next i


        For i = 0 To size - 1
            'Check Vertical
            If (checkIsVariable(1, i)) Then
                System.Diagnostics.Trace.WriteLine("Ada Var di Col " + (i + 1).ToString())
                v = rand.Next(1, 20)
                idx = rand.Next(0, size)
                boardbubble(idx, i).IsConstant = True
                boardbubble(idx, i).IsVariable = False
                boardbubble(idx, i).Value = v
            End If
            'Check Horizontal
            If (checkIsVariable(0, i)) Then
                System.Diagnostics.Trace.WriteLine("Ada Var di Baris " + (i + 1).ToString())
                v = rand.Next(1, 20)
                idx = rand.Next(0, size)
                boardbubble(i, idx).IsConstant = True
                boardbubble(i, idx).IsVariable = False
                boardbubble(i, idx).Value = v

            End If
        Next i
    End Sub

    Private Sub CheckGame2Fitness()
        Dim n As Double
        Dim v As Integer
        Dim rand As New Random
        Dim i, j As Integer
        Dim ada As Boolean = False
        Dim idx As Integer
        For i = 0 To size - 1
            'Check Vertical
            idx = rand.Next(0, size)
            If (checkSameCoeff(1, i, "x")) Then
                boardbubble(idx, i).Value = "2x"
            End If

            If (checkSameCoeff(1, i, "2x")) Then
                boardbubble(idx, i).Value = "3x"
            End If

            If (checkSameCoeff(1, i, "3x")) Then
                boardbubble(idx, i).Value = "x"
            End If

            'Check Horizontal
            If (checkSameCoeff(0, i, "x")) Then
                boardbubble(i, idx).Value = "2x"
            End If

            If (checkSameCoeff(0, i, "2x")) Then
                boardbubble(i, idx).Value = "3x"
            End If

            If (checkSameCoeff(0, i, "3x")) Then
                boardbubble(i, idx).Value = "x"
            End If 
        Next i 
    End Sub
    Private Sub CheckGame3Fitness()
        Dim n As Double
        Dim v As Integer
        Dim rand As New Random
        Dim i, j As Integer
        Dim ada As Boolean = False
        Dim idx As Integer
        For i = 0 To size - 1
            'Check Vertical

            If (checkSamePower(1, i)) Then
                idx = rand.Next(0, size)
                boardbubble(idx, i).IsCoefficient = False
                v = rand.Next(2, 4)
                boardbubble(idx, i).Value = "x" + v.ToString()
            End If
 

            'Check Horizontal
            If (checkSamePower(0, i)) Then
                idx = rand.Next(0, size)
                boardbubble(i, idx).IsCoefficient = False
                v = rand.Next(2, 4)
                boardbubble(idx, i).Value = "x" + v.ToString()
            End If

            
        Next i 
    End Sub
    Private Sub allLineRed(ByVal ibaris As Integer)
        For j = 0 To size - 1
            boardbubble(ibaris, j).Gambar = My.Resources.bubblebinggo
            boardbubble(ibaris, j).IsBubbleBingo = True
        Next j
    End Sub
    Public Sub ChangeBubble()
        If (barisganti <> -1) Then
            ChangeBubbleRow(barisganti)
        End If

        If (kolomganti <> -1) Then
            ChangeBubblCol(kolomganti)
        End If
    End Sub
    Private Sub ChangeBubbleRow(ByVal ibaris As Integer)
        Dim ble As New ClassBubble
        Dim rand As New Random
        Dim n As Double
        Dim v As Integer
        Dim i, j As Integer
        For j = 0 To size - 1
            ble = New ClassBubble()
            'Game 1
            If (tipegame = 1) Then
                n = rand.NextDouble()
                If (n < 0.6) Then
                    v = rand.Next(1, 20)
                    ble.IsConstant = True
                    ble.Value = v
                ElseIf (n < 1) Then
                    v = rand.Next(97, 122)
                    ble.IsVariable = True
                    ble.Value = ChrW(v)
                End If
            ElseIf (tipegame = 2) Then
                n = rand.NextDouble()
                ble.IsCoefficient = True
                If (n < 0.3) Then
                    ble.Value = "x"
                ElseIf (n < 0.6) Then
                    ble.Value = "2x"
                ElseIf (n <= 1) Then
                    ble.Value = "3x"
                End If
            ElseIf (tipegame = 3) Then
                n = rand.NextDouble()
                If (n < 0.5) Then
                    ble.IsCoefficient = True
                    v = rand.Next(1, 20)
                    ble.Value = v.ToString() + "x"
                ElseIf (n <= 1) Then
                    ble.IsCoefficient = False
                    v = rand.Next(2, 4)
                    ble.Value = "x" + v.ToString()
                End If

            End If

            boardbubble(ibaris, j) = ble
        Next j

    End Sub
    Private Sub ChangeBubblCol(ByVal icol As Integer)
        Dim ble As New ClassBubble
        Dim rand As New Random
        Dim n As Double
        Dim v As Integer
        Dim i, j As Integer
        For j = 0 To size - 1
            ble = New ClassBubble()
            'Game 1
            If (tipegame = 1) Then
                n = rand.NextDouble()
                If (n < 0.6) Then
                    v = rand.Next(1, 20)
                    ble.IsConstant = True
                    ble.Value = v
                ElseIf (n < 1) Then
                    v = rand.Next(97, 122)
                    ble.IsVariable = True
                    ble.Value = ChrW(v)
                End If
            ElseIf (tipegame = 2) Then
                n = rand.NextDouble()
                ble.IsCoefficient = True
                If (n < 0.3) Then
                    ble.Value = "x"
                ElseIf (n < 0.6) Then
                    ble.Value = "2x"
                ElseIf (n <= 1) Then
                    ble.Value = "3x"
                End If
            ElseIf (tipegame = 3) Then
                n = rand.NextDouble()
                If (n < 0.5) Then
                    ble.IsCoefficient = True
                    v = rand.Next(1, 20)
                    ble.Value = v.ToString() + "x"
                ElseIf (n <= 1) Then
                    ble.IsCoefficient = False
                    v = rand.Next(2, 4)
                    ble.Value = "x" + v.ToString()
                End If

            End If

            boardbubble(j, icol) = ble
        Next j

    End Sub
    Private Sub allColRed(ByVal icol As Integer)
        For j = 0 To size - 1
            boardbubble(j, icol).Gambar = My.Resources.bubblebinggo
            boardbubble(j, icol).IsBubbleBingo = True
        Next j
    End Sub
    Public Function Check() As Boolean
        Dim bingo As Boolean = False
        barisganti = -1
        kolomganti = -1
        For i = 0 To size - 1


            If (tipegame = 1) Then
                'Check Horizontal
                If (checkConstant(0, i)) Then
                    allLineRed(i)
                    mystat.score += 10
                    barisganti = i
                    bingo = True

                ElseIf (checkIsVariable(0, i)) Then
                    allLineRed(i)
                    mystat.score += 10
                    barisganti = i
                    bingo = True
                End If

                'Check Vertical
                If (checkConstant(1, i)) Then
                    allColRed(i)
                    mystat.score += 10
                    kolomganti = i
                    bingo = True
                ElseIf checkIsVariable(1, i) Then
                    allColRed(i)
                    mystat.score += 10
                    kolomganti = i
                    bingo = True
                End If
            ElseIf tipegame = 2 Then
                'Check Horizontal
                If (checkSameCoeff(0, i, "x")) Then
                    allLineRed(i)
                    mystat.score += 10
                    barisganti = i
                    bingo = True

                ElseIf (checkSameCoeff(0, i, "2x")) Then
                    allLineRed(i)
                    mystat.score += 10
                    barisganti = i
                    bingo = True
                ElseIf (checkSameCoeff(0, i, "3x")) Then
                    allLineRed(i)
                    mystat.score += 10
                    barisganti = i
                    bingo = True
                End If

                'Check Vertikal
                If (checkSameCoeff(1, i, "x")) Then
                    allColRed(i)
                    mystat.score += 10
                    kolomganti = i
                    bingo = True

                ElseIf (checkSameCoeff(1, i, "2x")) Then
                    allColRed(i)
                    mystat.score += 10
                    kolomganti = i
                    bingo = True
                ElseIf (checkSameCoeff(1, i, "3x")) Then
                    allColRed(i)
                    mystat.score += 10
                    kolomganti = i
                    bingo = True
                End If
            ElseIf (tipegame = 3) Then
                If (checkSamePower(0, i)) Then
                    allLineRed(i)
                    mystat.score += 10
                    barisganti = i
                    bingo = True
                End If
                If (checkSamePower(1, i)) Then
                    allColRed(i)
                    mystat.score += 10
                    kolomganti = i
                    bingo = True
                End If
            End If
                If bingo = True Then
                    Exit For
                End If

        Next i
        Return bingo
    End Function
    Public Sub NormalizeActiveBubble()
        Dim i, j As Integer
        For i = 0 To size - 1
            For j = 0 To size - 1
                boardbubble(i, j).Gambar = My.Resources.bubbleaktif
                boardbubble(i, j).IsSelected = False
            Next j
        Next i
    End Sub
    Public Function GetBubble(ByVal i As Integer, ByVal j As Integer) As ClassBubble
        Return boardbubble(i, j)
    End Function

End Class
