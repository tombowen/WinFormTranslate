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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnOneShot = New System.Windows.Forms.Button()
        Me.btnContinuous = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(535, 23)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 98)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(535, 258)
        Me.TextBox2.TabIndex = 1
        '
        'btnOneShot
        '
        Me.btnOneShot.Location = New System.Drawing.Point(9, 41)
        Me.btnOneShot.Name = "btnOneShot"
        Me.btnOneShot.Size = New System.Drawing.Size(81, 23)
        Me.btnOneShot.TabIndex = 2
        Me.btnOneShot.Text = "One Shot"
        Me.btnOneShot.UseVisualStyleBackColor = True
        '
        'btnContinuous
        '
        Me.btnContinuous.Location = New System.Drawing.Point(9, 362)
        Me.btnContinuous.Name = "btnContinuous"
        Me.btnContinuous.Size = New System.Drawing.Size(81, 23)
        Me.btnContinuous.TabIndex = 3
        Me.btnContinuous.Text = "Continuous"
        Me.btnContinuous.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnContinuous)
        Me.Controls.Add(Me.btnOneShot)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnOneShot As Button
    Friend WithEvents btnContinuous As Button
End Class
