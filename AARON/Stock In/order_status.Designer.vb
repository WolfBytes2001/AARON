<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order_status
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.onProcessTable = New System.Windows.Forms.DataGridView()
        Me.DeliveredTable = New System.Windows.Forms.DataGridView()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.onProcessTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveredTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(579, 477)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.onProcessTable)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(577, 452)
        Me.XtraTabPage1.Text = "On process"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.DeliveredTable)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(577, 452)
        Me.XtraTabPage2.Text = "Delivered"
        '
        'onProcessTable
        '
        Me.onProcessTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.onProcessTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.onProcessTable.Location = New System.Drawing.Point(0, 0)
        Me.onProcessTable.Name = "onProcessTable"
        Me.onProcessTable.RowHeadersWidth = 51
        Me.onProcessTable.Size = New System.Drawing.Size(577, 452)
        Me.onProcessTable.TabIndex = 1
        '
        'DeliveredTable
        '
        Me.DeliveredTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DeliveredTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeliveredTable.Location = New System.Drawing.Point(0, 0)
        Me.DeliveredTable.Name = "DeliveredTable"
        Me.DeliveredTable.RowHeadersWidth = 51
        Me.DeliveredTable.Size = New System.Drawing.Size(577, 452)
        Me.DeliveredTable.TabIndex = 1
        '
        'order_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "order_status"
        Me.Size = New System.Drawing.Size(579, 477)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.onProcessTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveredTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents onProcessTable As DataGridView
    Friend WithEvents DeliveredTable As DataGridView
End Class
