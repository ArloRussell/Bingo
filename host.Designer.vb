<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class host
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(host))
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstPrevious = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDraw
        '
        Me.btnDraw.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDraw.Location = New System.Drawing.Point(27, 192)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(171, 53)
        Me.btnDraw.TabIndex = 0
        Me.btnDraw.Text = "Draw Number"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'lblNum
        '
        Me.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNum.Font = New System.Drawing.Font("Kristen ITC", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(12, 248)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(201, 114)
        Me.lblNum.TabIndex = 1
        Me.lblNum.Text = "B17"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lstPrevious
        '
        Me.lstPrevious.FormattingEnabled = True
        Me.lstPrevious.Location = New System.Drawing.Point(247, 57)
        Me.lstPrevious.Name = "lstPrevious"
        Me.lstPrevious.Size = New System.Drawing.Size(120, 303)
        Me.lstPrevious.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Previous Calls:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(385, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetRToolStripMenuItem, Me.ReturnToMenuToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&file"
        '
        'ResetRToolStripMenuItem
        '
        Me.ResetRToolStripMenuItem.Name = "ResetRToolStripMenuItem"
        Me.ResetRToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ResetRToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ResetRToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ResetRToolStripMenuItem.Text = "Reset &F5"
        '
        'ReturnToMenuToolStripMenuItem
        '
        Me.ReturnToMenuToolStripMenuItem.Name = "ReturnToMenuToolStripMenuItem"
        Me.ReturnToMenuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.ReturnToMenuToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ReturnToMenuToolStripMenuItem.Text = "Return To Menu &F4"
        '
        'host
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 372)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPrevious)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.btnDraw)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "host"
        Me.Text = "Bingo Host"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDraw As Button
    Friend WithEvents lblNum As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstPrevious As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToMenuToolStripMenuItem As ToolStripMenuItem
End Class
