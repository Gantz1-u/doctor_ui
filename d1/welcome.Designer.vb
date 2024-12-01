<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welcome))
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Record_button = New CustomControls.RJControls.RoundedButton()
        Prescription_button = New CustomControls.RJControls.RoundedButton()
        Appointment_button = New CustomControls.RJControls.RoundedButton()
        DPrescription_button = New CustomControls.RJControls.RoundedButton()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Label4 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        Label16 = New Label()
        menu = New Button()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(11, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 19
        Label2.Text = "MENU"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(102, 314)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 15)
        Label1.TabIndex = 24
        Label1.Text = "PLEASE CHOOSE FROM THE " & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(117, 329)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 15)
        Label3.TabIndex = 25
        Label3.Text = "FOLLOWING SERVICES"
        ' 
        ' Record_button
        ' 
        Record_button.BackColor = SystemColors.ButtonHighlight
        Record_button.BackgroundColor = SystemColors.ButtonHighlight
        Record_button.BorderColor = Color.PaleVioletRed
        Record_button.BorderRadius = 9
        Record_button.BorderSize = 0
        Record_button.FlatAppearance.BorderSize = 0
        Record_button.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        Record_button.FlatStyle = FlatStyle.Flat
        Record_button.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Record_button.ForeColor = Color.Black
        Record_button.Image = CType(resources.GetObject("Record_button.Image"), Image)
        Record_button.Location = New Point(57, 390)
        Record_button.Name = "Record_button"
        Record_button.Size = New Size(117, 122)
        Record_button.TabIndex = 41
        Record_button.Text = vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Records"
        Record_button.TextColor = Color.Black
        Record_button.UseVisualStyleBackColor = False
        ' 
        ' Prescription_button
        ' 
        Prescription_button.BackColor = SystemColors.ButtonHighlight
        Prescription_button.BackgroundColor = SystemColors.ButtonHighlight
        Prescription_button.BorderColor = Color.PaleVioletRed
        Prescription_button.BorderRadius = 9
        Prescription_button.BorderSize = 0
        Prescription_button.FlatAppearance.BorderSize = 0
        Prescription_button.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        Prescription_button.FlatStyle = FlatStyle.Flat
        Prescription_button.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Prescription_button.ForeColor = Color.Black
        Prescription_button.Image = CType(resources.GetObject("Prescription_button.Image"), Image)
        Prescription_button.ImageAlign = ContentAlignment.TopCenter
        Prescription_button.Location = New Point(216, 390)
        Prescription_button.Name = "Prescription_button"
        Prescription_button.Size = New Size(117, 122)
        Prescription_button.TabIndex = 42
        Prescription_button.Text = vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Precriptions"
        Prescription_button.TextColor = Color.Black
        Prescription_button.UseVisualStyleBackColor = False
        ' 
        ' Appointment_button
        ' 
        Appointment_button.BackColor = SystemColors.ButtonHighlight
        Appointment_button.BackgroundColor = SystemColors.ButtonHighlight
        Appointment_button.BorderColor = Color.PaleVioletRed
        Appointment_button.BorderRadius = 9
        Appointment_button.BorderSize = 0
        Appointment_button.FlatAppearance.BorderSize = 0
        Appointment_button.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        Appointment_button.FlatStyle = FlatStyle.Flat
        Appointment_button.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Appointment_button.ForeColor = Color.Black
        Appointment_button.Image = CType(resources.GetObject("Appointment_button.Image"), Image)
        Appointment_button.Location = New Point(57, 547)
        Appointment_button.Name = "Appointment_button"
        Appointment_button.Size = New Size(117, 122)
        Appointment_button.TabIndex = 43
        Appointment_button.Text = vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Appointment"
        Appointment_button.TextColor = Color.Black
        Appointment_button.UseVisualStyleBackColor = False
        ' 
        ' DPrescription_button
        ' 
        DPrescription_button.BackColor = SystemColors.ButtonHighlight
        DPrescription_button.BackgroundColor = SystemColors.ButtonHighlight
        DPrescription_button.BorderColor = Color.PaleVioletRed
        DPrescription_button.BorderRadius = 9
        DPrescription_button.BorderSize = 0
        DPrescription_button.FlatAppearance.BorderSize = 0
        DPrescription_button.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        DPrescription_button.FlatStyle = FlatStyle.Flat
        DPrescription_button.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DPrescription_button.ForeColor = Color.Black
        DPrescription_button.Image = CType(resources.GetObject("DPrescription_button.Image"), Image)
        DPrescription_button.ImageAlign = ContentAlignment.TopCenter
        DPrescription_button.Location = New Point(216, 547)
        DPrescription_button.Name = "DPrescription_button"
        DPrescription_button.Size = New Size(117, 122)
        DPrescription_button.TabIndex = 44
        DPrescription_button.Text = vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Digital Prescription"
        DPrescription_button.TextColor = Color.Black
        DPrescription_button.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.BackgroundImage = My.Resources.Resources.photo_6219965685698772775_x__1__removebg_preview
        Panel4.BackgroundImageLayout = ImageLayout.Zoom
        Panel4.Location = New Point(31, 168)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(336, 192)
        Panel4.TabIndex = 45
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Transparent
        Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), Image)
        Panel5.BackgroundImageLayout = ImageLayout.Zoom
        Panel5.Location = New Point(-6, 31)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(402, 300)
        Panel5.TabIndex = 46
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(107, 335)
        Label4.Name = "Label4"
        Label4.Size = New Size(174, 21)
        Label4.TabIndex = 48
        Label4.Text = "FOLLOWING SERVICES"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.Location = New Point(90, 314)
        Label5.Name = "Label5"
        Label5.Size = New Size(216, 21)
        Label5.TabIndex = 47
        Label5.Text = "PLEASE CHOOSE FROM THE " & vbCrLf
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(menu)
        Panel1.Controls.Add(Panel2)
        Panel1.ForeColor = Color.Transparent
        Panel1.Location = New Point(-4, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 68)
        Panel1.TabIndex = 108
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(6, 44)
        Label16.Name = "Label16"
        Label16.Size = New Size(42, 15)
        Label16.TabIndex = 104
        Label16.Text = "MENU"
        ' 
        ' menu
        ' 
        menu.BackColor = Color.Transparent
        menu.BackgroundImage = My.Resources.Resources.menu
        menu.BackgroundImageLayout = ImageLayout.Zoom
        menu.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        menu.Location = New Point(3, 3)
        menu.Name = "menu"
        menu.Size = New Size(45, 38)
        menu.TabIndex = 106
        menu.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Location = New Point(31, -13)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(142, 90)
        Panel2.TabIndex = 12
        ' 
        ' welcome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Panel4)
        Controls.Add(Panel5)
        Controls.Add(DPrescription_button)
        Controls.Add(Appointment_button)
        Controls.Add(Prescription_button)
        Controls.Add(Record_button)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Name = "welcome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "record1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Record_button As CustomControls.RJControls.RoundedButton
    Friend WithEvents Prescription_button As CustomControls.RJControls.RoundedButton
    Friend WithEvents Appointment_button As CustomControls.RJControls.RoundedButton
    Friend WithEvents DPrescription_button As CustomControls.RJControls.RoundedButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents menu As Button
    Friend WithEvents Panel2 As Panel
End Class
