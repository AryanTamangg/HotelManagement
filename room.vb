Imports System.Data
Imports System.Data.SqlClient
Public Class room
    Dim connectionString As String = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Aryan Tamang\OneDrive\Documents\HotelVbDb.mdf';Integrated Security=True;Connect Timeout=30")
    Dim Con As New SqlConnection(connectionString)
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If RoomPhone.Text = "" Or RoomStatus.SelectedIndex = -1 Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "insert into RoomTbl values('" & RoomPhone.Text & "','" & RoomStatus.SelectedItem.ToString() & "')"
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
        Dim sql = "select * from RoomTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As New DataSet
        ds = New DataSet
        adapter.Fill(ds)
        RoomDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Clear()
        RoomPhone.Clear()
        RoomStatus.SelectedIndex = -1
    End Sub

    Private Sub room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub
    Dim key = 0
    Private Sub RoomDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles RoomDGV.CellMouseClick
        Dim row As DataGridViewRow = RoomDGV.Rows(e.RowIndex)
        RoomPhone.Text = row.Cells(1).Value.ToString
        RoomStatus.SelectedItem = row.Cells(2).Value.ToString
        If RoomPhone.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Clear()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If key = 0 Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "Delete from RoomTbl where RId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Room Deleted Successfully")
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
        If RoomPhone.Text = "" Or RoomStatus.SelectedIndex = -1 Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "UPDATE RoomTbl SET RPhone='" & RoomPhone.Text & "', RStatus='" & RoomStatus.SelectedItem.ToString() & "'where RId=" & key & ""
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
        Dim res As New Reservation
        res.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim log As New login
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cl As New client
        cl.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim searchText As String = TextBox1.Text.Trim()

        If searchText <> "" Then
            Dim sql As String = "SELECT * FROM RoomTbl WHERE RPhone LIKE '%" & searchText & "%' OR RStatus LIKE '%" & searchText & "%'"
            SearchData(sql)
        Else
            populate()
        End If
    End Sub

    Private Sub SearchData(ByVal sql As String)
        Try
            Con.Open()
            Dim adapter As New SqlDataAdapter(sql, Con)
            Dim builder As New SqlCommandBuilder(adapter)
            Dim ds As New DataSet()
            adapter.Fill(ds)
            RoomDGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
End Class