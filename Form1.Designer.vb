<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Catering))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radC = New System.Windows.Forms.RadioButton()
        Me.radW = New System.Windows.Forms.RadioButton()
        Me.radV = New System.Windows.Forms.RadioButton()
        Me.radS = New System.Windows.Forms.RadioButton()
        Me.radF = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radPre = New System.Windows.Forms.RadioButton()
        Me.radPick = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(434, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(345, 216)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tendrils", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Catering"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("VNI Russia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Star Market"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radF)
        Me.GroupBox1.Controls.Add(Me.radS)
        Me.GroupBox1.Controls.Add(Me.radV)
        Me.GroupBox1.Controls.Add(Me.radW)
        Me.GroupBox1.Controls.Add(Me.radC)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 170)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'radC
        '
        Me.radC.AutoSize = True
        Me.radC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.radC.Location = New System.Drawing.Point(30, 24)
        Me.radC.Name = "radC"
        Me.radC.Size = New System.Drawing.Size(181, 21)
        Me.radC.TabIndex = 0
        Me.radC.TabStop = True
        Me.radC.Text = "Gourmet Cheese $49.99"
        Me.radC.UseVisualStyleBackColor = True
        '
        'radW
        '
        Me.radW.AutoSize = True
        Me.radW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.radW.Location = New System.Drawing.Point(36, 51)
        Me.radW.Name = "radW"
        Me.radW.Size = New System.Drawing.Size(175, 21)
        Me.radW.TabIndex = 1
        Me.radW.TabStop = True
        Me.radW.Text = "Pinwheel Wraps $59.99"
        Me.radW.UseVisualStyleBackColor = True
        '
        'radV
        '
        Me.radV.AutoSize = True
        Me.radV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.radV.Location = New System.Drawing.Point(42, 78)
        Me.radV.Name = "radV"
        Me.radV.Size = New System.Drawing.Size(118, 21)
        Me.radV.TabIndex = 2
        Me.radV.TabStop = True
        Me.radV.Text = "Veggie $29.99"
        Me.radV.UseVisualStyleBackColor = True
        '
        'radS
        '
        Me.radS.AutoSize = True
        Me.radS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.radS.Location = New System.Drawing.Point(48, 105)
        Me.radS.Name = "radS"
        Me.radS.Size = New System.Drawing.Size(210, 21)
        Me.radS.TabIndex = 3
        Me.radS.TabStop = True
        Me.radS.Text = "Sausage and Cheese $49.99"
        Me.radS.UseVisualStyleBackColor = True
        '
        'radF
        '
        Me.radF.AutoSize = True
        Me.radF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.radF.Location = New System.Drawing.Point(57, 135)
        Me.radF.Name = "radF"
        Me.radF.Size = New System.Drawing.Size(102, 21)
        Me.radF.TabIndex = 4
        Me.radF.TabStop = True
        Me.radF.Text = "Fruit $29.99"
        Me.radF.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radPick)
        Me.GroupBox2.Controls.Add(Me.radPre)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(84, 279)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(195, 81)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'radPre
        '
        Me.radPre.AutoSize = True
        Me.radPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.radPre.Location = New System.Drawing.Point(29, 27)
        Me.radPre.Name = "radPre"
        Me.radPre.Size = New System.Drawing.Size(89, 24)
        Me.radPre.TabIndex = 0
        Me.radPre.TabStop = True
        Me.radPre.Text = "Pre-Pay"
        Me.radPre.UseVisualStyleBackColor = True
        '
        'radPick
        '
        Me.radPick.AutoSize = True
        Me.radPick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.radPick.Location = New System.Drawing.Point(29, 57)
        Me.radPick.Name = "radPick"
        Me.radPick.Size = New System.Drawing.Size(159, 24)
        Me.radPick.TabIndex = 1
        Me.radPick.TabStop = True
        Me.radPick.Text = "Pay upon Pickup"
        Me.radPick.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Penultimate", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Please Pay:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(431, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Loyalty Points"
        '
        'btnCal
        '
        Me.btnCal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCal.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.Location = New System.Drawing.Point(434, 324)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(116, 49)
        Me.btnCal.TabIndex = 7
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Aqua
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(657, 324)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(122, 49)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtPoints
        '
        Me.txtPoints.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoints.Location = New System.Drawing.Point(582, 257)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(105, 30)
        Me.txtPoints.TabIndex = 9
        '
        'lblOutput
        '
        Me.lblOutput.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(187, 388)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(500, 66)
        Me.lblOutput.TabIndex = 10
        '
        'Catering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Catering"
        Me.Text = "Catering"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radF As RadioButton
    Friend WithEvents radS As RadioButton
    Friend WithEvents radV As RadioButton
    Friend WithEvents radW As RadioButton
    Friend WithEvents radC As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radPick As RadioButton
    Friend WithEvents radPre As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents lblOutput As Label
End Class
