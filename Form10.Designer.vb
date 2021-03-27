<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.LaboratoriosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabasemedicamentosDataSetLaboratorios1 = New Sistema_Inventario.DatabasemedicamentosDataSetLaboratorios()
        Me.DatabasemedicamentosDataSetLaboratorios = New Sistema_Inventario.DatabasemedicamentosDataSetLaboratorios()
        Me.LaboratoriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LaboratoriosTableAdapter = New Sistema_Inventario.DatabasemedicamentosDataSetLaboratoriosTableAdapters.LaboratoriosTableAdapter()
        Me.IdlabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrelabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SedelabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionlabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumlabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratoriosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasemedicamentosDataSetLaboratorios1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasemedicamentosDataSetLaboratorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratoriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdlabDataGridViewTextBoxColumn, Me.NombrelabDataGridViewTextBoxColumn, Me.SedelabDataGridViewTextBoxColumn, Me.SucursalabDataGridViewTextBoxColumn, Me.DireccionlabDataGridViewTextBoxColumn, Me.NumlabDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LaboratoriosBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1032, 445)
        Me.DataGridView1.TabIndex = 0
        '
        'LaboratoriosBindingSource1
        '
        Me.LaboratoriosBindingSource1.DataMember = "Laboratorios"
        Me.LaboratoriosBindingSource1.DataSource = Me.DatabasemedicamentosDataSetLaboratorios1
        '
        'DatabasemedicamentosDataSetLaboratorios1
        '
        Me.DatabasemedicamentosDataSetLaboratorios1.DataSetName = "DatabasemedicamentosDataSetLaboratorios"
        Me.DatabasemedicamentosDataSetLaboratorios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabasemedicamentosDataSetLaboratorios
        '
        Me.DatabasemedicamentosDataSetLaboratorios.DataSetName = "DatabasemedicamentosDataSetLaboratorios"
        Me.DatabasemedicamentosDataSetLaboratorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LaboratoriosBindingSource
        '
        Me.LaboratoriosBindingSource.DataMember = "Laboratorios"
        Me.LaboratoriosBindingSource.DataSource = Me.DatabasemedicamentosDataSetLaboratorios
        '
        'LaboratoriosTableAdapter
        '
        Me.LaboratoriosTableAdapter.ClearBeforeFill = True
        '
        'IdlabDataGridViewTextBoxColumn
        '
        Me.IdlabDataGridViewTextBoxColumn.DataPropertyName = "idlab"
        Me.IdlabDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdlabDataGridViewTextBoxColumn.Name = "IdlabDataGridViewTextBoxColumn"
        '
        'NombrelabDataGridViewTextBoxColumn
        '
        Me.NombrelabDataGridViewTextBoxColumn.DataPropertyName = "nombrelab"
        Me.NombrelabDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombrelabDataGridViewTextBoxColumn.Name = "NombrelabDataGridViewTextBoxColumn"
        '
        'SedelabDataGridViewTextBoxColumn
        '
        Me.SedelabDataGridViewTextBoxColumn.DataPropertyName = "sedelab"
        Me.SedelabDataGridViewTextBoxColumn.HeaderText = "Sede"
        Me.SedelabDataGridViewTextBoxColumn.Name = "SedelabDataGridViewTextBoxColumn"
        '
        'SucursalabDataGridViewTextBoxColumn
        '
        Me.SucursalabDataGridViewTextBoxColumn.DataPropertyName = "sucursalab"
        Me.SucursalabDataGridViewTextBoxColumn.HeaderText = "Sucursales"
        Me.SucursalabDataGridViewTextBoxColumn.Name = "SucursalabDataGridViewTextBoxColumn"
        '
        'DireccionlabDataGridViewTextBoxColumn
        '
        Me.DireccionlabDataGridViewTextBoxColumn.DataPropertyName = "direccionlab"
        Me.DireccionlabDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionlabDataGridViewTextBoxColumn.Name = "DireccionlabDataGridViewTextBoxColumn"
        '
        'NumlabDataGridViewTextBoxColumn
        '
        Me.NumlabDataGridViewTextBoxColumn.DataPropertyName = "numlab"
        Me.NumlabDataGridViewTextBoxColumn.HeaderText = "Número "
        Me.NumlabDataGridViewTextBoxColumn.Name = "NumlabDataGridViewTextBoxColumn"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 445)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form10"
        Me.Text = "Laboratorios/Empresas "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratoriosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasemedicamentosDataSetLaboratorios1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasemedicamentosDataSetLaboratorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratoriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DatabasemedicamentosDataSetLaboratorios As DatabasemedicamentosDataSetLaboratorios
    Friend WithEvents LaboratoriosBindingSource As BindingSource
    Friend WithEvents LaboratoriosTableAdapter As DatabasemedicamentosDataSetLaboratoriosTableAdapters.LaboratoriosTableAdapter
    Friend WithEvents DatabasemedicamentosDataSetLaboratorios1 As DatabasemedicamentosDataSetLaboratorios
    Friend WithEvents LaboratoriosBindingSource1 As BindingSource
    Friend WithEvents IdlabDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombrelabDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SedelabDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SucursalabDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionlabDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumlabDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
