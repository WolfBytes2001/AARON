<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.adminID = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.allAdminsTable = New System.Windows.Forms.DataGridView()
        Me.fullnameBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.emploIDBOX = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.usernameBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.passwordBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allAdminsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fullnameBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emploIDBOX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usernameBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(144, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(307, 25)
        Me.LabelControl2.TabIndex = 82
        Me.LabelControl2.Text = "MANAGE ALL ADMIN ACCOUNTS"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.SimpleButton4.Appearance.Options.UseBackColor = True
        Me.SimpleButton4.Location = New System.Drawing.Point(100, 407)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(92, 25)
        Me.SimpleButton4.TabIndex = 77
        Me.SimpleButton4.Text = "SAVE"
        '
        'adminID
        '
        Me.adminID.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminID.Appearance.Options.UseFont = True
        Me.adminID.Location = New System.Drawing.Point(80, 38)
        Me.adminID.Name = "adminID"
        Me.adminID.Size = New System.Drawing.Size(73, 19)
        Me.adminID.TabIndex = 75
        Me.adminID.Text = "ADMIN ID"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(45, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(23, 19)
        Me.LabelControl1.TabIndex = 74
        Me.LabelControl1.Text = "ID:"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Location = New System.Drawing.Point(394, 407)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(92, 25)
        Me.SimpleButton3.TabIndex = 73
        Me.SimpleButton3.Text = "DELETE"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Location = New System.Drawing.Point(296, 407)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(92, 25)
        Me.SimpleButton2.TabIndex = 72
        Me.SimpleButton2.Text = "UPDATE"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(198, 407)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(92, 25)
        Me.SimpleButton1.TabIndex = 71
        Me.SimpleButton1.Text = "ADD"
        '
        'SearchControl1
        '
        Me.SearchControl1.Location = New System.Drawing.Point(45, 59)
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchControl1.Properties.Appearance.Options.UseFont = True
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl1.Size = New System.Drawing.Size(495, 30)
        Me.SearchControl1.TabIndex = 70
        '
        'allAdminsTable
        '
        Me.allAdminsTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.allAdminsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.allAdminsTable.Location = New System.Drawing.Point(41, 209)
        Me.allAdminsTable.Name = "allAdminsTable"
        Me.allAdminsTable.Size = New System.Drawing.Size(504, 192)
        Me.allAdminsTable.TabIndex = 69
        '
        'fullnameBox
        '
        Me.fullnameBox.Location = New System.Drawing.Point(45, 114)
        Me.fullnameBox.Name = "fullnameBox"
        Me.fullnameBox.Size = New System.Drawing.Size(222, 20)
        Me.fullnameBox.TabIndex = 83
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(45, 100)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl3.TabIndex = 84
        Me.LabelControl3.Text = "Code Name"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(309, 100)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl4.TabIndex = 86
        Me.LabelControl4.Text = "Employee ID"
        '
        'emploIDBOX
        '
        Me.emploIDBOX.Location = New System.Drawing.Point(309, 114)
        Me.emploIDBOX.Name = "emploIDBOX"
        Me.emploIDBOX.Size = New System.Drawing.Size(231, 20)
        Me.emploIDBOX.TabIndex = 85
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(45, 137)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl5.TabIndex = 88
        Me.LabelControl5.Text = "Username"
        '
        'usernameBox
        '
        Me.usernameBox.Location = New System.Drawing.Point(45, 151)
        Me.usernameBox.Name = "usernameBox"
        Me.usernameBox.Size = New System.Drawing.Size(222, 20)
        Me.usernameBox.TabIndex = 87
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(309, 137)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 90
        Me.LabelControl6.Text = "Password"
        '
        'passwordBox
        '
        Me.passwordBox.Location = New System.Drawing.Point(309, 151)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(231, 20)
        Me.passwordBox.TabIndex = 89
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(41, 190)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl7.TabIndex = 91
        Me.LabelControl7.Text = "All Admins"
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.passwordBox)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.usernameBox)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.emploIDBOX)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.fullnameBox)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.adminID)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SearchControl1)
        Me.Controls.Add(Me.allAdminsTable)
        Me.Name = "admin"
        Me.Size = New System.Drawing.Size(579, 477)
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allAdminsTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fullnameBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emploIDBOX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usernameBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents adminID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SearchControl1 As DevExpress.XtraEditors.SearchControl
    Friend WithEvents allAdminsTable As DataGridView
    Friend WithEvents fullnameBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents emploIDBOX As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents usernameBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents passwordBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
