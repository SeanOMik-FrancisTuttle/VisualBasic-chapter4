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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.mtxtBirthDate = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtCurrentDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.lblAmountOfTimeExer = New System.Windows.Forms.Label()
        Me.lblAmountOfTimeExerLabel = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnTrack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(182, 47)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(72, 51)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(86, 15)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name:"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDate.Location = New System.Drawing.Point(72, 77)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(81, 15)
        Me.lblBirthDate.TabIndex = 3
        Me.lblBirthDate.Text = "Birth Date:"
        '
        'mtxtBirthDate
        '
        Me.mtxtBirthDate.Location = New System.Drawing.Point(182, 74)
        Me.mtxtBirthDate.Mask = "00/00/0000"
        Me.mtxtBirthDate.Name = "mtxtBirthDate"
        Me.mtxtBirthDate.Size = New System.Drawing.Size(100, 20)
        Me.mtxtBirthDate.TabIndex = 4
        Me.mtxtBirthDate.ValidatingType = GetType(Date)
        '
        'mtxtCurrentDate
        '
        Me.mtxtCurrentDate.Location = New System.Drawing.Point(182, 100)
        Me.mtxtCurrentDate.Mask = "00/00/0000"
        Me.mtxtCurrentDate.Name = "mtxtCurrentDate"
        Me.mtxtCurrentDate.Size = New System.Drawing.Size(100, 20)
        Me.mtxtCurrentDate.TabIndex = 6
        Me.mtxtCurrentDate.ValidatingType = GetType(Date)
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.Location = New System.Drawing.Point(72, 103)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(98, 15)
        Me.lblCurrentDate.TabIndex = 5
        Me.lblCurrentDate.Text = "Current Date:"
        '
        'lblAmountOfTimeExer
        '
        Me.lblAmountOfTimeExer.AutoSize = True
        Me.lblAmountOfTimeExer.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountOfTimeExer.Location = New System.Drawing.Point(248, 134)
        Me.lblAmountOfTimeExer.Name = "lblAmountOfTimeExer"
        Me.lblAmountOfTimeExer.Size = New System.Drawing.Size(82, 17)
        Me.lblAmountOfTimeExer.TabIndex = 7
        Me.lblAmountOfTimeExer.Text = "10000 hrs"
        '
        'lblAmountOfTimeExerLabel
        '
        Me.lblAmountOfTimeExerLabel.AutoSize = True
        Me.lblAmountOfTimeExerLabel.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountOfTimeExerLabel.Location = New System.Drawing.Point(25, 134)
        Me.lblAmountOfTimeExerLabel.Name = "lblAmountOfTimeExerLabel"
        Me.lblAmountOfTimeExerLabel.Size = New System.Drawing.Size(217, 17)
        Me.lblAmountOfTimeExerLabel.TabIndex = 8
        Me.lblAmountOfTimeExerLabel.Text = "Amount of Time Exercised: "
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(89, 11)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(177, 24)
        Me.lblWelcome.TabIndex = 9
        Me.lblWelcome.Text = "Fitness Tracker"
        '
        'btnTrack
        '
        Me.btnTrack.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrack.Location = New System.Drawing.Point(12, 183)
        Me.btnTrack.Name = "btnTrack"
        Me.btnTrack.Size = New System.Drawing.Size(102, 100)
        Me.btnTrack.TabIndex = 10
        Me.btnTrack.Text = "Track"
        Me.btnTrack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(126, 183)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 100)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(241, 183)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 100)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 295)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTrack)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblAmountOfTimeExerLabel)
        Me.Controls.Add(Me.lblAmountOfTimeExer)
        Me.Controls.Add(Me.mtxtCurrentDate)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.mtxtBirthDate)
        Me.Controls.Add(Me.lblBirthDate)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents mtxtBirthDate As MaskedTextBox
    Friend WithEvents mtxtCurrentDate As MaskedTextBox
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents lblAmountOfTimeExer As Label
    Friend WithEvents lblAmountOfTimeExerLabel As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnTrack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
