Imports System.Media
Imports System.ComponentModel
Public Class FrmPlay
    Dim awalx As Integer, akhirx As Integer
    Dim awaly As Integer, akhiry As Integer
    Dim renggangx As Integer
    Dim renggangy As Integer
    Dim nxn As Integer
    Dim globalx As Integer
    Dim globaly As Integer
    Dim jatahwaktu() As Integer = {90, 180, 240}

    Dim gridlevel() As Integer = {3, 5, 10}
    Dim timenow As Integer
    Dim bGameStart As Boolean
    Dim animatedBubbleDestroy As Boolean
    Dim bykkedip As Integer
    Dim checkagain As Boolean
    Dim sndpback As SoundPlayer

    Private Structure GridPoint
        Dim row As Integer
        Dim col As Integer
    End Structure
    Dim cp As GridPoint
    Dim cplama As GridPoint
    Dim boardbbl As Board
    Dim bubbleselected As ClassBubble
    Private Function GetGridPoint(ByVal x As Integer, ByVal y As Integer) As GridPoint
        Dim sp As GridPoint
        If (renggangx <> 0) Then
            sp.col = ((x - awalx) \ renggangx) + 1
            sp.row = ((y - awaly) \ renggangy) + 1
        Else
            sp.col = 0
            sp.row = 0
        End If
        If (sp.col > nxn) Then
            sp.col = nxn
        End If
        If (sp.row > nxn) Then
            sp.row = nxn
        End If
        Return sp
    End Function
    Public Sub PlayBack()
        Dim th As Threading.Thread
        th = New Threading.Thread(AddressOf PlayBackGroundSound)

        th.IsBackground = True

        th.Start()


    End Sub
    Private Sub PlayBackGroundSound()
        Dim mediax As New System.Windows.Media.MediaPlayer()

        mediax.Open(New System.Uri(Application.StartupPath + "/back.mp3"))
        Dim ts As TimeSpan = mediax.Position

        While bGameStart = True
            mediax.Play()
            If (mediax.Position = mediax.NaturalDuration) Then
                mediax.Position = ts
            End If

        End While
        mediax.Stop()
        ' sndpback.Load()
        '   AddHandler sndpback.LoadCompleted, AddressOf wavPlayer_LoadCompleted
        '  sndpback.LoadAsync()
    End Sub
    Private Sub FrmPlay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StartGame(1, 1, 0)
        UpdateStat()
        bGameStart = True
        PlayBack()

    End Sub
    Private Sub wavPlayer_LoadCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        CType(sender, System.Media.SoundPlayer).Play()
    End Sub
    Private Sub StartGame(ByVal curGame As Integer, ByVal curLevel As Integer, ByVal curscore As Integer)

        bubbleselected = Nothing
        mystat.currentGame = curGame

        If (mystat.currentGame = 1) Then
            lblPetunjuk.Text = ModulBantu.PetunjukGame1
        ElseIf (mystat.currentGame = 2) Then
            lblPetunjuk.Text = ModulBantu.PetunjukGame2
        End If

        mystat.currentLevel = curLevel
        mystat.score = curscore
        timenow = jatahwaktu(mystat.currentLevel - 1)
        nxn = gridlevel(mystat.currentLevel - 1)

        awalx = 10
        akhirx = pbKotakGrid.Width - 10
        awaly = 10
        akhiry = pbKotakGrid.Height - 10
        renggangx = (akhirx - awalx) / nxn
        renggangy = (akhiry - awaly) / nxn

        boardbbl = New Board(nxn, mystat.currentGame)
        boardbbl.NormalizeActiveBubble()
        cplama = New GridPoint()
        cplama.col = -1
        cplama.row = -1

        Timer1.Enabled = True
        UpdateStat()

    End Sub
    Private Sub UpdateStat()
        lblGame.Text = "Game " + mystat.currentGame.ToString()
        lbllevel.Text = mystat.currentLevel.ToString()
        lblPlayer.Text = mystat.nmplayer
        lblScore.Text = mystat.score
    End Sub
    Private Sub FrmPlay_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

    End Sub
    Private Sub pbKotakGrid_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbKotakGrid.Paint
        Dim i As Integer, j As Integer
        Dim col, row As Integer
        Dim g As Graphics

        g = e.Graphics


        For row = 0 To nxn - 1
            For col = 0 To nxn - 1

                g.FillRectangle(Brushes.Black, awalx + ((col) * renggangx), awaly + ((row) * renggangy), renggangx, renggangy)

            Next col
        Next row


        'g.FillRectangle(Brushes.Gold, awalx + ((cp.col - 1) * renggangx), awaly + ((cp.row - 1) * renggangy), renggangx, renggangy)


        For i = 0 To nxn - 1
            For j = 0 To nxn - 1
                If Not (boardbbl.GetBubble(i, j).IsBubbleBingo) Then
                    g.DrawImage(boardbbl.GetBubble(i, j).Gambar, awalx + ((j) * renggangx), awaly + ((i) * renggangy), renggangx, renggangy)
                    g.DrawString(boardbbl.GetBubble(i, j).Value, New Font("verdana", 18 - ((mystat.currentLevel - 1) * 3), FontStyle.Bold), Brushes.Yellow, ((awalx + (j * renggangx)) + (renggangx / 2)) - (renggangx / (10 - ((mystat.currentLevel - 1) * 3))), (awaly + (i * renggangy) + (renggangy / 2)) - (renggangy / (10 - ((mystat.currentLevel - 1) * 3))))
                Else
                    If (animatedBubbleDestroy) Then
                        g.DrawImage(My.Resources.bubblebinggo, awalx + ((j) * renggangx), awaly + ((i) * renggangy), renggangx, renggangy)
                        g.DrawString(boardbbl.GetBubble(i, j).Value, New Font("verdana", 18 - ((mystat.currentLevel - 1) * 3), FontStyle.Bold), Brushes.Yellow, ((awalx + (j * renggangx)) + (renggangx / 2)) - (renggangx / (10 - ((mystat.currentLevel - 1) * 3))), (awaly + (i * renggangy) + (renggangy / 2)) - (renggangy / (10 - ((mystat.currentLevel - 1) * 3))))
                    End If
                End If



            Next j
        Next i

        Dim posborder As Integer = 0
        For i = awalx To akhirx + renggangx Step renggangx
            If (posborder Mod nxn = 0) Then
                g.DrawLine(New Pen(Color.Olive, 3), i, awaly, i, akhiry)
                posborder = 0
            Else
                g.DrawLine(New Pen(Color.Crimson), i, awaly, i, akhiry)
            End If

            posborder += 1
        Next i
        posborder = 0
        For i = awaly To akhiry Step renggangy
            If (posborder Mod nxn = 0) Then
                g.DrawLine(New Pen(Color.Olive, 3), awalx, i, akhirx, i)
                posborder = 0
            Else
                g.DrawLine(New Pen(Color.Crimson), awalx, i, akhirx, i)
            End If

            posborder += 1
        Next i
    End Sub
    Private Sub pbKotakGrid_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbKotakGrid.MouseMove
        globalx = e.X
        globaly = e.Y
        cp = GetGridPoint(globalx, globaly)
        System.Diagnostics.Trace.WriteLine("Row: " + cp.row.ToString() + ",Col:" + cp.col.ToString())
        If (cplama.col > -1 And cplama.row > -1) Then
            If (boardbbl.GetBubble(cplama.row - 1, cplama.col - 1).IsSelected = False) Then
                boardbbl.GetBubble(cplama.row - 1, cplama.col - 1).Gambar = My.Resources.bubbleaktif
            End If
        End If
        If (boardbbl.GetBubble(cp.row - 1, cp.col - 1).IsSelected = False) Then
            boardbbl.GetBubble(cp.row - 1, cp.col - 1).Gambar = My.Resources.bubblehover
        End If
        cplama = cp
        pbKotakGrid.Invalidate()
    End Sub
    Private Sub pbKotakGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbKotakGrid.Click
        ModulBantu.SuaraKlik()

        boardbbl.GetBubble(cp.row - 1, cp.col - 1).IsSelected = Not boardbbl.GetBubble(cp.row - 1, cp.col - 1).IsSelected
        If Not (bubbleselected Is Nothing) Then
            bubbleselected.IsSelected = False
            bubbleselected.Gambar = My.Resources.bubbleaktif

        End If

        If (boardbbl.GetBubble(cp.row - 1, cp.col - 1).IsSelected) Then
            boardbbl.GetBubble(cp.row - 1, cp.col - 1).Gambar = My.Resources.bubbleselected
            If Not (bubbleselected Is Nothing) Then
                Dim tempbubble As New ClassBubble
                tempbubble.Gambar = boardbbl.GetBubble(cp.row - 1, cp.col - 1).Gambar
                tempbubble.IsCoefficient = boardbbl.GetBubble(cp.row - 1, cp.col - 1).IsCoefficient
                tempbubble.IsConstant = boardbbl.GetBubble(cp.row - 1, cp.col - 1).IsConstant
                tempbubble.IsVariable = boardbbl.GetBubble(cp.row - 1, cp.col - 1).IsVariable
                tempbubble.IsSelected = boardbbl.GetBubble(cp.row - 1, cp.col - 1).IsSelected
                tempbubble.Value = boardbbl.GetBubble(cp.row - 1, cp.col - 1).Value

                boardbbl.GetBubble(cp.row - 1, cp.col - 1).Value = bubbleselected.Value
                boardbbl.GetBubble(cp.row - 1, cp.col - 1).IsSelected = False ' bubbleselected.IsSelected
                boardbbl.GetBubble(cp.row - 1, cp.col - 1).IsVariable = bubbleselected.IsVariable
                boardbbl.GetBubble(cp.row - 1, cp.col - 1).IsConstant = bubbleselected.IsConstant
                boardbbl.GetBubble(cp.row - 1, cp.col - 1).IsCoefficient = bubbleselected.IsCoefficient

                bubbleselected.Value = tempbubble.Value
                bubbleselected.IsCoefficient = tempbubble.IsCoefficient
                bubbleselected.IsConstant = tempbubble.IsConstant
                bubbleselected.IsSelected = tempbubble.IsSelected
                bubbleselected.IsVariable = tempbubble.IsVariable
                bubbleselected.Value = tempbubble.Value
                bubbleselected = Nothing
            Else
                bubbleselected = boardbbl.GetBubble(cp.row - 1, cp.col - 1)
            End If

            'boardbbl.GetBubble(cplama.row - 1, cplama.col - 1).IsSelected = False
        Else
            boardbbl.GetBubble(cp.row - 1, cp.col - 1).Gambar = My.Resources.bubbleaktif
            bubbleselected = Nothing
        End If
        checkagain = boardbbl.Check()
        If checkagain Then
            ModulBantu.SoundBubbleDestroy()
        End If
        tmranimasion.Start()
        'System.Diagnostics.Trace.WriteLine("Row: " + (cp.row - 1).ToString())
        pbKotakGrid.Invalidate()
    End Sub
    Private Function ConvertTime(ByVal waktu As Integer) As String
        Dim menit As Integer, detik As Integer
        Dim strwaktu As String
        menit = waktu \ 60
        detik = waktu Mod 60
        strwaktu = menit.ToString() + ":" + detik.ToString()
        Return strwaktu
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = ConvertTime(timenow)
        timenow -= 1
        If (timenow = 0) Then
            Dim frmmessage As New FrmShowMessage
            If (mystat.currentLevel <= 3) Then
                Timer1.Stop()
                If (mystat.currentLevel = 3) Then
                    If (mystat.currentGame < 3) Then
                        frmmessage.SetMessage("Game " + mystat.currentGame.ToString() + " , Level " + mystat.currentLevel.ToString() + " Berakhir" + Chr(13) + "Lanjut Game Selanjutnya >> ")
                        ModulBantu.SoundNextLevel()
                        frmmessage.ShowDialog()
                        StartGame(mystat.currentGame + 1, 1, mystat.score)
                    Else
                        bGameStart = False
                        ModulBantu.SoundGameOver()
                        frmmessage.SetMessage("Game Berakhir!" + Chr(13) + "Skor Anda " + mystat.score.ToString())
                        frmmessage.ShowDialog()
                        Me.Dispose()
                    End If
                Else
                    frmmessage.SetMessage("Game " + mystat.currentGame.ToString() + " , Level " + mystat.currentLevel.ToString() + " Berakhir" + Chr(13) + "Lanjut Stage Selanjutnya >> ")
                    ModulBantu.SoundNextLevel()
                    frmmessage.ShowDialog()
                    StartGame(mystat.currentGame, mystat.currentLevel + 1, mystat.score)
                End If

            End If

        End If
    End Sub
    Private Sub tmranimasion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmranimasion.Tick
        animatedBubbleDestroy = Not animatedBubbleDestroy
        pbKotakGrid.Invalidate()
        bykkedip += 1
        If (bykkedip = 12) Then
            bubbleselected = Nothing
            bykkedip = 0
            boardbbl.ChangeBubble()
            boardbbl.NormalizeActiveBubble()
            UpdateStat()
            pbKotakGrid.Invalidate()
            If (checkagain) Then
                checkagain = boardbbl.Check()
                If (checkagain) Then
                    ModulBantu.SoundBubbleDestroy()

                End If
            Else
                tmranimasion.Stop()
            End If
        End If
    End Sub
End Class