'para conectar la base de datos con SQL
'Imports System.Data
'Imports System.Data.SqlClient
'Imports System.Data.SqlClient.SqlConnection
'para conectatar base de datos de access
'Imports system.data
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbCommand
Public Class fmlab
    'Public conexion As New SqlConnection
    Public comandoAccess As New OleDbCommand
    Public adaptadores As OleDbDataAdapter
    Public lectura As OleDbDataReader
    Public consulta As String

    ' Public commandoSQL As New SqlCommand
    'Public adaptador As New SqlDataAdapter
    ' Public lector As SqlDataReader
    Public SQL As String

    ' Public commandoSQL As New SqlCommand
    'Public adaptador As New SqlDataAdapter
    ' Public lector As SqlDa
    Private Sub btnregistrarlab_Click(sender As Object, e As EventArgs) Handles btnregistrarlab.Click

        Dim cmd As New OleDb.OleDbCommand

        If txtnomblab.Text = "" Or txtsedelab.Text = "" Or txtsuculab.Text = "" Or txtdireclab.Text = "" Or txtnumlab.Text = "" Then
            MsgBox("Rellene los campos en blanco por favor", MsgBoxStyle.Information, "atencion")
            Me.txtnomblab.Focus()
            Exit Sub

        Else

            If IsNotDuplicate(txtidlab.Text) Then

                cn.Open()

                SQL = "INSERT INTO  Laboratorios (idlab, nombrelab, sedelab, sucursalab, direccionlab, numlab) 
               VALUES ('" & txtidlab.Text & "', '" & txtnomblab.Text & "','" & txtsedelab.Text & "','" & txtsuculab.Text & "','" & txtdireclab.Text & "','" & txtnumlab.Text & "' )"
                cmd = New OleDb.OleDbCommand(SQL, cn)
                cmd.ExecuteNonQuery()
                MsgBox("saved")


                cn.Close()


                'limpiar()


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


        SQL = "Select count(*) from Laboratorios where idlab = " + codigo + ""
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
    Private Sub fmlab_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnverlab_Click(sender As Object, e As EventArgs) Handles btnverlab.Click
        If btnverlab.Enabled = True Then
            Form10.Show()

        End If
    End Sub

    Private Sub btneliminalab_Click(sender As Object, e As EventArgs) Handles btneliminalab.Click
        If txtnomblab.Text = "" Or txtsedelab.Text = "" Or txtsuculab.Text = "" Or txtdireclab.Text = "" Or txtnumlab.Text = "" Then
            MsgBox("Rellene los campos en blanco por favor", MsgBoxStyle.Information, "atencion")
            Me.txtnomblab.Focus()
        End If

        Dim cmd As New OleDb.OleDbCommand

            cn.Open()


            SQL = String.Format("Delete from Laboratorios where idlab = {0}", txtidlab.Text)
            cmd = New OleDb.OleDbCommand(SQL, cn)
            cmd.ExecuteNonQuery()
            cn.Close()
        MsgBox("registro eliminado correcta mente", MsgBoxStyle.Information, "Eliminar")
    End Sub

    Private Sub txtnumlab_TextChanged(sender As Object, e As EventArgs) Handles txtnumlab.TextChanged

    End Sub

    Private Sub txtnomblab_TextChanged(sender As Object, e As EventArgs) Handles txtnomblab.TextChanged

    End Sub

    Private Sub txtsedelab_TextChanged(sender As Object, e As EventArgs) Handles txtsedelab.TextChanged

    End Sub

    Private Sub txtnomblab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnomblab.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) Then

            MessageBox.Show("Solo se permite introducir letras", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsedelab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsedelab.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) Then

            MessageBox.Show("Solo se permite introducir letras", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsuculab_TextChanged(sender As Object, e As EventArgs) Handles txtsuculab.TextChanged

    End Sub

    Private Sub txtsuculab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsuculab.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) Then

            MessageBox.Show("Solo se permite introducir letras", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtnumlab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumlab.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtidlab_TextChanged(sender As Object, e As EventArgs) Handles txtidlab.TextChanged

    End Sub

    Private Sub txtidlab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidlab.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnbuscalab_Click(sender As Object, e As EventArgs) Handles btnbuscalab.Click

    End Sub
End Class