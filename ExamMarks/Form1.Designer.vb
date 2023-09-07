<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnEnter = New Button()
        txtExamscore = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnEnter
        ' 
        btnEnter.Location = New Point(271, 185)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(187, 65)
        btnEnter.TabIndex = 0
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = True
        ' 
        ' txtExamscore
        ' 
        txtExamscore.Location = New Point(308, 130)
        txtExamscore.Name = "txtExamscore"
        txtExamscore.Size = New Size(150, 31)
        txtExamscore.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(158, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 25)
        Label1.TabIndex = 2
        Label1.Text = "Enter Exam Mark"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txtExamscore)
        Controls.Add(btnEnter)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents txtExamscore As TextBox
    Friend WithEvents Label1 As Label
End Class
