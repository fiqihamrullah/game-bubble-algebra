<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGameMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pbTtgProgram = New System.Windows.Forms.PictureBox
        Me.pbBantuan = New System.Windows.Forms.PictureBox
        Me.pbdepan = New System.Windows.Forms.PictureBox
        Me.pbpetunjukgame = New System.Windows.Forms.PictureBox
        Me.pbaturangame = New System.Windows.Forms.PictureBox
        Me.pbmulaigame = New System.Windows.Forms.PictureBox
        Me.pbkeluar = New System.Windows.Forms.PictureBox
        Me.pbshow = New System.Windows.Forms.PictureBox
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnPrev = New System.Windows.Forms.Button
        CType(Me.pbTtgProgram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBantuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbdepan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbpetunjukgame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbaturangame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmulaigame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbkeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbshow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbTtgProgram
        '
        Me.pbTtgProgram.BackgroundImage = Global.algebrabubblegame.My.Resources.Resources.btntentang
        Me.pbTtgProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbTtgProgram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbTtgProgram.Location = New System.Drawing.Point(386, 53)
        Me.pbTtgProgram.Name = "pbTtgProgram"
        Me.pbTtgProgram.Size = New System.Drawing.Size(202, 65)
        Me.pbTtgProgram.TabIndex = 0
        Me.pbTtgProgram.TabStop = False
        '
        'pbBantuan
        '
        Me.pbBantuan.BackgroundImage = Global.algebrabubblegame.My.Resources.Resources.btnbantuan
        Me.pbBantuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbBantuan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBantuan.Location = New System.Drawing.Point(386, 124)
        Me.pbBantuan.Name = "pbBantuan"
        Me.pbBantuan.Size = New System.Drawing.Size(202, 57)
        Me.pbBantuan.TabIndex = 0
        Me.pbBantuan.TabStop = False
        '
        'pbdepan
        '
        Me.pbdepan.BackgroundImage = Global.algebrabubblegame.My.Resources.Resources.btndepan
        Me.pbdepan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbdepan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbdepan.Location = New System.Drawing.Point(386, 187)
        Me.pbdepan.Name = "pbdepan"
        Me.pbdepan.Size = New System.Drawing.Size(202, 58)
        Me.pbdepan.TabIndex = 0
        Me.pbdepan.TabStop = False
        '
        'pbpetunjukgame
        '
        Me.pbpetunjukgame.BackgroundImage = Global.algebrabubblegame.My.Resources.Resources.btnpetunjuk
        Me.pbpetunjukgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbpetunjukgame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbpetunjukgame.Location = New System.Drawing.Point(390, 293)
        Me.pbpetunjukgame.Name = "pbpetunjukgame"
        Me.pbpetunjukgame.Size = New System.Drawing.Size(198, 52)
        Me.pbpetunjukgame.TabIndex = 1
        Me.pbpetunjukgame.TabStop = False
        '
        'pbaturangame
        '
        Me.pbaturangame.BackgroundImage = Global.algebrabubblegame.My.Resources.Resources.btnaturan
        Me.pbaturangame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbaturangame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbaturangame.Location = New System.Drawing.Point(390, 351)
        Me.pbaturangame.Name = "pbaturangame"
        Me.pbaturangame.Size = New System.Drawing.Size(198, 52)
        Me.pbaturangame.TabIndex = 1
        Me.pbaturangame.TabStop = False
        '
        'pbmulaigame
        '
        Me.pbmulaigame.BackgroundImage = Global.algebrabubblegame.My.Resources.Resources.btnstart
        Me.pbmulaigame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbmulaigame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbmulaigame.Location = New System.Drawing.Point(390, 409)
        Me.pbmulaigame.Name = "pbmulaigame"
        Me.pbmulaigame.Size = New System.Drawing.Size(198, 52)
        Me.pbmulaigame.TabIndex = 1
        Me.pbmulaigame.TabStop = False
        '
        'pbkeluar
        '
        Me.pbkeluar.BackgroundImage = Global.algebrabubblegame.My.Resources.Resources.btnkeluar
        Me.pbkeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbkeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbkeluar.Location = New System.Drawing.Point(390, 467)
        Me.pbkeluar.Name = "pbkeluar"
        Me.pbkeluar.Size = New System.Drawing.Size(198, 52)
        Me.pbkeluar.TabIndex = 1
        Me.pbkeluar.TabStop = False
        '
        'pbshow
        '

        Me.pbshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbshow.Location = New System.Drawing.Point(25, 29)
        Me.pbshow.Name = "pbshow"
        Me.pbshow.Size = New System.Drawing.Size(317, 504)
        Me.pbshow.TabIndex = 2
        Me.pbshow.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(184, 558)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(38, 33)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = " >>"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'btnPrev
        '
        Me.btnPrev.Enabled = False
        Me.btnPrev.Location = New System.Drawing.Point(140, 558)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(38, 33)
        Me.btnPrev.TabIndex = 3
        Me.btnPrev.Text = " <<"
        Me.btnPrev.UseVisualStyleBackColor = True
        Me.btnPrev.Visible = False
        '
        'FrmGameMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.algebrabubblegame.My.Resources.Resources.B1_OK
        Me.ClientSize = New System.Drawing.Size(632, 599)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.pbshow)
        Me.Controls.Add(Me.pbkeluar)
        Me.Controls.Add(Me.pbmulaigame)
        Me.Controls.Add(Me.pbaturangame)
        Me.Controls.Add(Me.pbpetunjukgame)
        Me.Controls.Add(Me.pbdepan)
        Me.Controls.Add(Me.pbBantuan)
        Me.Controls.Add(Me.pbTtgProgram)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmGameMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmGameMenu"
        CType(Me.pbTtgProgram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBantuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbdepan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbpetunjukgame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbaturangame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmulaigame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbkeluar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbshow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbTtgProgram As System.Windows.Forms.PictureBox
    Friend WithEvents pbBantuan As System.Windows.Forms.PictureBox
    Friend WithEvents pbdepan As System.Windows.Forms.PictureBox
    Friend WithEvents pbpetunjukgame As System.Windows.Forms.PictureBox
    Friend WithEvents pbaturangame As System.Windows.Forms.PictureBox
    Friend WithEvents pbmulaigame As System.Windows.Forms.PictureBox
    Friend WithEvents pbkeluar As System.Windows.Forms.PictureBox
    Friend WithEvents pbshow As System.Windows.Forms.PictureBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
End Class
