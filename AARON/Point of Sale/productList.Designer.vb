<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productList
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
        Me.poSearchTotal = New System.Windows.Forms.TextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.posSearchQuantity = New System.Windows.Forms.NumericUpDown()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.searchTable = New System.Windows.Forms.DataGridView()
        Me.poSearchBar = New DevExpress.XtraEditors.SearchControl()
        CType(Me.posSearchQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.poSearchBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(351, 29)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(70, 23)
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "ADD"
        '
        'poSearchTotal
        '
        Me.poSearchTotal.Location = New System.Drawing.Point(240, 235)
        Me.poSearchTotal.Name = "poSearchTotal"
        Me.poSearchTotal.ReadOnly = True
        Me.poSearchTotal.Size = New System.Drawing.Size(181, 21)
        Me.poSearchTotal.TabIndex = 13
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(202, 239)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "TOTAL"
        '
        'posSearchQuantity
        '
        Me.posSearchQuantity.Location = New System.Drawing.Point(65, 236)
        Me.posSearchQuantity.Name = "posSearchQuantity"
        Me.posSearchQuantity.Size = New System.Drawing.Size(120, 21)
        Me.posSearchQuantity.TabIndex = 11
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 239)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "QUANTITY"
        '
        'searchTable
        '
        Me.searchTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.searchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.searchTable.Location = New System.Drawing.Point(9, 70)
        Me.searchTable.Name = "searchTable"
        Me.searchTable.Size = New System.Drawing.Size(412, 160)
        Me.searchTable.TabIndex = 9
        '
        'poSearchBar
        '
        Me.poSearchBar.Location = New System.Drawing.Point(22, 31)
        Me.poSearchBar.Name = "poSearchBar"
        Me.poSearchBar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.poSearchBar.Size = New System.Drawing.Size(323, 20)
        Me.poSearchBar.TabIndex = 8
        '
        'productList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 265)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.poSearchTotal)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.posSearchQuantity)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.searchTable)
        Me.Controls.Add(Me.poSearchBar)
        Me.Name = "productList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "productList"
        CType(Me.posSearchQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.poSearchBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents poSearchTotal As TextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents posSearchQuantity As NumericUpDown
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents searchTable As DataGridView
    Friend WithEvents poSearchBar As DevExpress.XtraEditors.SearchControl
End Class
