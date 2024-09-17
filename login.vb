Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data
Imports System.Data.SqlClient
Public Class login

    Dim connectionString As String = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Aryan Tamang\OneDrive\Documents\HotelVbDb.mdf';Integrated Security=True;Connect Timeout=30")
    Dim Con As New SqlConnection(connectionString)

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PasswordTb.UseSystemPasswordChar = True
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UidTb.Text = "" And PasswordTb.Text = "" Then
            MsgBox("Enter the staff name and password.")
        Else
            Con.Open()
            Dim query = "select * from StaffTbl where StName='" & UidTb.Text & "' And StPass='" & PasswordTb.Text & "'"
            Dim cmd = New SqlCommand(query, Con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong Username and Password!")
            Else
                Dim Res = New Reservation
                Res.Show()
                Me.Hide()
            End If
            Con.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            PasswordTb.UseSystemPasswordChar = False
        Else
            PasswordTb.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Adm As New AdminLogin
        Adm.Show()
        Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Application.Exit()
    End Sub

End Class
