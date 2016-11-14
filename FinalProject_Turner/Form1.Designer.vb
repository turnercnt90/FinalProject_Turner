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
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.BtnEstimate = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.txtestimate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Oil Change", "Brake Pads Changed", "Coolant Flush", "Tune Up", "Struts Changed", "Tires Rotated", "All Fluids Changed", "Ac Recharged"})
        Me.ListBox1.Location = New System.Drawing.Point(117, 42)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 0
        '
        'TxtFindCustomer
        '
        Me.TxtFindCustomer.Location = New System.Drawing.Point(92, 179)
        Me.TxtFindCustomer.Name = "TxtFindCustomer"
        Me.TxtFindCustomer.Size = New System.Drawing.Size(145, 20)
        Me.TxtFindCustomer.TabIndex = 1
        '
        'LblFindCustomer
        '
        Me.LblFindCustomer.AutoSize = True
        Me.LblFindCustomer.Location = New System.Drawing.Point(12, 182)
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
        Me.ChkStudentDiscount.Location = New System.Drawing.Point(284, 42)
        Me.ChkStudentDiscount.Name = "ChkStudentDiscount"
        Me.ChkStudentDiscount.Size = New System.Drawing.Size(108, 17)
        Me.ChkStudentDiscount.TabIndex = 4
        Me.ChkStudentDiscount.Text = "Student Discount"
        Me.ChkStudentDiscount.UseVisualStyleBackColor = True
        '
        'ChkFamilyDiscount
        '
        Me.ChkFamilyDiscount.AutoSize = True
        Me.ChkFamilyDiscount.Location = New System.Drawing.Point(284, 79)
        Me.ChkFamilyDiscount.Name = "ChkFamilyDiscount"
        Me.ChkFamilyDiscount.Size = New System.Drawing.Size(100, 17)
        Me.ChkFamilyDiscount.TabIndex = 5
        Me.ChkFamilyDiscount.Text = "Family Discount"
        Me.ChkFamilyDiscount.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.Location = New System.Drawing.Point(12, 263)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(75, 23)
        Me.BtnFind.TabIndex = 6
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'BtnEstimate
        '
        Me.BtnEstimate.Location = New System.Drawing.Point(106, 263)
        Me.BtnEstimate.Name = "BtnEstimate"
        Me.BtnEstimate.Size = New System.Drawing.Size(75, 23)
        Me.BtnEstimate.TabIndex = 7
        Me.BtnEstimate.Text = "Estimate"
        Me.BtnEstimate.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(204, 263)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 8
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(302, 263)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(394, 263)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 10
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'txtestimate
        '
        Me.txtestimate.Location = New System.Drawing.Point(369, 179)
        Me.txtestimate.Name = "txtestimate"
        Me.txtestimate.Size = New System.Drawing.Size(100, 20)
        Me.txtestimate.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Estimate Cost"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 315)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtestimate)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnEstimate)
        Me.Controls.Add(Me.BtnFind)
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
    Friend WithEvents BtnFind As Button
    Friend WithEvents BtnEstimate As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents txtestimate As TextBox
    Friend WithEvents Label1 As Label
End Class
