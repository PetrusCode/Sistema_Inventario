'para conectar la base de datos con SQL
'Imports System.Data
'Imports System.Data.SqlClient
'Imports System.Data.SqlClient.SqlConnection
'para conectatar base de datos de access
'Imports system.data
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbCommand
Public Class fminventario
    'Public conexion As New SqlConnection
    Public comandoAccess As New OleDbCommand
    Public adaptadores As OleDbDataAdapter
    Public lectura As OleDbDataReader
    Public consulta As String

    ' Public commandoSQL As New SqlCommand
    'Public adaptador As New SqlDataAdapter
    ' Public lector As SqlDataReader
    Public SQL As String
    Sub New()
        Try
            cn.Open()
            MsgBox("Conectado")
        Catch ex As Exception
            MsgBox("Error al conectarse a: " + ex.ToString)
        End Try
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewmedicamentos.CellContentClick

    End Sub

    Private Sub fminventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasemedicamentosDataSetMED.Medicamentos' table. You can move, or remove it, as needed.
        Me.MedicamentosTableAdapter.Fill(Me.DatabasemedicamentosDataSetMED.Medicamentos)
        CargaMedicamento()


        If (txtnombremed.Text = "") Or (txtcodigo.Text = "") Then
            btnaddmed.Capture = False
        End If
        With cbopresenta
            .Items.Add("Tabletas")
            .Items.Add("Caja")
            .Items.Add("Ampollas")
            .Items.Add("Inyectable")
            .Items.Add("Pomada")
            .Items.Add("Liquido")
            .Items.Add("Unguento")
            .Items.Add("Locion")
            .Items.Add("Spray")
            .Items.Add("Gotas")
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = 0
        End With
        With cbotipo
            .Items.Add("Generico")
            .Items.Add("Controlado")
        End With
        With cbounidad
            .Items.Add("G")
            .Items.Add("Mg")
            .Items.Add("Ml")
        End With

        'With cbovencimientodia
        '    .Items.Add("1")
        '    .Items.Add("2")
        '    .Items.Add("3")
        '    .Items.Add("4")
        '    .Items.Add("Pomada")
        '    .Items.Add("Liquido")
        '    .Items.Add("Unguento")
        '    .Items.Add("Locion")
        '    .Items.Add("Spray")
        '    .Items.Add("Gotas")
        '    .DropDownStyle = ComboBoxStyle.DropDownList
        '    .SelectedIndex = 0
        'End With
        'With cbovencimientomes
        '    .Items.Add("1")
        '    .Items.Add("2")
        '    .Items.Add("3")
        '    .Items.Add("4")
        '    .Items.Add("Pomada")
        '    .Items.Add("Liquido")
        '    .Items.Add("Unguento")
        '    .Items.Add("Locion")
        '    .Items.Add("Spray")
        '    .Items.Add("Gotas")
        '    .DropDownStyle = ComboBoxStyle.DropDownList
        '    .SelectedIndex = 0
        'End With
        'With cbovencimientoaño
        '    .Items.Add("1")
        '    .Items.Add("2")
        '    .Items.Add("3")
        '    .Items.Add("4")
        '    .Items.Add("Pomada")
        '    .Items.Add("Liquido")
        '    .Items.Add("Unguento")
        '    .Items.Add("Locion")
        '    .Items.Add("Spray")
        '    .Items.Add("Gotas")
        '    .DropDownStyle = ComboBoxStyle.DropDownList
        '    .SelectedIndex = 0
        'End With


    End Sub

    Private Sub CargaMedicamento()
        'TODO: This line of code loads data into the 'DatabasemedicamentosDataSet.Medicamentos' table. You can move, or remove it, as needed.
        Me.MedicamentosTableAdapter.Fill(Me.DatabasemedicamentosDataSetMED.Medicamentos)
    End Sub

    Private Sub btnaddmed_Click(sender As Object, e As EventArgs) Handles btnaddmed.Click
        If txtnombremed.Text = "" Or txtcodigo.Text = "" Or cbotipo.Text = "" Or txtlaborato.Text = "" Or txtcantidad.Text = "" Or txtprecivent.Text = "" Or txtprecicompr.Text = "" Or txtdosis.Text = "" Or cbounidad.Text = "" Or txtsitio.Text = "" Then
            MsgBox("Rellene los campos en blanco para continuar", MsgBoxStyle.Information, "atencion")
            Exit Sub

        Else

            If IsNotDuplicate(txtcodigo.Text) Then



                Dim con As New OleDbConnection

                Dim cmd As New OleDb.OleDbCommand


                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PetrusPC\Documents\Databasemedicamentos.mdb"
                con.Open()
                'If Me.txtcodigo.Text = "" Then
                '    MsgBox("ingrese el codigo del cliente por favor", MsgBoxStyle.Information, "atencion")
                '    Me.txtcodigo.Focus()
                'End If

                SQL = "INSERT INTO  Medicamentos (codigomed, nombremed, presentacion, tipo, laboratorio, cantidad, precioventa, preciocompra, dosis, unidad, sitio, vencimiento) 
               VALUES ('" & txtcodigo.Text & "','" & txtnombremed.Text & "','" & cbopresenta.Text & "','" & cbotipo.Text & "','" & txtlaborato.Text & "','" & txtcantidad.Text & "','" & txtprecivent.Text & "','" & txtprecicompr.Text & "','" & txtdosis.Text & "', '" & cbounidad.Text & "', '" & txtsitio.Text & "', '" & DateTimePicker1.Value & "')"
                cmd = New OleDb.OleDbCommand(SQL, con)

                cmd.ExecuteNonQuery()
                con.Close()
                CargaMedicamento()

                MsgBox("saved")

                txtcodigo.Text = ""
                txtnombremed.Text = ""
                cbopresenta.Text = ""
                cbotipo.Text = ""
                txtlaborato.Text = ""
                txtcantidad.Text = ""
                txtprecivent.Text = ""
                txtprecicompr.Text = ""
                txtdosis.Text = ""
                cbounidad.Text = ""
                txtsitio.Text = ""






                Try
                    MsgBox("registro guardado correcta mente", MsgBoxStyle.Information, "Guardar")

                Catch ex As Exception
                    If ex.ToString.Contains("clave duplicada") Then
                        MsgBox("este codigo de cliente esta registrado en la base de datos...verifique", MsgBoxStyle.Information, " atention ")
                    Else
                        MsgBox(ex.ToString)

                    End If

                End Try
            Else
                MsgBox("este codigo de medicamento esta registrado en la base de datos...verifique", MsgBoxStyle.Information, " atention ")
            End If
        End If
    End Sub

    Private Function IsNotDuplicate(codigo As String) As Boolean
        Dim con As New OleDbConnection

        Dim cmd As New OleDbCommand

        Dim rd As OleDbDataReader


        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PetrusPC\Documents\Databasemedicamentos.mdb"
        con.Open()


        SQL = "Select count(*) from Medicamentos where codigomed = " + codigo + ""
        cmd = New OleDbCommand(SQL, con)

        rd = cmd.ExecuteReader()

        While (rd.Read())
            If Convert.ToInt16(rd(0)) > 0 Then
                con.Close()
                Return False
            End If
        End While
        con.Close()
        Return True
    End Function

    Private Sub MedicamentosBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        txtcodigo.Clear()
        txtnombremed.Clear()
        txtlaborato.Clear()
        txtcantidad.Clear()
        txtprecivent.Clear()
        txtprecicompr.Clear()
        txtdosis.Clear()
        cbounidad.Text = ""
        txtsitio.Clear()


    End Sub

    Private Sub btneliminar_Click_1(sender As Object, e As EventArgs) Handles btneliminar.Click
        If txtnombremed.Text = "" Or txtcodigo.Text = "" Or cbotipo.Text = "" Or txtlaborato.Text = "" Or txtcantidad.Text = "" Or txtprecivent.Text = "" Or txtprecicompr.Text = "" Or txtdosis.Text = "" Or cbounidad.Text = "" Or txtsitio.Text = "" Then
            MsgBox("Rellene los campos en blanco para continuar", MsgBoxStyle.Information, "atencion")
        End If

        Dim cmd As New OleDb.OleDbCommand

        'cn.Open()


        SQL = String.Format("Delete from medicamentos where codigomed = {0}", txtcodigo.Text)
        cmd = New OleDb.OleDbCommand(SQL, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        CargaMedicamento()


        MsgBox("registro eliminado correcta mente", MsgBoxStyle.Information, "Eliminar")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnmodificam.Click
        If txtnombremed.Text = "" Or txtcodigo.Text = "" Or cbotipo.Text = "" Or txtlaborato.Text = "" Or txtcantidad.Text = "" Or txtprecivent.Text = "" Or txtprecicompr.Text = "" Or txtdosis.Text = "" Or cbounidad.Text = "" Or txtsitio.Text = "" Then
            MsgBox("Rellene los campos en blanco para continuar", MsgBoxStyle.Information, "atencion")
            Exit Sub

        Else
            Dim cmd As New OleDbCommand("update Medicamentos set codigomed=@codigomed,nombremed=@nombremed,presentacion=@presentacion,tipo=@tipo,laboratorio=@laboratorio,cantidad=@cantidad,precioventa=@precioventa,preciocompra=@preciocompra,dosis=@dosis,unidad=@unidad,sitio=@sitio where codigomed=@codigomed", cn)


            cmd.Parameters.Add(New OleDbParameter("@codigomed", Convert.ToInt32(txtcodigo.Text)))
            cmd.Parameters.Add(New OleDbParameter("@nombremed", txtnombremed.Text))
            cmd.Parameters.Add(New OleDbParameter("@presentacion", cbopresenta.Text))
            cmd.Parameters.Add(New OleDbParameter("@tipo", cbotipo.Text))
            cmd.Parameters.Add(New OleDbParameter("@laboratorio", txtlaborato.Text))
            cmd.Parameters.Add(New OleDbParameter("@cantidad", Convert.ToInt32(txtcantidad.Text)))
            cmd.Parameters.Add(New OleDbParameter("@precioventa", Convert.ToInt32(txtprecivent.Text)))
            cmd.Parameters.Add(New OleDbParameter("@preciocompra", Convert.ToInt32(txtprecicompr.Text)))
            cmd.Parameters.Add(New OleDbParameter("@dosis", Convert.ToInt32(txtdosis.Text)))
            cmd.Parameters.Add(New OleDbParameter("@unidad", cbounidad.Text))
            cmd.Parameters.Add(New OleDbParameter("@sitio", txtsitio.Text))

            cmd.ExecuteNonQuery()

            cn.Close()
            CargaMedicamento()
            limpiar()
            listado()
            MsgBox("registro actualizado correcta mente", MsgBoxStyle.Information, "Actualizar")





            ''Dim codigo As Integer
            ''Dim nombre As String
            ''Dim presentacion As String
            ''Dim tipo As String
            ''Dim laboratorio As String
            ''Dim cantidad As String
            'Dim precivent As String
            '    Dim precicompr As String

            '    Dim Sitio As String

            'codigo = Me.txtcodigo.TabIndex
            'nombre = Me.txtnombremed.Text
            '    presentacion = Me.cbopresenta.Text
            '    tipo = Me.cbotipo.Text
            '    laboratorio = Me.txtlaborato.Text
            'cantidad = Me.txtcantidad.TabIndex
            'precivent = Me.txtprecivent.TabIndex
            'precicompr = Me.txtprecicompr.TabIndex
            'Sitio = Me.txtsitio.Text








        End If

    End Sub
    Private Sub limpiar()


        txtcodigo.Text = ""
        txtnombremed.Text = ""

    End Sub
    Private Sub listado()

        Dim sql As String = "select * from Medicamentos"
        Dim damedicamento As New OleDbDataAdapter(sql, cn)
        Dim dtmedicamento As New DataTable
        damedicamento.Fill(dtmedicamento)
        DataGridViewmedicamentos.DataSource = dtmedicamento
        cn.Close()

    End Sub

    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged

    End Sub

    Private Sub txtcodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtprecivent_TextChanged(sender As Object, e As EventArgs) Handles txtprecivent.TextChanged

    End Sub

    Private Sub txtprecivent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecivent.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtprecicompr_TextChanged(sender As Object, e As EventArgs) Handles txtprecicompr.TextChanged

    End Sub

    Private Sub txtprecicompr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecicompr.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtnombremed_TextChanged(sender As Object, e As EventArgs) Handles txtnombremed.TextChanged

    End Sub

    Private Sub txtnombremed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombremed.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) Then

            MessageBox.Show("Solo se permite introducir letras", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtlaborato_TextChanged(sender As Object, e As EventArgs) Handles txtlaborato.TextChanged

    End Sub

    Private Sub txtlaborato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlaborato.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) Then

            MessageBox.Show("Solo se permite introducir letras", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnaddmed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnaddmed.KeyPress


    End Sub

    Private Sub btnaddmed_DoubleClick(sender As Object, e As EventArgs) Handles btnaddmed.DoubleClick

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbounidad.SelectedIndexChanged

    End Sub

    Private Sub txtsitio_TextChanged(sender As Object, e As EventArgs) Handles txtsitio.TextChanged

    End Sub

    Private Sub txtdosis_TextChanged(sender As Object, e As EventArgs) Handles txtdosis.TextChanged

    End Sub

    Private Sub txtdosis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdosis.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        If ComprasToolStripMenuItem.CanSelect = True Then
            Me.LayoutMdi(MdiLayout.TileVertical)
            fmcompras.Show()
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewmedicamentos.CellDoubleClick

        DataGridViewmedicamentos.Rows(e.RowIndex).Selected = True

        With DataGridViewmedicamentos

            Dim codigo As String

            Dim nombre As String
            Dim presentacion As String
            Dim tipo As String
            Dim laboratorio As String
            Dim cantidad As String
            Dim venta As String
            Dim compra As String
            Dim dosis As String
            Dim unidad As String
            Dim sitio As String
            Dim fecha As String



            codigo = DataGridViewmedicamentos.Rows(e.RowIndex).Cells(0).Value.ToString()
            nombre = DataGridViewmedicamentos.Rows(e.RowIndex).Cells(1).Value.ToString()
            presentacion = DataGridViewmedicamentos.Rows(e.RowIndex).Cells(2).Value.ToString()
            tipo = DataGridViewmedicamentos.Rows(e.RowIndex).Cells(3).Value.ToString()
            laboratorio = DataGridViewmedicamentos.Rows(e.RowIndex).Cells(4).Value.ToString()
            cantidad = DataGridViewmedicamentos.Rows(e.RowIndex).Cells(5).Value.ToString()
            venta = DataGridViewmedicamentos.Rows(e.RowIndex).Cells(6).Value.ToString()
            compra = DataGridViewmedicamentos.Rows(e.RowIndex).Cells(7).Value.ToString()
            dosis = DataGridViewmedicamentos.Rows(e.RowIndex).Cells(8).Value.ToString()
            unidad = DataGridViewmedicamentos.Rows(e.RowIndex).Cells(9).Value.ToString()
            sitio = DataGridViewmedicamentos.Rows(e.RowIndex).Cells(10).Value.ToString()
            fecha = DataGridViewmedicamentos.Rows(e.RowIndex).Cells(11).Value.ToString()


            txtcodigo.Text = codigo.ToString

            txtnombremed.Text = nombre.ToString
            cbopresenta.Text = presentacion.ToString
            cbotipo.Text = tipo.ToString
            txtlaborato.Text = laboratorio.ToString
            txtcantidad.Text = cantidad.ToString
            txtprecivent.Text = venta.ToString
            txtprecicompr.Text = compra.ToString
            txtdosis.Text = dosis.ToString
            cbounidad.Text = unidad.ToString
            txtsitio.Text = sitio.ToString
            DateTimePicker1.Text = fecha.ToString


        End With
    End Sub

    Private Sub InformesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles infomenu1.Click

    End Sub
End Class