<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LifeSim
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.timebox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timelabel = New System.Windows.Forms.Label()
        Me.currenttime = New System.Windows.Forms.Label()
        Me.TimeProgress = New System.Windows.Forms.Label()
        Me.timepro = New System.Windows.Forms.Label()
        Me.TempLabel = New System.Windows.Forms.Label()
        Me.Temp = New System.Windows.Forms.Label()
        Me.specieslabel = New System.Windows.Forms.Label()
        Me.speciesnum = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.list = New System.Windows.Forms.ListBox()
        Me.SpeciesAdder = New System.Windows.Forms.TextBox()
        Me.addSpecies = New System.Windows.Forms.Button()
        Me.deleteSpecies = New System.Windows.Forms.Button()
        Me.Labelsp = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.poplimit = New System.Windows.Forms.TextBox()
        Me.Help = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Organisms:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(697, 497)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 526)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(760, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'timebox
        '
        Me.timebox.Location = New System.Drawing.Point(672, 40)
        Me.timebox.Name = "timebox"
        Me.timebox.Size = New System.Drawing.Size(100, 20)
        Me.timebox.TabIndex = 4
        Me.timebox.Text = "50"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(672, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Time to Run:"
        '
        'Timelabel
        '
        Me.Timelabel.AutoSize = True
        Me.Timelabel.Location = New System.Drawing.Point(13, 47)
        Me.Timelabel.Name = "Timelabel"
        Me.Timelabel.Size = New System.Drawing.Size(70, 13)
        Me.Timelabel.TabIndex = 6
        Me.Timelabel.Text = "Current Time:"
        '
        'currenttime
        '
        Me.currenttime.AutoSize = True
        Me.currenttime.Location = New System.Drawing.Point(89, 47)
        Me.currenttime.Name = "currenttime"
        Me.currenttime.Size = New System.Drawing.Size(13, 13)
        Me.currenttime.TabIndex = 7
        Me.currenttime.Text = "0"
        '
        'TimeProgress
        '
        Me.TimeProgress.AutoSize = True
        Me.TimeProgress.Location = New System.Drawing.Point(16, 507)
        Me.TimeProgress.Name = "TimeProgress"
        Me.TimeProgress.Size = New System.Drawing.Size(124, 13)
        Me.TimeProgress.TabIndex = 8
        Me.TimeProgress.Text = "Progress on current time:"
        '
        'timepro
        '
        Me.timepro.AutoSize = True
        Me.timepro.Location = New System.Drawing.Point(146, 507)
        Me.timepro.Name = "timepro"
        Me.timepro.Size = New System.Drawing.Size(13, 13)
        Me.timepro.TabIndex = 9
        Me.timepro.Text = "0"
        '
        'TempLabel
        '
        Me.TempLabel.AutoSize = True
        Me.TempLabel.Location = New System.Drawing.Point(13, 79)
        Me.TempLabel.Name = "TempLabel"
        Me.TempLabel.Size = New System.Drawing.Size(61, 13)
        Me.TempLabel.TabIndex = 10
        Me.TempLabel.Text = "Tempature:"
        '
        'Temp
        '
        Me.Temp.AutoSize = True
        Me.Temp.Location = New System.Drawing.Point(80, 79)
        Me.Temp.Name = "Temp"
        Me.Temp.Size = New System.Drawing.Size(13, 13)
        Me.Temp.TabIndex = 11
        Me.Temp.Text = "0"
        '
        'specieslabel
        '
        Me.specieslabel.AutoSize = True
        Me.specieslabel.Location = New System.Drawing.Point(13, 114)
        Me.specieslabel.Name = "specieslabel"
        Me.specieslabel.Size = New System.Drawing.Size(100, 13)
        Me.specieslabel.TabIndex = 12
        Me.specieslabel.Text = "Number of Species:"
        '
        'speciesnum
        '
        Me.speciesnum.AutoSize = True
        Me.speciesnum.Location = New System.Drawing.Point(119, 114)
        Me.speciesnum.Name = "speciesnum"
        Me.speciesnum.Size = New System.Drawing.Size(13, 13)
        Me.speciesnum.TabIndex = 13
        Me.speciesnum.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(675, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Start Tempature:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(672, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "65"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(672, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Evolve Factor:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(672, 130)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.Text = "100000"
        '
        'list
        '
        Me.list.FormattingEnabled = True
        Me.list.Items.AddRange(New Object() {"5;50;70;90;"})
        Me.list.Location = New System.Drawing.Point(16, 172)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(374, 95)
        Me.list.TabIndex = 18
        '
        'SpeciesAdder
        '
        Me.SpeciesAdder.Location = New System.Drawing.Point(19, 277)
        Me.SpeciesAdder.Name = "SpeciesAdder"
        Me.SpeciesAdder.Size = New System.Drawing.Size(127, 20)
        Me.SpeciesAdder.TabIndex = 19
        '
        'addSpecies
        '
        Me.addSpecies.Location = New System.Drawing.Point(150, 277)
        Me.addSpecies.Name = "addSpecies"
        Me.addSpecies.Size = New System.Drawing.Size(106, 23)
        Me.addSpecies.TabIndex = 20
        Me.addSpecies.Text = "Add New"
        Me.addSpecies.UseVisualStyleBackColor = True
        '
        'deleteSpecies
        '
        Me.deleteSpecies.Location = New System.Drawing.Point(150, 302)
        Me.deleteSpecies.Name = "deleteSpecies"
        Me.deleteSpecies.Size = New System.Drawing.Size(106, 23)
        Me.deleteSpecies.TabIndex = 21
        Me.deleteSpecies.Text = "Remove Selected"
        Me.deleteSpecies.UseVisualStyleBackColor = True
        '
        'Labelsp
        '
        Me.Labelsp.AutoSize = True
        Me.Labelsp.Location = New System.Drawing.Point(13, 156)
        Me.Labelsp.Name = "Labelsp"
        Me.Labelsp.Size = New System.Drawing.Size(48, 13)
        Me.Labelsp.TabIndex = 22
        Me.Labelsp.Text = "Species:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(675, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Population Limit:"
        '
        'poplimit
        '
        Me.poplimit.Location = New System.Drawing.Point(672, 174)
        Me.poplimit.Name = "poplimit"
        Me.poplimit.Size = New System.Drawing.Size(100, 20)
        Me.poplimit.TabIndex = 24
        Me.poplimit.Text = "1000"
        '
        'Help
        '
        Me.Help.Location = New System.Drawing.Point(697, 468)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(75, 23)
        Me.Help.TabIndex = 25
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = True
        '
        'LifeSim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.poplimit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Labelsp)
        Me.Controls.Add(Me.deleteSpecies)
        Me.Controls.Add(Me.addSpecies)
        Me.Controls.Add(Me.SpeciesAdder)
        Me.Controls.Add(Me.list)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.speciesnum)
        Me.Controls.Add(Me.specieslabel)
        Me.Controls.Add(Me.Temp)
        Me.Controls.Add(Me.TempLabel)
        Me.Controls.Add(Me.timepro)
        Me.Controls.Add(Me.TimeProgress)
        Me.Controls.Add(Me.currenttime)
        Me.Controls.Add(Me.Timelabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.timebox)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LifeSim"
        Me.Text = "Life Simulation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents timebox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timelabel As System.Windows.Forms.Label
    Friend WithEvents currenttime As System.Windows.Forms.Label
    Friend WithEvents TimeProgress As System.Windows.Forms.Label
    Friend WithEvents timepro As System.Windows.Forms.Label
    Friend WithEvents TempLabel As System.Windows.Forms.Label
    Friend WithEvents Temp As System.Windows.Forms.Label
    Public WithEvents specieslabel As System.Windows.Forms.Label
    Friend WithEvents speciesnum As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents list As System.Windows.Forms.ListBox
    Friend WithEvents SpeciesAdder As System.Windows.Forms.TextBox
    Friend WithEvents addSpecies As System.Windows.Forms.Button
    Friend WithEvents deleteSpecies As System.Windows.Forms.Button
    Friend WithEvents Labelsp As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents poplimit As System.Windows.Forms.TextBox
    Friend WithEvents Help As System.Windows.Forms.Button

End Class
