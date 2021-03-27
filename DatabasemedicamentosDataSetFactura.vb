Partial Class DatabasemedicamentosDataSetFactura
    Partial Public Class MedicamentosDataTable
        Private Sub MedicamentosDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.cantidadColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
