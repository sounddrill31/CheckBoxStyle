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
        Label1 = New Label()
        Label2 = New Label()
        Bold = New CheckBox()
        Underline = New CheckBox()
        Italics = New CheckBox()
        StringEntered = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(346, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 0
        Label1.Text = "Set Text Style"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(278, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter String"
        ' 
        ' Bold
        ' 
        Bold.AutoSize = True
        Bold.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bold.Location = New Point(243, 121)
        Bold.Name = "Bold"
        Bold.Size = New Size(51, 19)
        Bold.TabIndex = 2
        Bold.Text = "Bold"
        Bold.UseVisualStyleBackColor = True
        ' 
        ' Underline
        ' 
        Underline.AutoSize = True
        Underline.Font = New Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Underline.Location = New Point(448, 115)
        Underline.Name = "Underline"
        Underline.Size = New Size(77, 19)
        Underline.TabIndex = 3
        Underline.Text = "Underline"
        Underline.UseVisualStyleBackColor = True
        ' 
        ' Italics
        ' 
        Italics.AutoSize = True
        Italics.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Italics.Location = New Point(352, 115)
        Italics.Name = "Italics"
        Italics.Size = New Size(56, 19)
        Italics.TabIndex = 4
        Italics.Text = "Italics"
        Italics.UseVisualStyleBackColor = True
        ' 
        ' StringEntered
        ' 
        StringEntered.Location = New Point(352, 86)
        StringEntered.Name = "StringEntered"
        StringEntered.Size = New Size(100, 23)
        StringEntered.TabIndex = 5
        StringEntered.Text = "Hello World"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StringEntered)
        Controls.Add(Italics)
        Controls.Add(Underline)
        Controls.Add(Bold)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Bold As CheckBox
    Friend WithEvents Underline As CheckBox
    Friend WithEvents Italics As CheckBox
    Friend WithEvents StringEntered As TextBox

End Class
