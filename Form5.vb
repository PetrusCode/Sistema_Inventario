Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbCommand
Public Class fmproductos
    'Public conexion As New SqlConnection
    Public comandoAccess As New OleDbCommand
    Public adaptadores As OleDbDataAdapter
    Public lectura As OleDbDataReader
    Public consulta As String

    ' Public commandoSQL As New SqlCommand
    'Public adaptador As New SqlDataAdapter
    ' Public lector As SqlDataReader
    Public SQL As String

    Private Sub fmproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaRegistro()

    End Sub

    Private Sub CargaRegistro()
        'TODO: This line of code loads data into the 'DatabaseproductosDataSet.Productos' table. You can move, or remove it, as needed.
        Me.ProductosTableAdapter.Fill(Me.DatabaseproductosDataSet.Productos)
    End Sub

    Private Sub btnaddproduct_Click(sender As Object, e As EventArgs) Handles btnaddproduct.Click
        If txtcodigoprod.Text = "" Or txtnombreprod.Text = "" Or txtprovepro.Text = "" Or txtcantprod.Text = "" Or txtprecicompro.Text = "" Or txtpreciventpro.Text = "" Or txtsitiopro.Text = "" Then
            MsgBox("Rellene los campos en blanco para continuar", MsgBoxStyle.Information, "atencion")
            Exit Sub
        Else

            If IsNotDuplicate(txtcodigoprod.Text) Then



                Dim cmd As New OleDb.OleDbCommand




                cn2.Open()

                SQL = "INSERT INTO  Productos (codigoprod, nombreprod, proveedor, cantidadprod, preciocpro, preciovprod, sitiopro ) 
               VALUES ('" & txtcodigoprod.Text & "','" & txtnombreprod.Text & "','" & txtprovepro.Text & "','" & txtcantprod.Text & "','" & txtprecicompro.Text & "','" & txtpreciventpro.Text & "','" & txtsitiopro.Text & "' )"
                cmd = New OleDb.OleDbCommand(SQL, cn2)
                cmd.ExecuteNonQuery()
                MsgBox("saved")


                cn2.Close()
                CargaRegistro()

                limpiar()


                'Dim codigo As Integer
                'Dim nombre As String
                'Dim proveedor As String
                'Dim cantidad As Integer
                'Dim preciocompra As Integer
                'Dim precioventa As Integer
                'Dim sitio As String



                'codigo = Me.txtcantprod.TabIndex
                'nombre = Me.txtcodigoprod.Text
                'proveedor = Me.txtprovepro.Text
                'cantidad = Me.txtnombreprod.TabIndex
                'preciocompra = Me.txtprecicompro.TabIndex
                'precioventa = Me.txtpreciventpro.TabIndex
                'sitio = Me.txtsitiopro.Text




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
                MsgBox("este codigo de producto esta registrado en la base de datos...verifique", MsgBoxStyle.Information, " atention ")
            End If
        End If

    End Sub

    Private Function IsNotDuplicate(codigo As String) As Boolean
        Dim con As New OleDbConnection

        Dim cmd As New OleDbCommand

        Dim rd As OleDbDataReader


        con.ConnectionString = " Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PetrusPC\Documents\Databaseproductos.mdb"
        con.Open()


        SQL = "Select count(*) from Productos where codigoprod = " + codigo + ""
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
    Private Sub limpiar()


        txtcodigoprod.Text = ""
        txtnombreprod.Text = ""
        txtprovepro.Text = ""
        txtcantprod.Text = ""
        txtprecicompro.Text = ""
        txtpreciventpro.Text = ""
        txtsitiopro.Text = ""
    End Sub

    Private Sub txtcodigoprod_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoprod.TextChanged

    End Sub

    Private Sub txtcodigoprod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigoprod.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtcantprod_TextChanged(sender As Object, e As EventArgs) Handles txtcantprod.TextChanged

    End Sub

    Private Sub txtcantprod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantprod.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtprecicompro_TextChanged(sender As Object, e As EventArgs) Handles txtprecicompro.TextChanged

    End Sub

    Private Sub txtprecicompro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecicompro.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtpreciventpro_TextChanged(sender As Object, e As EventArgs) Handles txtpreciventpro.TextChanged

    End Sub

    Private Sub txtpreciventpro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpreciventpro.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtnombreprod_TextChanged(sender As Object, e As EventArgs) Handles txtnombreprod.TextChanged

    End Sub

    Private Sub txtnombreprod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreprod.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) Then

            MessageBox.Show("Solo se permite introducir letras", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtprovepro_TextChanged(sender As Object, e As EventArgs) Handles txtprovepro.TextChanged

    End Sub

    Private Sub txtprovepro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprovepro.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) Then

            MessageBox.Show("Solo se permite introducir letras", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsitiopro_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsitiopro_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btneliminaprod.Click
        If txtcodigoprod.Text = "" Or txtnombreprod.Text = "" Or txtprovepro.Text = "" Or txtcantprod.Text = "" Or txtprecicompro.Text = "" Or txtpreciventpro.Text = "" Or txtsitiopro.Text = "" Then
            MsgBox("Rellene los campos en blanco para continuar", MsgBoxStyle.Information, "atencion")
        End If

        Dim cmd As New OleDb.OleDbCommand

            cn2.Open()


            SQL = String.Format("Delete from Productos where codigoprod = {0}", txtcodigoprod.Text)
            cmd = New OleDb.OleDbCommand(SQL, cn2)
            cmd.ExecuteNonQuery()
            cn2.Close()
            CargaRegistro()
        MsgBox("registro eliminado correcta mente", MsgBoxStyle.Information, "Eliminar")
    End Sub

    Private Sub txtsitiopro_TextChanged_1(sender As Object, e As EventArgs) Handles txtsitiopro.TextChanged
    End Sub
    Private Sub listado()
        'cn2.Open()
        Dim sql As String = "select * from Productos"
        Dim daproducto As New OleDbDataAdapter(sql, cn2)
        Dim dtproducto As New DataTable
        daproducto.Fill(dtproducto)
        DataGridprod.DataSource = dtproducto
        cn2.Close()


    End Sub

    Private Sub btnmodificaprod_Click(sender As Object, e As EventArgs) Handles btnmodificaprod.Click
        If txtcodigoprod.Text = "" Or txtnombreprod.Text = "" Or txtprovepro.Text = "" Or txtcantprod.Text = "" Or txtprecicompro.Text = "" Or txtpreciventpro.Text = "" Or txtsitiopro.Text = "" Then
            MsgBox("Rellene los campos en blanco para continuar", MsgBoxStyle.Information, "atencion")
            Exit Sub
        Else
            Dim cmd As New OleDbCommand("update Productos set codigoprod=@codigoprod,nombreprod=@nombreprod,proveedor=@proveedor,cantidadprod=@cantidadprod,preciocpro=@preciocpro,preciovprod=@preciovprod,sitiopro=@sitiopro where codigoprod=@codigoprod", cn2)
        cn.ConnectionString = (" Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PetrusPC\Documents\Databaseproductos.mdb")

        cmd.Parameters.Add(New OleDbParameter("@codigoprod", Convert.ToInt32(txtcodigoprod.Text)))
        cmd.Parameters.Add(New OleDbParameter("@nombreprod", txtnombreprod.Text))

        cmd.Parameters.Add(New OleDbParameter("@proveedor", txtprovepro.Text))
        cmd.Parameters.Add(New OleDbParameter("@cantidadprod", Convert.ToInt32(txtcantprod.Text)))
        cmd.Parameters.Add(New OleDbParameter("@preciocpro", Convert.ToInt32(txtprecicompro.Text)))
        cmd.Parameters.Add(New OleDbParameter("@preciovprod", Convert.ToInt32(txtpreciventpro.Text)))
        cmd.Parameters.Add(New OleDbParameter("@sitiopro", txtsitiopro.Text))








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

        cn2.Open()

        cmd.ExecuteNonQuery()

        cn2.Close()
        CargaRegistro()
        limpiar()
            listado()
            MsgBox("registro actualizado correcta mente", MsgBoxStyle.Information, "Actualizar")
        End If
    End Sub

    Private Sub DataGridprod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridprod.CellContentClick

    End Sub

    Private Sub DataGridprod_DoubleClick(sender As Object, e As EventArgs) Handles DataGridprod.DoubleClick


    End Sub

    Private Sub DataGridprod_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridprod.CellDoubleClick
        DataGridprod.Rows(e.RowIndex).Selected = True

        With DataGridprod

            Dim codigo As String
            Dim nombre As String
            Dim proveedor As String
            Dim cantidad As String
            Dim compra As String
            Dim venta As String
            Dim sitio As String





            codigo = DataGridprod.Rows(e.RowIndex).Cells(0).Value.ToString()
            nombre = DataGridprod.Rows(e.RowIndex).Cells(1).Value.ToString()
            proveedor = DataGridprod.Rows(e.RowIndex).Cells(2).Value.ToString()
            cantidad = DataGridprod.Rows(e.RowIndex).Cells(3).Value.ToString()
            compra = DataGridprod.Rows(e.RowIndex).Cells(4).Value.ToString()
            venta = DataGridprod.Rows(e.RowIndex).Cells(5).Value.ToString()
            sitio = DataGridprod.Rows(e.RowIndex).Cells(6).Value.ToString()




            txtcodigoprod.Text = codigo.ToString
            txtnombreprod.Text = nombre.ToString
            txtprovepro.Text = proveedor.ToString
            txtcantprod.Text = cantidad.ToString
            txtprecicompro.Text = compra.ToString
            txtpreciventpro.Text = venta.ToString
            txtsitiopro.Text = sitio.ToString


        End With
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        txtcodigoprod.Clear()
        txtnombreprod.Clear()
        txtprovepro.Clear()
        txtcantprod.Clear()
        txtprecicompro.Clear()
        txtpreciventpro.Clear()
        txtsitiopro.Clear()

    End Sub
End Class