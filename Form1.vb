Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbCommand
Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    'Public conexion As New SqlConnection
    Public comandoAccess As New OleDbCommand
    Public adaptadores As OleDbDataAdapter
    Public lectura As OleDbDataReader
    Public consulta As String

    ' Public commandoSQL As New SqlCommand
    'Public adaptador As New SqlDataAdapter
    ' Public lector As SqlDataReader
    Public SQL As String

    Sub New()
        Try
            cn2.Open()
            MsgBox("Conectado")
        Catch ex As Exception
            MsgBox("Error al conectarse a: " + ex.ToString)
        End Try
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasemedicamentosDataSetUsuarios.Usuariosregistry' table. You can move, or remove it, as needed.
        Me.UsuariosregistryTableAdapter.Fill(Me.DatabasemedicamentosDataSetUsuarios.Usuariosregistry)
        'TODO: This line of code loads data into the 'DatabasemedicamentosDataSetFactura.Medicamentos' table. You can move, or remove it, as needed.
        Me.MedicamentosTableAdapter.Fill(Me.DatabasemedicamentosDataSetFactura.Medicamentos)


    End Sub
    Private Sub Imprimir()
        Try
            Cursor.Current = Cursors.WaitCursor
            With Me.PrintForm1
                .PrintAction = Printing.PrintAction.PrintToPreview
                .PrinterSettings.DefaultPageSettings.Landscape = True
                .Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
            End With
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error al tratar de imprimir")
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbarticulos.SelectedIndexChanged

    End Sub

    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        ListBox2.Items.Add(cbarticulos.Text)
        ListBox3.Items.Add(txtprecio.Text)
        ListBox1.Items.Add(txtcantidad.Text)
        listcliente.Items.Add(txtnombre.Text)
        Dim total As Double
        total = txtprecio.Text * txtcantidad.Text
        ListBox4.Items.Add(total)

        'Dim cmd As New OleDbCommand("update Medicamentos set cantidad = cantidad - " + txtcantidad.Text + " where codigomed = " + txtcodigofact.Text, cn)

        'Dim cmd As New OleDbCommand(String.Format("update Medicamentos set cantidad = cantidad - {0} where codigomed ={1}", txtcantidad.Text, txtcodigofact.Text), cn)

        Dim cmd As New OleDbCommand("update Medicamentos set cantidad = cantidad - @cantidad where codigomed =@codigomed", cn)

        cmd.Parameters.Add(New OleDbParameter("@cantidad", Convert.ToInt32(txtcantidad.Text)))
        cmd.Parameters.Add(New OleDbParameter("@codigomed", Convert.ToInt32(txtcodigofact.Text)))

        If cn.State = ConnectionState.Closed Then
            cn.Open()

        End If

        cmd.ExecuteNonQuery()
        cn.Close()

        listado()
    End Sub

    Private Sub txtdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.TextChanged
        txtdireccion.Text = "C/27 de Febrero, esq.Manoguayabo, san suan de la maguana"
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub btncalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalcular.Click
        If (Me.txtnombre.Text = "") Or (Me.txtcantidad.Text = "") Or (Me.txtdireccion.Text = "") Then
            MessageBox.Show("faltan espacios por completar...verifique por favor", "aviso", MessageBoxButtons.OK)
        End If

        Const lbligv = 10
        Dim lbltotal As Double
        'Dim Lisbox4 As Double
        Dim total As Double = 0
        For i As Int32 = 0 To Me.ListBox4.Items.Count - 1
            total = total + Convert.ToDouble(Me.ListBox4.Items.Item(i))
        Next
        Me.lbltotal.Text = Convert.ToString(total)
        'Lisbox4 = Val(Me.ListBox4.Text)

        'total = txtprecio.Text * txtcantidad.Text
        'ListBox4.Items.Add(lbltotal)

        'lbltotal =
        'Me.lbligv.Text = 10
        'Me.lbltotal.Text = Format(total, "### ###.##")
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If

    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim p, r, q, w, u As Integer
        p = ListBox1.SelectedIndex
        r = ListBox2.SelectedIndex
        q = ListBox3.SelectedIndex
        w = ListBox4.SelectedIndex
        u = listcliente.SelectedIndex
        If p <> -1 Then
            ListBox1.Items.RemoveAt(p)
        End If
        If r <> -1 Then
            ListBox2.Items.RemoveAt(r)
        End If
        If q <> -1 Then
            ListBox3.Items.RemoveAt(q)
        End If
        If w <> -1 Then
            ListBox4.Items.RemoveAt(w)
        End If
        If w <> -1 Then
            listcliente.Items.RemoveAt(u)
        End If
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        If MessageBox.Show("Cerrar este programa?", "atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
    Private Sub listado()

        Dim sql As String = "select * from Medicamentos"
        Dim damedicamento As New OleDbDataAdapter(sql, cn)
        Dim dtmedicamento As New DataTable
        damedicamento.Fill(dtmedicamento)
        fminventario.DataGridViewmedicamentos.DataSource = dtmedicamento
        cn.Close()

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub lbligv_Click(sender As Object, e As EventArgs) Handles lbligv.Click

    End Sub

    Private Sub MedicamentosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles MedicamentosBindingSource.CurrentChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If (ListBox1.Items.Count = 0) Then Return
        If (ListBox2.Items.Count = 0) Then Return
        If (ListBox3.Items.Count = 0) Then Return
        If (ListBox4.Items.Count = 0) Then Return
        Try
            Dim con As New OleDbConnection
            con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PetrusPC\Documents\Databaseproductos.mdb"
        con.Open()

        Dim cmd As New OleDbCommand
            '    Dim aql As String =
            '        "INSERT INTO Factura (cliente, cantidad, articu, preci, precitotal, fecha) 
            ''       VALUES ('" & listcliente.Text & "','" & ListBox1.Text & "','" & ListBox2.Text & "','" & ListBox3.Text & "','" & ListBox4.Text & "','" & fechafactura.Value & "')"
            'For Each item As String In listcliente.Items



            SQL = "INSERT INTO Factura (cliente, vendedor, cantidad, articu, preci, precitotal, fecha, direcciof) 
               VALUES ('" & listcliente.Text & "','" & cbovende.Text & "','" & ListBox1.Text & "','" & ListBox2.Text & "','" & ListBox3.Text & "','" & ListBox4.Text & "','" & fechafactura.Value & "','" & txtdireccion.Text & "')"
                cmd = New OleDb.OleDbCommand(SQL, con)

                Dim Lista = String.Join(", ", listcliente.Items.Cast(Of String)().ToArray()).
                                TrimEnd(","c)

                cmd.Parameters.AddWithValue("@cliente", Lista)
                cmd.Parameters.AddWithValue("@vendedor", Lista)
                cmd.Parameters.AddWithValue("@cantidad", Lista)
                cmd.Parameters.AddWithValue("@articu", Lista)
                cmd.Parameters.AddWithValue("@preci", Lista)
                cmd.Parameters.AddWithValue("@precitotal", Lista)
                cmd.Parameters.AddWithValue("@fecha", Lista)
                cmd.Parameters.AddWithValue("@direcciof", Lista)



                'cmd.Parameters.AddWithValue("@cliente", Convert.ToString((listcliente.Text)))

                'cmd.Parameters.Add(New OleDbParameter("@cliente", Convert.ToString(listcliente.Text)))

                'cmd.Parameters.Add(New OleDbParameter("@cantidad", Convert.ToInt32(ListBox1.Items)))
                'cmd.Parameters.Add(New OleDbParameter("@articu", Convert.ToString(ListBox2.Items)))
                'cmd.Parameters.Add(New OleDbParameter("@preci", Convert.ToDecimal(ListBox3.Items)))
                'cmd.Parameters.Add(New OleDbParameter("@precitotal", Convert.ToDecimal(ListBox4.Items)))

                cmd.ExecuteNonQuery()
                cn2.Close()


                MsgBox("saved")

                listcliente.Text = ""
                ListBox1.Text = ""
                ListBox2.Text = ""
                ListBox3.Text = ""
                ListBox4.Text = ""

            'Next
            ''       VALUES ('" & listcliente.Text & "','" & ListBox1.Text & "','" & ListBox2.Text & "','" & ListBox3.Text & "','" & ListBox4.Text & "','" & fechafactura.Value & "')"
            '        For Each item As String In ListBox1.Items
            '            Dim aql As String =
            '"INSERT INTO Factura (cliente, cantidad, articu, preci, precitotal, fecha) 
            '               VALUES ('" & listcliente.Text & "','" & ListBox1.Text & "','" & ListBox2.Text & "','" & ListBox3.Text & "','" & ListBox4.Text & "','" & fechafactura.Value & "')"




            '        Next

            '        '       VALUES ('" & listcliente.Text & "','" & ListBox1.Text & "','" & ListBox2.Text & "','" & ListBox3.Text & "','" & ListBox4.Text & "','" & fechafactura.Value & "')"
            '        For Each item As String In ListBox2.Items
            '            Dim aql As String =
            '"INSERT INTO Factura (cliente, cantidad, articu, preci, precitotal, fecha) 
            '               VALUES ('" & listcliente.Text & "','" & ListBox1.Text & "','" & ListBox2.Text & "','" & ListBox3.Text & "','" & ListBox4.Text & "','" & fechafactura.Value & "')"




            '        Next

            '        '       VALUES ('" & listcliente.Text & "','" & ListBox1.Text & "','" & ListBox2.Text & "','" & ListBox3.Text & "','" & ListBox4.Text & "','" & fechafactura.Value & "')"
            '        For Each item As String In ListBox3.Items
            '            Dim aql As String =
            '"INSERT INTO Factura (cliente, cantidad, articu, preci, precitotal, fecha) 
            '               VALUES ('" & listcliente.Text & "','" & ListBox1.Text & "','" & ListBox2.Text & "','" & ListBox3.Text & "','" & ListBox4.Text & "','" & fechafactura.Value & "')"




            '        Next

            '        '       VALUES ('" & listcliente.Text & "','" & ListBox1.Text & "','" & ListBox2.Text & "','" & ListBox3.Text & "','" & ListBox4.Text & "','" & fechafactura.Value & "')"
            '        For Each item As String In ListBox4.Items
            '            Dim aql As String =
            '"INSERT INTO Factura (cliente, cantidad, articu, preci, precitotal, fecha) 
            '               VALUES ('" & listcliente.Text & "','" & ListBox1.Text & "','" & ListBox2.Text & "','" & ListBox3.Text & "','" & ListBox4.Text & "','" & fechafactura.Value & "')"




            '        Next

            '        '       VALUES ('" & listcliente.Text & "','" & ListBox1.Text & "','" & ListBox2.Text & "','" & ListBox3.Text & "','" & ListBox4.Text & "','" & fechafactura.Value & "')"
            '        For Each item As String In fechafactura.Text
            '            Dim aql As String =
            '"INSERT INTO Factura (cliente, cantidad, articu, preci, precitotal, fecha) 
            '               VALUES ('" & listcliente.Text & "','" & ListBox1.Text & "','" & ListBox2.Text & "','" & ListBox3.Text & "','" & ListBox4.Text & "','" & fechafactura.Value & "')"




            '        Next

            '    Using cmd As OleDbCommand = cn2.CreateCommand()


            '        Dim Lista = String.Join(", ", listcliente.Items.Cast(Of String)().ToArray()).
            '                    TrimEnd(","c)



            '        cmd.Parameters.AddWithValue("@cliente", listcliente.Text(Lista))



            '        cmd.ExecuteNonQuery()

            '    End Using
            '    If cn2.State = ConnectionState.Closed Then
            '            cn2.Open()

            '        End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        'Dim con As New OleDbConnection

        'Dim cmd As New OleDb.OleDbCommand

        'cn.Close()
        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PetrusPC\Documents\Databasemedicamentos.mdb"
        'con.Open()


        'SQL = "INSERT INTO Factura (cliente, direcc, cantidad, articu, preci, precitotal, fecha) 
        '       VALUES ('" & txtnombre.Text & "','" & txtdireccion.Text & "','" & ListBox1.Text & "','" & ListBox2.Text & "','" & ListBox3.Text & "','" & ListBox4.Text & "', '" & fechafactura.Value & "')"
        'cmd = New OleDb.OleDbCommand(SQL, con)

        'cmd.Parameters.Add(New OleDbParameter("@cliente", txtnombre.Text))
        'cmd.Parameters.Add(New OleDbParameter("@direcc", txtdireccion.Text))
        'cmd.Parameters.Add(New OleDbParameter("@cantidad", Convert.ToInt32(ListBox1.Text)))
        'cmd.Parameters.Add(New OleDbParameter("@articu", ListBox2.Text))
        'cmd.Parameters.Add(New OleDbParameter("@preci", Convert.ToInt32(ListBox3.Text)))
        'cmd.Parameters.Add(New OleDbParameter("@precitotal", Convert.ToInt32(ListBox4.Text)))
        'cmd.Parameters.Add(New OleDbParameter("@fecha", Convert.ToDateTime(fechafactura.Text)))


        'cmd.ExecuteNonQuery()
        'con.Close()
        ''CargaMedicamento()

        'MsgBox("saved")

        'txtcodigo.Text = ""
        'txtnombremed.Text = ""
        'cbopresenta.Text = ""
        'cbotipo.Text = ""
        'txtlaborato.Text = ""
        'txtcantidad.Text = ""
        'txtprecivent.Text = ""
        'txtprecicompr.Text = ""
        'txtdosis.Text = ""
        'cbounidad.Text = ""
        'txtsitio.Text = ""






        'Try
        '    MsgBox("registro guardado correcta mente", MsgBoxStyle.Information, "Guardar")
    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs)


        Call Imprimir()

    End Sub

    Private Sub fechafactura_ValueChanged(sender As Object, e As EventArgs) Handles fechafactura.ValueChanged


        'TextBox1.Text = fechafactura.Value.Date.ToString("dd/MM/yyyy")
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Enabled Then
            Form14.Show()
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbovende.SelectedIndexChanged

    End Sub

    Private Sub listcliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listcliente.SelectedIndexChanged

    End Sub
End Class
