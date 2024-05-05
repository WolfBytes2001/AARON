<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pos
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
        Me.posDiscount = New System.Windows.Forms.CheckBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.posTotal = New System.Windows.Forms.TextBox()
        Me.posTax = New System.Windows.Forms.TextBox()
        Me.posSubTotal = New System.Windows.Forms.TextBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cartTable = New System.Windows.Forms.DataGridView()
        Me.posTRNUM = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.buyerName = New System.Windows.Forms.TextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.contactInfo = New System.Windows.Forms.TextBox()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cartTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'posDiscount
        '
        Me.posDiscount.AutoSize = True
        Me.posDiscount.Location = New System.Drawing.Point(314, 298)
        Me.posDiscount.Name = "posDiscount"
        Me.posDiscount.Size = New System.Drawing.Size(67, 17)
        Me.posDiscount.TabIndex = 28
        Me.posDiscount.Text = "Discount"
        Me.posDiscount.UseVisualStyleBackColor = True
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Location = New System.Drawing.Point(343, 384)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(82, 44)
        Me.SimpleButton2.TabIndex = 27
        Me.SimpleButton2.Text = "CANCEL"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(241, 384)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(82, 44)
        Me.SimpleButton1.TabIndex = 26
        Me.SimpleButton1.Text = "COMMIT"
        '
        'posTotal
        '
        Me.posTotal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.posTotal.ForeColor = System.Drawing.Color.Red
        Me.posTotal.Location = New System.Drawing.Point(99, 39)
        Me.posTotal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.posTotal.Name = "posTotal"
        Me.posTotal.ReadOnly = True
        Me.posTotal.Size = New System.Drawing.Size(431, 30)
        Me.posTotal.TabIndex = 25
        '
        'posTax
        '
        Me.posTax.Location = New System.Drawing.Point(202, 295)
        Me.posTax.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.posTax.Name = "posTax"
        Me.posTax.ReadOnly = True
        Me.posTax.Size = New System.Drawing.Size(69, 21)
        Me.posTax.TabIndex = 24
        Me.posTax.Text = "10"
        '
        'posSubTotal
        '
        Me.posSubTotal.Location = New System.Drawing.Point(202, 264)
        Me.posSubTotal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.posSubTotal.Name = "posSubTotal"
        Me.posSubTotal.ReadOnly = True
        Me.posSubTotal.Size = New System.Drawing.Size(211, 21)
        Me.posSubTotal.TabIndex = 23
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(40, 49)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(55, 19)
        Me.LabelControl6.TabIndex = 22
        Me.LabelControl6.Text = "TOTAL"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(147, 303)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "TAX"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(147, 273)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl4.TabIndex = 20
        Me.LabelControl4.Text = "SUBTOTAL"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(44, 83)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl3.TabIndex = 19
        Me.LabelControl3.Text = "Items included"
        '
        'cartTable
        '
        Me.cartTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.cartTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.cartTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cartTable.Location = New System.Drawing.Point(40, 111)
        Me.cartTable.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cartTable.Name = "cartTable"
        Me.cartTable.Size = New System.Drawing.Size(490, 139)
        Me.cartTable.TabIndex = 18
        '
        'posTRNUM
        '
        Me.posTRNUM.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.posTRNUM.Appearance.ForeColor = System.Drawing.Color.Red
        Me.posTRNUM.Appearance.Options.UseFont = True
        Me.posTRNUM.Appearance.Options.UseForeColor = True
        Me.posTRNUM.Location = New System.Drawing.Point(300, 75)
        Me.posTRNUM.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.posTRNUM.Name = "posTRNUM"
        Me.posTRNUM.Size = New System.Drawing.Size(113, 23)
        Me.posTRNUM.TabIndex = 17
        Me.posTRNUM.Text = "LabelControl2"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(176, 83)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(120, 13)
        Me.LabelControl1.TabIndex = 16
        Me.LabelControl1.Text = "TRANSACTION NUMBER:"
        '
        'buyerName
        '
        Me.buyerName.Location = New System.Drawing.Point(202, 322)
        Me.buyerName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.buyerName.Name = "buyerName"
        Me.buyerName.Size = New System.Drawing.Size(211, 21)
        Me.buyerName.TabIndex = 30
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(140, 330)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 29
        Me.LabelControl2.Text = "Buyer Name"
        '
        'contactInfo
        '
        Me.contactInfo.Location = New System.Drawing.Point(202, 349)
        Me.contactInfo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.contactInfo.Name = "contactInfo"
        Me.contactInfo.Size = New System.Drawing.Size(211, 21)
        Me.contactInfo.TabIndex = 32
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(137, 357)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl7.TabIndex = 31
        Me.LabelControl7.Text = "Contact Info"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Location = New System.Drawing.Point(140, 384)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(82, 44)
        Me.SimpleButton3.TabIndex = 33
        Me.SimpleButton3.Text = "ADD ITEM"
        '
        'pos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.contactInfo)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.buyerName)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.posDiscount)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.posTotal)
        Me.Controls.Add(Me.posTax)
        Me.Controls.Add(Me.posSubTotal)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cartTable)
        Me.Controls.Add(Me.posTRNUM)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "pos"
        Me.Size = New System.Drawing.Size(579, 477)
        CType(Me.cartTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents posDiscount As CheckBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents posTotal As TextBox
    Friend WithEvents posTax As TextBox
    Friend WithEvents posSubTotal As TextBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cartTable As DataGridView
    Friend WithEvents posTRNUM As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents buyerName As TextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents contactInfo As TextBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
