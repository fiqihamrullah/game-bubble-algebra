Imports System.Media
Public Structure GameStat
    Dim currentGame As Integer
    Dim currentLevel As Integer
    Dim nmplayer As String
    Dim score As Integer



End Structure

Module ModulBantu
    Public Const PetunjukGame1 As String = "Kelompokkan Bubble Algebra Antara Konstanta dengan Konstanta Dan Variabel dengan Variabel"
    Public Const PetunjukGame2 As String = "Kelompokkan/Jodohkan Bubble Algebra Antara Koefisien yang sama"
    Public Const PetunjukGame3 As String = "Kelompokkan/Jodohkan Bubble Algebra Antara Koefisien yang sama"
    Public mystat As GameStat
 

    Public Sub SuaraKlik()

        Dim sndP As New SoundPlayer(My.Resources.click)
        ' If (gs.adasuara) Then
        sndP.Play()
        '  End If

    End Sub

    Public Sub SoundBubbleDestroy()

        Dim sndP As New SoundPlayer(My.Resources.draw)
        ' If (gs.adasuara) Then
        sndP.Play()
        '  End If

    End Sub

    Public Sub SoundNextLevel()

        Dim sndP As New SoundPlayer(My.Resources.winnerofgame)
        ' If (gs.adasuara) Then
        sndP.Play()
        ' End If

    End Sub

    Public Sub SoundGameOver()

        Dim sndP As New SoundPlayer(My.Resources.gameover)
        'If (gs.adasuara) Then
        sndP.Play()
        ' End If

    End Sub

End Module
