Public Class FrmGameMenu
    Dim currentPage As Integer
    Private Sub pbTtgProgram_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTtgProgram.MouseHover
        pbTtgProgram.BackgroundImage = My.Resources.btntentang_hover
    End Sub

    Private Sub pbTtgProgram_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTtgProgram.MouseLeave
        pbTtgProgram.BackgroundImage = My.Resources.btntentang
    End Sub

    Private Sub pbBantuan_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBantuan.MouseHover
        pbBantuan.BackgroundImage = My.Resources.btnbantuan_hover
    End Sub

    Private Sub pbBantuan_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBantuan.MouseLeave
        pbBantuan.BackgroundImage = My.Resources.btnbantuan
    End Sub

    Private Sub pbdepan_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdepan.MouseHover
        pbdepan.BackgroundImage = My.Resources.btndepan_hover
    End Sub

    Private Sub pbdepan_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdepan.MouseLeave
        pbdepan.BackgroundImage = My.Resources.btndepan
    End Sub

    Private Sub pbpetunjukgame_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbpetunjukgame.MouseHover
        pbpetunjukgame.BackgroundImage = My.Resources.btnpetunjuk_hover
    End Sub

    Private Sub pbpetunjukgame_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbpetunjukgame.MouseLeave
        pbpetunjukgame.BackgroundImage = My.Resources.btnpetunjuk
    End Sub

    Private Sub pbaturangame_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbaturangame.MouseHover
        pbaturangame.BackgroundImage = My.Resources.btnaturan_hover
    End Sub

    Private Sub pbaturangame_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbaturangame.MouseLeave
        pbaturangame.BackgroundImage = My.Resources.btnaturan
    End Sub

    Private Sub pbmulaigame_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmulaigame.MouseHover
        pbmulaigame.BackgroundImage = My.Resources.btnstart_hover
    End Sub

    Private Sub pbmulaigame_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmulaigame.MouseLeave
        pbmulaigame.BackgroundImage = My.Resources.btnstart
    End Sub

    Private Sub pbkeluar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbkeluar.MouseHover
        pbkeluar.BackgroundImage = My.Resources.btnkeluar_hover
    End Sub

    Private Sub pbkeluar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbkeluar.MouseLeave
        pbkeluar.BackgroundImage = My.Resources.btnkeluar
    End Sub

    Private Sub pbTtgProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbTtgProgram.Click
        pbshow.BackgroundImage = My.Resources.p1
        btnNext.Visible = False
        btnPrev.Visible = False
    End Sub

    Private Sub pbBantuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBantuan.Click
        pbshow.BackgroundImage = My.Resources.p3
        btnNext.Visible = False
        btnPrev.Visible = False
    End Sub

    Private Sub pbdepan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbdepan.Click
        Me.Dispose()
        Dim FrmMU As New FrmMenuUtama
        FrmMU.Show()
    End Sub

    Private Sub pbpetunjukgame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbpetunjukgame.Click
        pbshow.BackgroundImage = My.Resources.pp3
        btnNext.Visible = True
        btnPrev.Visible = True
        currentPage = 1
    End Sub

    Private Sub pbaturangame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbaturangame.Click
        pbshow.BackgroundImage = My.Resources.p2
        btnNext.Visible = False
        btnPrev.Visible = False
    End Sub

    Private Sub pbkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbkeluar.Click
        Application.Exit()
    End Sub

    Private Sub pbmulaigame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbmulaigame.Click
        Dim frmPlay As New FrmPlay
        frmPlay.Show()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        currentPage += 1
        btnPrev.Enabled = True
        If (currentPage = 2) Then
            pbshow.BackgroundImage = My.Resources.pp2
        ElseIf (currentPage = 3) Then
            pbshow.BackgroundImage = My.Resources.pp1
            btnNext.Enabled = False
        End If
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click

        currentPage -= 1
        btnNext.Enabled = True
        If (currentPage = 2) Then
            pbshow.BackgroundImage = My.Resources.pp2
        ElseIf (currentPage = 1) Then
            pbshow.BackgroundImage = My.Resources.pp3
            btnPrev.Enabled = False
        End If
    End Sub
End Class