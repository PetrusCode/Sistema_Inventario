Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbCommand
Imports System.Data
Imports System.Data.SqlClient
Module Conexion
    Public cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PetrusPC\Documents\Databasemedicamentos.mdb")
    Public cn2 As New OleDbConnection(" Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PetrusPC\Documents\Databaseproductos.mdb")
End Module

'Function Medregistro(ByVal) codigomed As String 
'End Function