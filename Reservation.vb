Imports System.Data
Imports System.Data.SqlClient

Public Class Reservation
    Dim connectionString As String = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Aryan Tamang\OneDrive\Documents\HotelVbDb.mdf';Integrated Security=True;Connect Timeout=30")
    Dim Con As New SqlConnection(connectionString)
    Private Sub FillClient()
        Con.Open()
        Dim cmd As New SqlCommand("select * from ClientTbl", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        ClientId.DataSource = Tbl
        ClientId.DisplayMember = "CIId"
        ClientId.ValueMember = "CIId"
        Con.Close()

    End Sub
    Private Sub FillRoom()
        Dim Status = "Free"
        Con.Open()
        Dim cmd As New SqlCommand("select * from RoomTbl where RStatus='" & Status & "'", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        RoomNumberCb.DataSource = Tbl
        RoomNumberCb.DisplayMember = "RId"
        RoomNumberCb.ValueMember = "RId"
        Con.Close()

    End Sub
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillClient()
        FillRoom()
        populate()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim cl As New client
        client.Show()
        Me.Hide()
    End Sub
    Private Sub GetName()
        Con.Open()
        Dim Query = "select * from ClientTbl where CIId=" & ClientId.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(Query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            ClientName.Text = "" + reader(1).ToString
        End While
        Con.Close()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim room As New room
        room.Show()
        Me.Hide()
    End Sub

    Private Sub ClientId_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ClientId.SelectionChangeCommitted
        GetName()
    End Sub


    Private Sub populate()
        Con.Open()
        Dim sql = "select * from ReservationTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As New DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ReservationDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub UpdateRoom()
        Dim Status = "Booked"
        Try
            Con.Open()
            Dim query As String
            query = "UPDATE RoomTbl SET RStatus='" & Status & "'where RId=" & RoomNumberCb.SelectedValue.ToString() & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            'MsgBox("Client Updated Successfully.")
            Con.Close()
            'populate()
            'Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If ClientId.SelectedIndex = -1 Or RoomNumberCb.SelectedIndex = -1 Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                Dim dateInFormatted As String = DateIn.Value.ToString("yyyy-MM-dd")
                Dim dateOutFormatted As String = DateOut.Value.ToString("yyyy-MM-dd")
                query = "INSERT INTO ReservationTbl (ClientId, ClientName, RoomId, DateIn, DateOut) VALUES (" & ClientId.SelectedValue.ToString() & ", '" & ClientName.Text & "', " & RoomNumberCb.SelectedValue.ToString() & ", '" & dateInFormatted & "', '" & dateOutFormatted & "')"

                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Room Booked Successfully.")
                Con.Close()
                populate()
                UpdateRoom()
                'Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Dim key = 0
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If ClientId.SelectedIndex = -1 Or RoomNumberCb.SelectedIndex = -1 Then
            MsgBox("Missing Information!")
        Else
            Try
                Con.Open()
                Dim query As String
                Dim dateInFormatted As String = DateIn.Value.ToString("yyyy-MM-dd")
                Dim dateOutFormatted As String = DateOut.Value.ToString("yyyy-MM-dd")
                query = "INSERT INTO ReservationTbl (ClientId, ClientName, RoomId, DateIn, DateOut) VALUES (" & ClientId.SelectedValue.ToString() & ", '" & ClientName.Text & "', " & RoomNumberCb.SelectedValue.ToString() & ", '" & dateInFormatted & "', '" & dateOutFormatted & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Reservation Updated Successfully.")
                Con.Close()
                populate()
                'Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub ReservationDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ReservationDGV.CellMouseClick
        Dim row As DataGridViewRow = ReservationDGV.Rows(e.RowIndex)
        ClientId.SelectedValue = row.Cells(1).Value.ToString
        ClientName.Text = row.Cells(2).Value.ToString
        RoomNumberCb.SelectedValue = row.Cells(3).Value.ToString
        DateIn.Value = row.Cells(4).Value.ToString
        DateOut.Value = row.Cells(5).Value.ToString

        If ClientName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim log As New login
        log.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim searchText As String = TextBox1.Text.Trim()

        If searchText <> "" Then
            Dim sql As String = "SELECT * FROM ReservationTbl WHERE ClientName LIKE '%" & searchText & "%'"
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
            ReservationDGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
End Class