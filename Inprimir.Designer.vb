<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inprimir
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseproductosDataSetFacturas = New Sistema_Inventario.DatabaseproductosDataSetFacturas()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FacturaTableAdapter = New Sistema_Inventario.DatabaseproductosDataSetFacturasTableAdapters.FacturaTableAdapter()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseproductosDataSetFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.DatabaseproductosDataSetFacturas
        '
        'DatabaseproductosDataSetFacturas
        '
        Me.DatabaseproductosDataSetFacturas.DataSetName = "DatabaseproductosDataSetFacturas"
        Me.DatabaseproductosDataSetFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Facturasclient"
        ReportDataSource1.Value = Me.FacturaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Inventario.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 120)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1582, 794)
        Me.ReportViewer1.TabIndex = 0
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'Inprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1582, 753)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Inprimir"
        Me.Text = "Inprimir"
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseproductosDataSetFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents DatabaseproductosDataSetFacturas As DatabaseproductosDataSetFacturas
    Friend WithEvents FacturaTableAdapter As DatabaseproductosDataSetFacturasTableAdapters.FacturaTableAdapter
End Class
