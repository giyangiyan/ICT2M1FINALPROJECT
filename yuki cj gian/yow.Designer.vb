<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class yow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(yow))
        Button1 = New Button()
        txtPass = New TextBox()
        txtUser = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(518, 276)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 48)
        Button1.TabIndex = 0
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(477, 203)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(220, 23)
        txtPass.TabIndex = 1
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(477, 152)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(220, 23)
        txtUser.TabIndex = 2
        ' 
        ' yow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(txtUser)
        Controls.Add(txtPass)
        Controls.Add(Button1)
        Name = "yow"
        Text = "yow"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
End Class
