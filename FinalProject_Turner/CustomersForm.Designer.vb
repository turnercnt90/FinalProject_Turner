<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersForm
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
        Me.dgvcustomers = New System.Windows.Forms.DataGridView()
        Me.EstimateServicesDataSet = New FinalProject_Turner.EstimateServicesDataSet()
        Me.CustomersTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customers_TableTableAdapter = New FinalProject_Turner.EstimateServicesDataSetTableAdapters.Customers_TableTableAdapter()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicesPerformedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvcustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstimateServicesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvcustomers
        '
        Me.dgvcustomers.AutoGenerateColumns = False
        Me.dgvcustomers.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.ServicesPerformedDataGridViewTextBoxColumn})
        Me.dgvcustomers.DataSource = Me.CustomersTableBindingSource
        Me.dgvcustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvcustomers.Location = New System.Drawing.Point(0, 0)
        Me.dgvcustomers.Name = "dgvcustomers"
        Me.dgvcustomers.Size = New System.Drawing.Size(444, 287)
        Me.dgvcustomers.TabIndex = 1
        '
        'EstimateServicesDataSet
        '
        Me.EstimateServicesDataSet.DataSetName = "EstimateServicesDataSet"
        Me.EstimateServicesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableBindingSource
        '
        Me.CustomersTableBindingSource.DataMember = "Customers Table"
        Me.CustomersTableBindingSource.DataSource = Me.EstimateServicesDataSet
        '
        'Customers_TableTableAdapter
        '
        Me.Customers_TableTableAdapter.ClearBeforeFill = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'ServicesPerformedDataGridViewTextBoxColumn
        '
        Me.ServicesPerformedDataGridViewTextBoxColumn.DataPropertyName = "services performed"
        Me.ServicesPerformedDataGridViewTextBoxColumn.HeaderText = "services performed"
        Me.ServicesPerformedDataGridViewTextBoxColumn.Name = "ServicesPerformedDataGridViewTextBoxColumn"
        '
        'CustomersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 287)
        Me.Controls.Add(Me.dgvcustomers)
        Me.Name = "CustomersForm"
        Me.Text = "Customers"
        CType(Me.dgvcustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstimateServicesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvcustomers As DataGridView
    Friend WithEvents EstimateServicesDataSet As EstimateServicesDataSet
    Friend WithEvents CustomersTableBindingSource As BindingSource
    Friend WithEvents Customers_TableTableAdapter As EstimateServicesDataSetTableAdapters.Customers_TableTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServicesPerformedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
