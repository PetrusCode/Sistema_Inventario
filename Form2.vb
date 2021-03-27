Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbCommand
Imports System.Data
Imports System.Data.SqlClient
Public Class fmusuarios

    Public SQL As String
    Public dr As SqlDataReader



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        If txtcedu.Text = "" Or txtusureg.Text = "" Or txtdirecusu.Text = "" Then
            MsgBox("Rellene los campos en blanco para continuar", MsgBoxStyle.Information, "atencion")
            Exit Sub

        Else

            If IsNotDuplicate(txtcedu.Text) Then

                Dim usuario = txtusureg.Text
                Dim direccion = txtdirecusu.Text
                Dim cedula = txtcedu.Text






                Dim cmd As New OleDb.OleDbCommand




                cn.Open()

                SQL = "INSERT INTO  Usuariosregistry (cedula, usuarioreg, direccionusu) 
               VALUES ('" & txtcedu.Text & "','" & txtusureg.Text & "','" & txtdirecusu.Text & "')"
                cmd = New OleDb.OleDbCommand(SQL, cn)
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("saved")


                txtusureg.Text = ""
                txtdirecusu.Text = ""
                txtcedu.Text = ""

            Else
                MsgBox("este usuario ya esta registrado en la base de datos...verifique", MsgBoxStyle.Information, " atention ")
            End If

        End If
    End Sub
    Private Function IsNotDuplicate(codigo As String) As Boolean
        Dim con As New OleDbConnection

        Dim cmd As New OleDbCommand

        Dim rd As OleDbDataReader


        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PetrusPC\Documents\Databasemedicamentos.mdb"
        con.Open()


        SQL = "Select count(*) from Usuariosregistry where cedula = " + codigo + ""
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

    Private Sub fmusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasemedicamentosDataSetUsuarios.Usuariosregistry' table. You can move, or remove it, as needed.
        Me.UsuariosregistryTableAdapter.Fill(Me.DatabasemedicamentosDataSetUsuarios.Usuariosregistry)



        DataGridusuario.Hide()


    End Sub

    Private Sub btneliminarusu_Click(sender As Object, e As EventArgs) Handles btneliminarusu.Click
        If txtusureg.Text = "" Or txtdirecusu.Text = "" Then
            MsgBox("Rellene los campos en blanco para continuar", MsgBoxStyle.Information, "atencion")
        End If

        Dim cmd As New OleDb.OleDbCommand

            cn.Open()


        SQL = String.Format("Delete from Usuariosregistry where cedula = {0}", txtcedu.Text)
        cmd = New OleDb.OleDbCommand(SQL, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Usuario Eliminado correctamente")
            cn.Close()

    End Sub

    Private Sub DataGridusuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridusuario.CellContentClick

    End Sub

    Private Sub txtusureg_TextChanged(sender As Object, e As EventArgs) Handles txtusureg.TextChanged

    End Sub

    Private Sub txtusureg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusureg.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) Then

            MessageBox.Show("Solo se permite introducir letras", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub



    Private Sub CustomizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles custousu.Click

    End Sub

    Private Sub MedicamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles medicusu.Click
        If medicusu.Enabled Then
            fminformes.Show()
        End If
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles producusu.Click
        If producusu.Enabled Then
            fminfopro.Show()
        End If
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles factuusu.Click
        If factuusu.Enabled Then
            Inprimir.Show()
        End If
    End Sub

    Private Sub contausu_Click(sender As Object, e As EventArgs) Handles contausu.Click
        If contausu.Enabled Then
            fmcontac.Show()
        End If
    End Sub

    Private Sub labempusu_Click(sender As Object, e As EventArgs) Handles labempusu.Click
        If labempusu.Enabled Then
            fmlabemp.Show()
        End If
    End Sub

    Private Sub txtcedu_TextChanged(sender As Object, e As EventArgs) Handles txtcedu.TextChanged

    End Sub

    Private Sub txtcedu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcedu.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnlimpia_Click(sender As Object, e As EventArgs) Handles btnlimpia.Click
        txtcedu.Text = ""
        txtusureg.Text = ""
        txtdirecusu.Text = ""
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class