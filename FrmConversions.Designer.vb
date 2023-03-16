<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConversions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConversions))
        Me.picBluePrint = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.boxInput = New System.Windows.Forms.TextBox()
        Me.grpRadioBox = New System.Windows.Forms.GroupBox()
        Me.radMeters = New System.Windows.Forms.RadioButton()
        Me.radInches = New System.Windows.Forms.RadioButton()
        Me.lblConverted = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picBluePrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRadioBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBluePrint
        '
        Me.picBluePrint.Image = CType(resources.GetObject("picBluePrint.Image"), System.Drawing.Image)
        Me.picBluePrint.Location = New System.Drawing.Point(1, 1)
        Me.picBluePrint.Name = "picBluePrint"
        Me.picBluePrint.Size = New System.Drawing.Size(231, 160)
        Me.picBluePrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBluePrint.TabIndex = 0
        Me.picBluePrint.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Elephant", 20.0!)
        Me.lblHeading.Location = New System.Drawing.Point(387, 54)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(211, 35)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Converter App"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(322, 115)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(180, 46)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Enter a value and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "choose conversion"
        '
        'boxInput
        '
        Me.boxInput.BackColor = System.Drawing.Color.DarkSlateGray
        Me.boxInput.Font = New System.Drawing.Font("Britannic Bold", 16.0!)
        Me.boxInput.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.boxInput.Location = New System.Drawing.Point(551, 124)
        Me.boxInput.Name = "boxInput"
        Me.boxInput.Size = New System.Drawing.Size(100, 31)
        Me.boxInput.TabIndex = 6
        '
        'grpRadioBox
        '
        Me.grpRadioBox.BackColor = System.Drawing.Color.DarkSlateGray
        Me.grpRadioBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.grpRadioBox.Controls.Add(Me.radMeters)
        Me.grpRadioBox.Controls.Add(Me.radInches)
        Me.grpRadioBox.Font = New System.Drawing.Font("Britannic Bold", 16.0!)
        Me.grpRadioBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.grpRadioBox.Location = New System.Drawing.Point(393, 189)
        Me.grpRadioBox.Name = "grpRadioBox"
        Me.grpRadioBox.Size = New System.Drawing.Size(240, 97)
        Me.grpRadioBox.TabIndex = 7
        Me.grpRadioBox.TabStop = False
        Me.grpRadioBox.Text = "Convert Measurement"
        '
        'radMeters
        '
        Me.radMeters.AutoSize = True
        Me.radMeters.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.radMeters.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.radMeters.Location = New System.Drawing.Point(17, 59)
        Me.radMeters.Name = "radMeters"
        Me.radMeters.Size = New System.Drawing.Size(129, 22)
        Me.radMeters.TabIndex = 1
        Me.radMeters.TabStop = True
        Me.radMeters.Text = "Meters to Inches"
        Me.radMeters.UseVisualStyleBackColor = True
        '
        'radInches
        '
        Me.radInches.AutoSize = True
        Me.radInches.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.radInches.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.radInches.Location = New System.Drawing.Point(17, 31)
        Me.radInches.Name = "radInches"
        Me.radInches.Size = New System.Drawing.Size(129, 22)
        Me.radInches.TabIndex = 0
        Me.radInches.TabStop = True
        Me.radInches.Text = "Inches to Meters"
        Me.radInches.UseVisualStyleBackColor = True
        '
        'lblConverted
        '
        Me.lblConverted.AutoSize = True
        Me.lblConverted.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConverted.Location = New System.Drawing.Point(418, 321)
        Me.lblConverted.Name = "lblConverted"
        Me.lblConverted.Size = New System.Drawing.Size(0, 23)
        Me.lblConverted.TabIndex = 8
        '
        'btnConvert
        '
        Me.btnConvert.FlatAppearance.BorderSize = 3
        Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConvert.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.btnConvert.Location = New System.Drawing.Point(82, 379)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(117, 40)
        Me.btnConvert.TabIndex = 9
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.BorderSize = 3
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.btnClear.Location = New System.Drawing.Point(344, 379)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 40)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderSize = 3
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.btnExit.Location = New System.Drawing.Point(605, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 40)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmConversions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblConverted)
        Me.Controls.Add(Me.grpRadioBox)
        Me.Controls.Add(Me.boxInput)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picBluePrint)
        Me.Name = "frmConversions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Building Plans Conversion"
        CType(Me.picBluePrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRadioBox.ResumeLayout(False)
        Me.grpRadioBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBluePrint As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents boxInput As TextBox
    Friend WithEvents grpRadioBox As GroupBox
    Friend WithEvents radMeters As RadioButton
    Friend WithEvents radInches As RadioButton
    Friend WithEvents lblConverted As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
