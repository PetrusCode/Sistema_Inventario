<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblusuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblhora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Toolstripstatuslabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblfecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnusuario = New System.Windows.Forms.Button()
        Me.btninventario = New System.Windows.Forms.Button()
        Me.btnlab = New System.Windows.Forms.Button()
        Me.btncontact = New System.Windows.Forms.Button()
        Me.btnproductos = New System.Windows.Forms.Button()
        Me.btnfacturar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblusuario, Me.ToolStripStatusLabel3, Me.lblhora, Me.Toolstripstatuslabel, Me.lblfecha})
        Me.StatusStrip1.Location = New System.Drawing.Point(1000, -472)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(0, 25)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(71, 20)
        Me.ToolStripStatusLabel1.Text = "USUARIO"
        '
        'lblusuario
        '
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(59, 20)
        Me.lblusuario.Text = "Usuario"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripStatusLabel3.Text = "HORA"
        '
        'lblhora
        '
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(153, 20)
        Me.lblhora.Text = "ToolStripStatusLabel4"
        '
        'Toolstripstatuslabel
        '
        Me.Toolstripstatuslabel.Name = "Toolstripstatuslabel"
        Me.Toolstripstatuslabel.Size = New System.Drawing.Size(54, 20)
        Me.Toolstripstatuslabel.Text = "FECHA"
        '
        'lblfecha
        '
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(153, 20)
        Me.lblfecha.Text = "ToolStripStatusLabel6"
        '
        'btnusuario
        '
        Me.btnusuario.BackColor = System.Drawing.Color.Transparent
        Me.btnusuario.BackgroundImage = Global.Sistema_Inventario.My.Resources.Resources._123232
        Me.btnusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnusuario.ForeColor = System.Drawing.Color.Maroon
        Me.btnusuario.Location = New System.Drawing.Point(0, -1)
        Me.btnusuario.Name = "btnusuario"
        Me.btnusuario.Size = New System.Drawing.Size(153, 90)
        Me.btnusuario.TabIndex = 4
        Me.btnusuario.Text = "Usuarios"
        Me.btnusuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnusuario.UseVisualStyleBackColor = False
        '
        'btninventario
        '
        Me.btninventario.BackColor = System.Drawing.Color.Transparent
        Me.btninventario.BackgroundImage = Global.Sistema_Inventario.My.Resources.Resources._231334df1
        Me.btninventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btninventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninventario.ForeColor = System.Drawing.Color.Yellow
        Me.btninventario.Location = New System.Drawing.Point(296, -1)
        Me.btninventario.Name = "btninventario"
        Me.btninventario.Size = New System.Drawing.Size(153, 90)
        Me.btninventario.TabIndex = 5
        Me.btninventario.Text = "Medicamentos"
        Me.btninventario.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btninventario.UseVisualStyleBackColor = False
        '
        'btnlab
        '
        Me.btnlab.BackColor = System.Drawing.Color.Transparent
        Me.btnlab.BackgroundImage = Global.Sistema_Inventario.My.Resources.Resources.hrhtyy
        Me.btnlab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnlab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlab.ForeColor = System.Drawing.Color.Black
        Me.btnlab.Location = New System.Drawing.Point(446, -1)
        Me.btnlab.Name = "btnlab"
        Me.btnlab.Size = New System.Drawing.Size(153, 90)
        Me.btnlab.TabIndex = 6
        Me.btnlab.Text = "Laboratorios"
        Me.btnlab.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnlab.UseVisualStyleBackColor = False
        '
        'btncontact
        '
        Me.btncontact.BackColor = System.Drawing.Color.White
        Me.btncontact.BackgroundImage = Global.Sistema_Inventario.My.Resources.Resources.gtgtty1
        Me.btncontact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncontact.ForeColor = System.Drawing.Color.Maroon
        Me.btncontact.Location = New System.Drawing.Point(744, -1)
        Me.btncontact.Name = "btncontact"
        Me.btncontact.Size = New System.Drawing.Size(153, 90)
        Me.btncontact.TabIndex = 7
        Me.btncontact.Text = "Contactos"
        Me.btncontact.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncontact.UseVisualStyleBackColor = False
        '
        'btnproductos
        '
        Me.btnproductos.BackColor = System.Drawing.Color.Transparent
        Me.btnproductos.BackgroundImage = Global.Sistema_Inventario.My.Resources.Resources.benbrnrtrjh
        Me.btnproductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnproductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproductos.ForeColor = System.Drawing.Color.Yellow
        Me.btnproductos.Location = New System.Drawing.Point(596, -1)
        Me.btnproductos.Name = "btnproductos"
        Me.btnproductos.Size = New System.Drawing.Size(153, 90)
        Me.btnproductos.TabIndex = 10
        Me.btnproductos.Text = "Productos"
        Me.btnproductos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnproductos.UseVisualStyleBackColor = False
        '
        'btnfacturar
        '
        Me.btnfacturar.BackColor = System.Drawing.Color.Transparent
        Me.btnfacturar.BackgroundImage = Global.Sistema_Inventario.My.Resources.Resources.rr332r1
        Me.btnfacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnfacturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfacturar.ForeColor = System.Drawing.Color.Maroon
        Me.btnfacturar.Location = New System.Drawing.Point(148, -1)
        Me.btnfacturar.Name = "btnfacturar"
        Me.btnfacturar.Size = New System.Drawing.Size(153, 90)
        Me.btnfacturar.TabIndex = 11
        Me.btnfacturar.Text = "Factura"
        Me.btnfacturar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnfacturar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema_Inventario.My.Resources.Resources.y53yy5y5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(882, 553)
        Me.Controls.Add(Me.btnfacturar)
        Me.Controls.Add(Me.btnproductos)
        Me.Controls.Add(Me.btncontact)
        Me.Controls.Add(Me.btnlab)
        Me.Controls.Add(Me.btninventario)
        Me.Controls.Add(Me.btnusuario)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximumSize = New System.Drawing.Size(900, 600)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "Principal"
        Me.Padding = New System.Windows.Forms.Padding(1000)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro Farmaceútico Segura"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblusuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblhora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Toolstripstatuslabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblfecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnusuario As System.Windows.Forms.Button
    Friend WithEvents btninventario As Button
    Friend WithEvents btnlab As Button
    Friend WithEvents btncontact As Button
    Friend WithEvents btnproductos As Button
    Friend WithEvents btnfacturar As Button
    Friend WithEvents Timer1 As Timer
End Class
