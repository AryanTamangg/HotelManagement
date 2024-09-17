Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class staff
    Dim connectionString As String = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Aryan Tamang\OneDrive\Documents\HotelVbDb.mdf';Integrated Security=True;Connect Timeout=30")
    Dim Con As New SqlConnection(connectionString)
    Private Sub staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If StaffNameTb.Text = "" Or GenCb.SelectedIndex = -1 Or StaffPhoneTb.Text = "" Or Password.Text = "" Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "insert into StaffTbl values('" & StaffNameTb.Text & "','" & StaffPhoneTb.Text & "','" & GenCb.SelectedItem.ToString() & "','" & Password.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Staff Inserted Successfully.")
                Con.Close()
                populate()
                Clear()
            Catch ex As Exception
                MsgBox("ex.Message")
            End Try
        End If
    End Sub
    Private Sub populate()
        Con.Open()
        Dim sql = "select * from StaffTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As New DataSet
        ds = New DataSet
        adapter.Fill(ds)
        AgentDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Clear()
        StaffNameTb.Clear()
        StaffPhoneTb.Clear()
        GenCb.SelectedIndex = -1
        Password.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()
    End Sub
    Dim key = 0
    Private Sub AgentDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles AgentDGV.CellMouseClick
        Dim row As DataGridViewRow = AgentDGV.Rows(e.RowIndex)
        StaffNameTb.Text = row.Cells(1).Value.ToString
        StaffPhoneTb.Text = row.Cells(2).Value.ToString
        GenCb.SelectedItem = row.Cells(3).Value.ToString
        Password.Text = row.Cells(4).Value.ToString
        If StaffNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "Delete from StaffTbl where StaffId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Agent Deleted Successfully")
                Con.Close()
                populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If Con.State = ConnectionState.Open Then
                    Con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If StaffNameTb.Text = "" Or StaffPhoneTb.Text = "" Or GenCb.SelectedIndex = -1 Or Password.Text = "" Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "UPDATE StaffTbl SET StName='" & StaffNameTb.Text & "', StPhone='" & StaffPhoneTb.Text & "', StGender='" & GenCb.SelectedItem.ToString() & "', StPass='" & Password.Text & "' WHERE StaffId=" & key
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Agent Updated Successfully.")
                Con.Close()
                populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim log As New login
        log.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim searchText As String = TextBox4.Text.Trim()

        If searchText <> "" Then
            Dim sql As String = "SELECT * FROM StaffTbl WHERE StName LIKE '%" & searchText & "%' OR StPhone LIKE '%" & searchText & "%' OR StGender LIKE '%" & searchText & "%' OR StPass LIKE '%" & searchText & "%'"
            SearchData(sql)
        Else
            populate()
        End If
    End Sub

    Private Sub SearchData(ByVal sql As String)
        Con.Open()
        Dim adapter As New SqlDataAdapter(sql, Con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds)
        AgentDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

End Class