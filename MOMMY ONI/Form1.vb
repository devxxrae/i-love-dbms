Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        Dim name As String = txtName.Text
        Dim course As String = cmbCourse.Text


        Dim gender As String = ""
        If rdoFemale.Checked Then
            gender = "Female"
        ElseIf rdoMale.Checked Then
            gender = "Male"
        End If


        Dim subjects As String = ""
        If chkDBMSLAB.Checked Then
            subjects &= "Database Management System (Laboratory)" & vbCrLf
        End If
        If chkDBMSLEC.Checked Then
            subjects &= "Database Management System (L)" & vbCrLf
        End If
        If chkDISCRETE.Checked Then
            subjects &= "Discrete Structure 1" & vbCrLf
        End If
        If chkFILDIS.Checked Then
            subjects &= "Filipino sa Iba't ibang Disiplina" & vbCrLf
        End If
        If chkPANIPI.Checked Then
            subjects &= "Panitikan sa Pilipinas" & vbCrLf
        End If
        If chkPATHFIT.Checked Then
            subjects &= "Fitness Excercises" & vbCrLf
        End If
        If chkPURCOM.Checked Then
            subjects &= "Purpossive Communications" & vbCrLf
        End If
        If chkIPPROGLAB.Checked Then
            subjects &= "Computer Programming 2 (Intermediate Programming) (LAB)" & vbCrLf
        End If
        If chkIPPROGLEC.Checked Then
            subjects &= "Computer Programming 2 (Intermediate Programming) (LEC)" & vbCrLf
        End If
        If chkNSTP2.Checked Then
            subjects &= "National Service Training Program 2" & vbCrLf
        End If
        If chkREMMCRAT.Checked Then
            subjects &= "Discrete Structure" & vbCrLf
        End If



        txtOutput.Text = "Student Information" & vbCrLf & vbCrLf &
                 name & vbCrLf &
                 "Gender: " & gender & vbCrLf &
                 course & vbCrLf & vbCrLf &
                 "Subjects:" & vbCrLf & subjects
    End Sub

End Class