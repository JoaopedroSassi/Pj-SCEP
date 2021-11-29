<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pdf
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(370, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(370, 166)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(100, 20)
        Me.txt_search.TabIndex = 1
        '
        'frm_pdf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 472)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Button1)
        Me.MaximumSize = New System.Drawing.Size(896, 511)
        Me.MinimumSize = New System.Drawing.Size(896, 511)
        Me.Name = "frm_pdf"
        Me.Text = "frm_pdf"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents txt_search As Windows.Forms.TextBox
End Class
