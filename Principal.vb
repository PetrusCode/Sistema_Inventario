Public Class Principal

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub ToolStripContainer1_TopToolStripPanel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnusuario.Click
        If btnusuario.Enabled Then
            fmusuarios.Show()



        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btninventario.Click
        If btninventario.Enabled Then
            fminventario.Show()


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnlab.Click
        If btnlab.Enabled Then
            fmlab.Show()

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnproductos.Click
        If btnproductos.Enabled Then
            fmproductos.Show()


        End If
    End Sub

    Private Sub btncontact_Click(sender As Object, e As EventArgs) Handles btncontact.Click
        If btncontact.Enabled Then
            fmcontactos.Show()

        End If
    End Sub

    Private Sub btnalma_Click(sender As Object, e As EventArgs)
        If btnfacturar.Enabled Then
            fmcompras.Show()

        End If
    End Sub


    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnfacturar.Click
        If btnfacturar.Enabled Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Toolstripstatuslabel.Text = Now.ToString("dddd dd mmmm yyyy").ToUpper
        Me.lblhora.Text = Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Toolstripstatuslabel.Text = Now.ToString("dddd dd mmmm yyyy").ToUpper
        Me.lblhora.Text = Now.ToString("hh:mm:ss")
    End Sub


End Class