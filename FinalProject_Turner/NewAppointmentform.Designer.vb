<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAppointmentForm
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
        Me.components = New System.ComponentModel.Container()
        Me.cborepairtype = New System.Windows.Forms.ComboBox()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.cbocustomer = New System.Windows.Forms.ComboBox()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.txttime = New System.Windows.Forms.TextBox()
        Me.chklicensed = New System.Windows.Forms.CheckBox()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.errprovider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errprovider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cborepairtype
        '
        Me.cborepairtype.FormattingEnabled = True
        Me.cborepairtype.Location = New System.Drawing.Point(45, 158)
        Me.cborepairtype.Name = "cborepairtype"
        Me.cborepairtype.Size = New System.Drawing.Size(121, 21)
        Me.cborepairtype.TabIndex = 25
        '
        'dtpdate
        '
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdate.Location = New System.Drawing.Point(29, 82)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(121, 20)
        Me.dtpdate.TabIndex = 24
        '
        'cbocustomer
        '
        Me.cbocustomer.FormattingEnabled = True
        Me.cbocustomer.Location = New System.Drawing.Point(291, 81)
        Me.cbocustomer.Name = "cbocustomer"
        Me.cbocustomer.Size = New System.Drawing.Size(121, 21)
        Me.cbocustomer.TabIndex = 23
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(90, 211)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(288, 70)
        Me.txtdescription.TabIndex = 22
        '
        'txttime
        '
        Me.txttime.Location = New System.Drawing.Point(169, 82)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(100, 20)
        Me.txttime.TabIndex = 21
        '
        'chklicensed
        '
        Me.chklicensed.AutoSize = True
        Me.chklicensed.Location = New System.Drawing.Point(272, 162)
        Me.chklicensed.Name = "chklicensed"
        Me.chklicensed.Size = New System.Drawing.Size(106, 17)
        Me.chklicensed.TabIndex = 20
        Me.chklicensed.Text = "Must be licensed"
        Me.chklicensed.UseVisualStyleBackColor = True
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Location = New System.Drawing.Point(42, 194)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(123, 13)
        Me.lblstatus.TabIndex = 19
        Me.lblstatus.Text = "description (0-100 chars)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Customer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Repair Type"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(226, 287)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 14
        Me.btncancel.Text = "cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(90, 287)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 13
        Me.button1.Text = "Save"
        Me.button1.UseVisualStyleBackColor = True
        '
        'errprovider
        '
        Me.errprovider.ContainerControl = Me
        '
        'NewAppointmentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 375)
        Me.Controls.Add(Me.cborepairtype)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.cbocustomer)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.txttime)
        Me.Controls.Add(Me.chklicensed)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.button1)
        Me.Name = "NewAppointmentform"
        Me.Text = "New Appointment"
        CType(Me.errprovider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cborepairtype As ComboBox
    Friend WithEvents dtpdate As DateTimePicker
    Friend WithEvents cbocustomer As ComboBox
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents txttime As TextBox
    Friend WithEvents chklicensed As CheckBox
    Friend WithEvents lblstatus As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents button1 As Button
    Friend WithEvents errprovider As ErrorProvider
End Class
