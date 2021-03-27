'para conectar la base de datos con SQL
'Imports System.Data
'Imports System.Data.SqlClient
'Imports System.Data.SqlClient.SqlConnection
'para conectatar base de datos de access
'Imports system.data
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbCommand
Public Class fmcontactos
    'Public conexion As New SqlConnection
    Public comandoAccess As New OleDbCommand
    Public adaptadores As OleDbDataAdapter
    Public lectura As OleDbDataReader
    Public consulta As String

    ' Public commandoSQL As New SqlCommand
    'Public adaptador As New SqlDataAdapter
    ' Public lector As SqlDataReader
    Public SQL As String

    Private Sub btnregisconta_Click(sender As Object, e As EventArgs) Handles btnregisconta.Click
        If txtidconta.Text = "" Or txtnomconta.Text = "" Or txttelconta.Text = "" Or txtempconta.Text = "" Then
            MsgBox("Rellene los campos en blanco por favor", MsgBoxStyle.Information, "atencion")
            Me.txtidconta.Focus()
            Exit Sub
        Else

            If IsNotDuplicate(txtidconta.Text) Then
                Dim cmd As New OleDb.OleDbCommand

                cn.Open()

                SQL = "INSERT INTO  Contactos (idconta, nombconta, numconta, empconta  ) 
               VALUES ('" & txtidconta.Text & "','" & txtnomconta.Text & "','" & txttelconta.Text & "','" & txtempconta.Text & "')"
                cmd = New OleDb.OleDbCommand(SQL, cn)
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("saved")

                limpiar()

            Else
                MsgBox("este codigo de contacto esta registrado en la base de datos...verifique", MsgBoxStyle.Information, " atention ")
            End If
        End If

    End Sub

    Private Function IsNotDuplicate(codigo As String) As Boolean
        Dim con As New OleDbConnection

        Dim cmd As New OleDbCommand

        Dim rd As OleDbDataReader


        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PetrusPC\Documents\Databasemedicamentos.mdb"
        con.Open()


        SQL = "Select count(*) from Contactos where idconta = " + codigo + ""
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


        txtidconta.Text = ""
        txtnomconta.Text = ""
        txttelconta.Text = ""
        txtempconta.Text = ""
    End Sub
    Private Sub fmcontactos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtidconta_TextChanged(sender As Object, e As EventArgs) Handles txtidconta.TextChanged

    End Sub

    Private Sub txtidconta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidconta.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txttelconta_TextChanged(sender As Object, e As EventArgs) Handles txttelconta.TextChanged

    End Sub

    Private Sub txttelconta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelconta.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite introducir numeros", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtnomconta_TextChanged(sender As Object, e As EventArgs) Handles txtnomconta.TextChanged

    End Sub

    Private Sub txtnomconta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnomconta.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) Then

            MessageBox.Show("Solo se permite introducir letras", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtempconta_TextChanged(sender As Object, e As EventArgs) Handles txtempconta.TextChanged

    End Sub

    Private Sub btnmodifconta_Click(sender As Object, e As EventArgs) Handles btnmodifconta.Click
        If txtidconta.Text = "" Or txtnomconta.Text = "" Or txttelconta.Text = "" Or txtempconta.Text = "" Then
            MsgBox("Rellene los campos en blanco por favor", MsgBoxStyle.Information, "atencion")
            Me.txtidconta.Focus()
            Exit Sub
        Else
            Dim cmd As New OleDbCommand("update Contactos set idconta=@idconta,nombconta=@nombconta,numconta=@numconta,empconta=@empconta where idconta=@idconta", cn)
            cn.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PetrusPC\Documents\Databasemedicamentos.mdb")

            cmd.Parameters.Add(New OleDbParameter("@idconta", Convert.ToInt32(txtidconta.Text)))
            cmd.Parameters.Add(New OleDbParameter("@nombconta", txtnomconta.Text))
            cmd.Parameters.Add(New OleDbParameter("@numconta", Convert.ToDecimal(txttelconta.Text)))
            cmd.Parameters.Add(New OleDbParameter("@empconta", txtempconta.Text))






            cn.Open()

            cmd.ExecuteNonQuery()

            cn.Close()

            limpiar()
            MsgBox("registro actualizado correcta mente", MsgBoxStyle.Information, "Actualizar")
        End If
    End Sub

    Private Sub btnverconta_Click(sender As Object, e As EventArgs) Handles btnverconta.Click
        If btnverconta.Enabled = True Then
            Form11.Show()

        End If
    End Sub

    Private Sub btneliminaconta_Click(sender As Object, e As EventArgs) Handles btneliminaconta.Click
        If txtidconta.Text = "" Or txtnomconta.Text = "" Or txttelconta.Text = "" Or txtempconta.Text = "" Then
            MsgBox("Rellene los campos en blanco por favor", MsgBoxStyle.Information, "atencion")
            Me.txtidconta.Focus()
        End If

        Dim cmd As New OleDb.OleDbCommand

        cn.Open()


        SQL = String.Format("Delete from Contactos where idconta = {0}", txtidconta.Text)
        cmd = New OleDb.OleDbCommand(SQL, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("registro eliminado correcta mente", MsgBoxStyle.Information, "Eliminar")
    End Sub
End Class