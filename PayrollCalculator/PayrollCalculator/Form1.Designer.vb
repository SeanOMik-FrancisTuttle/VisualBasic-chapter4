<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollCalc
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
        Me.lblBiWeeklyIncome = New System.Windows.Forms.Label()
        Me.txtBiWeeklyIncome = New System.Windows.Forms.TextBox()
        Me.lblFICATaxLabel = New System.Windows.Forms.Label()
        Me.lblFederalTaxLabel = New System.Windows.Forms.Label()
        Me.lblStateIncomeTaxLabel = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnCalculatePay = New System.Windows.Forms.Button()
        Me.lblFICATax = New System.Windows.Forms.Label()
        Me.lblStateIncomeTax = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblNetPayLabel = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBiWeeklyIncome
        '
        Me.lblBiWeeklyIncome.AutoSize = True
        Me.lblBiWeeklyIncome.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiWeeklyIncome.Location = New System.Drawing.Point(80, 76)
        Me.lblBiWeeklyIncome.Name = "lblBiWeeklyIncome"
        Me.lblBiWeeklyIncome.Size = New System.Drawing.Size(154, 19)
        Me.lblBiWeeklyIncome.TabIndex = 0
        Me.lblBiWeeklyIncome.Text = "Biweekly Income:"
        '
        'txtBiWeeklyIncome
        '
        Me.txtBiWeeklyIncome.Location = New System.Drawing.Point(240, 75)
        Me.txtBiWeeklyIncome.Name = "txtBiWeeklyIncome"
        Me.txtBiWeeklyIncome.Size = New System.Drawing.Size(100, 20)
        Me.txtBiWeeklyIncome.TabIndex = 1
        '
        'lblFICATaxLabel
        '
        Me.lblFICATaxLabel.AutoSize = True
        Me.lblFICATaxLabel.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICATaxLabel.Location = New System.Drawing.Point(83, 108)
        Me.lblFICATaxLabel.Name = "lblFICATaxLabel"
        Me.lblFICATaxLabel.Size = New System.Drawing.Size(143, 17)
        Me.lblFICATaxLabel.TabIndex = 2
        Me.lblFICATaxLabel.Text = "FICA tax (7.65%):"
        '
        'lblFederalTaxLabel
        '
        Me.lblFederalTaxLabel.AutoSize = True
        Me.lblFederalTaxLabel.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTaxLabel.Location = New System.Drawing.Point(83, 125)
        Me.lblFederalTaxLabel.Name = "lblFederalTaxLabel"
        Me.lblFederalTaxLabel.Size = New System.Drawing.Size(148, 17)
        Me.lblFederalTaxLabel.TabIndex = 3
        Me.lblFederalTaxLabel.Text = "Federal tax (22%):"
        '
        'lblStateIncomeTaxLabel
        '
        Me.lblStateIncomeTaxLabel.AutoSize = True
        Me.lblStateIncomeTaxLabel.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateIncomeTaxLabel.Location = New System.Drawing.Point(83, 142)
        Me.lblStateIncomeTaxLabel.Name = "lblStateIncomeTaxLabel"
        Me.lblStateIncomeTaxLabel.Size = New System.Drawing.Size(185, 17)
        Me.lblStateIncomeTaxLabel.TabIndex = 4
        Me.lblStateIncomeTaxLabel.Text = "State Income Tax (4%):"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(103, 13)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(214, 24)
        Me.lblWelcome.TabIndex = 5
        Me.lblWelcome.Text = "Pay Roll Calculator"
        '
        'btnCalculatePay
        '
        Me.btnCalculatePay.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculatePay.Location = New System.Drawing.Point(12, 199)
        Me.btnCalculatePay.Name = "btnCalculatePay"
        Me.btnCalculatePay.Size = New System.Drawing.Size(122, 50)
        Me.btnCalculatePay.TabIndex = 6
        Me.btnCalculatePay.Text = "Calculate Pay"
        Me.btnCalculatePay.UseVisualStyleBackColor = True
        '
        'lblFICATax
        '
        Me.lblFICATax.AutoSize = True
        Me.lblFICATax.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICATax.Location = New System.Drawing.Point(270, 108)
        Me.lblFICATax.Name = "lblFICATax"
        Me.lblFICATax.Size = New System.Drawing.Size(67, 17)
        Me.lblFICATax.TabIndex = 7
        Me.lblFICATax.Text = "$888.88"
        '
        'lblStateIncomeTax
        '
        Me.lblStateIncomeTax.AutoSize = True
        Me.lblStateIncomeTax.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateIncomeTax.Location = New System.Drawing.Point(270, 142)
        Me.lblStateIncomeTax.Name = "lblStateIncomeTax"
        Me.lblStateIncomeTax.Size = New System.Drawing.Size(67, 17)
        Me.lblStateIncomeTax.TabIndex = 8
        Me.lblStateIncomeTax.Text = "$888.88"
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTax.Location = New System.Drawing.Point(270, 125)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(67, 17)
        Me.lblFederalTax.TabIndex = 9
        Me.lblFederalTax.Text = "$888.88"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(149, 200)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(122, 50)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(286, 200)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 50)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblNetPayLabel
        '
        Me.lblNetPayLabel.AutoSize = True
        Me.lblNetPayLabel.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPayLabel.Location = New System.Drawing.Point(82, 162)
        Me.lblNetPayLabel.Name = "lblNetPayLabel"
        Me.lblNetPayLabel.Size = New System.Drawing.Size(76, 19)
        Me.lblNetPayLabel.TabIndex = 13
        Me.lblNetPayLabel.Text = "Net Pay:"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(270, 163)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(67, 17)
        Me.lblNetPay.TabIndex = 14
        Me.lblNetPay.Text = "$888.88"
        '
        'frmPayrollCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 256)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblNetPayLabel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.lblStateIncomeTax)
        Me.Controls.Add(Me.lblFICATax)
        Me.Controls.Add(Me.btnCalculatePay)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblStateIncomeTaxLabel)
        Me.Controls.Add(Me.lblFederalTaxLabel)
        Me.Controls.Add(Me.lblFICATaxLabel)
        Me.Controls.Add(Me.txtBiWeeklyIncome)
        Me.Controls.Add(Me.lblBiWeeklyIncome)
        Me.Name = "frmPayrollCalc"
        Me.Text = "Payroll Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBiWeeklyIncome As Label
    Friend WithEvents txtBiWeeklyIncome As TextBox
    Friend WithEvents lblFICATaxLabel As Label
    Friend WithEvents lblFederalTaxLabel As Label
    Friend WithEvents lblStateIncomeTaxLabel As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnCalculatePay As Button
    Friend WithEvents lblFICATax As Label
    Friend WithEvents lblStateIncomeTax As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblNetPayLabel As Label
    Friend WithEvents lblNetPay As Label
End Class
