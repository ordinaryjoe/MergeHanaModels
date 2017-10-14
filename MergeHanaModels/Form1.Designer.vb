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
        Me.btnSource = New System.Windows.Forms.Button()
        Me.btnTarget = New System.Windows.Forms.Button()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSource
        '
        Me.btnSource.Location = New System.Drawing.Point(12, 27)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(75, 23)
        Me.btnSource.TabIndex = 0
        Me.btnSource.Text = "Source"
        Me.btnSource.UseVisualStyleBackColor = True
        '
        'btnTarget
        '
        Me.btnTarget.Location = New System.Drawing.Point(12, 71)
        Me.btnTarget.Name = "btnTarget"
        Me.btnTarget.Size = New System.Drawing.Size(75, 23)
        Me.btnTarget.TabIndex = 1
        Me.btnTarget.Text = "Target"
        Me.btnTarget.UseVisualStyleBackColor = True
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSource.Location = New System.Drawing.Point(115, 27)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(73, 16)
        Me.lblSource.TabIndex = 2
        Me.lblSource.Text = "SourcePath"
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.lblTarget.Location = New System.Drawing.Point(115, 69)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(71, 16)
        Me.lblTarget.TabIndex = 3
        Me.lblTarget.Text = "TargetPath"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 209)
        Me.Controls.Add(Me.lblTarget)
        Me.Controls.Add(Me.lblSource)
        Me.Controls.Add(Me.btnTarget)
        Me.Controls.Add(Me.btnSource)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSource As Button
    Friend WithEvents btnTarget As Button
    Friend WithEvents lblSource As Label
    Friend WithEvents lblTarget As Label
End Class
