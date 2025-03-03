<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.STUDENTSMARTCARDNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLASSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ROLLNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BOOKNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BOOKCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DATEOFBOOKISSUEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BOOKISSUEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIBDataSet5 = New LBS.LIBDataSet5
        Me.BOOKISSUEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIBDataSet = New LBS.LIBDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.BOOKISSUETableAdapter = New LBS.LIBDataSetTableAdapters.BOOKISSUETableAdapter
        Me.BOOKISSUETableAdapter1 = New LBS.LIBDataSet5TableAdapters.BOOKISSUETableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKISSUEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKISSUEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STUDENTSMARTCARDNODataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn, Me.CLASSDataGridViewTextBoxColumn, Me.ROLLNODataGridViewTextBoxColumn, Me.BOOKNAMEDataGridViewTextBoxColumn, Me.BOOKCODEDataGridViewTextBoxColumn, Me.DATEOFBOOKISSUEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BOOKISSUEBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(31, 151)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(745, 297)
        Me.DataGridView1.TabIndex = 0
        '
        'STUDENTSMARTCARDNODataGridViewTextBoxColumn
        '
        Me.STUDENTSMARTCARDNODataGridViewTextBoxColumn.DataPropertyName = "STUDENTSMARTCARDNO"
        Me.STUDENTSMARTCARDNODataGridViewTextBoxColumn.HeaderText = "STUDENTSMARTCARDNO"
        Me.STUDENTSMARTCARDNODataGridViewTextBoxColumn.Name = "STUDENTSMARTCARDNODataGridViewTextBoxColumn"
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        '
        'CLASSDataGridViewTextBoxColumn
        '
        Me.CLASSDataGridViewTextBoxColumn.DataPropertyName = "CLASS"
        Me.CLASSDataGridViewTextBoxColumn.HeaderText = "CLASS"
        Me.CLASSDataGridViewTextBoxColumn.Name = "CLASSDataGridViewTextBoxColumn"
        '
        'ROLLNODataGridViewTextBoxColumn
        '
        Me.ROLLNODataGridViewTextBoxColumn.DataPropertyName = "ROLL_NO"
        Me.ROLLNODataGridViewTextBoxColumn.HeaderText = "ROLL_NO"
        Me.ROLLNODataGridViewTextBoxColumn.Name = "ROLLNODataGridViewTextBoxColumn"
        '
        'BOOKNAMEDataGridViewTextBoxColumn
        '
        Me.BOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOK NAME"
        Me.BOOKNAMEDataGridViewTextBoxColumn.HeaderText = "BOOK NAME"
        Me.BOOKNAMEDataGridViewTextBoxColumn.Name = "BOOKNAMEDataGridViewTextBoxColumn"
        '
        'BOOKCODEDataGridViewTextBoxColumn
        '
        Me.BOOKCODEDataGridViewTextBoxColumn.DataPropertyName = "BOOK CODE"
        Me.BOOKCODEDataGridViewTextBoxColumn.HeaderText = "BOOK CODE"
        Me.BOOKCODEDataGridViewTextBoxColumn.Name = "BOOKCODEDataGridViewTextBoxColumn"
        '
        'DATEOFBOOKISSUEDataGridViewTextBoxColumn
        '
        Me.DATEOFBOOKISSUEDataGridViewTextBoxColumn.DataPropertyName = "DATE OF BOOK ISSUE"
        Me.DATEOFBOOKISSUEDataGridViewTextBoxColumn.HeaderText = "DATE OF BOOK ISSUE"
        Me.DATEOFBOOKISSUEDataGridViewTextBoxColumn.Name = "DATEOFBOOKISSUEDataGridViewTextBoxColumn"
        '
        'BOOKISSUEBindingSource1
        '
        Me.BOOKISSUEBindingSource1.DataMember = "BOOKISSUE"
        Me.BOOKISSUEBindingSource1.DataSource = Me.LIBDataSet5
        '
        'LIBDataSet5
        '
        Me.LIBDataSet5.DataSetName = "LIBDataSet5"
        Me.LIBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BOOKISSUEBindingSource
        '
        Me.BOOKISSUEBindingSource.DataMember = "BOOKISSUE"
        Me.BOOKISSUEBindingSource.DataSource = Me.LIBDataSet
        '
        'LIBDataSet
        '
        Me.LIBDataSet.DataSetName = "LIBDataSet"
        Me.LIBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(329, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BOOK ISSUE"
        '
        'BOOKISSUETableAdapter
        '
        Me.BOOKISSUETableAdapter.ClearBeforeFill = True
        '
        'BOOKISSUETableAdapter1
        '
        Me.BOOKISSUETableAdapter1.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 532)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form4"
        Me.Text = "Book Issue Detail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKISSUEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKISSUEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LIBDataSet As LBS.LIBDataSet
    Friend WithEvents BOOKISSUEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKISSUETableAdapter As LBS.LIBDataSetTableAdapters.BOOKISSUETableAdapter
    Friend WithEvents STUDENTSMARTCARDNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLASSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ROLLNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOKNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOKCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEOFBOOKISSUEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LIBDataSet5 As LBS.LIBDataSet5
    Friend WithEvents BOOKISSUEBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKISSUETableAdapter1 As LBS.LIBDataSet5TableAdapters.BOOKISSUETableAdapter
End Class
