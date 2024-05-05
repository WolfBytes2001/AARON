<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class approvalForm
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.incharge = New DevExpress.XtraEditors.LabelControl()
        Me.inchargeTxt = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.forApprovalTable = New System.Windows.Forms.DataGridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.inchargeTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.forApprovalTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'incharge
        '
        Me.incharge.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.incharge.Location = New System.Drawing.Point(10, 21)
        Me.incharge.Name = "incharge"
        Me.incharge.Size = New System.Drawing.Size(84, 13)
        Me.incharge.TabIndex = 14
        Me.incharge.Text = "Person in charge:"
        '
        'inchargeTxt
        '
        Me.inchargeTxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.inchargeTxt.Location = New System.Drawing.Point(96, 15)
        Me.inchargeTxt.Name = "inchargeTxt"
        Me.inchargeTxt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inchargeTxt.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.inchargeTxt.Properties.Appearance.Options.UseFont = True
        Me.inchargeTxt.Properties.Appearance.Options.UseForeColor = True
        Me.inchargeTxt.Size = New System.Drawing.Size(137, 26)
        Me.inchargeTxt.TabIndex = 13
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(490, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 37)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "Reject"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Location = New System.Drawing.Point(404, 9)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(80, 37)
        Me.SimpleButton3.TabIndex = 11
        Me.SimpleButton3.Text = "Approve"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.forApprovalTable)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 55)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(579, 422)
        Me.panel1.TabIndex = 7
        '
        'forApprovalTable
        '
        Me.forApprovalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.forApprovalTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.forApprovalTable.Location = New System.Drawing.Point(2, 2)
        Me.forApprovalTable.Name = "forApprovalTable"
        Me.forApprovalTable.Size = New System.Drawing.Size(575, 418)
        Me.forApprovalTable.TabIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.incharge)
        Me.PanelControl1.Controls.Add(Me.inchargeTxt)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.SimpleButton3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(579, 55)
        Me.PanelControl1.TabIndex = 6
        '
        'approvalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "approvalForm"
        Me.Size = New System.Drawing.Size(579, 477)
        CType(Me.inchargeTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        CType(Me.forApprovalTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents incharge As DevExpress.XtraEditors.LabelControl
    Friend WithEvents inchargeTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents forApprovalTable As DataGridView
End Class
