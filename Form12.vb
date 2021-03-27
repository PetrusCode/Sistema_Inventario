Public Class fmcontac
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasemedicamentosDataSetContactos.Contactos' table. You can move, or remove it, as needed.
        Me.ContactosTableAdapter.Fill(Me.DatabasemedicamentosDataSetContactos.Contactos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class