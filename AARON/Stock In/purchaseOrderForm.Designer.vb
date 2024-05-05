<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchaseOrderForm
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.POtotalPrice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.POpurposeBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.POfundBox = New System.Windows.Forms.TextBox()
        Me.quantity = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.POID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.POrequestedBy = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PRID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.itemsIncludedTable = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.itemsIncludedTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Location = New System.Drawing.Point(422, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(154, 34)
        Me.SimpleButton1.TabIndex = 41
        Me.SimpleButton1.Text = "Issue Purchase Order"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.POtotalPrice)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.POpurposeBox)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.POfundBox)
        Me.Panel2.Controls.Add(Me.quantity)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(0, 101)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(579, 155)
        Me.Panel2.TabIndex = 40
        '
        'POtotalPrice
        '
        Me.POtotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POtotalPrice.Location = New System.Drawing.Point(91, 91)
        Me.POtotalPrice.Multiline = True
        Me.POtotalPrice.Name = "POtotalPrice"
        Me.POtotalPrice.ReadOnly = True
        Me.POtotalPrice.Size = New System.Drawing.Size(396, 31)
        Me.POtotalPrice.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(86, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 18)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Source of Fund"
        '
        'POpurposeBox
        '
        Me.POpurposeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POpurposeBox.Location = New System.Drawing.Point(311, 37)
        Me.POpurposeBox.Name = "POpurposeBox"
        Me.POpurposeBox.ReadOnly = True
        Me.POpurposeBox.Size = New System.Drawing.Size(176, 24)
        Me.POpurposeBox.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(308, 16)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 18)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Purpose"
        '
        'POfundBox
        '
        Me.POfundBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POfundBox.Location = New System.Drawing.Point(89, 37)
        Me.POfundBox.Name = "POfundBox"
        Me.POfundBox.ReadOnly = True
        Me.POfundBox.Size = New System.Drawing.Size(184, 24)
        Me.POfundBox.TabIndex = 36
        '
        'quantity
        '
        Me.quantity.AutoSize = True
        Me.quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity.ForeColor = System.Drawing.Color.Red
        Me.quantity.Location = New System.Drawing.Point(87, 68)
        Me.quantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(116, 20)
        Me.quantity.TabIndex = 3
        Me.quantity.Text = "Total Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 224)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 18)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Item Description"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label12.Location = New System.Drawing.Point(12, 44)
        Me.label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(138, 16)
        Me.label12.TabIndex = 3
        Me.label12.Text = "Purchase Order ID:"
        '
        'POID
        '
        Me.POID.AutoSize = True
        Me.POID.BackColor = System.Drawing.Color.Transparent
        Me.POID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POID.ForeColor = System.Drawing.Color.Black
        Me.POID.Location = New System.Drawing.Point(154, 40)
        Me.POID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.POID.Name = "POID"
        Me.POID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.POID.Size = New System.Drawing.Size(41, 20)
        Me.POID.TabIndex = 2
        Me.POID.Text = "RQ-"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Controls.Add(Me.POrequestedBy)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PRID)
        Me.Panel1.Controls.Add(Me.label12)
        Me.Panel1.Controls.Add(Me.POID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(579, 101)
        Me.Panel1.TabIndex = 37
        '
        'POrequestedBy
        '
        Me.POrequestedBy.AutoSize = True
        Me.POrequestedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POrequestedBy.ForeColor = System.Drawing.Color.Black
        Me.POrequestedBy.Location = New System.Drawing.Point(125, 70)
        Me.POrequestedBy.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.POrequestedBy.Name = "POrequestedBy"
        Me.POrequestedBy.Size = New System.Drawing.Size(108, 16)
        Me.POrequestedBy.TabIndex = 7
        Me.POrequestedBy.Text = "Requested by:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(13, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Requested by:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(320, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PR ID:"
        '
        'PRID
        '
        Me.PRID.AutoSize = True
        Me.PRID.BackColor = System.Drawing.Color.Transparent
        Me.PRID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRID.ForeColor = System.Drawing.Color.Black
        Me.PRID.Location = New System.Drawing.Point(375, 44)
        Me.PRID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PRID.Name = "PRID"
        Me.PRID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PRID.Size = New System.Drawing.Size(41, 20)
        Me.PRID.TabIndex = 4
        Me.PRID.Text = "RQ-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PURCHASE ORDER"
        '
        'itemsIncludedTable
        '
        Me.itemsIncludedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.itemsIncludedTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemsIncludedTable.Location = New System.Drawing.Point(0, 256)
        Me.itemsIncludedTable.Name = "itemsIncludedTable"
        Me.itemsIncludedTable.Size = New System.Drawing.Size(579, 221)
        Me.itemsIncludedTable.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(9, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Items Included"
        '
        'purchaseOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.itemsIncludedTable)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "purchaseOrderForm"
        Me.Size = New System.Drawing.Size(579, 477)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.itemsIncludedTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents POtotalPrice As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents POpurposeBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents POfundBox As TextBox
    Friend WithEvents quantity As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents label12 As Label
    Friend WithEvents POID As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents POrequestedBy As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PRID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents itemsIncludedTable As DataGridView
End Class
