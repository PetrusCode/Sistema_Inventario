<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmproductos
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
        Me.btnmodificaprod = New System.Windows.Forms.Button()
        Me.btnaddproduct = New System.Windows.Forms.Button()
        Me.btneliminaprod = New System.Windows.Forms.Button()
        Me.DataGridprod = New System.Windows.Forms.DataGridView()
        Me.CodigoprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciocproDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciovprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SitioproDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseproductosDataSet = New Sistema_Inventario.DatabaseproductosDataSet()
        Me.ProductosTableAdapter = New Sistema_Inventario.DatabaseproductosDataSetTableAdapters.ProductosTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtsitiopro = New System.Windows.Forms.TextBox()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.txtpreciventpro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtprecicompro = New System.Windows.Forms.TextBox()
        Me.txtcantprod = New System.Windows.Forms.TextBox()
        Me.txtprovepro = New System.Windows.Forms.TextBox()
        Me.txtnombreprod = New System.Windows.Forms.TextBox()
        Me.txtcodigoprod = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridprod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseproductosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnmodificaprod
        '
        Me.btnmodificaprod.BackColor = System.Drawing.Color.White
        Me.btnmodificaprod.BackgroundImage = Global.Sistema_Inventario.My.Resources.Resources.gyihj
        Me.btnmodificaprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnmodificaprod.Location = New System.Drawing.Point(964, 138)
        Me.btnmodificaprod.Name = "btnmodificaprod"
        Me.btnmodificaprod.Size = New System.Drawing.Size(99, 80)
        Me.btnmodificaprod.TabIndex = 2
        Me.btnmodificaprod.UseVisualStyleBackColor = False
        '
        'btnaddproduct
        '
        Me.btnaddproduct.BackColor = System.Drawing.Color.White
        Me.btnaddproduct.BackgroundImage = Global.Sistema_Inventario.My.Resources.Resources.dftugih1
        Me.btnaddproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnaddproduct.Location = New System.Drawing.Point(964, 28)
        Me.btnaddproduct.Name = "btnaddproduct"
        Me.btnaddproduct.Size = New System.Drawing.Size(99, 100)
        Me.btnaddproduct.TabIndex = 3
        Me.btnaddproduct.UseVisualStyleBackColor = False
        '
        'btneliminaprod
        '
        Me.btneliminaprod.BackColor = System.Drawing.Color.White
        Me.btneliminaprod.BackgroundImage = Global.Sistema_Inventario.My.Resources.Resources.add
        Me.btneliminaprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btneliminaprod.Location = New System.Drawing.Point(964, 238)
        Me.btneliminaprod.Name = "btneliminaprod"
        Me.btneliminaprod.Size = New System.Drawing.Size(99, 95)
        Me.btneliminaprod.TabIndex = 4
        Me.btneliminaprod.UseVisualStyleBackColor = False
        '
        'DataGridprod
        '
        Me.DataGridprod.AutoGenerateColumns = False
        Me.DataGridprod.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridprod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoprodDataGridViewTextBoxColumn, Me.NombreprodDataGridViewTextBoxColumn, Me.ProveedorDataGridViewTextBoxColumn, Me.CantidadprodDataGridViewTextBoxColumn, Me.PreciocproDataGridViewTextBoxColumn, Me.PreciovprodDataGridViewTextBoxColumn, Me.SitioproDataGridViewTextBoxColumn})
        Me.DataGridprod.DataSource = Me.ProductosBindingSource
        Me.DataGridprod.Location = New System.Drawing.Point(12, 390)
        Me.DataGridprod.Name = "DataGridprod"
        Me.DataGridprod.RowTemplate.Height = 24
        Me.DataGridprod.Size = New System.Drawing.Size(1162, 349)
        Me.DataGridprod.TabIndex = 5
        '
        'CodigoprodDataGridViewTextBoxColumn
        '
        Me.CodigoprodDataGridViewTextBoxColumn.DataPropertyName = "codigoprod"
        Me.CodigoprodDataGridViewTextBoxColumn.HeaderText = "Cidigo del Producto"
        Me.CodigoprodDataGridViewTextBoxColumn.Name = "CodigoprodDataGridViewTextBoxColumn"
        Me.CodigoprodDataGridViewTextBoxColumn.Width = 120
        '
        'NombreprodDataGridViewTextBoxColumn
        '
        Me.NombreprodDataGridViewTextBoxColumn.DataPropertyName = "nombreprod"
        Me.NombreprodDataGridViewTextBoxColumn.HeaderText = "Nombre del Producto"
        Me.NombreprodDataGridViewTextBoxColumn.Name = "NombreprodDataGridViewTextBoxColumn"
        Me.NombreprodDataGridViewTextBoxColumn.Width = 140
        '
        'ProveedorDataGridViewTextBoxColumn
        '
        Me.ProveedorDataGridViewTextBoxColumn.DataPropertyName = "proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.Name = "ProveedorDataGridViewTextBoxColumn"
        '
        'CantidadprodDataGridViewTextBoxColumn
        '
        Me.CantidadprodDataGridViewTextBoxColumn.DataPropertyName = "cantidadprod"
        Me.CantidadprodDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadprodDataGridViewTextBoxColumn.Name = "CantidadprodDataGridViewTextBoxColumn"
        '
        'PreciocproDataGridViewTextBoxColumn
        '
        Me.PreciocproDataGridViewTextBoxColumn.DataPropertyName = "preciocpro"
        Me.PreciocproDataGridViewTextBoxColumn.HeaderText = "Precio de Compra"
        Me.PreciocproDataGridViewTextBoxColumn.Name = "PreciocproDataGridViewTextBoxColumn"
        Me.PreciocproDataGridViewTextBoxColumn.Width = 120
        '
        'PreciovprodDataGridViewTextBoxColumn
        '
        Me.PreciovprodDataGridViewTextBoxColumn.DataPropertyName = "preciovprod"
        Me.PreciovprodDataGridViewTextBoxColumn.HeaderText = "Precio de Venta"
        Me.PreciovprodDataGridViewTextBoxColumn.Name = "PreciovprodDataGridViewTextBoxColumn"
        Me.PreciovprodDataGridViewTextBoxColumn.Width = 120
        '
        'SitioproDataGridViewTextBoxColumn
        '
        Me.SitioproDataGridViewTextBoxColumn.DataPropertyName = "sitiopro"
        Me.SitioproDataGridViewTextBoxColumn.HeaderText = "Sitio"
        Me.SitioproDataGridViewTextBoxColumn.Name = "SitioproDataGridViewTextBoxColumn"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.DatabaseproductosDataSet
        '
        'DatabaseproductosDataSet
        '
        Me.DatabaseproductosDataSet.DataSetName = "DatabaseproductosDataSet"
        Me.DatabaseproductosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Sistema_Inventario.My.Resources.Resources.produc
        Me.GroupBox1.Controls.Add(Me.txtsitiopro)
        Me.GroupBox1.Controls.Add(Me.btnborrar)
        Me.GroupBox1.Controls.Add(Me.txtpreciventpro)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtprecicompro)
        Me.GroupBox1.Controls.Add(Me.txtcantprod)
        Me.GroupBox1.Controls.Add(Me.txtprovepro)
        Me.GroupBox1.Controls.Add(Me.txtnombreprod)
        Me.GroupBox1.Controls.Add(Me.txtcodigoprod)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 343)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'txtsitiopro
        '
        Me.txtsitiopro.Location = New System.Drawing.Point(180, 303)
        Me.txtsitiopro.Name = "txtsitiopro"
        Me.txtsitiopro.Size = New System.Drawing.Size(143, 27)
        Me.txtsitiopro.TabIndex = 6
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(354, 48)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(98, 44)
        Me.btnborrar.TabIndex = 17
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'txtpreciventpro
        '
        Me.txtpreciventpro.Location = New System.Drawing.Point(206, 262)
        Me.txtpreciventpro.Name = "txtpreciventpro"
        Me.txtpreciventpro.Size = New System.Drawing.Size(143, 27)
        Me.txtpreciventpro.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(1, 262)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 27)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Precio de Venta"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(1, 219)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 27)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Precio de Compra"
        '
        'txtprecicompro
        '
        Me.txtprecicompro.Location = New System.Drawing.Point(206, 219)
        Me.txtprecicompro.Name = "txtprecicompro"
        Me.txtprecicompro.Size = New System.Drawing.Size(143, 27)
        Me.txtprecicompro.TabIndex = 12
        '
        'txtcantprod
        '
        Me.txtcantprod.Location = New System.Drawing.Point(172, 174)
        Me.txtcantprod.Name = "txtcantprod"
        Me.txtcantprod.Size = New System.Drawing.Size(143, 27)
        Me.txtcantprod.TabIndex = 11
        '
        'txtprovepro
        '
        Me.txtprovepro.Location = New System.Drawing.Point(172, 133)
        Me.txtprovepro.Name = "txtprovepro"
        Me.txtprovepro.Size = New System.Drawing.Size(143, 27)
        Me.txtprovepro.TabIndex = 10
        '
        'txtnombreprod
        '
        Me.txtnombreprod.Location = New System.Drawing.Point(172, 89)
        Me.txtnombreprod.Name = "txtnombreprod"
        Me.txtnombreprod.Size = New System.Drawing.Size(143, 27)
        Me.txtnombreprod.TabIndex = 9
        '
        'txtcodigoprod
        '
        Me.txtcodigoprod.Location = New System.Drawing.Point(172, 48)
        Me.txtcodigoprod.Name = "txtcodigoprod"
        Me.txtcodigoprod.Size = New System.Drawing.Size(143, 27)
        Me.txtcodigoprod.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(1, 298)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 27)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sitio Estantería"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(1, 48)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(1, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Proveedor"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(1, 174)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 27)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(1, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'fmproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_Inventario.My.Resources.Resources.produc1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1378, 794)
        Me.Controls.Add(Me.DataGridprod)
        Me.Controls.Add(Me.btneliminaprod)
        Me.Controls.Add(Me.btnaddproduct)
        Me.Controls.Add(Me.btnmodificaprod)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "fmproductos"
        Me.Text = "Gestion de Productos"
        CType(Me.DataGridprod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseproductosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtprecicompro As TextBox
    Friend WithEvents txtcantprod As TextBox
    Friend WithEvents txtprovepro As TextBox
    Friend WithEvents txtnombreprod As TextBox
    Friend WithEvents txtcodigoprod As TextBox
    Friend WithEvents txtpreciventpro As TextBox
    Friend WithEvents btnborrar As Button
    Friend WithEvents btnmodificaprod As Button
    Friend WithEvents btnaddproduct As Button
    Friend WithEvents btneliminaprod As Button
    Friend WithEvents DataGridprod As DataGridView
    Friend WithEvents DatabaseproductosDataSet As DatabaseproductosDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As DatabaseproductosDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents txtsitiopro As TextBox
    Friend WithEvents CodigoprodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreprodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadprodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciocproDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciovprodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SitioproDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
