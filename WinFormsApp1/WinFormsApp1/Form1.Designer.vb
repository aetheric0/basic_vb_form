<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnCheck = New Button()
        txtNumber = New TextBox()
        cmbFavorites = New ComboBox()
        btnSelect = New Button()
        SuspendLayout()
        ' 
        ' btnCheck
        ' 
        btnCheck.Location = New Point(332, 144)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(100, 47)
        btnCheck.TabIndex = 0
        btnCheck.Text = "Choose Number"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(241, 98)
        txtNumber.Name = "txtNumber"
        txtNumber.PlaceholderText = "Enter a Number between 10 and 20"
        txtNumber.Size = New Size(298, 23)
        txtNumber.TabIndex = 1
        ' 
        ' cmbFavorites
        ' 
        cmbFavorites.FormattingEnabled = True
        cmbFavorites.Location = New Point(241, 242)
        cmbFavorites.Name = "cmbFavorites"
        cmbFavorites.Size = New Size(298, 23)
        cmbFavorites.TabIndex = 3
        cmbFavorites.Text = "Choose Your Delicacy..."
        ' 
        ' btnSelect
        ' 
        btnSelect.Location = New Point(332, 299)
        btnSelect.Name = "btnSelect"
        btnSelect.Size = New Size(100, 47)
        btnSelect.TabIndex = 4
        btnSelect.Text = "Select Favorite"
        btnSelect.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(800, 450)
        Controls.Add(btnSelect)
        Controls.Add(cmbFavorites)
        Controls.Add(txtNumber)
        Controls.Add(btnCheck)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCheck As Button
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents cmbFavorites As ComboBox
    Friend WithEvents btnSelect As Button

End Class
