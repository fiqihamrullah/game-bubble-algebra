<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlay
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
        Me.components = New System.ComponentModel.Container
        Me.pbKotakGrid = New System.Windows.Forms.PictureBox
        Me.lblPetunjuk = New System.Windows.Forms.Label
        Me.lbllevel = New System.Windows.Forms.Label
        Me.lblScore = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblPlayer = New System.Windows.Forms.Label
        Me.lblGame = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmranimasion = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbKotakGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbKotakGrid
        '
        Me.pbKotakGrid.BackColor = System.Drawing.Color.Transparent
        Me.pbKotakGrid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbKotakGrid.Location = New System.Drawing.Point(57, 136)
        Me.pbKotakGrid.Name = "pbKotakGrid"
        Me.pbKotakGrid.Size = New System.Drawing.Size(527, 369)
        Me.pbKotakGrid.TabIndex = 7
        Me.pbKotakGrid.TabStop = False
        '
        'lblPetunjuk
        '
        Me.lblPetunjuk.BackColor = System.Drawing.Color.Transparent
        Me.lblPetunjuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetunjuk.Location = New System.Drawing.Point(54, 41)
        Me.lblPetunjuk.Name = "lblPetunjuk"
        Me.lblPetunjuk.Size = New System.Drawing.Size(530, 72)
        Me.lblPetunjuk.TabIndex = 8
        '
        'lbllevel
        '
        Me.lbllevel.BackColor = System.Drawing.Color.Transparent
        Me.lbllevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllevel.ForeColor = System.Drawing.Color.Maroon
        Me.lbllevel.Location = New System.Drawing.Point(732, 154)
        Me.lbllevel.Name = "lbllevel"
        Me.lbllevel.Size = New System.Drawing.Size(47, 33)
        Me.lbllevel.TabIndex = 9
        Me.lbllevel.Text = "0"
        Me.lbllevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Maroon
        Me.lblScore.Location = New System.Drawing.Point(712, 245)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(90, 33)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "0000"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Maroon
        Me.lblTime.Location = New System.Drawing.Point(712, 350)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(96, 33)
        Me.lblTime.TabIndex = 9
        Me.lblTime.Text = "00:00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer
        '
        Me.lblPlayer.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.ForeColor = System.Drawing.Color.Maroon
        Me.lblPlayer.Location = New System.Drawing.Point(667, 440)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(170, 33)
        Me.lblPlayer.TabIndex = 9
        Me.lblPlayer.Text = "??????"
        Me.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGame
        '
        Me.lblGame.BackColor = System.Drawing.Color.Transparent
        Me.lblGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame.ForeColor = System.Drawing.Color.Maroon
        Me.lblGame.Location = New System.Drawing.Point(41, 527)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(123, 33)
        Me.lblGame.TabIndex = 9
        Me.lblGame.Text = "Game"
        Me.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'tmranimasion
        '
        Me.tmranimasion.Interval = 200
        '
        'FrmPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.algebrabubblegame.My.Resources.Resources.bgplay
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 578)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblGame)
        Me.Controls.Add(Me.lbllevel)
        Me.Controls.Add(Me.lblPetunjuk)
        Me.Controls.Add(Me.pbKotakGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPlay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPlay"
        CType(Me.pbKotakGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbKotakGrid As System.Windows.Forms.PictureBox
    Friend WithEvents lblPetunjuk As System.Windows.Forms.Label
    Friend WithEvents lbllevel As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents lblGame As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tmranimasion As System.Windows.Forms.Timer
End Class
