<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.numberOfDisks = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'numberOfDisks
        '
        Me.numberOfDisks.Location = New System.Drawing.Point(13, 13)
        Me.numberOfDisks.MaxLength = 2
        Me.numberOfDisks.Name = "numberOfDisks"
        Me.numberOfDisks.Size = New System.Drawing.Size(259, 20)
        Me.numberOfDisks.TabIndex = 0
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(115, 40)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(10, 13)
        Me.lblResult.TabIndex = 1
        Me.lblResult.Text = " "
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number Of Moves:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(120, 80)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(60, 26)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 122)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.numberOfDisks)
        Me.MaximumSize = New System.Drawing.Size(300, 160)
        Me.MinimumSize = New System.Drawing.Size(300, 160)
        Me.Name = "Form1"
        Me.Text = "Tower of Hanoi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numberOfDisks As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As Button
End Class
