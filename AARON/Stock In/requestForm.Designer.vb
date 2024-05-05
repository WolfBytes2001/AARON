<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class requestForm
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
        Me.purposeBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.measurementBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.requestCart = New System.Windows.Forms.DataGridView()
        Me.totalBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.priceBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.quantityBox = New System.Windows.Forms.NumericUpDown()
        Me.categBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.prodNameBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.sourceBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.officerBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.officeBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.requestID = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.subtotalBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.purposeBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.measurementBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.requestCart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.totalBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.priceBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantityBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.categBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prodNameBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sourceBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officerBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.subtotalBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'purposeBox
        '
        Me.purposeBox.Location = New System.Drawing.Point(331, 60)
        Me.purposeBox.Name = "purposeBox"
        Me.purposeBox.Size = New System.Drawing.Size(164, 20)
        Me.purposeBox.TabIndex = 32
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(331, 63)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl17.TabIndex = 30
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(38, 172)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 38
        Me.SimpleButton1.Text = "Add product"
        '
        'measurementBox
        '
        Me.measurementBox.Location = New System.Drawing.Point(209, 175)
        Me.measurementBox.Name = "measurementBox"
        Me.measurementBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.measurementBox.Properties.Items.AddRange(New Object() {"Unit", "Set", "Box", "Package", "Piece", "Dozen", "Box", "Liter"})
        Me.measurementBox.Size = New System.Drawing.Size(210, 20)
        Me.measurementBox.TabIndex = 37
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(138, 182)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl11.TabIndex = 36
        Me.LabelControl11.Text = "Measurement"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(13, 293)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl6.TabIndex = 35
        Me.LabelControl6.Text = "Items Included"
        '
        'requestCart
        '
        Me.requestCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.requestCart.Location = New System.Drawing.Point(13, 312)
        Me.requestCart.Name = "requestCart"
        Me.requestCart.Size = New System.Drawing.Size(547, 128)
        Me.requestCart.TabIndex = 34
        '
        'totalBox
        '
        Me.totalBox.Location = New System.Drawing.Point(77, 258)
        Me.totalBox.Name = "totalBox"
        Me.totalBox.Size = New System.Drawing.Size(444, 20)
        Me.totalBox.TabIndex = 33
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(38, 265)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl10.TabIndex = 32
        Me.LabelControl10.Text = "Total"
        '
        'priceBox
        '
        Me.priceBox.Location = New System.Drawing.Point(209, 232)
        Me.priceBox.Name = "priceBox"
        Me.priceBox.Size = New System.Drawing.Size(210, 20)
        Me.priceBox.TabIndex = 31
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(178, 239)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl9.TabIndex = 30
        Me.LabelControl9.Text = "Price"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(161, 205)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl8.TabIndex = 29
        Me.LabelControl8.Text = "Quantity"
        '
        'quantityBox
        '
        Me.quantityBox.Location = New System.Drawing.Point(209, 203)
        Me.quantityBox.Name = "quantityBox"
        Me.quantityBox.Size = New System.Drawing.Size(210, 21)
        Me.quantityBox.TabIndex = 28
        '
        'categBox
        '
        Me.categBox.Location = New System.Drawing.Point(209, 147)
        Me.categBox.Name = "categBox"
        Me.categBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.categBox.Properties.Items.AddRange(New Object() {"Hand Tools", "Power Tools", "Fasteners and Hardware", "Building Materials", "Paint and Painting Supplies", "Electrical Supplies", "Plumbing Supplies", "Outdoor Equipment", "Safety Equipment", "Storage and Organization", "Automotive Supplies", "Hardware Accessories", "Home Improvement Products", "Home Security", "Workshop Equipment"})
        Me.categBox.Size = New System.Drawing.Size(210, 20)
        Me.categBox.TabIndex = 27
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(156, 147)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl7.TabIndex = 26
        Me.LabelControl7.Text = "Category"
        '
        'prodNameBox
        '
        Me.prodNameBox.Location = New System.Drawing.Point(209, 117)
        Me.prodNameBox.Name = "prodNameBox"
        Me.prodNameBox.Size = New System.Drawing.Size(210, 20)
        Me.prodNameBox.TabIndex = 25
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(134, 120)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl5.TabIndex = 24
        Me.LabelControl5.Text = "Product Name"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(286, 63)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl16.TabIndex = 31
        Me.LabelControl16.Text = "Purpose"
        '
        'sourceBox
        '
        Me.sourceBox.Location = New System.Drawing.Point(109, 60)
        Me.sourceBox.Name = "sourceBox"
        Me.sourceBox.Size = New System.Drawing.Size(164, 20)
        Me.sourceBox.TabIndex = 29
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(30, 63)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl14.TabIndex = 28
        Me.LabelControl14.Text = "Source of Fund"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(109, 63)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl15.TabIndex = 27
        '
        'officerBox
        '
        Me.officerBox.Location = New System.Drawing.Point(109, 34)
        Me.officerBox.Name = "officerBox"
        Me.officerBox.Size = New System.Drawing.Size(164, 20)
        Me.officerBox.TabIndex = 26
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(72, 40)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl12.TabIndex = 25
        Me.LabelControl12.Text = "Name"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(109, 37)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl13.TabIndex = 24
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Location = New System.Drawing.Point(455, 5)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(105, 23)
        Me.SimpleButton2.TabIndex = 23
        Me.SimpleButton2.Text = "CONFIRM REQUEST"
        '
        'officeBox
        '
        Me.officeBox.Location = New System.Drawing.Point(331, 34)
        Me.officeBox.Name = "officeBox"
        Me.officeBox.Size = New System.Drawing.Size(164, 20)
        Me.officeBox.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(292, 37)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Office"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(331, 37)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl3.TabIndex = 3
        '
        'requestID
        '
        Me.requestID.Location = New System.Drawing.Point(69, 5)
        Me.requestID.Name = "requestID"
        Me.requestID.Size = New System.Drawing.Size(15, 13)
        Me.requestID.TabIndex = 2
        Me.requestID.Text = "ID:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Request ID:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(188, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(148, 25)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ITEM STOCK IN"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.purposeBox)
        Me.PanelControl1.Controls.Add(Me.LabelControl16)
        Me.PanelControl1.Controls.Add(Me.LabelControl17)
        Me.PanelControl1.Controls.Add(Me.sourceBox)
        Me.PanelControl1.Controls.Add(Me.LabelControl14)
        Me.PanelControl1.Controls.Add(Me.LabelControl15)
        Me.PanelControl1.Controls.Add(Me.officerBox)
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.officeBox)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.requestID)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(579, 93)
        Me.PanelControl1.TabIndex = 23
        '
        'subtotalBox
        '
        Me.subtotalBox.Location = New System.Drawing.Point(77, 446)
        Me.subtotalBox.Name = "subtotalBox"
        Me.subtotalBox.Size = New System.Drawing.Size(444, 20)
        Me.subtotalBox.TabIndex = 40
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(38, 453)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl18.TabIndex = 39
        Me.LabelControl18.Text = "Total"
        '
        'requestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.subtotalBox)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.measurementBox)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.requestCart)
        Me.Controls.Add(Me.totalBox)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.priceBox)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.quantityBox)
        Me.Controls.Add(Me.categBox)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.prodNameBox)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "requestForm"
        Me.Size = New System.Drawing.Size(579, 477)
        CType(Me.purposeBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.measurementBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.requestCart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.totalBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.priceBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantityBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.categBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prodNameBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sourceBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officerBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.subtotalBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents purposeBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents measurementBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents requestCart As DataGridView
    Friend WithEvents totalBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents priceBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents quantityBox As NumericUpDown
    Friend WithEvents categBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents prodNameBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sourceBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents officerBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents officeBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents requestID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents subtotalBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
End Class
