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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RoastingLabel = New System.Windows.Forms.Label()
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProcess = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCopy = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.RoastingPic = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.RoastingPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.RoastingLabel)
        Me.Panel1.Controls.Add(Me.RoastingPic)
        Me.Panel1.Controls.Add(Me.Closebtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 25)
        Me.Panel1.TabIndex = 0
        '
        'RoastingLabel
        '
        Me.RoastingLabel.AutoSize = True
        Me.RoastingLabel.Location = New System.Drawing.Point(31, 6)
        Me.RoastingLabel.Name = "RoastingLabel"
        Me.RoastingLabel.Size = New System.Drawing.Size(122, 14)
        Me.RoastingLabel.TabIndex = 2
        Me.RoastingLabel.Text = "Roasting Link Shortener"
        '
        'Closebtn
        '
        Me.Closebtn.BackColor = System.Drawing.Color.Red
        Me.Closebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Closebtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Closebtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Closebtn.Location = New System.Drawing.Point(212, 0)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(25, 25)
        Me.Closebtn.TabIndex = 0
        Me.Closebtn.Text = "X"
        Me.Closebtn.UseVisualStyleBackColor = False
        '
        'txtURL
        '
        Me.txtURL.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtURL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtURL.ForeColor = System.Drawing.Color.White
        Me.txtURL.Location = New System.Drawing.Point(12, 45)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(213, 26)
        Me.txtURL.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter URL"
        '
        'btnProcess
        '
        Me.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcess.Location = New System.Drawing.Point(15, 77)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.btnProcess.Size = New System.Drawing.Size(79, 25)
        Me.btnProcess.TabIndex = 3
        Me.btnProcess.Values.Text = "Shorten Link"
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOutput.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.ForeColor = System.Drawing.Color.White
        Me.txtOutput.Location = New System.Drawing.Point(12, 125)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(213, 26)
        Me.txtOutput.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Shortened Link"
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(12, 157)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.btnCopy.Size = New System.Drawing.Size(79, 25)
        Me.btnCopy.TabIndex = 6
        Me.btnCopy.Values.Text = "Copy"
        '
        'RoastingPic
        '
        Me.RoastingPic.BackColor = System.Drawing.Color.Black
        Me.RoastingPic.BackgroundImage = Global.Roasting_Link_Shortener.My.Resources.Resources.shorten
        Me.RoastingPic.Image = Global.Roasting_Link_Shortener.My.Resources.Resources.shorten
        Me.RoastingPic.Location = New System.Drawing.Point(0, 0)
        Me.RoastingPic.Name = "RoastingPic"
        Me.RoastingPic.Size = New System.Drawing.Size(25, 25)
        Me.RoastingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RoastingPic.TabIndex = 1
        Me.RoastingPic.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(237, 190)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RoastingPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Closebtn As Button
    Friend WithEvents RoastingLabel As Label
    Friend WithEvents RoastingPic As PictureBox
    Friend WithEvents txtURL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnProcess As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCopy As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
