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
        Me.picBuilding = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMeterstoInches = New System.Windows.Forms.RadioButton()
        Me.radInchestoMeters = New System.Windows.Forms.RadioButton()
        Me.lblConversion = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBuilding
        '
        Me.picBuilding.Image = Global.Midterm_Exam_Project.My.Resources.Resources.building
        Me.picBuilding.Location = New System.Drawing.Point(-6, 12)
        Me.picBuilding.Name = "picBuilding"
        Me.picBuilding.Size = New System.Drawing.Size(215, 128)
        Me.picBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBuilding.TabIndex = 0
        Me.picBuilding.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(215, 21)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(271, 36)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Converter App"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInstruction
        '
        Me.lblInstruction.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.Location = New System.Drawing.Point(226, 83)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(203, 56)
        Me.lblInstruction.TabIndex = 2
        Me.lblInstruction.Text = "Enter a value and choose conversion"
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.Indigo
        Me.txtInput.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtInput.ForeColor = System.Drawing.Color.White
        Me.txtInput.Location = New System.Drawing.Point(459, 100)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(91, 24)
        Me.txtInput.TabIndex = 3
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Indigo
        Me.GroupBox1.Controls.Add(Me.radMeterstoInches)
        Me.GroupBox1.Controls.Add(Me.radInchestoMeters)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(272, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 78)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Convert Measurement"
        '
        'radMeterstoInches
        '
        Me.radMeterstoInches.AutoSize = True
        Me.radMeterstoInches.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radMeterstoInches.ForeColor = System.Drawing.Color.White
        Me.radMeterstoInches.Location = New System.Drawing.Point(13, 51)
        Me.radMeterstoInches.Name = "radMeterstoInches"
        Me.radMeterstoInches.Size = New System.Drawing.Size(130, 21)
        Me.radMeterstoInches.TabIndex = 1
        Me.radMeterstoInches.TabStop = True
        Me.radMeterstoInches.Text = "Meters to Inches"
        Me.radMeterstoInches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radMeterstoInches.UseVisualStyleBackColor = True
        '
        'radInchestoMeters
        '
        Me.radInchestoMeters.AutoSize = True
        Me.radInchestoMeters.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radInchestoMeters.ForeColor = System.Drawing.Color.White
        Me.radInchestoMeters.Location = New System.Drawing.Point(13, 29)
        Me.radInchestoMeters.Name = "radInchestoMeters"
        Me.radInchestoMeters.Size = New System.Drawing.Size(130, 21)
        Me.radInchestoMeters.TabIndex = 0
        Me.radInchestoMeters.TabStop = True
        Me.radInchestoMeters.Text = "Inches to Meters"
        Me.radInchestoMeters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radInchestoMeters.UseVisualStyleBackColor = True
        '
        'lblConversion
        '
        Me.lblConversion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversion.Location = New System.Drawing.Point(272, 292)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(301, 32)
        Me.lblConversion.TabIndex = 5
        Me.lblConversion.Text = "Conversion will be displayed here"
        Me.lblConversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnConvert.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnConvert.Location = New System.Drawing.Point(12, 384)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(153, 40)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(220, 384)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(153, 40)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.Location = New System.Drawing.Point(420, 384)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(153, 40)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(607, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblConversion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picBuilding)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBuilding As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblInstruction As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radMeterstoInches As RadioButton
    Friend WithEvents radInchestoMeters As RadioButton
    Friend WithEvents lblConversion As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
