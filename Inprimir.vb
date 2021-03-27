Public Class Inprimir
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Inprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseproductosDataSetFacturas.Factura' table. You can move, or remove it, as needed.
        Me.FacturaTableAdapter.Fill(Me.DatabaseproductosDataSetFacturas.Factura)

        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        'PrintForm1.Print()
        'Timer1.Stop()
    End Sub
End Class