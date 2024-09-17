Imports System.Data
Imports System.Data.SqlClient

Public Class client

    Dim connectionString As String = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Aryan Tamang\OneDrive\Documents\HotelVbDb.mdf';Integrated Security=True;Connect Timeout=30")
    Dim Con As New SqlConnection(connectionString)

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If CINameTb.Text = "" Or CIAge.Text = "" Or CIPhoneTb.Text = "" Or GenCb.SelectedIndex = -1 Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "insert into ClientTbl values('" & CINameTb.Text & "','" & GenCb.SelectedItem.ToString() & "','" & CIAge.Text & "','" & CIPhoneTb.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Client Inserted Successfully.")
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
        Dim sql = "select * from ClientTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As New DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Clear()
        CINameTb.Clear()
        GenCb.SelectedIndex = -1
        CIAge.Clear()
        CIPhoneTb.Clear()
    End Sub

    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        CINameTb.Text = row.Cells(1).Value.ToString
        GenCb.SelectedItem = row.Cells(2).Value.ToString
        CIAge.Text = row.Cells(3).Value.ToString
        CIPhoneTb.Text = row.Cells(4).Value.ToString
        If CINameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Clear()
    End Sub

    Dim key = 0

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If key = 0 Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "Delete from ClientTbl where CIId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Client Deleted Successfully")
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

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If CINameTb.Text = "" Or CIAge.Text = "" Or CIPhoneTb.Text = "" Or GenCb.SelectedIndex = -1 Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "UPDATE ClientTbl SET CIName='" & CINameTb.Text & "', CIGender='" & GenCb.SelectedItem.ToString() & "', CIAge=" & CIAge.Text & ", CIPhone='" & CIPhoneTb.Text & "' WHERE CIID=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Client Updated Successfully.")
                Con.Close()
                populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Res As New Reservation
        Res.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim log As New login
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim room As New room
        room.Show()
        Me.Hide()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim searchText As String = TextBox1.Text.Trim()

        If searchText <> "" Then
            Dim sql As String = "SELECT * FROM ClientTbl WHERE CIName LIKE '%" & searchText & "%' OR CIGender LIKE '%" & searchText & "%' OR CIAge LIKE '%" & searchText & "%' OR CIPhone LIKE '%" & searchText & "%'"
            SearchData(sql)
        Else
            SearchData("SELECT * FROM ClientTbl")
        End If
    End Sub

    Private Sub SearchData(ByVal sql As String)
        Con.Open()
        Dim adapter As New SqlDataAdapter(sql, Con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As New DataSet()
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

End Class
