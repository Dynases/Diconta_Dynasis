﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1_ServicioVenta
    Inherits Modelos.ModeloF00

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_ServicioVenta))
        Dim SuperTabColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabColorTable = New DevComponents.DotNetBar.Rendering.SuperTabColorTable()
        Dim swTipoVenta_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim tbEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbEstadoFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbsector_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.PanelTotal = New System.Windows.Forms.Panel()
        Me.GroupPanelFactura = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.QrFactura = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.TbNit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.TbNombre1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.tbSubTotal = New DevComponents.Editors.DoubleInput()
        Me.tbMdesc = New DevComponents.Editors.DoubleInput()
        Me.tbtotal = New DevComponents.Editors.DoubleInput()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.tbPdesc = New DevComponents.Editors.DoubleInput()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.PanelDetalle = New System.Windows.Forms.Panel()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.grdetalle = New Janus.Windows.GridEX.GridEX()
        Me.GPanelProductos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.grServicios = New Janus.Windows.GridEX.GridEX()
        Me.PanelContentSup = New System.Windows.Forms.Panel()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.GroupPanelFactura2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.tbCodigoControl = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.dtiFechaFactura = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.tbNroFactura = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbNroAutoriz = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.swTipoVenta = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.tbEstado = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cbEstadoFactura = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.tbanular = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.tbTipoVenta = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.cbsector = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.tbsecnumi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.lbCredito = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.tbFechaVenc = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.tbFechaVenta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.tbObservacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbobservacion = New DevComponents.DotNetBar.LabelX()
        Me.tbCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelVentas = New System.Windows.Forms.Panel()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.grVentas = New Janus.Windows.GridEX.GridEX()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ELIMINARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CachedR_ArqueoResumen1 = New Presentacion.CachedR_ArqueoResumen()
        Me.swreporte = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.CbOP = New System.Windows.Forms.CheckBox()
        Me.tbCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelToolBar2.SuspendLayout()
        Me.PanelPrincipal.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MSuperTabControlPanel1.SuspendLayout()
        CType(Me.MSuperTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSuperTabControl.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBuscador.SuspendLayout()
        Me.PanelTotal.SuspendLayout()
        Me.GroupPanelFactura.SuspendLayout()
        CType(Me.QrFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.tbSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMdesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPdesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetalle.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.grdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPanelProductos.SuspendLayout()
        CType(Me.grServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContentSup.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.GroupPanelFactura2.SuspendLayout()
        CType(Me.dtiFechaFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.swTipoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEstadoFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbsector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaVenc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelVentas.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.grVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.CbOP)
        Me.PanelSuperior.Controls.Add(Me.swreporte)
        Me.MHighlighterFocus.SetHighlightOnFocus(Me.PanelSuperior, True)
        Me.PanelSuperior.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PanelSuperior.Size = New System.Drawing.Size(1364, 89)
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.Style.BackgroundImage = CType(resources.GetObject("PanelSuperior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        Me.PanelSuperior.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PanelSuperior.StyleMouseOver.BackgroundImage = CType(resources.GetObject("PanelSuperior.StyleMouseOver.BackgroundImage"), System.Drawing.Image)
        Me.PanelSuperior.TabIndex = 6
        Me.PanelSuperior.Controls.SetChildIndex(Me.PanelToolBar1, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.PanelToolBar2, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.MRlAccion, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.swreporte, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.CbOP, 0)
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 702)
        Me.PanelInferior.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelInferior.Size = New System.Drawing.Size(1364, 48)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.PanelInferior.Style.BackgroundImage = CType(resources.GetObject("PanelInferior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        '
        'BubbleBarUsuario
        '
        '
        '
        '
        Me.BubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'TxtNombreUsu
        '
        Me.TxtNombreUsu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombreUsu.ReadOnly = True
        Me.TxtNombreUsu.Size = New System.Drawing.Size(179, 27)
        Me.TxtNombreUsu.Text = "DEFAULT"
        '
        'PanelToolBar1
        '
        Me.PanelToolBar1.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.TabIndex = 11
        '
        'btnGrabar
        '
        Me.btnGrabar.TabIndex = 10
        '
        'btnEliminar
        '
        Me.btnEliminar.TabIndex = 3
        '
        'btnModificar
        '
        Me.btnModificar.TabIndex = 2
        '
        'btnNuevo
        '
        Me.btnNuevo.TabIndex = 1
        '
        'PanelToolBar2
        '
        Me.PanelToolBar2.Location = New System.Drawing.Point(1257, 0)
        Me.PanelToolBar2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PanelToolBar2.TabIndex = 0
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelPrincipal.Size = New System.Drawing.Size(1364, 750)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.PanelInferior, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.PanelUsuario, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.PanelSuperior, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.Panel1, 0)
        '
        'btnImprimir
        '
        Me.btnImprimir.TabIndex = 0
        '
        'btnUltimo
        '
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(49, 26, 49, 26)
        '
        'btnSiguiente
        '
        '
        'btnAnterior
        '
        '
        'btnPrimero
        '
        '
        'MPanelUserAct
        '
        Me.MPanelUserAct.Location = New System.Drawing.Point(1097, 0)
        Me.MPanelUserAct.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        'MRlAccion
        '
        '
        '
        '
        Me.MRlAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MRlAccion.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MRlAccion.Size = New System.Drawing.Size(756, 89)
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.PanelTotal)
        Me.PanelContent.Controls.Add(Me.PanelDetalle)
        Me.PanelContent.Controls.Add(Me.PanelContentSup)
        Me.PanelContent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelContent.Size = New System.Drawing.Size(1327, 613)
        '
        'Panel1
        '
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Size = New System.Drawing.Size(1364, 613)
        '
        'MSuperTabControlPanel1
        '
        Me.MSuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MSuperTabControlPanel1.Size = New System.Drawing.Size(1327, 613)
        '
        'MSuperTabControl
        '
        '
        '
        '
        '
        '
        '
        Me.MSuperTabControl.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.MSuperTabControl.ControlBox.MenuBox.Name = ""
        Me.MSuperTabControl.ControlBox.Name = ""
        Me.MSuperTabControl.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MSuperTabControl.ControlBox.MenuBox, Me.MSuperTabControl.ControlBox.CloseBox})
        Me.MSuperTabControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MSuperTabControl.SelectedTabIndex = 1
        Me.MSuperTabControl.Size = New System.Drawing.Size(1364, 613)
        Me.MSuperTabControl.Controls.SetChildIndex(Me.MSuperTabControlPanel1, 0)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(892, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        'PanelBuscador
        '
        Me.PanelBuscador.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelBuscador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelBuscador.Size = New System.Drawing.Size(1275, 579)
        '
        'PanelTotal
        '
        Me.PanelTotal.AutoScroll = True
        Me.PanelTotal.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelTotal.Controls.Add(Me.GroupPanelFactura)
        Me.PanelTotal.Controls.Add(Me.Panel4)
        Me.PanelTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelTotal.Location = New System.Drawing.Point(0, 473)
        Me.PanelTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelTotal.Name = "PanelTotal"
        Me.PanelTotal.Size = New System.Drawing.Size(1327, 140)
        Me.PanelTotal.TabIndex = 2
        '
        'GroupPanelFactura
        '
        Me.GroupPanelFactura.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelFactura.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelFactura.Controls.Add(Me.QrFactura)
        Me.GroupPanelFactura.Controls.Add(Me.TbNit)
        Me.GroupPanelFactura.Controls.Add(Me.LabelX12)
        Me.GroupPanelFactura.Controls.Add(Me.TbNombre1)
        Me.GroupPanelFactura.Controls.Add(Me.LabelX6)
        Me.GroupPanelFactura.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelFactura.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupPanelFactura.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanelFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanelFactura.Name = "GroupPanelFactura"
        Me.GroupPanelFactura.Size = New System.Drawing.Size(649, 174)
        '
        '
        '
        Me.GroupPanelFactura.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelFactura.Style.BackColorGradientAngle = 90
        Me.GroupPanelFactura.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelFactura.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFactura.Style.BorderBottomWidth = 1
        Me.GroupPanelFactura.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelFactura.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFactura.Style.BorderLeftWidth = 1
        Me.GroupPanelFactura.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFactura.Style.BorderRightWidth = 1
        Me.GroupPanelFactura.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFactura.Style.BorderTopWidth = 1
        Me.GroupPanelFactura.Style.CornerDiameter = 4
        Me.GroupPanelFactura.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelFactura.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelFactura.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelFactura.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelFactura.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelFactura.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelFactura.TabIndex = 40
        Me.GroupPanelFactura.Text = "DATOS FACTURA"
        '
        'QrFactura
        '
        Me.QrFactura.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.QrFactura.Image = CType(resources.GetObject("QrFactura.Image"), System.Drawing.Image)
        Me.QrFactura.Location = New System.Drawing.Point(507, 2)
        Me.QrFactura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QrFactura.Name = "QrFactura"
        Me.QrFactura.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.QrFactura.Size = New System.Drawing.Size(127, 111)
        Me.QrFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QrFactura.TabIndex = 22
        Me.QrFactura.TabStop = False
        Me.QrFactura.Text = "QrCodeImgControl1"
        '
        'TbNit
        '
        '
        '
        '
        Me.TbNit.Border.Class = "TextBoxBorder"
        Me.TbNit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbNit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNit.Location = New System.Drawing.Point(140, 6)
        Me.TbNit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbNit.MaxLength = 20
        Me.TbNit.Name = "TbNit"
        Me.TbNit.PreventEnterBeep = True
        Me.TbNit.Size = New System.Drawing.Size(200, 26)
        Me.TbNit.TabIndex = 0
        Me.TbNit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelX12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelX12.Location = New System.Drawing.Point(12, 39)
        Me.LabelX12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(120, 28)
        Me.LabelX12.TabIndex = 3
        Me.LabelX12.Text = "Razon Social:"
        '
        'TbNombre1
        '
        '
        '
        '
        Me.TbNombre1.Border.Class = "TextBoxBorder"
        Me.TbNombre1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbNombre1.Location = New System.Drawing.Point(140, 42)
        Me.TbNombre1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbNombre1.MaxLength = 100
        Me.TbNombre1.Multiline = True
        Me.TbNombre1.Name = "TbNombre1"
        Me.TbNombre1.PreventEnterBeep = True
        Me.TbNombre1.Size = New System.Drawing.Size(360, 62)
        Me.TbNombre1.TabIndex = 1
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelX6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelX6.Location = New System.Drawing.Point(12, 4)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(120, 28)
        Me.LabelX6.TabIndex = 0
        Me.LabelX6.Text = "Nit:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.LabelX13)
        Me.Panel4.Controls.Add(Me.tbSubTotal)
        Me.Panel4.Controls.Add(Me.tbMdesc)
        Me.Panel4.Controls.Add(Me.tbtotal)
        Me.Panel4.Controls.Add(Me.LabelX8)
        Me.Panel4.Controls.Add(Me.LabelX11)
        Me.Panel4.Controls.Add(Me.tbPdesc)
        Me.Panel4.Controls.Add(Me.LabelX9)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(798, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(508, 174)
        Me.Panel4.TabIndex = 39
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.ForeColor = System.Drawing.Color.White
        Me.LabelX13.Location = New System.Drawing.Point(53, 9)
        Me.LabelX13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX13.Size = New System.Drawing.Size(115, 22)
        Me.LabelX13.TabIndex = 42
        Me.LabelX13.Text = "Sub Total:"
        '
        'tbSubTotal
        '
        '
        '
        '
        Me.tbSubTotal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbSubTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbSubTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSubTotal.Increment = 1.0R
        Me.tbSubTotal.Location = New System.Drawing.Point(196, 6)
        Me.tbSubTotal.LockUpdateChecked = False
        Me.tbSubTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbSubTotal.MinValue = 0R
        Me.tbSubTotal.Name = "tbSubTotal"
        Me.tbSubTotal.Size = New System.Drawing.Size(119, 24)
        Me.tbSubTotal.TabIndex = 2
        Me.tbSubTotal.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'tbMdesc
        '
        '
        '
        '
        Me.tbMdesc.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbMdesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbMdesc.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbMdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMdesc.Increment = 1.0R
        Me.tbMdesc.Location = New System.Drawing.Point(196, 70)
        Me.tbMdesc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbMdesc.MinValue = 0R
        Me.tbMdesc.Name = "tbMdesc"
        Me.tbMdesc.Size = New System.Drawing.Size(119, 24)
        Me.tbMdesc.TabIndex = 2
        Me.tbMdesc.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'tbtotal
        '
        '
        '
        '
        Me.tbtotal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbtotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbtotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtotal.Increment = 1.0R
        Me.tbtotal.Location = New System.Drawing.Point(196, 98)
        Me.tbtotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbtotal.MinValue = 0R
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.Size = New System.Drawing.Size(119, 24)
        Me.tbtotal.TabIndex = 4
        Me.tbtotal.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.White
        Me.LabelX8.Location = New System.Drawing.Point(53, 43)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX8.Size = New System.Drawing.Size(115, 22)
        Me.LabelX8.TabIndex = 34
        Me.LabelX8.Text = "P. Descuento:"
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.Color.White
        Me.LabelX11.Location = New System.Drawing.Point(53, 103)
        Me.LabelX11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX11.Size = New System.Drawing.Size(100, 22)
        Me.LabelX11.TabIndex = 38
        Me.LabelX11.Text = "Total Neto:"
        '
        'tbPdesc
        '
        '
        '
        '
        Me.tbPdesc.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbPdesc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbPdesc.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbPdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPdesc.Increment = 1.0R
        Me.tbPdesc.Location = New System.Drawing.Point(196, 39)
        Me.tbPdesc.LockUpdateChecked = False
        Me.tbPdesc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPdesc.MinValue = 0R
        Me.tbPdesc.Name = "tbPdesc"
        Me.tbPdesc.Size = New System.Drawing.Size(119, 24)
        Me.tbPdesc.TabIndex = 1
        Me.tbPdesc.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.White
        Me.LabelX9.Location = New System.Drawing.Point(53, 73)
        Me.LabelX9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX9.Size = New System.Drawing.Size(135, 22)
        Me.LabelX9.TabIndex = 36
        Me.LabelX9.Text = "M. Descuento:"
        '
        'PanelDetalle
        '
        Me.PanelDetalle.BackColor = System.Drawing.Color.White
        Me.PanelDetalle.Controls.Add(Me.GroupPanel4)
        Me.PanelDetalle.Controls.Add(Me.GPanelProductos)
        Me.PanelDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetalle.Location = New System.Drawing.Point(0, 324)
        Me.PanelDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelDetalle.Name = "PanelDetalle"
        Me.PanelDetalle.Size = New System.Drawing.Size(1327, 289)
        Me.PanelDetalle.TabIndex = 3
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.Panel5)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(1327, 39)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel4.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 0
        Me.GroupPanel4.Text = "DETALLE DE LA VENTA"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.grdetalle)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1321, 12)
        Me.Panel5.TabIndex = 0
        '
        'grdetalle
        '
        Me.grdetalle.BackColor = System.Drawing.Color.GhostWhite
        Me.grdetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdetalle.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdetalle.Location = New System.Drawing.Point(0, 0)
        Me.grdetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdetalle.Name = "grdetalle"
        Me.grdetalle.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grdetalle.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grdetalle.Size = New System.Drawing.Size(1321, 12)
        Me.grdetalle.TabIndex = 0
        Me.grdetalle.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GPanelProductos
        '
        Me.GPanelProductos.CanvasColor = System.Drawing.SystemColors.Control
        Me.GPanelProductos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GPanelProductos.Controls.Add(Me.grServicios)
        Me.GPanelProductos.DisabledBackColor = System.Drawing.Color.Empty
        Me.GPanelProductos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GPanelProductos.Location = New System.Drawing.Point(0, 39)
        Me.GPanelProductos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPanelProductos.Name = "GPanelProductos"
        Me.GPanelProductos.Size = New System.Drawing.Size(1327, 250)
        '
        '
        '
        Me.GPanelProductos.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GPanelProductos.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GPanelProductos.Style.BackColorGradientAngle = 90
        Me.GPanelProductos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderBottomWidth = 1
        Me.GPanelProductos.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GPanelProductos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderLeftWidth = 1
        Me.GPanelProductos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderRightWidth = 1
        Me.GPanelProductos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GPanelProductos.Style.BorderTopWidth = 1
        Me.GPanelProductos.Style.CornerDiameter = 4
        Me.GPanelProductos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GPanelProductos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GPanelProductos.Style.TextColor = System.Drawing.Color.White
        Me.GPanelProductos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GPanelProductos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GPanelProductos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GPanelProductos.TabIndex = 2
        Me.GPanelProductos.Text = "SERVICIOS"
        '
        'grServicios
        '
        Me.grServicios.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grServicios.BackColor = System.Drawing.Color.GhostWhite
        Me.grServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grServicios.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grServicios.Location = New System.Drawing.Point(0, 0)
        Me.grServicios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grServicios.Name = "grServicios"
        Me.grServicios.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grServicios.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grServicios.Size = New System.Drawing.Size(1321, 223)
        Me.grServicios.TabIndex = 1
        Me.grServicios.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'PanelContentSup
        '
        Me.PanelContentSup.BackColor = System.Drawing.Color.White
        Me.PanelContentSup.Controls.Add(Me.SuperTabControl1)
        Me.PanelContentSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelContentSup.Location = New System.Drawing.Point(0, 0)
        Me.PanelContentSup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelContentSup.Name = "PanelContentSup"
        Me.PanelContentSup.Size = New System.Drawing.Size(1327, 324)
        Me.PanelContentSup.TabIndex = 4
        '
        'SuperTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(1327, 324)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 246
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1})
        SuperTabColorTable1.InnerBorder = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SuperTabControl1.TabStripColor = SuperTabColorTable1
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.GroupPanelFactura2)
        Me.SuperTabControlPanel1.Controls.Add(Me.Panel2)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 29)
        Me.SuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(1327, 295)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'GroupPanelFactura2
        '
        Me.GroupPanelFactura2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelFactura2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelFactura2.Controls.Add(Me.tbCodigoControl)
        Me.GroupPanelFactura2.Controls.Add(Me.LabelX16)
        Me.GroupPanelFactura2.Controls.Add(Me.dtiFechaFactura)
        Me.GroupPanelFactura2.Controls.Add(Me.tbNroFactura)
        Me.GroupPanelFactura2.Controls.Add(Me.tbNroAutoriz)
        Me.GroupPanelFactura2.Controls.Add(Me.LabelX15)
        Me.GroupPanelFactura2.Controls.Add(Me.LabelX14)
        Me.GroupPanelFactura2.Controls.Add(Me.LabelX7)
        Me.GroupPanelFactura2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelFactura2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelFactura2.Location = New System.Drawing.Point(1104, 0)
        Me.GroupPanelFactura2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanelFactura2.Name = "GroupPanelFactura2"
        Me.GroupPanelFactura2.Size = New System.Drawing.Size(223, 295)
        '
        '
        '
        Me.GroupPanelFactura2.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanelFactura2.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanelFactura2.Style.BackColorGradientAngle = 90
        Me.GroupPanelFactura2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFactura2.Style.BorderBottomWidth = 1
        Me.GroupPanelFactura2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelFactura2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFactura2.Style.BorderLeftWidth = 1
        Me.GroupPanelFactura2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFactura2.Style.BorderRightWidth = 1
        Me.GroupPanelFactura2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFactura2.Style.BorderTopWidth = 1
        Me.GroupPanelFactura2.Style.CornerDiameter = 4
        Me.GroupPanelFactura2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelFactura2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelFactura2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelFactura2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelFactura2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelFactura2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelFactura2.TabIndex = 236
        Me.GroupPanelFactura2.Text = "DATOS FACTURACIÓN"
        '
        'tbCodigoControl
        '
        '
        '
        '
        Me.tbCodigoControl.Border.Class = "TextBoxBorder"
        Me.tbCodigoControl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodigoControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigoControl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbCodigoControl.Location = New System.Drawing.Point(185, 112)
        Me.tbCodigoControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCodigoControl.Name = "tbCodigoControl"
        Me.tbCodigoControl.PreventEnterBeep = True
        Me.tbCodigoControl.Size = New System.Drawing.Size(160, 26)
        Me.tbCodigoControl.TabIndex = 243
        Me.tbCodigoControl.TabStop = False
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX16.Location = New System.Drawing.Point(4, 111)
        Me.LabelX16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX16.Size = New System.Drawing.Size(173, 28)
        Me.LabelX16.TabIndex = 242
        Me.LabelX16.Text = "Código de Control:"
        '
        'dtiFechaFactura
        '
        '
        '
        '
        Me.dtiFechaFactura.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiFechaFactura.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaFactura.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiFechaFactura.ButtonDropDown.Visible = True
        Me.dtiFechaFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtiFechaFactura.IsPopupCalendarOpen = False
        Me.dtiFechaFactura.Location = New System.Drawing.Point(185, 39)
        Me.dtiFechaFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        '
        '
        '
        '
        '
        Me.dtiFechaFactura.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaFactura.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtiFechaFactura.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiFechaFactura.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaFactura.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.dtiFechaFactura.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtiFechaFactura.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiFechaFactura.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaFactura.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiFechaFactura.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaFactura.MonthCalendar.TodayButtonVisible = True
        Me.dtiFechaFactura.Name = "dtiFechaFactura"
        Me.dtiFechaFactura.Size = New System.Drawing.Size(160, 26)
        Me.dtiFechaFactura.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiFechaFactura.TabIndex = 241
        Me.dtiFechaFactura.TabStop = False
        '
        'tbNroFactura
        '
        '
        '
        '
        Me.tbNroFactura.Border.Class = "TextBoxBorder"
        Me.tbNroFactura.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNroFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNroFactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbNroFactura.Location = New System.Drawing.Point(185, 76)
        Me.tbNroFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbNroFactura.Name = "tbNroFactura"
        Me.tbNroFactura.PreventEnterBeep = True
        Me.tbNroFactura.Size = New System.Drawing.Size(160, 26)
        Me.tbNroFactura.TabIndex = 240
        Me.tbNroFactura.TabStop = False
        Me.tbNroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbNroAutoriz
        '
        '
        '
        '
        Me.tbNroAutoriz.Border.Class = "TextBoxBorder"
        Me.tbNroAutoriz.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNroAutoriz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNroAutoriz.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbNroAutoriz.Location = New System.Drawing.Point(185, 5)
        Me.tbNroAutoriz.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbNroAutoriz.Name = "tbNroAutoriz"
        Me.tbNroAutoriz.PreventEnterBeep = True
        Me.tbNroAutoriz.Size = New System.Drawing.Size(267, 26)
        Me.tbNroAutoriz.TabIndex = 239
        Me.tbNroAutoriz.TabStop = False
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX15.Location = New System.Drawing.Point(4, 75)
        Me.LabelX15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX15.Size = New System.Drawing.Size(173, 28)
        Me.LabelX15.TabIndex = 237
        Me.LabelX15.Text = "Nro. Factura:"
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX14.Location = New System.Drawing.Point(4, 39)
        Me.LabelX14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX14.Size = New System.Drawing.Size(173, 28)
        Me.LabelX14.TabIndex = 233
        Me.LabelX14.Text = "Fecha Factura:"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX7.Location = New System.Drawing.Point(4, 4)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX7.Size = New System.Drawing.Size(173, 28)
        Me.LabelX7.TabIndex = 232
        Me.LabelX7.Text = "Nro de Autorización:"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.tbCliente)
        Me.Panel2.Controls.Add(Me.LabelX2)
        Me.Panel2.Controls.Add(Me.swTipoVenta)
        Me.Panel2.Controls.Add(Me.LabelX20)
        Me.Panel2.Controls.Add(Me.tbEstado)
        Me.Panel2.Controls.Add(Me.cbEstadoFactura)
        Me.Panel2.Controls.Add(Me.tbanular)
        Me.Panel2.Controls.Add(Me.tbTipoVenta)
        Me.Panel2.Controls.Add(Me.LabelX19)
        Me.Panel2.Controls.Add(Me.cbsector)
        Me.Panel2.Controls.Add(Me.tbsecnumi)
        Me.Panel2.Controls.Add(Me.LabelX10)
        Me.Panel2.Controls.Add(Me.lbCredito)
        Me.Panel2.Controls.Add(Me.LabelX5)
        Me.Panel2.Controls.Add(Me.LabelX4)
        Me.Panel2.Controls.Add(Me.tbFechaVenc)
        Me.Panel2.Controls.Add(Me.tbFechaVenta)
        Me.Panel2.Controls.Add(Me.LabelX1)
        Me.Panel2.Controls.Add(Me.tbObservacion)
        Me.Panel2.Controls.Add(Me.lbobservacion)
        Me.Panel2.Controls.Add(Me.tbCodigo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1104, 295)
        Me.Panel2.TabIndex = 234
        '
        'swTipoVenta
        '
        swTipoVenta_DesignTimeLayout.LayoutString = resources.GetString("swTipoVenta_DesignTimeLayout.LayoutString")
        Me.swTipoVenta.DesignTimeLayout = swTipoVenta_DesignTimeLayout
        Me.swTipoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swTipoVenta.Location = New System.Drawing.Point(751, 25)
        Me.swTipoVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.swTipoVenta.Name = "swTipoVenta"
        Me.swTipoVenta.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.swTipoVenta.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.swTipoVenta.SelectedIndex = -1
        Me.swTipoVenta.SelectedItem = Nothing
        Me.swTipoVenta.Size = New System.Drawing.Size(208, 26)
        Me.swTipoVenta.TabIndex = 252
        Me.swTipoVenta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX20
        '
        Me.LabelX20.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX20.Location = New System.Drawing.Point(16, 46)
        Me.LabelX20.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX20.Size = New System.Drawing.Size(151, 28)
        Me.LabelX20.TabIndex = 251
        Me.LabelX20.Text = "Estado:"
        '
        'tbEstado
        '
        tbEstado_DesignTimeLayout.LayoutString = resources.GetString("tbEstado_DesignTimeLayout.LayoutString")
        Me.tbEstado.DesignTimeLayout = tbEstado_DesignTimeLayout
        Me.tbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEstado.Location = New System.Drawing.Point(179, 47)
        Me.tbEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.tbEstado.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.tbEstado.SelectedIndex = -1
        Me.tbEstado.SelectedItem = Nothing
        Me.tbEstado.Size = New System.Drawing.Size(329, 26)
        Me.tbEstado.TabIndex = 250
        Me.tbEstado.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cbEstadoFactura
        '
        cbEstadoFactura_DesignTimeLayout.LayoutString = resources.GetString("cbEstadoFactura_DesignTimeLayout.LayoutString")
        Me.cbEstadoFactura.DesignTimeLayout = cbEstadoFactura_DesignTimeLayout
        Me.cbEstadoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoFactura.Location = New System.Drawing.Point(352, 154)
        Me.cbEstadoFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbEstadoFactura.Name = "cbEstadoFactura"
        Me.cbEstadoFactura.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbEstadoFactura.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbEstadoFactura.SelectedIndex = -1
        Me.cbEstadoFactura.SelectedItem = Nothing
        Me.cbEstadoFactura.Size = New System.Drawing.Size(159, 26)
        Me.cbEstadoFactura.TabIndex = 249
        Me.cbEstadoFactura.Visible = False
        Me.cbEstadoFactura.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'tbanular
        '
        '
        '
        '
        Me.tbanular.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbanular.Location = New System.Drawing.Point(375, 187)
        Me.tbanular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbanular.Name = "tbanular"
        Me.tbanular.OffBackColor = System.Drawing.Color.Crimson
        Me.tbanular.OffText = "ANULADA"
        Me.tbanular.OffTextColor = System.Drawing.Color.White
        Me.tbanular.OnBackColor = System.Drawing.Color.Gold
        Me.tbanular.OnText = "NORMAL"
        Me.tbanular.OnTextColor = System.Drawing.Color.Black
        Me.tbanular.Size = New System.Drawing.Size(133, 28)
        Me.tbanular.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbanular.TabIndex = 248
        Me.tbanular.Value = True
        Me.tbanular.ValueObject = "Y"
        '
        'tbTipoVenta
        '
        '
        '
        '
        Me.tbTipoVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTipoVenta.Location = New System.Drawing.Point(179, 187)
        Me.tbTipoVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbTipoVenta.Name = "tbTipoVenta"
        Me.tbTipoVenta.OffBackColor = System.Drawing.Color.LawnGreen
        Me.tbTipoVenta.OffText = "MANUAL"
        Me.tbTipoVenta.OffTextColor = System.Drawing.Color.Black
        Me.tbTipoVenta.OnBackColor = System.Drawing.Color.Gold
        Me.tbTipoVenta.OnText = "AUTOMATICO"
        Me.tbTipoVenta.OnTextColor = System.Drawing.Color.Black
        Me.tbTipoVenta.Size = New System.Drawing.Size(188, 28)
        Me.tbTipoVenta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbTipoVenta.TabIndex = 246
        Me.tbTipoVenta.Value = True
        Me.tbTipoVenta.ValueObject = "Y"
        '
        'LabelX19
        '
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX19.Location = New System.Drawing.Point(16, 187)
        Me.LabelX19.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(107, 28)
        Me.LabelX19.TabIndex = 247
        Me.LabelX19.Text = "Tipo Venta:"
        '
        'cbsector
        '
        cbsector_DesignTimeLayout.LayoutString = resources.GetString("cbsector_DesignTimeLayout.LayoutString")
        Me.cbsector.DesignTimeLayout = cbsector_DesignTimeLayout
        Me.cbsector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsector.Location = New System.Drawing.Point(179, 115)
        Me.cbsector.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbsector.Name = "cbsector"
        Me.cbsector.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbsector.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbsector.SelectedIndex = -1
        Me.cbsector.SelectedItem = Nothing
        Me.cbsector.Size = New System.Drawing.Size(155, 26)
        Me.cbsector.TabIndex = 1
        Me.cbsector.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'tbsecnumi
        '
        Me.tbsecnumi.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbsecnumi.Border.Class = "TextBoxBorder"
        Me.tbsecnumi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbsecnumi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsecnumi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbsecnumi.Location = New System.Drawing.Point(352, 119)
        Me.tbsecnumi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbsecnumi.Name = "tbsecnumi"
        Me.tbsecnumi.PreventEnterBeep = True
        Me.tbsecnumi.Size = New System.Drawing.Size(84, 26)
        Me.tbsecnumi.TabIndex = 2
        Me.tbsecnumi.Visible = False
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX10.Location = New System.Drawing.Point(16, 117)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX10.Size = New System.Drawing.Size(151, 28)
        Me.LabelX10.TabIndex = 240
        Me.LabelX10.Text = "Tipo:"
        '
        'lbCredito
        '
        Me.lbCredito.AutoSize = True
        Me.lbCredito.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCredito.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCredito.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbCredito.Location = New System.Drawing.Point(532, 60)
        Me.lbCredito.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbCredito.Name = "lbCredito"
        Me.lbCredito.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCredito.Size = New System.Drawing.Size(193, 20)
        Me.lbCredito.TabIndex = 233
        Me.lbCredito.Text = "Vencimiento De Credito:"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX5.Location = New System.Drawing.Point(533, 17)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX5.Size = New System.Drawing.Size(172, 28)
        Me.LabelX5.TabIndex = 232
        Me.LabelX5.Text = "Tipo Venta:"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(17, 154)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX4.Size = New System.Drawing.Size(103, 20)
        Me.LabelX4.TabIndex = 231
        Me.LabelX4.Text = "Fecha Venta:"
        '
        'tbFechaVenc
        '
        '
        '
        '
        Me.tbFechaVenc.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaVenc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaVenc.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaVenc.ButtonDropDown.Visible = True
        Me.tbFechaVenc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaVenc.IsPopupCalendarOpen = False
        Me.tbFechaVenc.Location = New System.Drawing.Point(751, 58)
        Me.tbFechaVenc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        '
        '
        '
        '
        '
        Me.tbFechaVenc.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaVenc.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaVenc.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaVenc.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaVenc.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaVenc.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaVenc.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaVenc.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaVenc.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaVenc.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaVenc.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.tbFechaVenc.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaVenc.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaVenc.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaVenc.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaVenc.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaVenc.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaVenc.Name = "tbFechaVenc"
        Me.tbFechaVenc.Size = New System.Drawing.Size(160, 26)
        Me.tbFechaVenc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaVenc.TabIndex = 6
        Me.tbFechaVenc.Visible = False
        '
        'tbFechaVenta
        '
        '
        '
        '
        Me.tbFechaVenta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaVenta.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaVenta.ButtonDropDown.Visible = True
        Me.tbFechaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaVenta.IsPopupCalendarOpen = False
        Me.tbFechaVenta.Location = New System.Drawing.Point(179, 154)
        Me.tbFechaVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        '
        '
        '
        '
        '
        Me.tbFechaVenta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaVenta.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaVenta.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaVenta.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.tbFechaVenta.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaVenta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaVenta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaVenta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaVenta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaVenta.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaVenta.Name = "tbFechaVenta"
        Me.tbFechaVenta.Size = New System.Drawing.Size(160, 26)
        Me.tbFechaVenta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaVenta.TabIndex = 5
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(17, 17)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX1.Size = New System.Drawing.Size(62, 20)
        Me.LabelX1.TabIndex = 224
        Me.LabelX1.Text = "Código:"
        '
        'tbObservacion
        '
        Me.tbObservacion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbObservacion.Border.Class = "TextBoxBorder"
        Me.tbObservacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbObservacion.Location = New System.Drawing.Point(751, 89)
        Me.tbObservacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbObservacion.Multiline = True
        Me.tbObservacion.Name = "tbObservacion"
        Me.tbObservacion.PreventEnterBeep = True
        Me.tbObservacion.ReadOnly = True
        Me.tbObservacion.Size = New System.Drawing.Size(360, 52)
        Me.tbObservacion.TabIndex = 7
        '
        'lbobservacion
        '
        Me.lbobservacion.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbobservacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbobservacion.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbobservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbobservacion.Location = New System.Drawing.Point(533, 89)
        Me.lbobservacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbobservacion.Name = "lbobservacion"
        Me.lbobservacion.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbobservacion.Size = New System.Drawing.Size(120, 27)
        Me.lbobservacion.TabIndex = 226
        Me.lbobservacion.Text = "Observacion:"
        '
        'tbCodigo
        '
        '
        '
        '
        Me.tbCodigo.Border.Class = "TextBoxBorder"
        Me.tbCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbCodigo.Location = New System.Drawing.Point(179, 14)
        Me.tbCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.PreventEnterBeep = True
        Me.tbCodigo.Size = New System.Drawing.Size(84, 26)
        Me.tbCodigo.TabIndex = 0
        Me.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "DATOS GENERALES"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelVentas, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 713.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1275, 579)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'PanelVentas
        '
        Me.PanelVentas.AutoScroll = True
        Me.PanelVentas.BackColor = System.Drawing.Color.White
        Me.PanelVentas.Controls.Add(Me.GroupPanel2)
        Me.PanelVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVentas.Location = New System.Drawing.Point(4, 4)
        Me.PanelVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelVentas.Name = "PanelVentas"
        Me.PanelVentas.Size = New System.Drawing.Size(1267, 571)
        Me.PanelVentas.TabIndex = 0
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Panel6)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1267, 571)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel2.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 3
        Me.GroupPanel2.Text = "BUSCADOR  VENTAS"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.grVentas)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1261, 544)
        Me.Panel6.TabIndex = 0
        '
        'grVentas
        '
        Me.grVentas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grVentas.BackColor = System.Drawing.Color.GhostWhite
        Me.grVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grVentas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grVentas.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.grVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grVentas.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle
        Me.grVentas.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grVentas.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grVentas.Location = New System.Drawing.Point(0, 0)
        Me.grVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grVentas.Name = "grVentas"
        Me.grVentas.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grVentas.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grVentas.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.grVentas.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grVentas.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.grVentas.SelectOnExpand = False
        Me.grVentas.Size = New System.Drawing.Size(1261, 544)
        Me.grVentas.TabIndex = 0
        Me.grVentas.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ELIMINARToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(158, 40)
        '
        'ELIMINARToolStripMenuItem
        '
        Me.ELIMINARToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.elim_fila2
        Me.ELIMINARToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ELIMINARToolStripMenuItem.Name = "ELIMINARToolStripMenuItem"
        Me.ELIMINARToolStripMenuItem.Size = New System.Drawing.Size(157, 36)
        Me.ELIMINARToolStripMenuItem.Text = "ELIMINAR"
        '
        'swreporte
        '
        '
        '
        '
        Me.swreporte.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swreporte.Dock = System.Windows.Forms.DockStyle.Right
        Me.swreporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swreporte.Location = New System.Drawing.Point(632, 0)
        Me.swreporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.swreporte.Name = "swreporte"
        Me.swreporte.OffBackColor = System.Drawing.Color.DodgerBlue
        Me.swreporte.OffText = "Reporte Media Carta"
        Me.swreporte.OffTextColor = System.Drawing.Color.White
        Me.swreporte.OnBackColor = System.Drawing.Color.Gold
        Me.swreporte.OnText = "Reporte Carta"
        Me.swreporte.OnTextColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.swreporte.Padding = New System.Windows.Forms.Padding(0, 20, 0, 20)
        Me.swreporte.Size = New System.Drawing.Size(260, 89)
        Me.swreporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swreporte.TabIndex = 254
        Me.swreporte.Visible = False
        '
        'CbOP
        '
        Me.CbOP.AutoSize = True
        Me.CbOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbOP.ForeColor = System.Drawing.Color.White
        Me.CbOP.Location = New System.Drawing.Point(645, 0)
        Me.CbOP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbOP.Name = "CbOP"
        Me.CbOP.Size = New System.Drawing.Size(81, 21)
        Me.CbOP.TabIndex = 255
        Me.CbOP.Text = "Optimo"
        Me.CbOP.UseVisualStyleBackColor = True
        Me.CbOP.Visible = False
        '
        'tbCliente
        '
        Me.tbCliente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbCliente.Border.Class = "TextBoxBorder"
        Me.tbCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbCliente.Location = New System.Drawing.Point(179, 81)
        Me.tbCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.PreventEnterBeep = True
        Me.tbCliente.Size = New System.Drawing.Size(332, 26)
        Me.tbCliente.TabIndex = 253
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(16, 82)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX2.Size = New System.Drawing.Size(151, 28)
        Me.LabelX2.TabIndex = 254
        Me.LabelX2.Text = "Cliente:"
        '
        'F1_ServicioVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 750)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "F1_ServicioVenta"
        Me.Text = "F1_ServicioVenta"
        Me.Controls.SetChildIndex(Me.PanelPrincipal, 0)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelToolBar2.ResumeLayout(False)
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContent.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MSuperTabControlPanel1.ResumeLayout(False)
        CType(Me.MSuperTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSuperTabControl.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBuscador.ResumeLayout(False)
        Me.PanelTotal.ResumeLayout(False)
        Me.GroupPanelFactura.ResumeLayout(False)
        CType(Me.QrFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.tbSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMdesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPdesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetalle.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.grdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPanelProductos.ResumeLayout(False)
        CType(Me.grServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContentSup.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.GroupPanelFactura2.ResumeLayout(False)
        CType(Me.dtiFechaFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.swTipoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEstadoFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbsector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaVenc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelVentas.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.grVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTotal As System.Windows.Forms.Panel
    Friend WithEvents GroupPanelFactura As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TbNit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbNombre1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbSubTotal As DevComponents.Editors.DoubleInput
    Friend WithEvents tbMdesc As DevComponents.Editors.DoubleInput
    Friend WithEvents tbtotal As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbPdesc As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelDetalle As System.Windows.Forms.Panel
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents grdetalle As Janus.Windows.GridEX.GridEX
    Friend WithEvents PanelContentSup As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupPanelFactura2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents tbCodigoControl As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtiFechaFactura As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents tbNroFactura As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbNroAutoriz As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbCredito As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbFechaVenc As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents tbFechaVenta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbObservacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbobservacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelVentas As System.Windows.Forms.Panel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents grVentas As Janus.Windows.GridEX.GridEX
    Friend WithEvents tbsecnumi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbsector As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents QrFactura As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents grServicios As Janus.Windows.GridEX.GridEX
    Friend WithEvents GPanelProductos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents tbTipoVenta As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbanular As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ELIMINARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbEstadoFactura As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents tbEstado As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents swTipoVenta As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents swreporte As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents CachedR_ArqueoResumen1 As CachedR_ArqueoResumen
    Friend WithEvents CbOP As CheckBox
    Friend WithEvents tbCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
