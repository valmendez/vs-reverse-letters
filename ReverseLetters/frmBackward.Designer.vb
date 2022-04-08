<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackward
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
        Me.lblWord = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.txtBackward = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(110, 79)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(61, 13)
        Me.lblWord.TabIndex = 0
        Me.lblWord.Text = "Enter word:"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(177, 76)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(100, 20)
        Me.txtWord.TabIndex = 1
        '
        'btnReverse
        '
        Me.btnReverse.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnReverse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReverse.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReverse.Location = New System.Drawing.Point(113, 118)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(164, 35)
        Me.btnReverse.TabIndex = 2
        Me.btnReverse.Text = "Reverse Letters"
        Me.btnReverse.UseVisualStyleBackColor = False
        '
        'txtBackward
        '
        Me.txtBackward.Location = New System.Drawing.Point(113, 170)
        Me.txtBackward.Name = "txtBackward"
        Me.txtBackward.ReadOnly = True
        Me.txtBackward.Size = New System.Drawing.Size(164, 20)
        Me.txtBackward.TabIndex = 3
        '
        'frmBackward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtBackward)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblWord)
        Me.Name = "frmBackward"
        Me.Text = "Write Backward"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWord As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents btnReverse As Button
    Friend WithEvents txtBackward As TextBox
End Class
