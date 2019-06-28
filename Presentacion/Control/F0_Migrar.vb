Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar.Controls
Imports System.IO
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class F0_Migrar


    Public Function _fnobtenernivel(cadena As String) As Integer
        nivel = 1
        Dim codigo As String = ""
        Dim i As Integer = 0
        Dim contador As Integer = 0
        Dim bandera = False
        cadena = cadena.Trim
        While i < cadena.Length And bandera = False
            Dim letra As String = cadena(i)
            If (letra = ".") Then
                contador += 1
                If (i + 1 < cadena.Length) Then
                    nivel += 1
                End If
            Else
                codigo = codigo + letra
            End If
            If (contador = nivel) Then
                bandera = True
            End If
            i += 1

        End While

        Return nivel
    End Function

    Public Sub _ColocarNivel(ByRef dt As DataTable)
        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim cuenta As String = dt.Rows(i).Item("nro")
            Dim nivel As Integer = _fnobtenernivel(cuenta)
            dt.Rows(i).Item("nivel") = nivel
        Next
        Dim a As Integer = 0
    End Sub
    Public Function _fnobtenerNumiPadre(nivel As Integer, cadena As String, table As DataTable, posicion As Integer) As Integer
        nivel = nivel - 1
        Dim codigo As String = ""
        Dim i As Integer = 0
        Dim contador As Integer = 0
        Dim bandera = False
        While i < cadena.Length And bandera = False
            Dim letra As String = cadena(i)
            If (letra = ".") Then
                contador += 1
            Else
                codigo = codigo + letra
            End If
            If (contador = nivel) Then
                bandera = True
            End If
            i += 1

        End While
        Dim dt As DataTable = L_prCuentaGetByNroCuenta(codigo, 1)
        If (dt.Rows.Count > 0) Then
            Return dt.Rows(0).Item("canumi")
        Else
            If (nivel + 1 = 5) Then
                Dim numi As String
                Dim cuenta As String = table.Rows(posicion).Item("nro")
                cuenta = cuenta.Replace(".", "")
                cuenta = cuenta.Substring(0, cuenta.Length - 3)

                Dim res As Boolean = L_prCuentaGrabar2(numi, 1, cuenta, table.Rows(posicion).Item("descripcion"), Str(nivel), "BO", table.Rows(posicion).Item("tipo"), Str(_fnobtenerNumiPadre(4, cadena, table, posicion)))
                Dim dt2 As DataTable = L_prCuentaGetByNroCuenta(cuenta, 1)
                If (dt2.Rows.Count > 0) Then
                    Return dt2.Rows(0).Item("canumi")
                End If

            End If
            If (nivel + 1 = 6) Then
                Dim numi As String
                Dim cuenta As String = table.Rows(posicion).Item("nro")
                cuenta = cuenta.Replace(".", "")
                cuenta = cuenta.Substring(0, cuenta.Length - 3)

                Dim res As Boolean = L_prCuentaGrabar2(numi, 1, cuenta, table.Rows(posicion).Item("descripcion"), Str(nivel), "BO", table.Rows(posicion).Item("tipo"), Str(_fnobtenerNumiPadre(4, cadena, table, posicion)))
                Dim dt2 As DataTable = L_prCuentaGetByNroCuenta(cuenta, 1)
                If (dt2.Rows.Count > 0) Then
                    Return dt2.Rows(0).Item("canumi")
                End If

            End If
            If (nivel + 1 = 7) Then
                Dim numi As String
                Dim cuenta As String = table.Rows(posicion).Item("nro")
                cuenta = cuenta.Replace(".", "")
                cuenta = cuenta.Substring(0, cuenta.Length - 3)

                Dim res As Boolean = L_prCuentaGrabar2(numi, 1, cuenta, table.Rows(posicion).Item("descripcion"), Str(nivel), "BO", table.Rows(posicion).Item("tipo"), Str(_fnobtenerNumiPadre(4, cadena, table, posicion)))
                Dim dt2 As DataTable = L_prCuentaGetByNroCuenta(cuenta, 1)
                If (dt2.Rows.Count > 0) Then
                    Return dt2.Rows(0).Item("canumi")
                End If

            End If
        End If
        Return 0
    End Function
    Public Sub _prMigrarCuenta()
        L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, "BDDicon_Dynasis")
        Dim dt As DataTable = Import()
        _ColocarNivel(dt)
        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim nivel As Integer = dt.Rows(i).Item("nivel")
            If nivel = 7 Then
                'ByRef _yhnumi As String, _yhnombre As String, _yhcodigo As String,
                '                                   _yhcategoria As Integer, _yhimg As String, _yhestado As Integer
                Dim numipadre As Integer = _fnobtenerNumiPadre(nivel, dt.Rows(i).Item("nro"), dt, i)
                Dim cuenta As String = dt.Rows(i).Item("nro")
                cuenta = cuenta.Replace(".", "")
                If (numipadre >= 0) Then
                    Dim res As Boolean = L_prCuentaGrabar2("", 1, cuenta, dt.Rows(i).Item("descripcion"), Str(nivel), "BO", dt.Rows(i).Item("tipo"), Str(numipadre))
                End If

            End If



        Next
    End Sub
    Private Shared Function Import() As DataTable
        Dim conStr As String = ""
        Dim dtExcelSchema As DataTable
        Dim dt As DataSet = New DataSet

        conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=Yes'"
        conStr = String.Format(conStr, "A:\DINASES\Dinases Srl\DicontaColegio\Migrar\Migrar.xlsx")
        Dim connExcel As New OleDbConnection(conStr)
        Dim cmdExcel As New OleDbCommand()
        Dim oda As New OleDbDataAdapter()
        cmdExcel.Connection = connExcel
        'Get the name of First Sheet
        connExcel.Open()
        dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        Dim name As String = "migrar"
        Dim SheetName As String = name + "$"
        'If dtExcelSchema.Rows.Count > 0 Then
        '    SheetName = dtExcelSchema.Rows(dtExcelSchema.Rows.Count - 1)("TABLE_NAME").ToString()
        'End If
        connExcel.Close()
        'Read Data from First Sheet
        connExcel.Open()
        cmdExcel.CommandText = "SELECT * From [" & SheetName & "]"
        oda.SelectCommand = cmdExcel
        oda.Fill(dt)
        Dim dtt As DataTable = dt.Tables(0)


        'dt.TableName = SheetName.ToString().Replace("$", "")
        connExcel.Close()
        Return dtt
    End Function

    Private Sub F0_Migrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prMigrarCuenta()
    End Sub
End Class