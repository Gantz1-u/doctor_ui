<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class role
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(role))
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        RoundedButton3 = New CustomControls.RJControls.RoundedButton()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = SystemColors.ButtonHighlight
        RoundedButton1.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton1.BorderColor = Color.PaleVioletRed
        RoundedButton1.BorderRadius = 9
        RoundedButton1.BorderSize = 0
        RoundedButton1.FlatAppearance.BorderSize = 0
        RoundedButton1.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.ForeColor = Color.Black
        RoundedButton1.Location = New Point(118, 451)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(150, 40)
        RoundedButton1.TabIndex = 3
        RoundedButton1.Text = "NURSE"
        RoundedButton1.TextColor = Color.Black
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.BackColor = SystemColors.ButtonHighlight
        RoundedButton3.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton3.BorderColor = Color.PaleVioletRed
        RoundedButton3.BorderRadius = 9
        RoundedButton3.BorderSize = 0
        RoundedButton3.FlatAppearance.BorderSize = 0
        RoundedButton3.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton3.FlatStyle = FlatStyle.Flat
        RoundedButton3.ForeColor = Color.Black
        RoundedButton3.Location = New Point(118, 497)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(150, 40)
        RoundedButton3.TabIndex = 4
        RoundedButton3.Text = "DOCTOR"
        RoundedButton3.TextColor = Color.Black
        RoundedButton3.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(43, 57)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(289, 178)
        Panel1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label1.Location = New Point(96, 263)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 20)
        Label1.TabIndex = 8
        Label1.Text = "Welcome to HealthGuard! "
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label2.Location = New Point(16, 283)
        Label2.Name = "Label2"
        Label2.Size = New Size(358, 20)
        Label2.TabIndex = 9
        Label2.Text = "Let’s make managing your prescriptions and health"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label3.Location = New Point(96, 303)
        Label3.Name = "Label3"
        Label3.Size = New Size(185, 20)
        Label3.TabIndex = 10
        Label3.Text = "updates easier, every day."
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(87, 559)
        Label4.Name = "Label4"
        Label4.Size = New Size(194, 20)
        Label4.TabIndex = 11
        Label4.Text = "Please select your user role"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label5.Location = New Point(67, 622)
        Label5.Name = "Label5"
        Label5.Size = New Size(183, 20)
        Label5.TabIndex = 12
        Label5.Text = "Doesn't have an account?"
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.BackColor = SystemColors.ButtonHighlight
        RoundedButton2.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton2.BorderColor = Color.PaleVioletRed
        RoundedButton2.BorderRadius = 9
        RoundedButton2.BorderSize = 0
        RoundedButton2.FlatAppearance.BorderSize = 0
        RoundedButton2.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton2.FlatStyle = FlatStyle.Flat
        RoundedButton2.ForeColor = Color.Black
        RoundedButton2.Location = New Point(118, 405)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(150, 40)
        RoundedButton2.TabIndex = 2
        RoundedButton2.Text = "PATIENT"
        RoundedButton2.TextColor = Color.Black
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.SteelBlue
        Label7.Location = New Point(247, 624)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 17)
        Label7.TabIndex = 15
        Label7.Text = "Register"
        ' 
        ' role
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(RoundedButton3)
        Controls.Add(RoundedButton1)
        Controls.Add(RoundedButton2)
        FormBorderStyle = FormBorderStyle.None
        Name = "role"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton3 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Label7 As Label

End Class
