<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LaboratoriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabasemedicamentosDataSetLaboratorios = New Sistema_Inventario.DatabasemedicamentosDataSetLaboratorios()
        Me.DatabasemedicamentosDataSet1 = New Sistema_Inventario.DatabasemedicamentosDataSet1()
        Me.DatabasemedicamentosDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicamentosTableAdapter = New Sistema_Inventario.DatabasemedicamentosDataSet1TableAdapters.MedicamentosTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaboratoriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasemedicamentosDataSetLaboratorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasemedicamentosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasemedicamentosDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1063, 432)
        Me.DataGridView1.TabIndex = 0
        '
        'LaboratoriosBindingSource
        '
        Me.LaboratoriosBindingSource.DataMember = "Laboratorios"
        Me.LaboratoriosBindingSource.DataSource = Me.DatabasemedicamentosDataSetLaboratorios
        '
        'DatabasemedicamentosDataSetLaboratorios
        '
        Me.DatabasemedicamentosDataSetLaboratorios.DataSetName = "DatabasemedicamentosDataSetLaboratorios"
        Me.DatabasemedicamentosDataSetLaboratorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabasemedicamentosDataSet1
        '
        Me.DatabasemedicamentosDataSet1.DataSetName = "DatabasemedicamentosDataSet1"
        Me.DatabasemedicamentosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabasemedicamentosDataSet1BindingSource
        '
        Me.DatabasemedicamentosDataSet1BindingSource.DataSource = Me.DatabasemedicamentosDataSet1
        Me.DatabasemedicamentosDataSet1BindingSource.Position = 0
        '
        'MedicamentosBindingSource
        '
        Me.MedicamentosBindingSource.DataMember = "Medicamentos"
        Me.MedicamentosBindingSource.DataSource = Me.DatabasemedicamentosDataSet1
        '
        'MedicamentosTableAdapter
        '
        Me.MedicamentosTableAdapter.ClearBeforeFill = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 432)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form10"
        Me.Text = "Form10"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaboratoriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasemedicamentosDataSetLaboratorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasemedicamentosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasemedicamentosDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DatabasemedicamentosDataSet1BindingSource As BindingSource
    Friend WithEvents DatabasemedicamentosDataSet1 As DatabasemedicamentosDataSet1
    Friend WithEvents MedicamentosBindingSource As BindingSource
    Friend WithEvents MedicamentosTableAdapter As DatabasemedicamentosDataSet1TableAdapters.MedicamentosTableAdapter
    Friend WithEvents DatabasemedicamentosDataSetLaboratorios As DatabasemedicamentosDataSetLaboratorios
    Friend WithEvents LaboratoriosBindingSource As BindingSource
End Class

Friend Class DatabasemedicamentosDataSetLaboratorios
    Public Sub New()
    End Sub
End Class
