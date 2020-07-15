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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.showgraph = New System.Windows.Forms.Button()
        Me.processing = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.enmass = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.seet = New System.Windows.Forms.Button()
        Me.envsize = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.removesubstance = New System.Windows.Forms.Button()
        Me.addsubstance = New System.Windows.Forms.Button()
        Me.substance = New System.Windows.Forms.TextBox()
        Me.Substances = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'list
        '
        Me.list.FormattingEnabled = True
        Me.list.Items.AddRange(New Object() {"5;50;70;90;1;", "12;35;61;83;3;", "9;41;66;87;5;", "4;55;76;101;4;", "7;44;68;89;16;"})
        Me.list.Location = New System.Drawing.Point(9, 137)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(651, 95)
        Me.list.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of Organisms:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tempature:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Current Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Species:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Number of Species:"
        '
        'NOO
        '
        Me.NOO.AutoSize = True
        Me.NOO.Location = New System.Drawing.Point(123, 12)
        Me.NOO.Name = "NOO"
        Me.NOO.Size = New System.Drawing.Size(13, 13)
        Me.NOO.TabIndex = 6
        Me.NOO.Text = "0"
        '
        'T
        '
        Me.T.AutoSize = True
        Me.T.Location = New System.Drawing.Point(73, 35)
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(13, 13)
        Me.T.TabIndex = 7
        Me.T.Text = "0"
        '
        'Ti
        '
        Me.Ti.AutoSize = True
        Me.Ti.Location = New System.Drawing.Point(82, 58)
        Me.Ti.Name = "Ti"
        Me.Ti.Size = New System.Drawing.Size(13, 13)
        Me.Ti.TabIndex = 8
        Me.Ti.Text = "0"
        '
        'NOS
        '
        Me.NOS.AutoSize = True
        Me.NOS.Location = New System.Drawing.Point(112, 80)
        Me.NOS.Name = "NOS"
        Me.NOS.Size = New System.Drawing.Size(13, 13)
        Me.NOS.TabIndex = 9
        Me.NOS.Text = "0"
        '
        'SAB
        '
        Me.SAB.Location = New System.Drawing.Point(9, 238)
        Me.SAB.Name = "SAB"
        Me.SAB.Size = New System.Drawing.Size(131, 20)
        Me.SAB.TabIndex = 10
        '
        'AddS
        '
        Me.AddS.Location = New System.Drawing.Point(146, 238)
        Me.AddS.Name = "AddS"
        Me.AddS.Size = New System.Drawing.Size(124, 23)
        Me.AddS.TabIndex = 11
        Me.AddS.Text = "Add New"
        Me.AddS.UseVisualStyleBackColor = True
        '
        'RS
        '
        Me.RS.Location = New System.Drawing.Point(276, 238)
        Me.RS.Name = "RS"
        Me.RS.Size = New System.Drawing.Size(124, 23)
        Me.RS.TabIndex = 12
        Me.RS.Text = "Remove Selected"
        Me.RS.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(666, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "1000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(663, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Time to Run:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(663, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Starting Tempature:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(666, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Text = "70"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(663, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Evolve Factor:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(666, 122)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 18
        Me.TextBox3.Text = "1000000"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 495)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(760, 23)
        Me.ProgressBar1.TabIndex = 21
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(691, 466)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(75, 23)
        Me.start.TabIndex = 22
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = True
        '
        'help
        '
        Me.help.Location = New System.Drawing.Point(691, 437)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(75, 23)
        Me.help.TabIndex = 23
        Me.help.Text = "Help"
        Me.help.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(136, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Tempature Every"
        '
        'tempchange
        '
        Me.tempchange.Location = New System.Drawing.Point(230, 294)
        Me.tempchange.Name = "tempchange"
        Me.tempchange.Size = New System.Drawing.Size(100, 20)
        Me.tempchange.TabIndex = 27
        Me.tempchange.Text = "100"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(336, 297)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Time"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(785, 560)
        Me.TabControl1.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.showgraph)
        Me.TabPage1.Controls.Add(Me.processing)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.tempchange)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.NOO)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.T)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Ti)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.help)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.start)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.NOS)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.ProgressBar1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.list)
        Me.TabPage1.Controls.Add(Me.SAB)
        Me.TabPage1.Controls.Add(Me.AddS)
        Me.TabPage1.Controls.Add(Me.RS)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(777, 534)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Base Setup-Quickveiw"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'showgraph
        '
        Me.showgraph.Location = New System.Drawing.Point(691, 408)
        Me.showgraph.Name = "showgraph"
        Me.showgraph.Size = New System.Drawing.Size(75, 23)
        Me.showgraph.TabIndex = 32
        Me.showgraph.Text = "Show Graph"
        Me.showgraph.UseVisualStyleBackColor = True
        '
        'processing
        '
        Me.processing.AutoSize = True
        Me.processing.Location = New System.Drawing.Point(9, 476)
        Me.processing.Name = "processing"
        Me.processing.Size = New System.Drawing.Size(0, 13)
        Me.processing.TabIndex = 31
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Raise", "Lower"})
        Me.ComboBox1.Location = New System.Drawing.Point(9, 294)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 30
        Me.ComboBox1.Text = "Raise"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.enmass)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.seet)
        Me.TabPage2.Controls.Add(Me.envsize)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.removesubstance)
        Me.TabPage2.Controls.Add(Me.addsubstance)
        Me.TabPage2.Controls.Add(Me.substance)
        Me.TabPage2.Controls.Add(Me.Substances)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(777, 534)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Enviroment Setup"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'enmass
        '
        Me.enmass.AutoSize = True
        Me.enmass.Location = New System.Drawing.Point(128, 247)
        Me.enmass.Name = "enmass"
        Me.enmass.Size = New System.Drawing.Size(13, 13)
        Me.enmass.TabIndex = 8
        Me.enmass.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 247)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Mass of Enviroment(g):"
        '
        'seet
        '
        Me.seet.Location = New System.Drawing.Point(8, 134)
        Me.seet.Name = "seet"
        Me.seet.Size = New System.Drawing.Size(133, 23)
        Me.seet.TabIndex = 6
        Me.seet.Text = "Set Enviroment"
        Me.seet.UseVisualStyleBackColor = True
        '
        'envsize
        '
        Me.envsize.Location = New System.Drawing.Point(391, 24)
        Me.envsize.Name = "envsize"
        Me.envsize.Size = New System.Drawing.Size(167, 20)
        Me.envsize.TabIndex = 5
        Me.envsize.Text = "1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(391, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(167, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Size of Enviroment(Meters Cubed)"
        '
        'removesubstance
        '
        Me.removesubstance.Location = New System.Drawing.Point(267, 104)
        Me.removesubstance.Name = "removesubstance"
        Me.removesubstance.Size = New System.Drawing.Size(117, 23)
        Me.removesubstance.TabIndex = 3
        Me.removesubstance.Text = "Remove Selected"
        Me.removesubstance.UseVisualStyleBackColor = True
        '
        'addsubstance
        '
        Me.addsubstance.Location = New System.Drawing.Point(148, 104)
        Me.addsubstance.Name = "addsubstance"
        Me.addsubstance.Size = New System.Drawing.Size(113, 23)
        Me.addsubstance.TabIndex = 2
        Me.addsubstance.Text = "Add New Substance"
        Me.addsubstance.UseVisualStyleBackColor = True
        '
        'substance
        '
        Me.substance.Location = New System.Drawing.Point(8, 108)
        Me.substance.Name = "substance"
        Me.substance.Size = New System.Drawing.Size(133, 20)
        Me.substance.TabIndex = 1
        '
        'Substances
        '
        Me.Substances.FormattingEnabled = True
        Me.Substances.Items.AddRange(New Object() {"Water;1-"})
        Me.Substances.Location = New System.Drawing.Point(8, 6)
        Me.Substances.Name = "Substances"
        Me.Substances.Size = New System.Drawing.Size(376, 95)
        Me.Substances.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Life Simulation"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents processing As System.Windows.Forms.Label
    Friend WithEvents removesubstance As System.Windows.Forms.Button
    Friend WithEvents addsubstance As System.Windows.Forms.Button
    Friend WithEvents substance As System.Windows.Forms.TextBox
    Friend WithEvents Substances As System.Windows.Forms.ListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents seet As System.Windows.Forms.Button
    Friend WithEvents envsize As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents enmass As System.Windows.Forms.Label
    Friend WithEvents showgraph As System.Windows.Forms.Button

End Class
