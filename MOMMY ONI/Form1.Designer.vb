<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        cmbCourse = New ComboBox()
        Label3 = New Label()
        rdoFemale = New RadioButton()
        rdoMale = New RadioButton()
        Label4 = New Label()
        chkDBMSLAB = New CheckBox()
        chkDBMSLEC = New CheckBox()
        chkDISCRETE = New CheckBox()
        chkFILDIS = New CheckBox()
        chkPANIPI = New CheckBox()
        btnSave = New Button()
        chkPATHFIT = New CheckBox()
        chkPURCOM = New CheckBox()
        chkIPPROGLAB = New CheckBox()
        chkIPPROGLEC = New CheckBox()
        chkNSTP2 = New CheckBox()
        chkREMMCRAT = New CheckBox()
        txtOutput = New TextBox()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(143, 27)
        txtName.Name = "txtName"
        txtName.Size = New Size(265, 31)
        txtName.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 25)
        Label1.TabIndex = 1
        Label1.Text = "Student Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 25)
        Label2.TabIndex = 2
        Label2.Text = "Student Course :"
        ' 
        ' cmbCourse
        ' 
        cmbCourse.FormattingEnabled = True
        cmbCourse.Items.AddRange(New Object() {"BS Computer Science", "BS Information Technology"})
        cmbCourse.Location = New Point(154, 79)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(254, 33)
        cmbCourse.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 25)
        Label3.TabIndex = 4
        Label3.Text = "Gender :"
        ' 
        ' rdoFemale
        ' 
        rdoFemale.AutoSize = True
        rdoFemale.Location = New Point(124, 134)
        rdoFemale.Name = "rdoFemale"
        rdoFemale.Size = New Size(93, 29)
        rdoFemale.TabIndex = 5
        rdoFemale.TabStop = True
        rdoFemale.Text = "Female"
        rdoFemale.UseVisualStyleBackColor = True
        ' 
        ' rdoMale
        ' 
        rdoMale.AutoSize = True
        rdoMale.Location = New Point(237, 135)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(75, 29)
        rdoMale.TabIndex = 6
        rdoMale.TabStop = True
        rdoMale.Text = "Male"
        rdoMale.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(41, 190)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 25)
        Label4.TabIndex = 7
        Label4.Text = "Subject Enrolled :"
        ' 
        ' chkDBMSLAB
        ' 
        chkDBMSLAB.AutoSize = True
        chkDBMSLAB.Location = New Point(201, 193)
        chkDBMSLAB.Name = "chkDBMSLAB"
        chkDBMSLAB.Size = New Size(385, 29)
        chkDBMSLAB.TabIndex = 8
        chkDBMSLAB.Text = "Database Management System (Laboratory)"
        chkDBMSLAB.UseVisualStyleBackColor = True
        ' 
        ' chkDBMSLEC
        ' 
        chkDBMSLEC.AutoSize = True
        chkDBMSLEC.Location = New Point(201, 230)
        chkDBMSLEC.Name = "chkDBMSLEC"
        chkDBMSLEC.Size = New Size(355, 29)
        chkDBMSLEC.TabIndex = 9
        chkDBMSLEC.Text = "Database Management System (Lecture)"
        chkDBMSLEC.UseVisualStyleBackColor = True
        ' 
        ' chkDISCRETE
        ' 
        chkDISCRETE.AutoSize = True
        chkDISCRETE.Location = New Point(201, 265)
        chkDISCRETE.Name = "chkDISCRETE"
        chkDISCRETE.Size = New Size(191, 29)
        chkDISCRETE.TabIndex = 10
        chkDISCRETE.Text = "Discrete Structure 1"
        chkDISCRETE.UseVisualStyleBackColor = True
        ' 
        ' chkFILDIS
        ' 
        chkFILDIS.AutoSize = True
        chkFILDIS.Location = New Point(201, 300)
        chkFILDIS.Name = "chkFILDIS"
        chkFILDIS.Size = New Size(279, 29)
        chkFILDIS.TabIndex = 11
        chkFILDIS.Text = "Filipino sa Iba't ibang Disiplina"
        chkFILDIS.UseVisualStyleBackColor = True
        ' 
        ' chkPANIPI
        ' 
        chkPANIPI.AutoSize = True
        chkPANIPI.Location = New Point(201, 335)
        chkPANIPI.Name = "chkPANIPI"
        chkPANIPI.Size = New Size(199, 29)
        chkPANIPI.TabIndex = 12
        chkPANIPI.Text = "Panitikan sa Pilipinas"
        chkPANIPI.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.ButtonHighlight
        btnSave.Location = New Point(619, 587)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(103, 34)
        btnSave.TabIndex = 13
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' chkPATHFIT
        ' 
        chkPATHFIT.AutoSize = True
        chkPATHFIT.Location = New Point(201, 370)
        chkPATHFIT.Name = "chkPATHFIT"
        chkPATHFIT.Size = New Size(166, 29)
        chkPATHFIT.TabIndex = 14
        chkPATHFIT.Text = "Fitness Exercises"
        chkPATHFIT.UseVisualStyleBackColor = True
        ' 
        ' chkPURCOM
        ' 
        chkPURCOM.AutoSize = True
        chkPURCOM.Location = New Point(201, 405)
        chkPURCOM.Name = "chkPURCOM"
        chkPURCOM.Size = New Size(247, 29)
        chkPURCOM.TabIndex = 15
        chkPURCOM.Text = "Purposive Communication"
        chkPURCOM.UseVisualStyleBackColor = True
        ' 
        ' chkIPPROGLAB
        ' 
        chkIPPROGLAB.AutoSize = True
        chkIPPROGLAB.Location = New Point(201, 440)
        chkIPPROGLAB.Name = "chkIPPROGLAB"
        chkIPPROGLAB.Size = New Size(524, 29)
        chkIPPROGLAB.TabIndex = 16
        chkIPPROGLAB.Text = "Computer Programming 2 (Intermediate Programming) (LAB)"
        chkIPPROGLAB.UseVisualStyleBackColor = True
        ' 
        ' chkIPPROGLEC
        ' 
        chkIPPROGLEC.AutoSize = True
        chkIPPROGLEC.Location = New Point(201, 475)
        chkIPPROGLEC.Name = "chkIPPROGLEC"
        chkIPPROGLEC.Size = New Size(521, 29)
        chkIPPROGLEC.TabIndex = 17
        chkIPPROGLEC.Text = "Computer Programming 2 (Intermediate Programming) (LEC)"
        chkIPPROGLEC.UseVisualStyleBackColor = True
        ' 
        ' chkNSTP2
        ' 
        chkNSTP2.AutoSize = True
        chkNSTP2.Location = New Point(201, 511)
        chkNSTP2.Name = "chkNSTP2"
        chkNSTP2.Size = New Size(319, 29)
        chkNSTP2.TabIndex = 18
        chkNSTP2.Text = "National Service Training Program 2"
        chkNSTP2.UseVisualStyleBackColor = True
        ' 
        ' chkREMMCRAT
        ' 
        chkREMMCRAT.AutoSize = True
        chkREMMCRAT.Location = New Point(201, 546)
        chkREMMCRAT.Name = "chkREMMCRAT"
        chkREMMCRAT.Size = New Size(329, 29)
        chkREMMCRAT.TabIndex = 19
        chkREMMCRAT.Text = "Mathematics for College Readiness 1"
        chkREMMCRAT.UseVisualStyleBackColor = True
        ' 
        ' txtOutput
        ' 
        txtOutput.BackColor = SystemColors.Control
        txtOutput.Location = New Point(89, 655)
        txtOutput.Multiline = True
        txtOutput.Name = "txtOutput"
        txtOutput.ReadOnly = True
        txtOutput.ScrollBars = ScrollBars.Vertical
        txtOutput.Size = New Size(554, 181)
        txtOutput.TabIndex = 20
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(756, 870)
        Controls.Add(txtOutput)
        Controls.Add(chkREMMCRAT)
        Controls.Add(chkNSTP2)
        Controls.Add(chkIPPROGLEC)
        Controls.Add(chkIPPROGLAB)
        Controls.Add(chkPURCOM)
        Controls.Add(chkPATHFIT)
        Controls.Add(btnSave)
        Controls.Add(chkPANIPI)
        Controls.Add(chkFILDIS)
        Controls.Add(chkDISCRETE)
        Controls.Add(chkDBMSLEC)
        Controls.Add(chkDBMSLAB)
        Controls.Add(Label4)
        Controls.Add(rdoMale)
        Controls.Add(rdoFemale)
        Controls.Add(Label3)
        Controls.Add(cmbCourse)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtName)
        Name = "Form1"
        Text = "Student Information"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents chkDBMSLAB As CheckBox
    Friend WithEvents chkDBMSLEC As CheckBox
    Friend WithEvents chkDISCRETE As CheckBox
    Friend WithEvents chkFILDIS As CheckBox
    Friend WithEvents chkPANIPI As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents chkPATHFIT As CheckBox
    Friend WithEvents chkPURCOM As CheckBox
    Friend WithEvents chkIPPROGLAB As CheckBox
    Friend WithEvents chkIPPROGLEC As CheckBox
    Friend WithEvents chkNSTP2 As CheckBox
    Friend WithEvents chkREMMCRAT As CheckBox
    Friend WithEvents txtOutput As TextBox

End Class
