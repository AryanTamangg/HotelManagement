<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservation))
        Panel2 = New Panel()
        DateOut = New DateTimePicker()
        DateIn = New DateTimePicker()
        ClientId = New ComboBox()
        Label1 = New Label()
        ReservationDGV = New DataGridView()
        Button8 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        PictureBox2 = New PictureBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        RoomNumberCb = New ComboBox()
        Label10 = New Label()
        ClientName = New TextBox()
        Label11 = New Label()
        PictureBox3 = New PictureBox()
        Label12 = New Label()
        Button7 = New Button()
        Button6 = New Button()
        Label7 = New Label()
        Label3 = New Label()
        Panel2.SuspendLayout()
        CType(ReservationDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(DateOut)
        Panel2.Controls.Add(DateIn)
        Panel2.Controls.Add(ClientId)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(ReservationDGV)
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(Button10)
        Panel2.Controls.Add(Button11)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(RoomNumberCb)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(ClientName)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Label12)
        Panel2.Dock = DockStyle.Right
        Panel2.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(180, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(923, 630)
        Panel2.TabIndex = 44
        ' 
        ' DateOut
        ' 
        DateOut.CalendarFont = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateOut.Format = DateTimePickerFormat.Short
        DateOut.Location = New Point(678, 170)
        DateOut.Name = "DateOut"
        DateOut.Size = New Size(148, 25)
        DateOut.TabIndex = 27
        ' 
        ' DateIn
        ' 
        DateIn.CalendarFont = New Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateIn.Format = DateTimePickerFormat.Short
        DateIn.Location = New Point(511, 170)
        DateIn.Name = "DateIn"
        DateIn.Size = New Size(148, 25)
        DateIn.TabIndex = 26
        ' 
        ' ClientId
        ' 
        ClientId.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ClientId.FormattingEnabled = True
        ClientId.Location = New Point(26, 170)
        ClientId.Name = "ClientId"
        ClientId.Size = New Size(104, 25)
        ClientId.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Goldenrod
        Label1.Location = New Point(26, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 27)
        Label1.TabIndex = 24
        Label1.Text = "Client Id"
        ' 
        ' ReservationDGV
        ' 
        ReservationDGV.BackgroundColor = Color.White
        ReservationDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ReservationDGV.Location = New Point(80, 323)
        ReservationDGV.Name = "ReservationDGV"
        ReservationDGV.RowHeadersWidth = 51
        ReservationDGV.Size = New Size(746, 274)
        ReservationDGV.TabIndex = 23
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Goldenrod
        Button8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.White
        Button8.Location = New Point(603, 201)
        Button8.Name = "Button8"
        Button8.Size = New Size(86, 33)
        Button8.TabIndex = 22
        Button8.Text = "RESET"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Goldenrod
        Button10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = Color.White
        Button10.Location = New Point(454, 201)
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
        Button11.Location = New Point(306, 201)
        Button11.Name = "Button11"
        Button11.Size = New Size(86, 33)
        Button11.TabIndex = 19
        Button11.Text = "ADD"
        Button11.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(773, 266)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(66, 25)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial Rounded MT Bold", 9F)
        TextBox1.Location = New Point(600, 266)
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
        Label2.Size = New Size(218, 24)
        Label2.TabIndex = 16
        Label2.Text = "Reservations List"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Goldenrod
        Label8.Location = New Point(663, 140)
        Label8.Name = "Label8"
        Label8.Size = New Size(111, 27)
        Label8.TabIndex = 14
        Label8.Text = "Date Out"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Goldenrod
        Label9.Location = New Point(511, 140)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 27)
        Label9.TabIndex = 13
        Label9.Text = "Date In"
        ' 
        ' RoomNumberCb
        ' 
        RoomNumberCb.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RoomNumberCb.FormattingEnabled = True
        RoomNumberCb.Location = New Point(321, 170)
        RoomNumberCb.Name = "RoomNumberCb"
        RoomNumberCb.Size = New Size(175, 25)
        RoomNumberCb.TabIndex = 11
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Goldenrod
        Label10.Location = New Point(320, 140)
        Label10.Name = "Label10"
        Label10.Size = New Size(172, 27)
        Label10.TabIndex = 10
        Label10.Text = "Room Number"
        ' 
        ' ClientName
        ' 
        ClientName.Enabled = False
        ClientName.Font = New Font("Arial Rounded MT Bold", 9F)
        ClientName.Location = New Point(146, 170)
        ClientName.Name = "ClientName"
        ClientName.Size = New Size(167, 25)
        ClientName.TabIndex = 9
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Goldenrod
        Label11.Location = New Point(146, 140)
        Label11.Name = "Label11"
        Label11.Size = New Size(148, 27)
        Label11.TabIndex = 8
        Label11.Text = "Client Name"
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
        Button7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button7.ForeColor = Color.White
        Button7.Location = New Point(37, 371)
        Button7.Name = "Button7"
        Button7.Size = New Size(102, 44)
        Button7.TabIndex = 48
        Button7.Text = "Clients"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.DarkKhaki
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button6.ForeColor = Color.White
        Button6.Location = New Point(37, 247)
        Button6.Name = "Button6"
        Button6.Size = New Size(102, 44)
        Button6.TabIndex = 47
        Button6.Text = "Room"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Stencil", 11.8F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkKhaki
        Label7.Location = New Point(12, 59)
        Label7.Name = "Label7"
        Label7.Size = New Size(166, 24)
        Label7.TabIndex = 45
        Label7.Text = "Reservations"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Stencil", 11.8F, FontStyle.Bold Or FontStyle.Underline)
        Label3.ForeColor = Color.DarkKhaki
        Label3.Location = New Point(37, 597)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 24)
        Label3.TabIndex = 49
        Label3.Text = "LOGOUT"
        ' 
        ' Reservation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkKhaki
        ClientSize = New Size(1103, 630)
        Controls.Add(Label3)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Label7)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Reservation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reservation"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ReservationDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents ReservationDGV As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RoomNumberCb As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ClientName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ClientId As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateIn As DateTimePicker
    Friend WithEvents DateOut As DateTimePicker
    Friend WithEvents Label3 As Label
End Class
