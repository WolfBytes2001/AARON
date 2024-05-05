<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addNewStock
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
        Me.isForSaleBox = New System.Windows.Forms.CheckBox()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.measBox = New System.Windows.Forms.ComboBox()
        Me.cateBox = New System.Windows.Forms.ComboBox()
        Me.invID = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PO_ID = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.descripBox = New DevExpress.XtraEditors.TextEdit()
        Me.quantiBox = New DevExpress.XtraEditors.TextEdit()
        Me.priceBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.totBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.allItemsTable = New System.Windows.Forms.DataGridView()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.itemIDD = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.retailPrice = New DevExpress.XtraEditors.TextEdit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.descripBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantiBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.priceBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.totBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allItemsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.retailPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'isForSaleBox
        '
        Me.isForSaleBox.AutoSize = True
        Me.isForSaleBox.Location = New System.Drawing.Point(460, 91)
        Me.isForSaleBox.Name = "isForSaleBox"
        Me.isForSaleBox.Size = New System.Drawing.Size(65, 17)
        Me.isForSaleBox.TabIndex = 54
        Me.isForSaleBox.Text = "For Sale"
        Me.isForSaleBox.UseVisualStyleBackColor = True
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.SimpleButton4.Appearance.Options.UseBackColor = True
        Me.SimpleButton4.Location = New System.Drawing.Point(54, 443)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(92, 25)
        Me.SimpleButton4.TabIndex = 53
        Me.SimpleButton4.Text = "SAVE"
        '
        'measBox
        '
        Me.measBox.FormattingEnabled = True
        Me.measBox.Items.AddRange(New Object() {"Unit", "Set", "Box", "Package", "Piece", "Dozen", "Box", "Liter"})
        Me.measBox.Location = New System.Drawing.Point(54, 205)
        Me.measBox.Name = "measBox"
        Me.measBox.Size = New System.Drawing.Size(221, 21)
        Me.measBox.TabIndex = 52
        '
        'cateBox
        '
        Me.cateBox.FormattingEnabled = True
        Me.cateBox.Items.AddRange(New Object() {"Hand Tools", "Power Tools", "Fasteners and Hardware", "Building Materials", "Paint and Painting Supplies", "Electrical Supplies", "Plumbing Supplies", "Outdoor Equipment", "Safety Equipment", "Storage and Organization", "Automotive Supplies", "Hardware Accessories", "Home Improvement Products", "Home Security", "Workshop Equipment"})
        Me.cateBox.Location = New System.Drawing.Point(312, 119)
        Me.cateBox.Name = "cateBox"
        Me.cateBox.Size = New System.Drawing.Size(213, 21)
        Me.cateBox.TabIndex = 51
        '
        'invID
        '
        Me.invID.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invID.Appearance.ForeColor = System.Drawing.Color.LimeGreen
        Me.invID.Appearance.Options.UseFont = True
        Me.invID.Appearance.Options.UseForeColor = True
        Me.invID.Location = New System.Drawing.Point(412, 26)
        Me.invID.Name = "invID"
        Me.invID.Size = New System.Drawing.Size(113, 23)
        Me.invID.TabIndex = 46
        Me.invID.Text = "Inventory ID:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(296, 26)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(113, 23)
        Me.LabelControl2.TabIndex = 45
        Me.LabelControl2.Text = "Inventory ID:"
        '
        'PO_ID
        '
        Me.PO_ID.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PO_ID.Appearance.ForeColor = System.Drawing.Color.LimeGreen
        Me.PO_ID.Appearance.Options.UseFont = True
        Me.PO_ID.Appearance.Options.UseForeColor = True
        Me.PO_ID.Location = New System.Drawing.Point(114, 26)
        Me.PO_ID.Name = "PO_ID"
        Me.PO_ID.Size = New System.Drawing.Size(63, 25)
        Me.PO_ID.TabIndex = 44
        Me.PO_ID.Text = "PO ID:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(45, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 25)
        Me.LabelControl1.TabIndex = 43
        Me.LabelControl1.Text = "PO ID:"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Location = New System.Drawing.Point(433, 443)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(92, 25)
        Me.SimpleButton3.TabIndex = 42
        Me.SimpleButton3.Text = "DELETE"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Location = New System.Drawing.Point(312, 443)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(92, 25)
        Me.SimpleButton2.TabIndex = 41
        Me.SimpleButton2.Text = "UPDATE"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(183, 443)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(92, 25)
        Me.SimpleButton1.TabIndex = 40
        Me.SimpleButton1.Text = "ADD"
        '
        'SearchControl1
        '
        Me.SearchControl1.Location = New System.Drawing.Point(41, 55)
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchControl1.Properties.Appearance.Options.UseFont = True
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl1.Size = New System.Drawing.Size(495, 30)
        Me.SearchControl1.TabIndex = 39
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(54, 101)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl3.TabIndex = 55
        Me.LabelControl3.Text = "Description"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(54, 153)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl4.TabIndex = 56
        Me.LabelControl4.Text = "Quantity"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(312, 106)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl5.TabIndex = 57
        Me.LabelControl5.Text = "Category"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(54, 192)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl6.TabIndex = 58
        Me.LabelControl6.Text = "Measurement"
        '
        'descripBox
        '
        Me.descripBox.Location = New System.Drawing.Point(54, 120)
        Me.descripBox.Name = "descripBox"
        Me.descripBox.Size = New System.Drawing.Size(221, 20)
        Me.descripBox.TabIndex = 59
        '
        'quantiBox
        '
        Me.quantiBox.Location = New System.Drawing.Point(54, 166)
        Me.quantiBox.Name = "quantiBox"
        Me.quantiBox.Size = New System.Drawing.Size(221, 20)
        Me.quantiBox.TabIndex = 60
        '
        'priceBox
        '
        Me.priceBox.Location = New System.Drawing.Point(312, 202)
        Me.priceBox.Name = "priceBox"
        Me.priceBox.Size = New System.Drawing.Size(213, 20)
        Me.priceBox.TabIndex = 61
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(312, 188)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl7.TabIndex = 62
        Me.LabelControl7.Text = "Price"
        '
        'totBox
        '
        Me.totBox.Location = New System.Drawing.Point(54, 252)
        Me.totBox.Name = "totBox"
        Me.totBox.Size = New System.Drawing.Size(471, 20)
        Me.totBox.TabIndex = 63
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(54, 233)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl8.TabIndex = 64
        Me.LabelControl8.Text = "Total"
        '
        'allItemsTable
        '
        Me.allItemsTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.allItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.allItemsTable.Location = New System.Drawing.Point(54, 291)
        Me.allItemsTable.Name = "allItemsTable"
        Me.allItemsTable.Size = New System.Drawing.Size(482, 136)
        Me.allItemsTable.TabIndex = 65
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(54, 278)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl9.TabIndex = 66
        Me.LabelControl9.Text = "All inventory Items"
        '
        'itemIDD
        '
        Me.itemIDD.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemIDD.Appearance.ForeColor = System.Drawing.Color.LimeGreen
        Me.itemIDD.Appearance.Options.UseFont = True
        Me.itemIDD.Appearance.Options.UseForeColor = True
        Me.itemIDD.Location = New System.Drawing.Point(3, 3)
        Me.itemIDD.Name = "itemIDD"
        Me.itemIDD.Size = New System.Drawing.Size(63, 25)
        Me.itemIDD.TabIndex = 68
        Me.itemIDD.Text = "PO ID:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(312, 152)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl10.TabIndex = 70
        Me.LabelControl10.Text = "Retail Price"
        '
        'retailPrice
        '
        Me.retailPrice.Location = New System.Drawing.Point(312, 166)
        Me.retailPrice.Name = "retailPrice"
        Me.retailPrice.Size = New System.Drawing.Size(213, 20)
        Me.retailPrice.TabIndex = 71
        '
        'addNewStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.retailPrice)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.itemIDD)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.allItemsTable)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.totBox)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.priceBox)
        Me.Controls.Add(Me.quantiBox)
        Me.Controls.Add(Me.descripBox)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.isForSaleBox)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.measBox)
        Me.Controls.Add(Me.cateBox)
        Me.Controls.Add(Me.invID)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PO_ID)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SearchControl1)
        Me.Name = "addNewStock"
        Me.Size = New System.Drawing.Size(579, 477)
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.descripBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantiBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.priceBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.totBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allItemsTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.retailPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents isForSaleBox As CheckBox
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents measBox As ComboBox
    Friend WithEvents cateBox As ComboBox
    Friend WithEvents invID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PO_ID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SearchControl1 As DevExpress.XtraEditors.SearchControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents descripBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents quantiBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents priceBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents totBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents allItemsTable As DataGridView
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents itemIDD As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents retailPrice As DevExpress.XtraEditors.TextEdit
End Class
