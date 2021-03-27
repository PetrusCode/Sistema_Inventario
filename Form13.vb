Public Class fmlabemp
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasemedicamentosDataSetLaboratorios.Laboratorios' table. You can move, or remove it, as needed.
        Me.LaboratoriosTableAdapter.Fill(Me.DatabasemedicamentosDataSetLaboratorios.Laboratorios)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class