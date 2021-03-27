<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContactosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabasemedicamentosDataSetContactos = New Sistema_Inventario.DatabasemedicamentosDataSetContactos()
        Me.ContactosTableAdapter = New Sistema_Inventario.DatabasemedicamentosDataSetContactosTableAdapters.ContactosTableAdapter()
        Me.IdcontaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombcontaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumcontaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpcontaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasemedicamentosDataSetContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcontaDataGridViewTextBoxColumn, Me.NombcontaDataGridViewTextBoxColumn, Me.NumcontaDataGridViewTextBoxColumn, Me.EmpcontaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ContactosBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(736, 422)
        Me.DataGridView1.TabIndex = 0
        '
        'ContactosBindingSource
        '
        Me.ContactosBindingSource.DataMember = "Contactos"
        Me.ContactosBindingSource.DataSource = Me.DatabasemedicamentosDataSetContactos
        '
        'DatabasemedicamentosDataSetContactos
        '
        Me.DatabasemedicamentosDataSetContactos.DataSetName = "DatabasemedicamentosDataSetContactos"
        Me.DatabasemedicamentosDataSetContactos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContactosTableAdapter
        '
        Me.ContactosTableAdapter.ClearBeforeFill = True
        '
        'IdcontaDataGridViewTextBoxColumn
        '
        Me.IdcontaDataGridViewTextBoxColumn.DataPropertyName = "Idconta"
        Me.IdcontaDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdcontaDataGridViewTextBoxColumn.Name = "IdcontaDataGridViewTextBoxColumn"
        '
        'NombcontaDataGridViewTextBoxColumn
        '
        Me.NombcontaDataGridViewTextBoxColumn.DataPropertyName = "nombconta"
        Me.NombcontaDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombcontaDataGridViewTextBoxColumn.Name = "NombcontaDataGridViewTextBoxColumn"
        '
        'NumcontaDataGridViewTextBoxColumn
        '
        Me.NumcontaDataGridViewTextBoxColumn.DataPropertyName = "numconta"
        Me.NumcontaDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumcontaDataGridViewTextBoxColumn.Name = "NumcontaDataGridViewTextBoxColumn"
        '
        'EmpcontaDataGridViewTextBoxColumn
        '
        Me.EmpcontaDataGridViewTextBoxColumn.DataPropertyName = "empconta"
        Me.EmpcontaDataGridViewTextBoxColumn.HeaderText = "Empresa/Laboratorio"
        Me.EmpcontaDataGridViewTextBoxColumn.Name = "EmpcontaDataGridViewTextBoxColumn"
        Me.EmpcontaDataGridViewTextBoxColumn.Width = 150
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 422)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form11"
        Me.Text = "Contactos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasemedicamentosDataSetContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DatabasemedicamentosDataSetContactos As DatabasemedicamentosDataSetContactos
    Friend WithEvents ContactosBindingSource As BindingSource
    Friend WithEvents ContactosTableAdapter As DatabasemedicamentosDataSetContactosTableAdapters.ContactosTableAdapter
    Friend WithEvents IdcontaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombcontaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumcontaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpcontaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
