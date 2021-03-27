<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmcontac
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ContactosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabasemedicamentosDataSetContactos = New Sistema_Inventario.DatabasemedicamentosDataSetContactos()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ContactosTableAdapter = New Sistema_Inventario.DatabasemedicamentosDataSetContactosTableAdapters.ContactosTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ContactosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasemedicamentosDataSetContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'ReportViewer1
        '
        ReportDataSource1.Name = "Datacontactos"
        ReportDataSource1.Value = Me.ContactosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Inventario.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-5, 127)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1600, 800)
        Me.ReportViewer1.TabIndex = 0
        '
        'ContactosTableAdapter
        '
        Me.ContactosTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fecha2)
        Me.GroupBox1.Controls.Add(Me.fecha1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1455, 100)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'fecha2
        '
        Me.fecha2.Location = New System.Drawing.Point(674, 54)
        Me.fecha2.Name = "fecha2"
        Me.fecha2.Size = New System.Drawing.Size(264, 22)
        Me.fecha2.TabIndex = 14
        '
        'fecha1
        '
        Me.fecha1.Location = New System.Drawing.Point(341, 52)
        Me.fecha1.Name = "fecha1"
        Me.fecha1.Size = New System.Drawing.Size(264, 22)
        Me.fecha1.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(611, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(270, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Desde"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(63, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 22)
        Me.TextBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Titulo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1000, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fmcontac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1582, 753)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "fmcontac"
        Me.Text = "Contactos"
        CType(Me.ContactosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasemedicamentosDataSetContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ContactosBindingSource As BindingSource
    Friend WithEvents DatabasemedicamentosDataSetContactos As DatabasemedicamentosDataSetContactos
    Friend WithEvents ContactosTableAdapter As DatabasemedicamentosDataSetContactosTableAdapters.ContactosTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents fecha2 As DateTimePicker
    Friend WithEvents fecha1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
