Partial Class DatabaseproductosDataSet
    Partial Public Class ProductosDataTable
        Private Sub ProductosDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.sitioproColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub ProductosDataTable_ProductosRowChanging(sender As Object, e As ProductosRowChangeEvent) Handles Me.ProductosRowChanging

        End Sub

    End Class
End Class
