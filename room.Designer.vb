<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class room
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(room))
        Panel2 = New Panel()
        RoomDGV = New DataGridView()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        PictureBox2 = New PictureBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        RoomPhone = New TextBox()
        Label8 = New Label()
        RoomStatus = New ComboBox()
        Label10 = New Label()
        PictureBox3 = New PictureBox()
        Label12 = New Label()
        Button7 = New Button()
        Button6 = New Button()
        Label7 = New Label()
        Label3 = New Label()
        Panel2.SuspendLayout()
        CType(RoomDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(RoomDGV)
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Button9)
        Panel2.Controls.Add(Button10)
        Panel2.Controls.Add(Button11)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(RoomPhone)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(RoomStatus)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Label12)
        Panel2.Dock = DockStyle.Right
        Panel2.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(162, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(923, 583)
        Panel2.TabIndex = 44
        ' 
        ' RoomDGV
        ' 
        RoomDGV.BackgroundColor = Color.White
        RoomDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        RoomDGV.Location = New Point(194, 304)
        RoomDGV.Name = "RoomDGV"
        RoomDGV.RowHeadersWidth = 51
        RoomDGV.Size = New Size(403, 232)
        RoomDGV.TabIndex = 23
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Goldenrod
        Button8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.White
        Button8.Location = New Point(603, 210)
        Button8.Name = "Button8"
        Button8.Size = New Size(86, 33)
        Button8.TabIndex = 22
        Button8.Text = "RESET"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Goldenrod
        Button9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button9.ForeColor = Color.White
        Button9.Location = New Point(473, 210)
        Button9.Name = "Button9"
        Button9.Size = New Size(86, 33)
        Button9.TabIndex = 21
        Button9.Text = "DELETE"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Goldenrod
        Button10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = Color.White
        Button10.Location = New Point(319, 210)
        Button10.Name = "Button10"
        Button10.Size = New Size(86, 33)
        Button10.TabIndex = 20
        Button10.Text = "EDIT"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.Goldenrod
        Button11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button11.ForeColor = Color.White
        Button11.Location = New Point(178, 210)
        Button11.Name = "Button11"
        Button11.Size = New Size(86, 33)
        Button11.TabIndex = 19
        Button11.Text = "ADD"
        Button11.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(776, 304)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(66, 25)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial Rounded MT Bold", 9F)
        TextBox1.Location = New Point(603, 304)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(167, 25)
        TextBox1.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 11.8F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkKhaki
        Label2.Location = New Point(347, 267)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 24)
        Label2.TabIndex = 16
        Label2.Text = "Rooms List"
        ' 
        ' RoomPhone
        ' 
        RoomPhone.Font = New Font("Arial Rounded MT Bold", 9F)
        RoomPhone.Location = New Point(228, 170)
        RoomPhone.Name = "RoomPhone"
        RoomPhone.Size = New Size(167, 25)
        RoomPhone.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Goldenrod
        Label8.Location = New Point(228, 140)
        Label8.Name = "Label8"
        Label8.Size = New Size(154, 27)
        Label8.TabIndex = 14
        Label8.Text = "Room Phone"
        ' 
        ' RoomStatus
        ' 
        RoomStatus.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RoomStatus.FormattingEnabled = True
        RoomStatus.Items.AddRange(New Object() {"Free", "Booked"})
        RoomStatus.Location = New Point(460, 170)
        RoomStatus.Name = "RoomStatus"
        RoomStatus.Size = New Size(175, 25)
        RoomStatus.TabIndex = 11
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Goldenrod
        Label10.Location = New Point(460, 140)
        Label10.Name = "Label10"
        Label10.Size = New Size(154, 27)
        Label10.TabIndex = 10
        Label10.Text = "Room Status"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(397, 42)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(154, 62)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.DarkKhaki
        Label12.Location = New Point(380, 12)
        Label12.Name = "Label12"
        Label12.Size = New Size(193, 27)
        Label12.TabIndex = 5
        Label12.Text = "Khasor hotel"
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.DarkKhaki
        Button7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button7.ForeColor = Color.White
        Button7.Location = New Point(23, 328)
        Button7.Name = "Button7"
        Button7.Size = New Size(102, 44)
        Button7.TabIndex = 48
        Button7.Text = "Reservation"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.DarkKhaki
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button6.ForeColor = Color.White
        Button6.Location = New Point(23, 210)
        Button6.Name = "Button6"
        Button6.Size = New Size(102, 44)
        Button6.TabIndex = 47
        Button6.Text = "Clients"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Stencil", 11.8F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkKhaki
        Label7.Location = New Point(23, 42)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 24)
        Label7.TabIndex = 45
        Label7.Text = "Rooms"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Stencil", 11.8F, FontStyle.Bold Or FontStyle.Underline)
        Label3.ForeColor = Color.DarkKhaki
        Label3.Location = New Point(34, 538)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 24)
        Label3.TabIndex = 50
        Label3.Text = "LOGOUT"
        ' 
        ' room
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkKhaki
        ClientSize = New Size(1085, 583)
        Controls.Add(Label3)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Label7)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "room"
        StartPosition = FormStartPosition.CenterScreen
        Text = "room"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(RoomDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents RoomDGV As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RoomPhone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RoomStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
End Class
