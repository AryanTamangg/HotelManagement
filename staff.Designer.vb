<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staff))
        Panel1 = New Panel()
        AgentDGV = New DataGridView()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        TextBox4 = New TextBox()
        Label6 = New Label()
        Password = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        StaffPhoneTb = New TextBox()
        GenCb = New ComboBox()
        Label3 = New Label()
        StaffNameTb = New TextBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        CType(AgentDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(AgentDGV)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Password)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(StaffPhoneTb)
        Panel1.Controls.Add(GenCb)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(StaffNameTb)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Right
        Panel1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(180, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(923, 630)
        Panel1.TabIndex = 1
        ' 
        ' AgentDGV
        ' 
        AgentDGV.BackgroundColor = Color.White
        AgentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AgentDGV.Location = New Point(148, 323)
        AgentDGV.Name = "AgentDGV"
        AgentDGV.RowHeadersWidth = 51
        AgentDGV.Size = New Size(627, 283)
        AgentDGV.TabIndex = 23
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Goldenrod
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(603, 201)
        Button4.Name = "Button4"
        Button4.Size = New Size(86, 33)
        Button4.TabIndex = 22
        Button4.Text = "RESET"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Goldenrod
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(511, 201)
        Button3.Name = "Button3"
        Button3.Size = New Size(86, 33)
        Button3.TabIndex = 21
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Goldenrod
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(410, 201)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 33)
        Button2.TabIndex = 20
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Goldenrod
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(306, 201)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 33)
        Button1.TabIndex = 19
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(722, 266)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(66, 25)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Arial Rounded MT Bold", 9F)
        TextBox4.Location = New Point(549, 266)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(167, 25)
        TextBox4.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Stencil", 11.8F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkKhaki
        Label6.Location = New Point(347, 267)
        Label6.Name = "Label6"
        Label6.Size = New Size(140, 24)
        Label6.TabIndex = 16
        Label6.Text = "Agents List"
        ' 
        ' Password
        ' 
        Password.Font = New Font("Arial Rounded MT Bold", 9F)
        Password.Location = New Point(663, 170)
        Password.Name = "Password"
        Password.Size = New Size(167, 25)
        Password.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Goldenrod
        Label5.Location = New Point(663, 140)
        Label5.Name = "Label5"
        Label5.Size = New Size(181, 27)
        Label5.TabIndex = 14
        Label5.Text = "Staff Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Goldenrod
        Label4.Location = New Point(272, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 27)
        Label4.TabIndex = 13
        Label4.Text = "Staff Phone"
        ' 
        ' StaffPhoneTb
        ' 
        StaffPhoneTb.Font = New Font("Arial Rounded MT Bold", 9F)
        StaffPhoneTb.Location = New Point(262, 170)
        StaffPhoneTb.Name = "StaffPhoneTb"
        StaffPhoneTb.Size = New Size(167, 25)
        StaffPhoneTb.TabIndex = 12
        ' 
        ' GenCb
        ' 
        GenCb.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GenCb.FormattingEnabled = True
        GenCb.Items.AddRange(New Object() {"Male", "Female"})
        GenCb.Location = New Point(459, 170)
        GenCb.Name = "GenCb"
        GenCb.Size = New Size(175, 25)
        GenCb.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Goldenrod
        Label3.Location = New Point(469, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 27)
        Label3.TabIndex = 10
        Label3.Text = "Staff Gender"
        ' 
        ' StaffNameTb
        ' 
        StaffNameTb.Font = New Font("Arial Rounded MT Bold", 9F)
        StaffNameTb.Location = New Point(73, 170)
        StaffNameTb.Name = "StaffNameTb"
        StaffNameTb.Size = New Size(167, 25)
        StaffNameTb.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Goldenrod
        Label2.Location = New Point(73, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 27)
        Label2.TabIndex = 8
        Label2.Text = "Staff Name"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(397, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(154, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkKhaki
        Label1.Location = New Point(380, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 27)
        Label1.TabIndex = 5
        Label1.Text = "Khasor hotel"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Stencil", 11.8F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkKhaki
        Label7.Location = New Point(37, 38)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 24)
        Label7.TabIndex = 23
        Label7.Text = "Staff"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Stencil", 11.8F, FontStyle.Bold Or FontStyle.Underline)
        Label8.ForeColor = Color.DarkKhaki
        Label8.Location = New Point(48, 582)
        Label8.Name = "Label8"
        Label8.Size = New Size(91, 24)
        Label8.TabIndex = 24
        Label8.Text = "LOGOUT"
        ' 
        ' staff
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkKhaki
        ClientSize = New Size(1103, 630)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "staff"
        Text = "staff"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(AgentDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents AgentDGV As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents StaffPhoneTb As TextBox
    Friend WithEvents GenCb As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents StaffNameTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
