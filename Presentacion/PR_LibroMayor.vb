﻿Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class PR_LibroMayor
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Public _modo As Integer = 0
    Public _cobrarPagar As Integer = 0

#Region "metodos privados"
    Private Sub _prIniciarTodo()
        Me.Text = "libro mayor".ToUpper
        tbFechaDel.Value = Now.Date
        tbFechaAl.Value = Now.Date
        _prCargarComboMoneda()
        tbReferencia.Enabled = False
    End Sub
    Private Sub _prCargarComboMoneda()
        Dim dt As New DataTable
        dt.Columns.Add("numi", GetType(String))
        dt.Columns.Add("desc", GetType(String))
        dt.Rows.Add(0, "BO")
        dt.Rows.Add(1, "SUS")
        dt.Rows.Add(2, "AMBOS")

        With tbMoneda
            .DropDownList.Columns.Clear()

            .DropDownList.Columns.Add("numi").Width = 100
            .DropDownList.Columns("numi").Caption = "COD"

            .DropDownList.Columns.Add("desc").Width = 200
            .DropDownList.Columns("desc").Caption = "MONEDA"

            .ValueMember = "numi"
            .DisplayMember = "desc"
            .DataSource = dt
            .Refresh()
        End With
        tbMoneda.SelectedIndex = 0
    End Sub
    Private Sub _prCargarGridDetalle()
        Dim dt As New DataTable
        If tbCliente.Tag = 0 Then
            dt = L_prCuentaReporteLibroMayor(tbNumi.Tag.ToString.Trim, tbFechaDel.Value.ToString("yyyy/MM/dd"), tbFechaAl.Value.ToString("yyyy/MM/dd"))

        Else
            dt = L_prCuentaReporteLibroMayorPorCliente(tbNumi.Tag.ToString.Trim, tbFechaDel.Value.ToString("yyyy/MM/dd"), tbFechaAl.Value.ToString("yyyy/MM/dd"), tbCliente.Tag)
        End If

        'preguntar si hay que filtrar por referencia
        If tbFiltrarRef.Value = True Then
            Dim filasFiltradas As DataRow() = dt.Select("obobs like '%" + tbReferencia.Text + "%'", "orden,oafdoc asc")
            If filasFiltradas.Count = 0 Then
                Dim fila1 As DataRow = dt.Rows(0)
                dt.Rows.Clear()
                dt.Rows.Add(fila1)
            Else
                dt = filasFiltradas.CopyToDataTable
            End If
        End If

        'calcular el saldo
        dt.Rows(0).Item("saldo") = IIf(IsDBNull(dt.Rows(0).Item("obdebebs")) = True, 0, dt.Rows(0).Item("obdebebs")) - IIf(IsDBNull(dt.Rows(0).Item("obhaberbs")) = True, 0, dt.Rows(0).Item("obhaberbs"))
        dt.Rows(0).Item("saldoSus") = IIf(IsDBNull(dt.Rows(0).Item("obdebeus")) = True, 0, dt.Rows(0).Item("obdebeus")) - IIf(IsDBNull(dt.Rows(0).Item("obhaberus")) = True, 0, dt.Rows(0).Item("obhaberus"))

        dt.Rows(0).Item("obdebebs") = DBNull.Value
        dt.Rows(0).Item("obhaberbs") = DBNull.Value
        dt.Rows(0).Item("obdebeus") = DBNull.Value
        dt.Rows(0).Item("obhaberus") = DBNull.Value
        dt.Rows(0).Item("obobs") = "SALDO ANTERIOR"


        Dim debe, haber, saldo, debeSus, haberSus, saldoSus As Double
        Dim sumDebe, sumHaber, sumDebeSus, sumHaberSus As Double
        sumDebe = 0
        sumHaber = 0
        sumDebeSus = 0
        sumHaberSus = 0
        saldo = dt.Rows(0).Item("saldo")
        saldoSus = dt.Rows(0).Item("saldoSus")
        For i = 1 To dt.Rows.Count - 1
            debe = dt.Rows(i).Item("obdebebs")
            haber = dt.Rows(i).Item("obhaberbs")
            debeSus = dt.Rows(i).Item("obdebeus")
            haberSus = dt.Rows(i).Item("obhaberus")
            If debe > 0 Then
                saldo = saldo + debe
                saldoSus = saldoSus + debeSus
            Else
                saldo = saldo - haber
                saldoSus = saldoSus - haberSus
            End If
            dt.Rows(i).Item("saldo") = saldo
            dt.Rows(i).Item("saldoSus") = saldoSus
            sumDebe = sumDebe + debe
            sumHaber = sumHaber + haber
            sumDebeSus = sumDebeSus + debeSus
            sumHaberSus = sumHaberSus + haberSus
        Next

        'calcular el saldo
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1).Item("saldo") = DBNull.Value
        dt.Rows(dt.Rows.Count - 1).Item("obdebebs") = sumDebe
        dt.Rows(dt.Rows.Count - 1).Item("obhaberbs") = sumHaber
        dt.Rows(dt.Rows.Count - 1).Item("obdebeus") = sumDebeSus
        dt.Rows(dt.Rows.Count - 1).Item("obhaberus") = sumHaberSus
        dt.Rows(dt.Rows.Count - 1).Item("obobs") = "TOTAL"

        grDetalle.DataSource = dt
        grDetalle.RetrieveStructure()

        'dar formato a las columnas
        With grDetalle.RootTable.Columns("oanumi")
            .Width = 50
            .Visible = False
        End With
        With grDetalle.RootTable.Columns("obnumi")
            .Width = 50
            .Visible = False
        End With
        With grDetalle.RootTable.Columns("oblin")
            .Width = 50
            .Visible = False
        End With
        With grDetalle.RootTable.Columns("cacta")
            .Caption = "CUENTA"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With
        With grDetalle.RootTable.Columns("obobs")
            .Caption = "DETALLE"
            .Width = 300
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With
        With grDetalle.RootTable.Columns("oafdoc")
            .Caption = "FECHA"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With
        With grDetalle.RootTable.Columns("oanumdoc")
            .Caption = "CBTE"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With
        With grDetalle.RootTable.Columns("obdebebs")
            .Caption = "DEBE"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far
        End With
        With grDetalle.RootTable.Columns("obhaberbs")
            .Caption = "HABER"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far

        End With
        With grDetalle.RootTable.Columns("saldo")
            .Caption = "SALDO"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far

        End With
        With grDetalle.RootTable.Columns("oatc")
            .Caption = "FACTOR"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far

        End With
        With grDetalle.RootTable.Columns("obdebeus")
            .Caption = "DEBE $US"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far

        End With
        With grDetalle.RootTable.Columns("obhaberus")
            .Caption = "HABER $US"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far

        End With

        With grDetalle.RootTable.Columns("orden")
            .Width = 50
            .Visible = False
        End With

        With grDetalle.RootTable.Columns("mesanio")
            .Width = 50
            .Visible = False
        End With

        With grDetalle.RootTable.Columns("saldoSus")
            .Caption = "SALDO US"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far

        End With

        With grDetalle
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007

        End With


    End Sub

    Private Sub _prCargarGridDetalleConTotalesMeses()
        Dim dt As New DataTable
        If tbCliente.Tag = 0 Then
            dt = L_prCuentaReporteLibroMayor(tbNumi.Tag.ToString.Trim, tbFechaDel.Value.ToString("yyyy/MM/dd"), tbFechaAl.Value.ToString("yyyy/MM/dd"))

        Else
            dt = L_prCuentaReporteLibroMayorPorCliente(tbNumi.Tag.ToString.Trim, tbFechaDel.Value.ToString("yyyy/MM/dd"), tbFechaAl.Value.ToString("yyyy/MM/dd"), tbCliente.Tag)
        End If

        'preguntar si hay que filtrar por referencia
        If tbFiltrarRef.Value = True Then
            Dim dtMyCopia As DataTable = dt.Copy
            'Dim primeraFila As DataRow = dt.Rows(0)

            Dim filasFiltradas As DataRow() = dt.Select("obobs like '%" + tbReferencia.Text + "%'", "orden,oafdoc asc")
            If filasFiltradas.Count = 0 Then
                'Dim fila1 As DataRow = dt.Rows(0)
                dt.Rows.Clear()
                'dt.Rows.Add(fila1)
            Else
                'dt = filasFiltradas.CopyToDataTable
                Dim dtResultado As DataTable = filasFiltradas.CopyToDataTable
                dt.Clear()
                dt.ImportRow(dtMyCopia.Rows(0))
                For Each fila1 As DataRow In dtResultado.Rows
                    dt.ImportRow(fila1)
                Next
            End If

            'dt.Rows.InsertAt(primeraFila, 0)

        End If

        'cargo los totales meses
        Dim dtCopia As DataTable = dt.Copy
        dtCopia.Clear()
        dtCopia.ImportRow(dt.Rows(0))

        If dt.Rows.Count > 1 Then

            Dim mesAnio As String = dt.Rows(1).Item("mesanio")
            Dim mesAnioDate As Date = dt.Rows(1).Item("oafdoc")

            For i = 1 To dt.Rows.Count - 1
                If mesAnio <> dt.Rows(i).Item("mesanio") Then
                    dtCopia.Rows.Add()
                    dtCopia.Rows(dtCopia.Rows.Count - 1).Item("obobs") = "total mes ".ToUpper + mesAnioDate.Month.ToString("00") + "/" + mesAnioDate.Year.ToString() + ":"
                    dtCopia.Rows(dtCopia.Rows.Count - 1).Item("oanumi") = -1
                    mesAnioDate = dt.Rows(i).Item("oafdoc")
                    mesAnio = dt.Rows(i).Item("mesanio")
                End If
                dtCopia.ImportRow(dt.Rows(i))
            Next

            'falta el total del ultimo mes
            dtCopia.Rows.Add()
            dtCopia.Rows(dtCopia.Rows.Count - 1).Item("obobs") = "total mes ".ToUpper + mesAnioDate.Month.ToString("00") + "/" + mesAnioDate.Year.ToString() + ":"
            dtCopia.Rows(dtCopia.Rows.Count - 1).Item("oanumi") = -1

        End If
        dt = dtCopia
        '***************

        'calcular el saldo
        dt.Rows(0).Item("saldo") = IIf(IsDBNull(dt.Rows(0).Item("obdebebs")) = True, 0, dt.Rows(0).Item("obdebebs")) - IIf(IsDBNull(dt.Rows(0).Item("obhaberbs")) = True, 0, dt.Rows(0).Item("obhaberbs"))
        dt.Rows(0).Item("saldoSus") = IIf(IsDBNull(dt.Rows(0).Item("obdebeus")) = True, 0, dt.Rows(0).Item("obdebeus")) - IIf(IsDBNull(dt.Rows(0).Item("obhaberus")) = True, 0, dt.Rows(0).Item("obhaberus"))

        dt.Rows(0).Item("obdebebs") = DBNull.Value
        dt.Rows(0).Item("obhaberbs") = DBNull.Value
        dt.Rows(0).Item("obdebeus") = DBNull.Value
        dt.Rows(0).Item("obhaberus") = DBNull.Value

        dt.Rows(0).Item("obobs") = "SALDO ANTERIOR"


        Dim debe, haber, saldo, debeSus, haberSus, saldoSus As Double
        Dim sumDebe, sumHaber, sumDebeSus, sumHaberSus As Double
        sumDebe = 0
        sumHaber = 0
        sumDebeSus = 0
        sumHaberSus = 0
        saldo = dt.Rows(0).Item("saldo")
        saldoSus = dt.Rows(0).Item("saldoSus")
        Dim totMesDebe As Double = 0
        Dim totMesHaber As Double = 0
        Dim totMesDebeSus As Double = 0
        Dim totMesHaberSus As Double = 0

        For i = 1 To dt.Rows.Count - 1
            If dt.Rows(i).Item("oanumi") = -1 Then
                dt.Rows(i).Item("obdebebs") = totMesDebe
                dt.Rows(i).Item("obhaberbs") = totMesHaber
                dt.Rows(i).Item("obdebeus") = totMesDebeSus
                dt.Rows(i).Item("obhaberus") = totMesHaberSus

                totMesDebe = 0
                totMesHaber = 0
                totMesDebeSus = 0
                totMesHaberSus = 0
            Else
                debe = dt.Rows(i).Item("obdebebs")
                haber = dt.Rows(i).Item("obhaberbs")
                debeSus = dt.Rows(i).Item("obdebeus")
                haberSus = dt.Rows(i).Item("obhaberus")
                If debe > 0 Then
                    saldo = saldo + debe
                    saldoSus = saldoSus + debeSus
                Else
                    saldo = saldo - haber
                    saldoSus = saldoSus - haberSus
                End If
                dt.Rows(i).Item("saldo") = saldo
                dt.Rows(i).Item("saldoSus") = saldoSus
                sumDebe = sumDebe + debe
                sumHaber = sumHaber + haber
                sumDebeSus = sumDebeSus + debeSus
                sumHaberSus = sumHaberSus + haberSus

                totMesDebe = totMesDebe + debe
                totMesHaber = totMesHaber + haber
                totMesDebeSus = totMesDebeSus + debeSus
                totMesHaberSus = totMesHaberSus + haberSus
            End If
        Next

        'calcular el saldo
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1).Item("saldo") = DBNull.Value
        dt.Rows(dt.Rows.Count - 1).Item("obdebebs") = sumDebe
        dt.Rows(dt.Rows.Count - 1).Item("obhaberbs") = sumHaber
        dt.Rows(dt.Rows.Count - 1).Item("obdebeus") = sumDebeSus
        dt.Rows(dt.Rows.Count - 1).Item("obhaberus") = sumHaberSus
        dt.Rows(dt.Rows.Count - 1).Item("obobs") = "TOTAL"

        grDetalle.DataSource = dt
        grDetalle.RetrieveStructure()

        'dar formato a las columnas
        With grDetalle.RootTable.Columns("oanumi")
            .Width = 50
            .Visible = False
        End With
        With grDetalle.RootTable.Columns("obnumi")
            .Width = 50
            .Visible = False
        End With
        With grDetalle.RootTable.Columns("oblin")
            .Width = 50
            .Visible = False
        End With
        With grDetalle.RootTable.Columns("cacta")
            .Caption = "CUENTA"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With
        With grDetalle.RootTable.Columns("obobs")
            .Caption = "DETALLE"
            .Width = 300
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With
        With grDetalle.RootTable.Columns("oafdoc")
            .Caption = "FECHA"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With
        With grDetalle.RootTable.Columns("oanumdoc")
            .Caption = "CBTE"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With
        With grDetalle.RootTable.Columns("obdebebs")
            .Caption = "DEBE"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far
        End With
        With grDetalle.RootTable.Columns("obhaberbs")
            .Caption = "HABER"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far

        End With
        With grDetalle.RootTable.Columns("saldo")
            .Caption = "SALDO"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far

        End With
        With grDetalle.RootTable.Columns("oatc")
            .Caption = "FACTOR"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far

        End With
        With grDetalle.RootTable.Columns("obdebeus")
            .Caption = "DEBE $US"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far

        End With
        With grDetalle.RootTable.Columns("obhaberus")
            .Caption = "HABER $US"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far

        End With

        With grDetalle.RootTable.Columns("orden")
            .Width = 50
            .Visible = False
        End With

        With grDetalle.RootTable.Columns("mesanio")
            .Width = 50
            .Visible = False
        End With

        With grDetalle.RootTable.Columns("saldoSus")
            .Caption = "SALDO US"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .FormatString = "0.00"
            .CellStyle.TextAlignment = TextAlignment.Far

        End With

        With grDetalle
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007

        End With

        Dim fc As GridEXFormatCondition
        fc = New GridEXFormatCondition(grDetalle.RootTable.Columns("oanumi"), ConditionOperator.Equal, -1)
        fc.FormatStyle.BackColor = Color.LightGreen
        fc.FormatStyle.FontBold = TriState.True
        grDetalle.RootTable.FormatConditions.Add(fc)


    End Sub
    Private Sub _prImprimir()
        If IsNothing(grDetalle.DataSource) = False Then
            Dim objrep As New R_LibroMayor
            Dim dt As DataTable = CType(grDetalle.DataSource, DataTable)
            If tbMeses.Value = True Then
                Dim filasFiltradas As DataRow() = dt.Select("oanumi<>-1")
                If filasFiltradas.Count > 0 Then
                    dt = filasFiltradas.CopyToDataTable
                End If
            End If
            'saco el ultimo registro del total
            dt.Rows(dt.Rows.Count - 1).Delete()

            'ahora lo mando al visualizador
            P_Global.Visualizador = New Visualizador
            objrep.SetDataSource(dt)

            objrep.SetParameterValue("fechaDesde", tbFechaDel.Value.ToString("dd/MM/yyyy"))
            objrep.SetParameterValue("fechaHasta", tbFechaAl.Value.ToString("dd/MM/yyyy"))
            objrep.SetParameterValue("titulo", "AUTOMOVIL CLUB BOLIVIANO " + gs_empresaDesc.ToUpper)
            objrep.SetParameterValue("nit", gs_empresaNit.ToUpper)
            objrep.SetParameterValue("cliente", IIf(tbCliente.Tag > 0, _cobrarPagar, ""))
            objrep.SetParameterValue("nroCuenta", tbNumi.Text)
            objrep.SetParameterValue("cuenta", tbCuenta.Text)
            objrep.SetParameterValue("moneda", tbMoneda.Value)
            If tbMeses.Value = True Then
                objrep.SetParameterValue("conMeses", 1)

            Else
                objrep.SetParameterValue("conMeses", 0)

            End If


            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.Show() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        End If
    End Sub

    Private Sub _prImprimirHorizontal()
        If IsNothing(grDetalle.DataSource) = False Then
            Dim objrep As New R_LibroMayorHorizontal
            Dim dt As DataTable = CType(grDetalle.DataSource, DataTable)
            If tbMeses.Value = True Then
                Dim filasFiltradas As DataRow() = dt.Select("oanumi<>-1")
                If filasFiltradas.Count > 0 Then
                    dt = filasFiltradas.CopyToDataTable
                End If
            End If
            'saco el ultimo registro del total
            dt.Rows(dt.Rows.Count - 1).Delete()

            'ahora lo mando al visualizador
            P_Global.Visualizador = New Visualizador
            objrep.SetDataSource(dt)

            objrep.SetParameterValue("fechaDesde", tbFechaDel.Value.ToString("dd/MM/yyyy"))
            objrep.SetParameterValue("fechaHasta", tbFechaAl.Value.ToString("dd/MM/yyyy"))
            objrep.SetParameterValue("titulo", "AUTOMOVIL CLUB BOLIVIANO " + gs_empresaDesc.ToUpper)
            objrep.SetParameterValue("nit", gs_empresaNit.ToUpper)
            objrep.SetParameterValue("cliente", IIf(tbCliente.Tag > 0, _cobrarPagar, ""))
            objrep.SetParameterValue("nroCuenta", tbNumi.Text)
            objrep.SetParameterValue("cuenta", tbCuenta.Text)
            'objrep.SetParameterValue("moneda", tbMoneda.Value)
            If tbMeses.Value = True Then
                objrep.SetParameterValue("conMeses", 1)

            Else
                objrep.SetParameterValue("conMeses", 0)

            End If


            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.Show() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        End If
    End Sub
#End Region
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbNumi.TextChanged

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If tbFechaDel.Value > tbFechaAl.Value Then
            ToastNotification.Show(Me, "seleccione un rango de fecha correcto, la fecha de inicio es mayor a la del fin..!!!".ToUpper,
                                           My.Resources.WARNING, 2000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
            Exit Sub
        End If

        If tbNumi.Text = "" Then
            ToastNotification.Show(Me, "seleccione una cuenta..!!!".ToUpper,
                                           My.Resources.WARNING, 2000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
            Exit Sub
        End If
        gpGrilla.Text = "cuenta ".ToUpper + tbNumi.Text + " " + tbCuenta.Text
        If tbMeses.Value = True Then
            _prCargarGridDetalleConTotalesMeses()
        Else
            _prCargarGridDetalle()
        End If
    End Sub

    Private Sub tbNumi_KeyDown(sender As Object, e As KeyEventArgs) Handles tbNumi.KeyDown, tbCuenta.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            Dim frmAyuda As Modelos.ModeloAyuda
            Dim dt As DataTable

            dt = L_prCuentaGeneralBasicoParaLibroMayor(gi_empresaNumi)

            Dim listEstCeldas As New List(Of Modelos.Celda)
            listEstCeldas.Add(New Modelos.Celda("canumi", False))
            listEstCeldas.Add(New Modelos.Celda("cacta", True, "codigo".ToUpper, 150))
            listEstCeldas.Add(New Modelos.Celda("cadesc", True, "cuenta".ToUpper, 200))
            listEstCeldas.Add(New Modelos.Celda("camon", True, "moneda".ToUpper, 150))
            listEstCeldas.Add(New Modelos.Celda("catipo", False))
            listEstCeldas.Add(New Modelos.Celda("cndesc1", True, "tipo".ToUpper, 150))
            listEstCeldas.Add(New Modelos.Celda("isCobrar", False, "", 100))
            listEstCeldas.Add(New Modelos.Celda("isPagar", False, "", 100))


            frmAyuda = New Modelos.ModeloAyuda(0, 0, dt, "seleccione cuenta".ToUpper, listEstCeldas)
            frmAyuda.ShowDialog()

            If frmAyuda.seleccionado = True Then
                tbCliente.Text = ""
                tbCliente.Tag = 0

                Dim numiCuenta As String = frmAyuda.filaSelect.Cells("canumi").Value
                Dim cod As String = frmAyuda.filaSelect.Cells("cacta").Value
                Dim desc As String = frmAyuda.filaSelect.Cells("cadesc").Value
                Dim isCobrar As Integer = frmAyuda.filaSelect.Cells("isCobrar").Value
                Dim isPagar As Integer = frmAyuda.filaSelect.Cells("isPagar").Value

                tbCuenta.Text = desc
                tbNumi.Text = cod
                tbNumi.Tag = numiCuenta
                If isCobrar = 1 Or isPagar = 1 Then
                    tbCliente.Enabled = True
                    tbCliente.Visible = True
                    LabelX5.Visible = True
                    If isCobrar = 1 Then
                        _cobrarPagar = 1
                    Else
                        _cobrarPagar = 2
                    End If
                Else
                    tbCliente.Enabled = False
                    tbCliente.Visible = False
                    LabelX5.Visible = False


                    tbCliente.Text = ""
                    tbCliente.Tag = 0
                End If

            Else
                tbNumi.Text = ""
                tbNumi.Tag = 0
                tbCuenta.Text = ""

                tbCliente.Enabled = False
                tbCliente.Visible = False
                LabelX5.Visible = False

                tbCliente.Text = ""
                tbCliente.Tag = 0
            End If

        End If
    End Sub

    Private Sub PR_LibroMayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If _modo = 0 Then
            _modulo.Select()
            _tab.Close()
        Else
            Close()

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If tbMoneda.Value = 2 Then
            _prImprimirHorizontal()
        Else
            _prImprimir()

        End If
    End Sub

    Private Sub tbCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCliente.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            Dim frmAyuda As Modelos.ModeloAyuda
            Dim dt As DataTable

            If _cobrarPagar = 1 Then
                dt = L_prClientesComprobante(1, tbNumi.Tag)

            Else
                dt = L_prClientesComprobante(2, tbNumi.Tag)

            End If
            Dim listEstCeldas As New List(Of Modelos.Celda)
            listEstCeldas.Add(New Modelos.Celda("cjnumi", False))
            listEstCeldas.Add(New Modelos.Celda("cjci", True, "ci".ToUpper, 100))
            listEstCeldas.Add(New Modelos.Celda("cjnombre", True, "nombre".ToUpper, 300))
            listEstCeldas.Add(New Modelos.Celda("cjtipo", False))


            frmAyuda = New Modelos.ModeloAyuda(0, 0, dt, "seleccione cliente".ToUpper, listEstCeldas)
            frmAyuda.ShowDialog()

            If frmAyuda.seleccionado = True Then
                Dim numiCliente As String = frmAyuda.filaSelect.Cells("cjnumi").Value
                Dim desc As String = frmAyuda.filaSelect.Cells("cjnombre").Value

                tbCliente.Text = desc
                tbCliente.Tag = numiCliente

            Else
                tbCliente.Text = ""
                tbCliente.Tag = 0
            End If

        End If
    End Sub

    Private Sub grDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles grDetalle.KeyDown
        Dim f As Integer = grDetalle.Row
        Dim c As Integer = grDetalle.Col
        If e.KeyData = Keys.Control + Keys.Enter Then
            If f >= 0 And IsDBNull(grDetalle.GetValue("oanumi")) = False Then
                If grDetalle.GetValue("oanumi") > 0 Then
                    Dim objrep As New R_Comprobante
                    Dim dt As New DataTable
                    dt = L_prComprobanteReporteComprobante(grDetalle.GetValue("oanumi"))

                    'ahora lo mando al visualizador
                    P_Global.Visualizador = New Visualizador
                    objrep.SetDataSource(dt)
                    objrep.SetParameterValue("fechaDesde", "")
                    objrep.SetParameterValue("fechaHasta", "")
                    objrep.SetParameterValue("titulo", "AUTOMOVIL CLUB BOLIVIANO " + gs_empresaDescSistema.ToUpper)
                    objrep.SetParameterValue("nit", gs_empresaNit.ToUpper)
                    objrep.SetParameterValue("ultimoRegistro", 0)

                    P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
                    P_Global.Visualizador.Show() 'Comentar
                    P_Global.Visualizador.BringToFront() 'Comentar
                End If


            End If

        End If
    End Sub

    Private Sub tbMeses_ValueChanged(sender As Object, e As EventArgs) Handles tbMeses.ValueChanged
        grDetalle.DataSource = Nothing
    End Sub

    Private Sub tbFiltrarRef_ValueChanged(sender As Object, e As EventArgs) Handles tbFiltrarRef.ValueChanged
        tbReferencia.Enabled = tbFiltrarRef.Value
        grDetalle.DataSource = Nothing

    End Sub
End Class