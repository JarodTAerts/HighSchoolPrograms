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
        Me.list = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NOO = New System.Windows.Forms.Label()
        Me.T = New System.Windows.Forms.Label()
        Me.Ti = New System.Windows.Forms.Label()
        Me.NOS = New System.Windows.Forms.Label()
        Me.SAB = New System.Windows.Forms.TextBox()
        Me.AddS = New System.Windows.Forms.Button()
        Me.RS = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.start = New System.Windows.Forms.Button()
        Me.help = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tempchange = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lower = New System.Windows.Forms.RadioButton()
        Me.raise = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'list
        '
        Me.list.FormattingEnabled = True
        Me.list.Items.AddRange(New Object() {"5;50;70;90;1;"})
        Me.list.Location = New System.Drawing.Point(12, 159)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(388, 95)
        Me.list.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of Organisms:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tempature:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Current Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Species:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Number of Species:"
        '
        'NOO
        '
        Me.NOO.AutoSize = True
        Me.NOO.Location = New System.Drawing.Point(130, 13)
        Me.NOO.Name = "NOO"
        Me.NOO.Size = New System.Drawing.Size(13, 13)
        Me.NOO.TabIndex = 6
        Me.NOO.Text = "0"
        '
        'T
        '
        Me.T.AutoSize = True
        Me.T.Location = New System.Drawing.Point(80, 42)
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(13, 13)
        Me.T.TabIndex = 7
        Me.T.Text = "0"
        '
        'Ti
        '
        Me.Ti.AutoSize = True
        Me.Ti.Location = New System.Drawing.Point(89, 73)
        Me.Ti.Name = "Ti"
        Me.Ti.Size = New System.Drawing.Size(13, 13)
        Me.Ti.TabIndex = 8
        Me.Ti.Text = "0"
        '
        'NOS
        '
        Me.NOS.AutoSize = True
        Me.NOS.Location = New System.Drawing.Point(122, 103)
        Me.NOS.Name = "NOS"
        Me.NOS.Size = New System.Drawing.Size(13, 13)
        Me.NOS.TabIndex = 9
        Me.NOS.Text = "0"
        '
        'SAB
        '
        Me.SAB.Location = New System.Drawing.Point(15, 260)
        Me.SAB.Name = "SAB"
        Me.SAB.Size = New System.Drawing.Size(131, 20)
        Me.SAB.TabIndex = 10
        '
        'AddS
        '
        Me.AddS.Location = New System.Drawing.Point(149, 257)
        Me.AddS.Name = "AddS"
        Me.AddS.Size = New System.Drawing.Size(124, 23)
        Me.AddS.TabIndex = 11
        Me.AddS.Text = "Add New"
        Me.AddS.UseVisualStyleBackColor = True
        '
        'RS
        '
        Me.RS.Location = New System.Drawing.Point(149, 287)
        Me.RS.Name = "RS"
        Me.RS.Size = New System.Drawing.Size(124, 23)
        Me.RS.TabIndex = 12
        Me.RS.Text = "Remove Selected"
        Me.RS.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(672, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "100"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(669, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Time to Run:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(669, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Starting Tempature:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(672, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Text = "70"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(669, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Evolve Factor:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(672, 113)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 18
        Me.TextBox3.Text = "10000"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 526)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(760, 23)
        Me.ProgressBar1.TabIndex = 21
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(694, 497)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(75, 23)
        Me.start.TabIndex = 22
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = True
        '
        'help
        '
        Me.help.Location = New System.Drawing.Point(694, 468)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(75, 23)
        Me.help.TabIndex = 23
        Me.help.Text = "Help"
        Me.help.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(58, 354)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Tempature Every"
        '
        'tempchange
        '
        Me.tempchange.Location = New System.Drawing.Point(149, 351)
        Me.tempchange.Name = "tempchange"
        Me.tempchange.Size = New System.Drawing.Size(100, 20)
        Me.tempchange.TabIndex = 27
        Me.tempchange.Text = "100"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(258, 354)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Time"
        '
        'lower
        '
        Me.lower.AutoSize = True
        Me.lower.Location = New System.Drawing.Point(6, 362)
        Me.lower.Name = "lower"
        Me.lower.Size = New System.Drawing.Size(54, 17)
        Me.lower.TabIndex = 25
        Me.lower.Text = "Lower"
        Me.lower.UseVisualStyleBackColor = True
        '
        'raise
        '
        Me.raise.AutoSize = True
        Me.raise.Checked = True
        Me.raise.Location = New System.Drawing.Point(6, 339)
        Me.raise.Name = "raise"
        Me.raise.Size = New System.Drawing.Size(52, 17)
        Me.raise.TabIndex = 24
        Me.raise.TabStop = True
        Me.raise.Text = "Raise"
        Me.raise.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tempchange)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lower)
        Me.Controls.Add(Me.raise)
        Me.Controls.Add(Me.help)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RS)
        Me.Controls.Add(Me.AddS)
        Me.Controls.Add(Me.SAB)
        Me.Controls.Add(Me.NOS)
        Me.Controls.Add(Me.Ti)
        Me.Controls.Add(Me.T)
        Me.Controls.Add(Me.NOO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.list)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents list As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NOO As System.Windows.Forms.Label
    Friend WithEvents T As System.Windows.Forms.Label
    Friend WithEvents Ti As System.Windows.Forms.Label
    Friend WithEvents NOS As System.Windows.Forms.Label
    Friend WithEvents SAB As System.Windows.Forms.TextBox
    Friend WithEvents AddS As System.Windows.Forms.Button
    Friend WithEvents RS As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents start As System.Windows.Forms.Button
    Friend WithEvents help As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tempchange As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lower As System.Windows.Forms.RadioButton
    Friend WithEvents raise As System.Windows.Forms.RadioButton

End Class
