<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TxtFindCustomer = New System.Windows.Forms.TextBox()
        Me.LblFindCustomer = New System.Windows.Forms.Label()
        Me.LblServicePerformed = New System.Windows.Forms.Label()
        Me.ChkStudentDiscount = New System.Windows.Forms.CheckBox()
        Me.ChkFamilyDiscount = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(117, 42)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 0
        '
        'TxtFindCustomer
        '
        Me.TxtFindCustomer.Location = New System.Drawing.Point(92, 386)
        Me.TxtFindCustomer.Name = "TxtFindCustomer"
        Me.TxtFindCustomer.Size = New System.Drawing.Size(100, 20)
        Me.TxtFindCustomer.TabIndex = 1
        '
        'LblFindCustomer
        '
        Me.LblFindCustomer.AutoSize = True
        Me.LblFindCustomer.Location = New System.Drawing.Point(12, 389)
        Me.LblFindCustomer.Name = "LblFindCustomer"
        Me.LblFindCustomer.Size = New System.Drawing.Size(74, 13)
        Me.LblFindCustomer.TabIndex = 2
        Me.LblFindCustomer.Text = "Find Customer"
        '
        'LblServicePerformed
        '
        Me.LblServicePerformed.AutoSize = True
        Me.LblServicePerformed.Location = New System.Drawing.Point(12, 42)
        Me.LblServicePerformed.Name = "LblServicePerformed"
        Me.LblServicePerformed.Size = New System.Drawing.Size(99, 13)
        Me.LblServicePerformed.TabIndex = 3
        Me.LblServicePerformed.Text = "Services Performed"
        '
        'ChkStudentDiscount
        '
        Me.ChkStudentDiscount.AutoSize = True
        Me.ChkStudentDiscount.Location = New System.Drawing.Point(284, 41)
        Me.ChkStudentDiscount.Name = "ChkStudentDiscount"
        Me.ChkStudentDiscount.Size = New System.Drawing.Size(108, 17)
        Me.ChkStudentDiscount.TabIndex = 4
        Me.ChkStudentDiscount.Text = "Student Discount"
        Me.ChkStudentDiscount.UseVisualStyleBackColor = True
        '
        'ChkFamilyDiscount
        '
        Me.ChkFamilyDiscount.AutoSize = True
        Me.ChkFamilyDiscount.Location = New System.Drawing.Point(284, 64)
        Me.ChkFamilyDiscount.Name = "ChkFamilyDiscount"
        Me.ChkFamilyDiscount.Size = New System.Drawing.Size(100, 17)
        Me.ChkFamilyDiscount.TabIndex = 5
        Me.ChkFamilyDiscount.Text = "Family Discount"
        Me.ChkFamilyDiscount.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 451)
        Me.Controls.Add(Me.ChkFamilyDiscount)
        Me.Controls.Add(Me.ChkStudentDiscount)
        Me.Controls.Add(Me.LblServicePerformed)
        Me.Controls.Add(Me.LblFindCustomer)
        Me.Controls.Add(Me.TxtFindCustomer)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Cody's Car Estimates"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TxtFindCustomer As TextBox
    Friend WithEvents LblFindCustomer As Label
    Friend WithEvents LblServicePerformed As Label
    Friend WithEvents ChkStudentDiscount As CheckBox
    Friend WithEvents ChkFamilyDiscount As CheckBox
End Class
