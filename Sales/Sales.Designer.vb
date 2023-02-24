<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pbxLogo2 = New System.Windows.Forms.PictureBox()
        Me.grpQuantity = New System.Windows.Forms.GroupBox()
        Me.txtPackage3 = New System.Windows.Forms.TextBox()
        Me.txtPackage2 = New System.Windows.Forms.TextBox()
        Me.txtPackage1 = New System.Windows.Forms.TextBox()
        Me.lblPackageC = New System.Windows.Forms.Label()
        Me.lblPackageB = New System.Windows.Forms.Label()
        Me.lblPackageA = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbloutput = New System.Windows.Forms.Label()
        Me.lblDateAndTime = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQuantity.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(2, 12)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(105, 85)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
        '
        'pbxLogo2
        '
        Me.pbxLogo2.Image = CType(resources.GetObject("pbxLogo2.Image"), System.Drawing.Image)
        Me.pbxLogo2.Location = New System.Drawing.Point(444, 12)
        Me.pbxLogo2.Name = "pbxLogo2"
        Me.pbxLogo2.Size = New System.Drawing.Size(105, 85)
        Me.pbxLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo2.TabIndex = 1
        Me.pbxLogo2.TabStop = False
        '
        'grpQuantity
        '
        Me.grpQuantity.Controls.Add(Me.txtPackage3)
        Me.grpQuantity.Controls.Add(Me.txtPackage2)
        Me.grpQuantity.Controls.Add(Me.txtPackage1)
        Me.grpQuantity.Controls.Add(Me.lblPackageC)
        Me.grpQuantity.Controls.Add(Me.lblPackageB)
        Me.grpQuantity.Controls.Add(Me.lblPackageA)
        Me.grpQuantity.Location = New System.Drawing.Point(179, 117)
        Me.grpQuantity.Name = "grpQuantity"
        Me.grpQuantity.Size = New System.Drawing.Size(220, 141)
        Me.grpQuantity.TabIndex = 2
        Me.grpQuantity.TabStop = False
        Me.grpQuantity.Text = "Quantity"
        '
        'txtPackage3
        '
        Me.txtPackage3.Location = New System.Drawing.Point(86, 101)
        Me.txtPackage3.Name = "txtPackage3"
        Me.txtPackage3.Size = New System.Drawing.Size(100, 20)
        Me.txtPackage3.TabIndex = 5
        '
        'txtPackage2
        '
        Me.txtPackage2.Location = New System.Drawing.Point(86, 61)
        Me.txtPackage2.Name = "txtPackage2"
        Me.txtPackage2.Size = New System.Drawing.Size(100, 20)
        Me.txtPackage2.TabIndex = 4
        '
        'txtPackage1
        '
        Me.txtPackage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPackage1.Location = New System.Drawing.Point(86, 26)
        Me.txtPackage1.Name = "txtPackage1"
        Me.txtPackage1.Size = New System.Drawing.Size(100, 20)
        Me.txtPackage1.TabIndex = 3
        '
        'lblPackageC
        '
        Me.lblPackageC.AutoSize = True
        Me.lblPackageC.Location = New System.Drawing.Point(6, 104)
        Me.lblPackageC.Name = "lblPackageC"
        Me.lblPackageC.Size = New System.Drawing.Size(63, 13)
        Me.lblPackageC.TabIndex = 2
        Me.lblPackageC.Text = "Package C:"
        '
        'lblPackageB
        '
        Me.lblPackageB.AutoSize = True
        Me.lblPackageB.Location = New System.Drawing.Point(6, 68)
        Me.lblPackageB.Name = "lblPackageB"
        Me.lblPackageB.Size = New System.Drawing.Size(63, 13)
        Me.lblPackageB.TabIndex = 1
        Me.lblPackageB.Text = "Package B:"
        '
        'lblPackageA
        '
        Me.lblPackageA.AutoSize = True
        Me.lblPackageA.Location = New System.Drawing.Point(6, 29)
        Me.lblPackageA.Name = "lblPackageA"
        Me.lblPackageA.Size = New System.Drawing.Size(63, 13)
        Me.lblPackageA.TabIndex = 0
        Me.lblPackageA.Text = "Package A:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(363, 316)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "This will Calculate your total")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(272, 374)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "This will Clear your inputs and results")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(465, 374)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "This will Exit you out of the Program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbloutput
        '
        Me.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbloutput.Location = New System.Drawing.Point(12, 299)
        Me.lbloutput.Name = "lbloutput"
        Me.lbloutput.Size = New System.Drawing.Size(254, 131)
        Me.lbloutput.TabIndex = 3
        '
        'lblDateAndTime
        '
        Me.lblDateAndTime.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDateAndTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateAndTime.Location = New System.Drawing.Point(330, 410)
        Me.lblDateAndTime.Name = "lblDateAndTime"
        Me.lblDateAndTime.Size = New System.Drawing.Size(219, 25)
        Me.lblDateAndTime.TabIndex = 7
        Me.lblDateAndTime.Text = "Date and Time"
        '
        'lblCompany
        '
        Me.lblCompany.Font = New System.Drawing.Font("Vivaldi", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCompany.Location = New System.Drawing.Point(113, 12)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(325, 85)
        Me.lblCompany.TabIndex = 8
        Me.lblCompany.Text = "Ice Wolf hotel Package Sales"
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(458, 441)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(91, 13)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Brian Nicewander"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.Location = New System.Drawing.Point(123, 77)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(303, 20)
        Me.lblSales.TabIndex = 10
        Me.lblSales.Text = "Calculate the total of packages price"
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 459)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblDateAndTime)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lbloutput)
        Me.Controls.Add(Me.grpQuantity)
        Me.Controls.Add(Me.pbxLogo2)
        Me.Controls.Add(Me.pbxLogo)
        Me.Name = "Sales"
        Me.Text = "Package Sales"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQuantity.ResumeLayout(False)
        Me.grpQuantity.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents pbxLogo2 As PictureBox
    Friend WithEvents grpQuantity As GroupBox
    Friend WithEvents txtPackage3 As TextBox
    Friend WithEvents txtPackage2 As TextBox
    Friend WithEvents txtPackage1 As TextBox
    Friend WithEvents lblPackageC As Label
    Friend WithEvents lblPackageB As Label
    Friend WithEvents lblPackageA As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lbloutput As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDateAndTime As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblSales As Label
End Class
