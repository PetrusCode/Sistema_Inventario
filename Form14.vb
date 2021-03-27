Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseproductosDataSetFacturas.Factura' table. You can move, or remove it, as needed.
        Me.FacturaTableAdapter.Fill(Me.DatabaseproductosDataSetFacturas.Factura)

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub Imprimir()
        Try
            Cursor.Current = Cursors.WaitCursor
            With Me.printform1
                .printaction = Printing.PrintAction.PrintToPreview
                .PrinterSettings.DefaultPageSettings.Landscape = True
                .print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
            End With
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al tratar de imprimir")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call imprimir()

    End Sub
End Class