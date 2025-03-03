<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.DATEOFBOOKRETURNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BOOKRETURNBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIBDataSet4 = New LBS.LIBDataSet4
        Me.BOOKRETURNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIBDataSet1 = New LBS.LIBDataSet1
        Me.Label1 = New System.Windows.Forms.Label
        Me.BOOKRETURNTableAdapter = New LBS.LIBDataSet1TableAdapters.BOOKRETURNTableAdapter
        Me.BOOKRETURNTableAdapter1 = New LBS.LIBDataSet4TableAdapters.BOOKRETURNTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKRETURNBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKRETURNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STUDENTSMARTCARDNODataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn, Me.CLASSDataGridViewTextBoxColumn, Me.ROLLNODataGridViewTextBoxColumn, Me.BOOKNAMEDataGridViewTextBoxColumn, Me.BOOKCODEDataGridViewTextBoxColumn, Me.DATEOFBOOKISSUEDataGridViewTextBoxColumn, Me.DATEOFBOOKRETURNDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BOOKRETURNBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(3, 171)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(826, 282)
        Me.DataGridView1.TabIndex = 0
        '
        'STUDENTSMARTCARDNODataGridViewTextBoxColumn
        '
        Me.STUDENTSMARTCARDNODataGridViewTextBoxColumn.DataPropertyName = "STUDENTSMARTCARD NO"
        Me.STUDENTSMARTCARDNODataGridViewTextBoxColumn.HeaderText = "STUDENTSMARTCARD NO"
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
        Me.BOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOK_NAME"
        Me.BOOKNAMEDataGridViewTextBoxColumn.HeaderText = "BOOK_NAME"
        Me.BOOKNAMEDataGridViewTextBoxColumn.Name = "BOOKNAMEDataGridViewTextBoxColumn"
        '
        'BOOKCODEDataGridViewTextBoxColumn
        '
        Me.BOOKCODEDataGridViewTextBoxColumn.DataPropertyName = "BOOK_CODE"
        Me.BOOKCODEDataGridViewTextBoxColumn.HeaderText = "BOOK_CODE"
        Me.BOOKCODEDataGridViewTextBoxColumn.Name = "BOOKCODEDataGridViewTextBoxColumn"
        '
        'DATEOFBOOKISSUEDataGridViewTextBoxColumn
        '
        Me.DATEOFBOOKISSUEDataGridViewTextBoxColumn.DataPropertyName = "DATE OF BOOK ISSUE"
        Me.DATEOFBOOKISSUEDataGridViewTextBoxColumn.HeaderText = "DATE OF BOOK ISSUE"
        Me.DATEOFBOOKISSUEDataGridViewTextBoxColumn.Name = "DATEOFBOOKISSUEDataGridViewTextBoxColumn"
        '
        'DATEOFBOOKRETURNDataGridViewTextBoxColumn
        '
        Me.DATEOFBOOKRETURNDataGridViewTextBoxColumn.DataPropertyName = "DATE OF BOOK RETURN"
        Me.DATEOFBOOKRETURNDataGridViewTextBoxColumn.HeaderText = "DATE OF BOOK RETURN"
        Me.DATEOFBOOKRETURNDataGridViewTextBoxColumn.Name = "DATEOFBOOKRETURNDataGridViewTextBoxColumn"
        '
        'BOOKRETURNBindingSource1
        '
        Me.BOOKRETURNBindingSource1.DataMember = "BOOKRETURN"
        Me.BOOKRETURNBindingSource1.DataSource = Me.LIBDataSet4
        '
        'LIBDataSet4
        '
        Me.LIBDataSet4.DataSetName = "LIBDataSet4"
        Me.LIBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BOOKRETURNBindingSource
        '
        Me.BOOKRETURNBindingSource.DataMember = "BOOKRETURN"
        Me.BOOKRETURNBindingSource.DataSource = Me.LIBDataSet1
        '
        'LIBDataSet1
        '
        Me.LIBDataSet1.DataSetName = "LIBDataSet1"
        Me.LIBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BOOK RETURN"
        '
        'BOOKRETURNTableAdapter
        '
        Me.BOOKRETURNTableAdapter.ClearBeforeFill = True
        '
        'BOOKRETURNTableAdapter1
        '
        Me.BOOKRETURNTableAdapter1.ClearBeforeFill = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 529)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form6"
        Me.Text = "Book Return Detail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKRETURNBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKRETURNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LIBDataSet1 As LBS.LIBDataSet1
    Friend WithEvents BOOKRETURNBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKRETURNTableAdapter As LBS.LIBDataSet1TableAdapters.BOOKRETURNTableAdapter
    Friend WithEvents STUDENTSMARTCARDNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLASSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ROLLNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOKNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOKCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEOFBOOKISSUEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEOFBOOKRETURNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LIBDataSet4 As LBS.LIBDataSet4
    Friend WithEvents BOOKRETURNBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKRETURNTableAdapter1 As LBS.LIBDataSet4TableAdapters.BOOKRETURNTableAdapter
End Class
