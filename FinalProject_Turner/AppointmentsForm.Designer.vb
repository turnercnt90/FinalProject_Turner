<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Appointmentsform
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appointmentsform))
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnclose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnedit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboCustomer = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btndelete = New System.Windows.Forms.ToolStripButton()
        Me.btnAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvappointments = New System.Windows.Forms.DataGridView()
        Me.EstimateServicesDataSet = New FinalProject_Turner.EstimateServicesDataSet()
        Me.Appointment1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Appointment1TableAdapter = New FinalProject_Turner.EstimateServicesDataSetTableAdapters.Appointment1TableAdapter()
        Me.CustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduledDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvappointments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimateServicesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Appointment1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 50)
        '
        'btnclose
        '
        Me.btnclose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(40, 47)
        Me.btnclose.Text = "Close"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 50)
        '
        'btnedit
        '
        Me.btnedit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(31, 47)
        Me.btnedit.Text = "Edit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 50)
        '
        'cboCustomer
        '
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(121, 50)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(59, 47)
        Me.ToolStripLabel1.Text = "Customer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 50)
        '
        'btndelete
        '
        Me.btndelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(44, 47)
        Me.btndelete.Text = "Delete"
        '
        'btnAll
        '
        Me.btnAll.AutoSize = False
        Me.btnAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAll.Image = CType(resources.GetObject("btnAll.Image"), System.Drawing.Image)
        Me.btnAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(23, 50)
        Me.btnAll.Text = "all"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAll, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.cboCustomer, Me.ToolStripSeparator2, Me.btnedit, Me.ToolStripSeparator3, Me.btnclose, Me.ToolStripSeparator4, Me.btndelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(513, 50)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'AppointmentsBindingSource
        '
        Me.AppointmentsBindingSource.DataMember = "Appointments"
        '
        'dgvappointments
        '
        Me.dgvappointments.AutoGenerateColumns = False
        Me.dgvappointments.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvappointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvappointments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerDataGridViewTextBoxColumn, Me.ScheduledDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.dgvappointments.DataSource = Me.Appointment1BindingSource
        Me.dgvappointments.Location = New System.Drawing.Point(0, 53)
        Me.dgvappointments.Name = "dgvappointments"
        Me.dgvappointments.Size = New System.Drawing.Size(513, 224)
        Me.dgvappointments.TabIndex = 4
        '
        'EstimateServicesDataSet
        '
        Me.EstimateServicesDataSet.DataSetName = "EstimateServicesDataSet"
        Me.EstimateServicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Appointment1BindingSource
        '
        Me.Appointment1BindingSource.DataMember = "Appointment1"
        Me.Appointment1BindingSource.DataSource = Me.EstimateServicesDataSet
        '
        'Appointment1TableAdapter
        '
        Me.Appointment1TableAdapter.ClearBeforeFill = True
        '
        'CustomerDataGridViewTextBoxColumn
        '
        Me.CustomerDataGridViewTextBoxColumn.DataPropertyName = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.Name = "CustomerDataGridViewTextBoxColumn"
        '
        'ScheduledDataGridViewTextBoxColumn
        '
        Me.ScheduledDataGridViewTextBoxColumn.DataPropertyName = "Scheduled"
        Me.ScheduledDataGridViewTextBoxColumn.HeaderText = "Scheduled"
        Me.ScheduledDataGridViewTextBoxColumn.Name = "ScheduledDataGridViewTextBoxColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'Appointmentsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 403)
        Me.Controls.Add(Me.dgvappointments)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Appointmentsform"
        Me.Text = "Appointments"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvappointments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimateServicesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Appointment1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btnclose As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnedit As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cboCustomer As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btndelete As ToolStripButton
    Friend WithEvents btnAll As ToolStripButton
    Friend WithEvents AppointmentsBindingSource As BindingSource
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents dgvappointments As DataGridView
    Friend WithEvents EstimateServicesDataSet As EstimateServicesDataSet
    Friend WithEvents Appointment1BindingSource As BindingSource
    Friend WithEvents Appointment1TableAdapter As EstimateServicesDataSetTableAdapters.Appointment1TableAdapter
    Friend WithEvents CustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScheduledDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
