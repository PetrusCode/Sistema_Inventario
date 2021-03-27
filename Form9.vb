Public Class fminfopro
    Public SQL As String
    Private visor As Object
    Private mdtsEBindingSource As Object

    Private Sub fmreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseproductosDataSet.Productos' table. You can move, or remove it, as needed.
        Me.ProductosTableAdapter.Fill(Me.DatabaseproductosDataSet.Productos)


        Me.ReportViewer1.RefreshReport()

    End Sub
    'Private Sub fminfopro_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    If Me.WindowState = FormWindowState.Maximized Then
    '        Exit Sub
    '    Else
    '        Me.WindowState = FormWindowState.Maximized
    '    End If
    'End Sub
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) 

    End Sub
    'Private Sub Imprimir()
    '    Try
    '        Cursor.Current = Cursors.WaitCursor
    '        With Me.printform1
    '            .printaction = Printing.PrintAction.PrintToPreview
    '            .PrinterSettings.DefaultPageSettings.Landscape = True
    '            .print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
    '        End With
    '        Cursor.Current = Cursors.Default
    '    Catch ex As Exception
    '        Cursor.Current = Cursors.Default
    '        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al tratar de imprimir")
    '    End Try
    'End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Call Imprimir()
    'End Sub

    'Private Sub ReportViewer1_Load_1(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    'End Sub
End Class