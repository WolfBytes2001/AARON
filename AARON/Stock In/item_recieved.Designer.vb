<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class item_recieved
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.recieveButton = New DevExpress.XtraEditors.SimpleButton()
        Me.recieveOn = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.condition = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.InspectedBy = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.vehicleType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.personnelDe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.recPOID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(579, 75)
        Me.Panel1.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ORDER RECIEVED"
        '
        'recieveButton
        '
        Me.recieveButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.recieveButton.Appearance.Options.UseBackColor = True
        Me.recieveButton.Location = New System.Drawing.Point(230, 370)
        Me.recieveButton.Name = "recieveButton"
        Me.recieveButton.Size = New System.Drawing.Size(122, 32)
        Me.recieveButton.TabIndex = 72
        Me.recieveButton.Text = "Recieve"
        '
        'recieveOn
        '
        Me.recieveOn.Location = New System.Drawing.Point(295, 307)
        Me.recieveOn.Name = "recieveOn"
        Me.recieveOn.Size = New System.Drawing.Size(213, 21)
        Me.recieveOn.TabIndex = 71
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(290, 285)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 18)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Recieved on"
        '
        'condition
        '
        Me.condition.FormattingEnabled = True
        Me.condition.Items.AddRange(New Object() {"Good"})
        Me.condition.Location = New System.Drawing.Point(52, 306)
        Me.condition.Name = "condition"
        Me.condition.Size = New System.Drawing.Size(213, 21)
        Me.condition.TabIndex = 69
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(49, 285)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Condition"
        '
        'InspectedBy
        '
        Me.InspectedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InspectedBy.Location = New System.Drawing.Point(295, 242)
        Me.InspectedBy.Name = "InspectedBy"
        Me.InspectedBy.Size = New System.Drawing.Size(213, 21)
        Me.InspectedBy.TabIndex = 67
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(292, 221)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 18)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Inspected By"
        '
        'vehicleType
        '
        Me.vehicleType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vehicleType.Location = New System.Drawing.Point(295, 188)
        Me.vehicleType.Name = "vehicleType"
        Me.vehicleType.Size = New System.Drawing.Size(213, 21)
        Me.vehicleType.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(292, 167)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 18)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Vehicle Type"
        '
        'personnelDe
        '
        Me.personnelDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.personnelDe.Location = New System.Drawing.Point(53, 242)
        Me.personnelDe.Name = "personnelDe"
        Me.personnelDe.Size = New System.Drawing.Size(213, 21)
        Me.personnelDe.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(50, 221)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 18)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Delivery Personnel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(20, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Delivery Details"
        '
        'recPOID
        '
        Me.recPOID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.recPOID.Location = New System.Drawing.Point(53, 188)
        Me.recPOID.Name = "recPOID"
        Me.recPOID.Size = New System.Drawing.Size(213, 21)
        Me.recPOID.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(50, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "PO ID"
        '
        'item_recieved
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.recieveButton)
        Me.Controls.Add(Me.recieveOn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.condition)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.InspectedBy)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.vehicleType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.personnelDe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.recPOID)
        Me.Controls.Add(Me.Label4)
        Me.Name = "item_recieved"
        Me.Size = New System.Drawing.Size(579, 477)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents recieveButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents recieveOn As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents condition As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents InspectedBy As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents vehicleType As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents personnelDe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents recPOID As TextBox
    Friend WithEvents Label4 As Label
End Class
