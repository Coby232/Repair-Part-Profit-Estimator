<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PartDescriptionString = New System.Windows.Forms.Label()
        Me.PartIdentifierTextBox = New System.Windows.Forms.TextBox()
        Me.PartIdentityString = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.RetailPriceTextBox = New System.Windows.Forms.TextBox()
        Me.NetProfit = New System.Windows.Forms.Label()
        Me.StorageCharges = New System.Windows.Forms.Label()
        Me.GrossProfit = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.Label()
        Me.WholesaleCost = New System.Windows.Forms.Label()
        Me.RetailPrice = New System.Windows.Forms.Label()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.TotalNetProfitButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.PartDescriptionString)
        Me.GroupBox1.Controls.Add(Me.PartIdentifierTextBox)
        Me.GroupBox1.Controls.Add(Me.PartIdentityString)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(40, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Part Information"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(165, 60)
        Me.TextBox2.MaxLength = 21
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(340, 26)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "Radiator, Ford Escort"
        '
        'PartDescriptionString
        '
        Me.PartDescriptionString.AutoSize = True
        Me.PartDescriptionString.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartDescriptionString.ForeColor = System.Drawing.Color.Black
        Me.PartDescriptionString.Location = New System.Drawing.Point(6, 63)
        Me.PartDescriptionString.Name = "PartDescriptionString"
        Me.PartDescriptionString.Size = New System.Drawing.Size(136, 20)
        Me.PartDescriptionString.TabIndex = 1
        Me.PartDescriptionString.Text = "Part Description:"
        '
        'PartIdentifierTextBox
        '
        Me.PartIdentifierTextBox.HideSelection = False
        Me.PartIdentifierTextBox.Location = New System.Drawing.Point(165, 23)
        Me.PartIdentifierTextBox.MaximumSize = New System.Drawing.Size(340, 26)
        Me.PartIdentifierTextBox.MaxLength = 9
        Me.PartIdentifierTextBox.MinimumSize = New System.Drawing.Size(340, 26)
        Me.PartIdentifierTextBox.Name = "PartIdentifierTextBox"
        Me.PartIdentifierTextBox.Size = New System.Drawing.Size(340, 26)
        Me.PartIdentifierTextBox.TabIndex = 1
        Me.PartIdentifierTextBox.Text = "X456YVK98"
        '
        'PartIdentityString
        '
        Me.PartIdentityString.AutoSize = True
        Me.PartIdentityString.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartIdentityString.ForeColor = System.Drawing.Color.Black
        Me.PartIdentityString.Location = New System.Drawing.Point(6, 29)
        Me.PartIdentityString.Name = "PartIdentityString"
        Me.PartIdentityString.Size = New System.Drawing.Size(114, 20)
        Me.PartIdentityString.TabIndex = 0
        Me.PartIdentityString.Text = "Part Identifier:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.RetailPriceTextBox)
        Me.GroupBox2.Controls.Add(Me.NetProfit)
        Me.GroupBox2.Controls.Add(Me.StorageCharges)
        Me.GroupBox2.Controls.Add(Me.GrossProfit)
        Me.GroupBox2.Controls.Add(Me.Quantity)
        Me.GroupBox2.Controls.Add(Me.WholesaleCost)
        Me.GroupBox2.Controls.Add(Me.RetailPrice)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(40, 162)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 265)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Price, Cost, Storage, Profit"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(176, 209)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(170, 26)
        Me.TextBox8.TabIndex = 11
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(176, 175)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(170, 26)
        Me.TextBox7.TabIndex = 10
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(176, 141)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(170, 26)
        Me.TextBox6.TabIndex = 9
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(244, 107)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(102, 26)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(176, 73)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(170, 26)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RetailPriceTextBox
        '
        Me.RetailPriceTextBox.Location = New System.Drawing.Point(176, 39)
        Me.RetailPriceTextBox.Name = "RetailPriceTextBox"
        Me.RetailPriceTextBox.Size = New System.Drawing.Size(170, 26)
        Me.RetailPriceTextBox.TabIndex = 6
        Me.RetailPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NetProfit
        '
        Me.NetProfit.AutoSize = True
        Me.NetProfit.ForeColor = System.Drawing.Color.Black
        Me.NetProfit.Location = New System.Drawing.Point(19, 212)
        Me.NetProfit.Name = "NetProfit"
        Me.NetProfit.Size = New System.Drawing.Size(85, 20)
        Me.NetProfit.TabIndex = 5
        Me.NetProfit.Text = "Net Profit:"
        '
        'StorageCharges
        '
        Me.StorageCharges.AutoSize = True
        Me.StorageCharges.ForeColor = System.Drawing.Color.Black
        Me.StorageCharges.Location = New System.Drawing.Point(19, 178)
        Me.StorageCharges.Name = "StorageCharges"
        Me.StorageCharges.Size = New System.Drawing.Size(140, 20)
        Me.StorageCharges.TabIndex = 4
        Me.StorageCharges.Text = "Storage Charges:"
        '
        'GrossProfit
        '
        Me.GrossProfit.AutoSize = True
        Me.GrossProfit.ForeColor = System.Drawing.Color.Black
        Me.GrossProfit.Location = New System.Drawing.Point(19, 144)
        Me.GrossProfit.Name = "GrossProfit"
        Me.GrossProfit.Size = New System.Drawing.Size(105, 20)
        Me.GrossProfit.TabIndex = 3
        Me.GrossProfit.Text = "Gross Profit:"
        '
        'Quantity
        '
        Me.Quantity.AutoSize = True
        Me.Quantity.ForeColor = System.Drawing.Color.Black
        Me.Quantity.Location = New System.Drawing.Point(19, 110)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(76, 20)
        Me.Quantity.TabIndex = 2
        Me.Quantity.Text = "Quantity:"
        '
        'WholesaleCost
        '
        Me.WholesaleCost.AutoSize = True
        Me.WholesaleCost.ForeColor = System.Drawing.Color.Black
        Me.WholesaleCost.Location = New System.Drawing.Point(19, 76)
        Me.WholesaleCost.Name = "WholesaleCost"
        Me.WholesaleCost.Size = New System.Drawing.Size(132, 20)
        Me.WholesaleCost.TabIndex = 1
        Me.WholesaleCost.Text = "Wholesale Cost:"
        '
        'RetailPrice
        '
        Me.RetailPrice.AutoSize = True
        Me.RetailPrice.ForeColor = System.Drawing.Color.Black
        Me.RetailPrice.Location = New System.Drawing.Point(19, 42)
        Me.RetailPrice.Name = "RetailPrice"
        Me.RetailPrice.Size = New System.Drawing.Size(101, 20)
        Me.RetailPrice.TabIndex = 0
        Me.RetailPrice.Text = "Retail Price:"
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(432, 175)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(146, 49)
        Me.ComputeButton.TabIndex = 2
        Me.ComputeButton.Text = "Compute"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(432, 235)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(146, 49)
        Me.ResetButton.TabIndex = 3
        Me.ResetButton.Text = "Reset Form"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'TotalNetProfitButton
        '
        Me.TotalNetProfitButton.Location = New System.Drawing.Point(432, 293)
        Me.TotalNetProfitButton.Name = "TotalNetProfitButton"
        Me.TotalNetProfitButton.Size = New System.Drawing.Size(146, 62)
        Me.TotalNetProfitButton.TabIndex = 4
        Me.TotalNetProfitButton.Text = "Total Net" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Profit"
        Me.TotalNetProfitButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(432, 361)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(146, 49)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ToolTip2
        '
        Me.ToolTip2.ToolTipTitle = "RetailPrice"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TotalNetProfitButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(621, 497)
        Me.MinimumSize = New System.Drawing.Size(621, 497)
        Me.Name = "Form1"
        Me.Text = "Repair Part Profit Estimator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PartDescriptionString As Label
    Friend WithEvents PartIdentifierTextBox As TextBox
    Friend WithEvents PartIdentityString As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RetailPriceTextBox As TextBox
    Friend WithEvents NetProfit As Label
    Friend WithEvents StorageCharges As Label
    Friend WithEvents GrossProfit As Label
    Friend WithEvents Quantity As Label
    Friend WithEvents WholesaleCost As Label
    Friend WithEvents RetailPrice As Label
    Friend WithEvents ComputeButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents TotalNetProfitButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip2 As ToolTip
End Class
