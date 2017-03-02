<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SumOfNumbers
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
        Me.EnterNumberButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EnterNumberButton
        '
        Me.EnterNumberButton.Location = New System.Drawing.Point(39, 45)
        Me.EnterNumberButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EnterNumberButton.Name = "EnterNumberButton"
        Me.EnterNumberButton.Size = New System.Drawing.Size(108, 44)
        Me.EnterNumberButton.TabIndex = 0
        Me.EnterNumberButton.Text = "Enter Numbers"
        Me.EnterNumberButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(188, 45)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(99, 44)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SumOfNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 134)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.EnterNumberButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SumOfNumbers"
        Me.Text = "Sum of Numbers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EnterNumberButton As Button
    Friend WithEvents ExitButton As Button
End Class
