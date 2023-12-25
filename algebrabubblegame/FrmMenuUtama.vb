Public Class FrmMenuUtama

    Private Sub pbBtnOK_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBtnOK.MouseHover
        pbBtnOK.BackgroundImage = My.Resources.btnOK_hover
    End Sub

    Private Sub pbBtnOK_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBtnOK.MouseLeave
        pbBtnOK.BackgroundImage = My.Resources.btnOK
    End Sub

    Private Sub pbBtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBtnOK.Click
        If (txtNama.Text <> "") Then
            Dim FrmGameMn As New FrmGameMenu
            mystat.nmplayer = txtNama.Text
            FrmGameMn.ShowDialog()
        Else
            MessageBox.Show("Nama Pemain Belum Diisi!", "Tidak Boleh Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
