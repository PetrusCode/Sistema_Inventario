Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasemedicamentosDataSetLaboratorios1.Laboratorios' table. You can move, or remove it, as needed.
        Me.LaboratoriosTableAdapter.Fill(Me.DatabasemedicamentosDataSetLaboratorios1.Laboratorios)
        'TODO: This line of code loads data into the 'DatabasemedicamentosDataSetLaboratorios.Laboratorios' table. You can move, or remove it, as needed.
        Me.LaboratoriosTableAdapter.Fill(Me.DatabasemedicamentosDataSetLaboratorios.Laboratorios)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class