
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbCommand

Public Class fminformes
    'Public conexion As New SqlConnection
    Public comandoAccess As New OleDbCommand
    Public adaptadores As OleDbDataAdapter
    Public lectura As OleDbDataReader
    Public consulta As String
    Public Shared conexion As OleDbConnection
    Public Shared comando As OleDbCommand
    Public Shared adaptador As OleDbDataAdapter
    ' Public commandoSQL As New SqlCommand
    'Public adaptador As New SqlDataAdapter
    ' Public lector As SqlDataReader
    Public SQL As String
    Private visor As Object
    Private mdtsEBindingSource As Object
    Public Property DatabasemedicamentosDataSetMEDBindingSource As Object

    Private Sub fminformes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DatabasemedicamentosDataSetMED.Medicamentos' table. You can move, or remove it, as needed.
        Me.MedicamentosTableAdapter.Fill(Me.DatabasemedicamentosDataSetMED.Medicamentos)


        Me.ReportViewer1.RefreshReport()





    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


        'Dim p1, p2, p3 As String

        'p1 = TextBox1.Text.Trim()
        'p2 = fecha1.Value.ToShortDateString()
        'p3 = fecha2.Value.ToShortDateString()
        ''DatabasemedicamentosDataSetMED = New DatabasemedicamentosDataSetMED()
        'Dim mdtsE As New DatabasemedicamentosDataSetMED

        'Dim con As New OleDbConnection




        ''con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PetrusPC\Documents\Databasemedicamentos.mdb"
        ''con.Open()
        ''Dim cmd As New OleDbCommand("SELECT * FROM Medicamentos ", cn)

        ''#region "CREA TABLA DE EJEMPLO"
        'Dim tabla As New DataTable()
        'Dim col As New DataColumn("codigomed")
        'col.DataType = System.Type.GetType("System.Int32")
        'tabla.Columns.Add(col)
        'col = New DataColumn("nombremed")
        'col.DataType = System.Type.GetType("System.String")
        'tabla.Columns.Add(col)
        'col = New DataColumn("presentacion")
        'col.DataType = System.Type.GetType("System.String")
        'tabla.Columns.Add(col)
        'col = New DataColumn("tipo")
        'col.DataType = System.Type.GetType("System.String")
        'tabla.Columns.Add(col)
        'col = New DataColumn("laboratorio")
        'col.DataType = System.Type.GetType("System.String")
        'tabla.Columns.Add(col)
        'col = New DataColumn("cantidad")
        'col.DataType = System.Type.GetType("System.Int32")
        'tabla.Columns.Add(col)
        'col = New DataColumn("precioventa")
        'col.DataType = System.Type.GetType("System.Int32")
        'tabla.Columns.Add(col)
        'col = New DataColumn("preciocompra")
        'col.DataType = System.Type.GetType("System.Int32")
        'tabla.Columns.Add(col)
        'col = New DataColumn("dosis")
        'col.DataType = System.Type.GetType("System.Int32")
        'tabla.Columns.Add(col)
        'col = New DataColumn("unidad")
        'col.DataType = System.Type.GetType("System.String")
        'tabla.Columns.Add(col)
        'col = New DataColumn("sitio")
        'col.DataType = System.Type.GetType("System.String")
        'tabla.Columns.Add(col)
        'col = New DataColumn("vencimiento")
        'col.DataType = System.Type.GetType("System.DateTime")
        'tabla.Columns.Add(col)




        ''#End Region



        ''If cn.State = ConnectionState.Closed Then
        ''    cn.Open()

        ''End If

        'For i As Integer = 0 To 10 - 1
        '    Dim linea As DataRow = tabla.NewRow()
        '    linea("codigomed") = "" & (i + 1).GetTypeCode()
        '    linea("nombremed") = "Linea " & (i + 1).ToString()
        '    linea("presentacion") = "Linea " & (i + 1).ToString()
        '    linea("tipo") = "Linea " & (i + 1).ToString()
        '    linea("laboratorio") = "Linea " & (i + 1).ToString()
        '    linea("cantidad") = "" & (i + 1).GetTypeCode()
        '    linea("precioventa") = "" & (i + 1).GetTypeCode()
        '    linea("preciocompra") = "" & (i + 1).GetTypeCode()
        '    linea("dosis") = "" & (i + 1).ToString()
        '    linea("unidad") = "Linea " & (i + 1).ToString()
        '    linea("sitio") = "Linea " & (i + 1).ToString()

        '    tabla.Rows.Add(linea)


        'Next


        'mdtsE.Tables.RemoveAt(0)
        'mdtsE.Tables.Add("tabla")



        'mdtsEBindingSource.DataSource = mdtsE
        '    mdtsEBindingSource.DataMember = "Table1"

        '    'Array que contendrá los parámetros
        '    Dim parameters(0 To 3 - 1) As ReportParameter
        ''Establecemos el valor de los parámetros
        'parameters(0) = New ReportParameter("p1", p1)
        'parameters(1) = New ReportParameter("p2", p2)
        'parameters(2) = New ReportParameter("p3", p3)
        ''Pasamos el array de los parámetros al ReportViewer
        'visor.LocalReport.SetParameters(parameters)
        'visor.Width = 1032
        'visor.Height = 600
        'visor.Visible = True
        'visor.RefreshReport()



    End Sub







    Private Sub MedicamentosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MedicamentosBindingSource.CurrentChanged


    End Sub



    Private Sub FillByToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
End Class

Friend Class ReportParameter
    Private p1 As String
    Private v As String

    Public Sub New(v As String, p1 As String)
        Me.v = v
        Me.p1 = p1
    End Sub
End Class
