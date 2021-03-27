Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasemedicamentosDataSetContactos.Contactos' table. You can move, or remove it, as needed.
        Me.ContactosTableAdapter.Fill(Me.DatabasemedicamentosDataSetContactos.Contactos)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class