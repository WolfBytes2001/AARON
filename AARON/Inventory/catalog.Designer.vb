<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class catalog
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
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.cat_ID = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.allICatalogable = New System.Windows.Forms.DataGridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.descripBox = New DevExpress.XtraEditors.TextEdit()
        Me.quantiBox = New DevExpress.XtraEditors.TextEdit()
        Me.priceBox = New DevExpress.XtraEditors.TextEdit()
        Me.cateBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.measBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.retailPriceBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allICatalogable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.descripBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantiBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.priceBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cateBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.measBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.retailPriceBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.SimpleButton4.Appearance.Options.UseBackColor = True
        Me.SimpleButton4.Location = New System.Drawing.Point(102, 434)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(92, 25)
        Me.SimpleButton4.TabIndex = 75
        Me.SimpleButton4.Text = "SAVE"
        '
        'cat_ID
        '
        Me.cat_ID.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat_ID.Appearance.Options.UseFont = True
        Me.cat_ID.Location = New System.Drawing.Point(155, 5)
        Me.cat_ID.Name = "cat_ID"
        Me.cat_ID.Size = New System.Drawing.Size(63, 25)
        Me.cat_ID.TabIndex = 69
        Me.cat_ID.Text = "PO ID:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(43, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(106, 25)
        Me.LabelControl1.TabIndex = 68
        Me.LabelControl1.Text = "Catalog ID:"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Location = New System.Drawing.Point(396, 434)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(92, 25)
        Me.SimpleButton3.TabIndex = 67
        Me.SimpleButton3.Text = "DELETE"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Location = New System.Drawing.Point(298, 434)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(92, 25)
        Me.SimpleButton2.TabIndex = 66
        Me.SimpleButton2.Text = "UPDATE"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(200, 434)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(92, 25)
        Me.SimpleButton1.TabIndex = 65
        Me.SimpleButton1.Text = "ADD"
        '
        'SearchControl1
        '
        Me.SearchControl1.Location = New System.Drawing.Point(39, 59)
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchControl1.Properties.Appearance.Options.UseFont = True
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl1.Size = New System.Drawing.Size(504, 30)
        Me.SearchControl1.TabIndex = 64
        '
        'allICatalogable
        '
        Me.allICatalogable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.allICatalogable.Location = New System.Drawing.Point(39, 263)
        Me.allICatalogable.Name = "allICatalogable"
        Me.allICatalogable.Size = New System.Drawing.Size(504, 118)
        Me.allICatalogable.TabIndex = 63
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(55, 113)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 76
        Me.LabelControl2.Text = "Description"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(52, 159)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl3.TabIndex = 77
        Me.LabelControl3.Text = "Quantity"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(310, 113)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl4.TabIndex = 78
        Me.LabelControl4.Text = "Category"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(52, 205)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl5.TabIndex = 79
        Me.LabelControl5.Text = "Measurement"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(310, 206)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl6.TabIndex = 80
        Me.LabelControl6.Text = "Price"
        '
        'descripBox
        '
        Me.descripBox.Location = New System.Drawing.Point(55, 132)
        Me.descripBox.Name = "descripBox"
        Me.descripBox.Size = New System.Drawing.Size(218, 20)
        Me.descripBox.TabIndex = 81
        '
        'quantiBox
        '
        Me.quantiBox.Location = New System.Drawing.Point(55, 178)
        Me.quantiBox.Name = "quantiBox"
        Me.quantiBox.Size = New System.Drawing.Size(218, 20)
        Me.quantiBox.TabIndex = 83
        '
        'priceBox
        '
        Me.priceBox.Location = New System.Drawing.Point(310, 226)
        Me.priceBox.Name = "priceBox"
        Me.priceBox.Size = New System.Drawing.Size(214, 20)
        Me.priceBox.TabIndex = 86
        '
        'cateBox
        '
        Me.cateBox.Location = New System.Drawing.Point(310, 132)
        Me.cateBox.Name = "cateBox"
        Me.cateBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cateBox.Properties.Items.AddRange(New Object() {"Hand Tools", "Power Tools", "Fasteners and Hardware", "Building Materials", "Paint and Painting Supplies", "Electrical Supplies", "Plumbing Supplies", "Outdoor Equipment", "Safety Equipment", "Storage and Organization", "Automotive Supplies", "Hardware Accessories", "Home Improvement Products", "Home Security", "Workshop Equipment"})
        Me.cateBox.Size = New System.Drawing.Size(214, 20)
        Me.cateBox.TabIndex = 87
        '
        'measBox
        '
        Me.measBox.Location = New System.Drawing.Point(55, 224)
        Me.measBox.Name = "measBox"
        Me.measBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.measBox.Properties.Items.AddRange(New Object() {"Unit", "Set", "Box", "Package", "Piece", "Dozen", "Box", "Liter"})
        Me.measBox.Size = New System.Drawing.Size(218, 20)
        Me.measBox.TabIndex = 88
        '
        'retailPriceBox
        '
        Me.retailPriceBox.Location = New System.Drawing.Point(310, 178)
        Me.retailPriceBox.Name = "retailPriceBox"
        Me.retailPriceBox.Size = New System.Drawing.Size(214, 20)
        Me.retailPriceBox.TabIndex = 90
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(310, 158)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl7.TabIndex = 89
        Me.LabelControl7.Text = "Retail Price"
        '
        'catalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.retailPriceBox)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.measBox)
        Me.Controls.Add(Me.cateBox)
        Me.Controls.Add(Me.priceBox)
        Me.Controls.Add(Me.quantiBox)
        Me.Controls.Add(Me.descripBox)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.cat_ID)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SearchControl1)
        Me.Controls.Add(Me.allICatalogable)
        Me.Name = "catalog"
        Me.Size = New System.Drawing.Size(579, 477)
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allICatalogable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.descripBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantiBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.priceBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cateBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.measBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.retailPriceBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cat_ID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SearchControl1 As DevExpress.XtraEditors.SearchControl
    Friend WithEvents allICatalogable As DataGridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents descripBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents quantiBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents priceBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cateBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents measBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents retailPriceBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
