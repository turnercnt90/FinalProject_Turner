<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerInfomationForm
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
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblService = New System.Windows.Forms.Label()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtDate = New System.Windows.Forms.TextBox()
        Me.TxtService = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(32, 46)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(35, 13)
        Me.LblName.TabIndex = 0
        Me.LblName.Text = "Name"
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.Location = New System.Drawing.Point(32, 90)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(78, 13)
        Me.LblPhone.TabIndex = 1
        Me.LblPhone.Text = "Phone Number"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Location = New System.Drawing.Point(37, 137)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(30, 13)
        Me.LblDate.TabIndex = 2
        Me.LblDate.Text = "Date"
        '
        'LblService
        '
        Me.LblService.AutoSize = True
        Me.LblService.Location = New System.Drawing.Point(37, 176)
        Me.LblService.Name = "LblService"
        Me.LblService.Size = New System.Drawing.Size(99, 13)
        Me.LblService.TabIndex = 3
        Me.LblService.Text = "Services Performed"
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(167, 83)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(130, 20)
        Me.TxtPhone.TabIndex = 4
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(167, 43)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(130, 20)
        Me.TxtName.TabIndex = 5
        '
        'TxtDate
        '
        Me.TxtDate.Location = New System.Drawing.Point(167, 130)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.Size = New System.Drawing.Size(130, 20)
        Me.TxtDate.TabIndex = 6
        '
        'TxtService
        '
        Me.TxtService.Location = New System.Drawing.Point(167, 173)
        Me.TxtService.Name = "TxtService"
        Me.TxtService.Size = New System.Drawing.Size(130, 20)
        Me.TxtService.TabIndex = 7
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(49, 253)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(222, 253)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 9
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 298)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtService)
        Me.Controls.Add(Me.TxtDate)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtPhone)
        Me.Controls.Add(Me.LblService)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.LblPhone)
        Me.Controls.Add(Me.LblName)
        Me.Name = "Form2"
        Me.Text = "Customer Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblName As Label
    Friend WithEvents LblPhone As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents LblService As Label
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtDate As TextBox
    Friend WithEvents TxtService As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnExit As Button
End Class
