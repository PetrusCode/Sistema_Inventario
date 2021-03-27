Public Class fmrlogueo
    Dim cont% = 0
    Private Sub fmrlogueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        progressbar1.Visible = False
        lblmsjcarga.Visible = False
    End Sub

    Private Sub logintimer_Tick(sender As Object, e As EventArgs) Handles logintimer.Tick
        cont = cont + 1
        lblmsjcarga.Text = " Cargando " & cont & " % "
        progressbar1.Value = cont
        If cont = 100 Then
            logintimer.Enabled = False
            Me.Hide()
            Form1.Show()
           

        End If
    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim usu = txtusu.Text
        Dim pass = txtpass.Text
        If (usu = "" And pass = "") Then
            progressbar1.Visible = True
            lblmsjcarga.Visible = True
            txtusu.Text = usu
            txtpass.Text = pass
            logintimer.Enabled = True
            Form1.lblusuario.Text = Me.txtusu.Text.ToUpper

        End If
    End Sub
End Class