<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.BOOKCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BOOKNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AUTHORSNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EDITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BOOKPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PAGESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ADDABOOKBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIBDataSet3 = New LBS.LIBDataSet3
        Me.ADDABOOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIBDataSet2 = New LBS.LIBDataSet2
        Me.Label1 = New System.Windows.Forms.Label
        Me.ADDABOOKTableAdapter = New LBS.LIBDataSet2TableAdapters.ADDABOOKTableAdapter
        Me.ADDABOOKTableAdapter1 = New LBS.LIBDataSet3TableAdapters.ADDABOOKTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADDABOOKBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADDABOOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BOOKCODEDataGridViewTextBoxColumn, Me.BOOKNAMEDataGridViewTextBoxColumn, Me.AUTHORSNAMEDataGridViewTextBoxColumn, Me.EDITIONDataGridViewTextBoxColumn, Me.BOOKPRICEDataGridViewTextBoxColumn, Me.PAGESDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ADDABOOKBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(94, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 217)
        Me.DataGridView1.TabIndex = 0
        '
        'BOOKCODEDataGridViewTextBoxColumn
        '
        Me.BOOKCODEDataGridViewTextBoxColumn.DataPropertyName = "BOOKCODE"
        Me.BOOKCODEDataGridViewTextBoxColumn.HeaderText = "BOOKCODE"
        Me.BOOKCODEDataGridViewTextBoxColumn.Name = "BOOKCODEDataGridViewTextBoxColumn"
        '
        'BOOKNAMEDataGridViewTextBoxColumn
        '
        Me.BOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOK NAME"
        Me.BOOKNAMEDataGridViewTextBoxColumn.HeaderText = "BOOK NAME"
        Me.BOOKNAMEDataGridViewTextBoxColumn.Name = "BOOKNAMEDataGridViewTextBoxColumn"
        '
        'AUTHORSNAMEDataGridViewTextBoxColumn
        '
        Me.AUTHORSNAMEDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR'S NAME"
        Me.AUTHORSNAMEDataGridViewTextBoxColumn.HeaderText = "AUTHOR'S NAME"
        Me.AUTHORSNAMEDataGridViewTextBoxColumn.Name = "AUTHORSNAMEDataGridViewTextBoxColumn"
        '
        'EDITIONDataGridViewTextBoxColumn
        '
        Me.EDITIONDataGridViewTextBoxColumn.DataPropertyName = "EDITION"
        Me.EDITIONDataGridViewTextBoxColumn.HeaderText = "EDITION"
        Me.EDITIONDataGridViewTextBoxColumn.Name = "EDITIONDataGridViewTextBoxColumn"
        '
        'BOOKPRICEDataGridViewTextBoxColumn
        '
        Me.BOOKPRICEDataGridViewTextBoxColumn.DataPropertyName = "BOOK PRICE"
        Me.BOOKPRICEDataGridViewTextBoxColumn.HeaderText = "BOOK PRICE"
        Me.BOOKPRICEDataGridViewTextBoxColumn.Name = "BOOKPRICEDataGridViewTextBoxColumn"
        '
        'PAGESDataGridViewTextBoxColumn
        '
        Me.PAGESDataGridViewTextBoxColumn.DataPropertyName = "PAGES"
        Me.PAGESDataGridViewTextBoxColumn.HeaderText = "PAGES"
        Me.PAGESDataGridViewTextBoxColumn.Name = "PAGESDataGridViewTextBoxColumn"
        '
        'ADDABOOKBindingSource1
        '
        Me.ADDABOOKBindingSource1.DataMember = "ADDABOOK"
        Me.ADDABOOKBindingSource1.DataSource = Me.LIBDataSet3
        '
        'LIBDataSet3
        '
        Me.LIBDataSet3.DataSetName = "LIBDataSet3"
        Me.LIBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ADDABOOKBindingSource
        '
        Me.ADDABOOKBindingSource.DataMember = "ADDABOOK"
        Me.ADDABOOKBindingSource.DataSource = Me.LIBDataSet2
        '
        'LIBDataSet2
        '
        Me.LIBDataSet2.DataSetName = "LIBDataSet2"
        Me.LIBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADD A BOOK"
        '
        'ADDABOOKTableAdapter
        '
        Me.ADDABOOKTableAdapter.ClearBeforeFill = True
        '
        'ADDABOOKTableAdapter1
        '
        Me.ADDABOOKTableAdapter1.ClearBeforeFill = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 489)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form8"
        Me.Text = "Add Book Detail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADDABOOKBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADDABOOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LIBDataSet2 As LBS.LIBDataSet2
    Friend WithEvents ADDABOOKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ADDABOOKTableAdapter As LBS.LIBDataSet2TableAdapters.ADDABOOKTableAdapter
    Friend WithEvents BOOKCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOKNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AUTHORSNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EDITIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOKPRICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAGESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LIBDataSet3 As LBS.LIBDataSet3
    Friend WithEvents ADDABOOKBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ADDABOOKTableAdapter1 As LBS.LIBDataSet3TableAdapters.ADDABOOKTableAdapter
End Class
