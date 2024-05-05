<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.passwordBox = New DevExpress.XtraEditors.TextEdit()
        Me.usernameBox = New DevExpress.XtraEditors.TextEdit()
        CType(Me.passwordBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usernameBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(232, 194)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "Login"
        '
        'passwordBox
        '
        Me.passwordBox.EditValue = "Password"
        Me.passwordBox.Location = New System.Drawing.Point(200, 156)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(145, 20)
        Me.passwordBox.TabIndex = 6
        '
        'usernameBox
        '
        Me.usernameBox.EditValue = "Username"
        Me.usernameBox.Location = New System.Drawing.Point(200, 130)
        Me.usernameBox.Name = "usernameBox"
        Me.usernameBox.Size = New System.Drawing.Size(145, 20)
        Me.usernameBox.TabIndex = 5
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 390)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.passwordBox)
        Me.Controls.Add(Me.usernameBox)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.passwordBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usernameBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents passwordBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents usernameBox As DevExpress.XtraEditors.TextEdit
End Class
