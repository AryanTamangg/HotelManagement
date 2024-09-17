Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AdminLogin
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim log As New login
        log.Show()
        Me.Hide()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PasswordTbl.Text = "admin" Then
            Dim staff As New staff
            staff.Show()
            Hide()
        Else
            MsgBox("Wrong Password.")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' Show the password
            PasswordTbl.UseSystemPasswordChar = False
        Else
            ' Hide the password
            PasswordTbl.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTbl.UseSystemPasswordChar = True
    End Sub
End Class