﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1_Dosificacion
    Inherits Modelos.ModeloF1

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_Dosificacion))
        Dim LabelX4 As DevComponents.DotNetBar.LabelX
        Dim CbCompania_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CbAlmacen_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.GroupPanelDatosGenerales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelExDatosGenerales = New DevComponents.DotNetBar.PanelEx()
        Me.LabelFinal = New DevComponents.DotNetBar.LabelX()
        Me.LbInicial = New DevComponents.DotNetBar.LabelX()
        Me.tbfinal = New DevComponents.Editors.IntegerInput()
        Me.tbinicial = New DevComponents.Editors.IntegerInput()
        Me.swtipo = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.TbNroAutoriz = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TbiSfc = New DevComponents.Editors.IntegerInput()
        Me.TbNota2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.TbLlave = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.SbEstado = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.CbCompania = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.TbCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TbNota1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DtiFechaIni = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.DtiFechaLim = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.TbiNroFactura = New DevComponents.Editors.IntegerInput()
        Me.CbAlmacen = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        LabelX4 = New DevComponents.DotNetBar.LabelX()
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabPrincipal.SuspendLayout()
        Me.SuperTabControlPanelRegistro.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelToolBar2.SuspendLayout()
        Me.MPanelSup.SuspendLayout()
        Me.PanelPrincipal.SuspendLayout()
        Me.GroupPanelBuscador.SuspendLayout()
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelDatosGenerales.SuspendLayout()
        Me.PanelExDatosGenerales.SuspendLayout()
        CType(Me.tbfinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbinicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbiSfc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbCompania, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtiFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtiFechaLim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbiNroFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperTabPrincipal
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.MenuBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabPrincipal.ControlBox.MenuBox, Me.SuperTabPrincipal.ControlBox.CloseBox})
        Me.SuperTabPrincipal.Margin = New System.Windows.Forms.Padding(5)
        Me.SuperTabPrincipal.Size = New System.Drawing.Size(1179, 1037)
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelBuscador, 0)
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelRegistro, 0)
        '
        'SuperTabControlPanelBuscador
        '
        Me.SuperTabControlPanelBuscador.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanelBuscador.Margin = New System.Windows.Forms.Padding(5)
        Me.SuperTabControlPanelBuscador.Size = New System.Drawing.Size(1144, 624)
        '
        'SuperTabControlPanelRegistro
        '
        Me.SuperTabControlPanelRegistro.Margin = New System.Windows.Forms.Padding(5)
        Me.SuperTabControlPanelRegistro.Size = New System.Drawing.Size(1144, 1037)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelSuperior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelInferior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelPrincipal, 0)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelSuperior.Size = New System.Drawing.Size(1144, 89)
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelSuperior.Style.BackgroundImage = CType(resources.GetObject("PanelSuperior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 993)
        Me.PanelInferior.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelInferior.Size = New System.Drawing.Size(1144, 44)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.DarkSlateGray
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
        Me.TxtNombreUsu.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtNombreUsu.Size = New System.Drawing.Size(267, 44)
        '
        'btnSalir
        '
        '
        'btnNuevo
        '
        '
        'PanelToolBar2
        '
        Me.PanelToolBar2.Location = New System.Drawing.Point(1037, 0)
        Me.PanelToolBar2.Margin = New System.Windows.Forms.Padding(5)
        '
        'MPanelSup
        '
        Me.MPanelSup.Controls.Add(Me.GroupPanelDatosGenerales)
        Me.MPanelSup.Margin = New System.Windows.Forms.Padding(5)
        Me.MPanelSup.Size = New System.Drawing.Size(1144, 322)
        Me.MPanelSup.Controls.SetChildIndex(Me.PanelUsuario, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.GroupPanelDatosGenerales, 0)
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelPrincipal.Size = New System.Drawing.Size(1144, 904)
        '
        'GroupPanelBuscador
        '
        Me.GroupPanelBuscador.Location = New System.Drawing.Point(0, 322)
        Me.GroupPanelBuscador.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupPanelBuscador.Size = New System.Drawing.Size(1144, 582)
        '
        '
        '
        Me.GroupPanelBuscador.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.GroupPanelBuscador.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.GroupPanelBuscador.Style.BackColorGradientAngle = 90
        Me.GroupPanelBuscador.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderBottomWidth = 1
        Me.GroupPanelBuscador.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.GroupPanelBuscador.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderLeftWidth = 1
        Me.GroupPanelBuscador.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderRightWidth = 1
        Me.GroupPanelBuscador.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderTopWidth = 1
        Me.GroupPanelBuscador.Style.CornerDiameter = 4
        Me.GroupPanelBuscador.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelBuscador.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelBuscador.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelBuscador.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanelBuscador.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'JGrM_Buscador
        '
        Me.JGrM_Buscador.BackColor = System.Drawing.Color.WhiteSmoke
        Me.JGrM_Buscador.CardBorders = False
        Me.JGrM_Buscador.FlatBorderColor = System.Drawing.Color.DodgerBlue
        Me.JGrM_Buscador.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.GridLineColor = System.Drawing.Color.DodgerBlue
        Me.JGrM_Buscador.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold)
        Me.JGrM_Buscador.HeaderFormatStyle.FontUnderline = Janus.Windows.GridEX.TriState.[False]
        Me.JGrM_Buscador.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.JGrM_Buscador.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.JGrM_Buscador.Margin = New System.Windows.Forms.Padding(5)
        Me.JGrM_Buscador.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGrM_Buscador.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGrM_Buscador.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGrM_Buscador.SelectedFormatStyle.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGrM_Buscador.Size = New System.Drawing.Size(1138, 555)
        Me.JGrM_Buscador.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(171, 0)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(2)
        '
        'MPanelUserAct
        '
        Me.MPanelUserAct.Location = New System.Drawing.Point(877, 0)
        Me.MPanelUserAct.Margin = New System.Windows.Forms.Padding(5)
        '
        'MRlAccion
        '
        '
        '
        '
        Me.MRlAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MRlAccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MRlAccion.Size = New System.Drawing.Size(536, 89)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(685, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        '
        'LabelX4
        '
        '
        '
        '
        LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        LabelX4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        LabelX4.Location = New System.Drawing.Point(4, 111)
        LabelX4.Margin = New System.Windows.Forms.Padding(4)
        LabelX4.Name = "LabelX4"
        LabelX4.Size = New System.Drawing.Size(167, 28)
        LabelX4.TabIndex = 7
        LabelX4.Text = "SFC:"
        '
        'GroupPanelDatosGenerales
        '
        Me.GroupPanelDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelDatosGenerales.Controls.Add(Me.PanelExDatosGenerales)
        Me.GroupPanelDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanelDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanelDatosGenerales.Name = "GroupPanelDatosGenerales"
        Me.GroupPanelDatosGenerales.Size = New System.Drawing.Size(1144, 322)
        '
        '
        '
        Me.GroupPanelDatosGenerales.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelDatosGenerales.Style.BackColorGradientAngle = 90
        Me.GroupPanelDatosGenerales.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelDatosGenerales.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderBottomWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelDatosGenerales.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderLeftWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderRightWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderTopWidth = 1
        Me.GroupPanelDatosGenerales.Style.CornerDiameter = 4
        Me.GroupPanelDatosGenerales.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelDatosGenerales.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelDatosGenerales.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelDatosGenerales.Style.TextColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GroupPanelDatosGenerales.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelDatosGenerales.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelDatosGenerales.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelDatosGenerales.TabIndex = 20
        Me.GroupPanelDatosGenerales.Text = "DATOS GENERALES"
        '
        'PanelExDatosGenerales
        '
        Me.PanelExDatosGenerales.AutoScroll = True
        Me.PanelExDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelFinal)
        Me.PanelExDatosGenerales.Controls.Add(Me.LbInicial)
        Me.PanelExDatosGenerales.Controls.Add(Me.tbfinal)
        Me.PanelExDatosGenerales.Controls.Add(Me.tbinicial)
        Me.PanelExDatosGenerales.Controls.Add(Me.swtipo)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX13)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbNroAutoriz)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbiSfc)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbNota2)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX12)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbLlave)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX1)
        Me.PanelExDatosGenerales.Controls.Add(Me.SbEstado)
        Me.PanelExDatosGenerales.Controls.Add(Me.CbCompania)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX11)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbCodigo)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbNota1)
        Me.PanelExDatosGenerales.Controls.Add(Me.DtiFechaIni)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX10)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX2)
        Me.PanelExDatosGenerales.Controls.Add(Me.DtiFechaLim)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX9)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX3)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX8)
        Me.PanelExDatosGenerales.Controls.Add(LabelX4)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX5)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX7)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX6)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbiNroFactura)
        Me.PanelExDatosGenerales.Controls.Add(Me.CbAlmacen)
        Me.PanelExDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelExDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelExDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.PanelExDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelExDatosGenerales.Name = "PanelExDatosGenerales"
        Me.PanelExDatosGenerales.Size = New System.Drawing.Size(1138, 295)
        Me.PanelExDatosGenerales.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelExDatosGenerales.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.PanelExDatosGenerales.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.PanelExDatosGenerales.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelExDatosGenerales.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelExDatosGenerales.Style.GradientAngle = 90
        Me.PanelExDatosGenerales.TabIndex = 22
        '
        'LabelFinal
        '
        '
        '
        '
        Me.LabelFinal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelFinal.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelFinal.Location = New System.Drawing.Point(588, 254)
        Me.LabelFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelFinal.Name = "LabelFinal"
        Me.LabelFinal.Size = New System.Drawing.Size(96, 28)
        Me.LabelFinal.TabIndex = 31
        Me.LabelFinal.Text = "Nro Final:"
        '
        'LbInicial
        '
        '
        '
        '
        Me.LbInicial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LbInicial.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LbInicial.Location = New System.Drawing.Point(399, 254)
        Me.LbInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.LbInicial.Name = "LbInicial"
        Me.LbInicial.Size = New System.Drawing.Size(96, 28)
        Me.LbInicial.TabIndex = 30
        Me.LbInicial.Text = "Nro Inicial:"
        '
        'tbfinal
        '
        '
        '
        '
        Me.tbfinal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbfinal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbfinal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbfinal.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbfinal.Location = New System.Drawing.Point(692, 254)
        Me.tbfinal.Margin = New System.Windows.Forms.Padding(4)
        Me.tbfinal.MinValue = 0
        Me.tbfinal.Name = "tbfinal"
        Me.tbfinal.Size = New System.Drawing.Size(76, 28)
        Me.tbfinal.TabIndex = 28
        Me.tbfinal.Visible = False
        '
        'tbinicial
        '
        '
        '
        '
        Me.tbinicial.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbinicial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbinicial.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbinicial.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbinicial.Location = New System.Drawing.Point(503, 254)
        Me.tbinicial.Margin = New System.Windows.Forms.Padding(4)
        Me.tbinicial.MinValue = 0
        Me.tbinicial.Name = "tbinicial"
        Me.tbinicial.Size = New System.Drawing.Size(76, 28)
        Me.tbinicial.TabIndex = 26
        Me.tbinicial.Visible = False
        '
        'swtipo
        '
        '
        '
        '
        Me.swtipo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swtipo.Location = New System.Drawing.Point(203, 254)
        Me.swtipo.Margin = New System.Windows.Forms.Padding(4)
        Me.swtipo.Name = "swtipo"
        Me.swtipo.OffBackColor = System.Drawing.Color.LawnGreen
        Me.swtipo.OffText = "MANUAL"
        Me.swtipo.OffTextColor = System.Drawing.Color.Black
        Me.swtipo.OnBackColor = System.Drawing.Color.Gold
        Me.swtipo.OnText = "AUTOMATICO"
        Me.swtipo.OnTextColor = System.Drawing.Color.Black
        Me.swtipo.Size = New System.Drawing.Size(188, 28)
        Me.swtipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swtipo.TabIndex = 24
        Me.swtipo.Value = True
        Me.swtipo.ValueObject = "Y"
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX13.Location = New System.Drawing.Point(4, 254)
        Me.LabelX13.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(107, 28)
        Me.LabelX13.TabIndex = 25
        Me.LabelX13.Text = "Tipo:"
        '
        'TbNroAutoriz
        '
        '
        '
        '
        Me.TbNroAutoriz.Border.Class = "TextBoxBorder"
        Me.TbNroAutoriz.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbNroAutoriz.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNroAutoriz.Location = New System.Drawing.Point(203, 148)
        Me.TbNroAutoriz.Margin = New System.Windows.Forms.Padding(4)
        Me.TbNroAutoriz.MaxLength = 18
        Me.TbNroAutoriz.Name = "TbNroAutoriz"
        Me.TbNroAutoriz.PreventEnterBeep = True
        Me.TbNroAutoriz.Size = New System.Drawing.Size(267, 28)
        Me.TbNroAutoriz.TabIndex = 4
        Me.TbNroAutoriz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbiSfc
        '
        '
        '
        '
        Me.TbiSfc.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TbiSfc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbiSfc.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TbiSfc.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbiSfc.Location = New System.Drawing.Point(203, 111)
        Me.TbiSfc.Margin = New System.Windows.Forms.Padding(4)
        Me.TbiSfc.MinValue = 0
        Me.TbiSfc.Name = "TbiSfc"
        Me.TbiSfc.Size = New System.Drawing.Size(133, 28)
        Me.TbiSfc.TabIndex = 3
        '
        'TbNota2
        '
        '
        '
        '
        Me.TbNota2.Border.Class = "TextBoxBorder"
        Me.TbNota2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbNota2.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNota2.Location = New System.Drawing.Point(568, 146)
        Me.TbNota2.Margin = New System.Windows.Forms.Padding(4)
        Me.TbNota2.MaxLength = 255
        Me.TbNota2.Multiline = True
        Me.TbNota2.Name = "TbNota2"
        Me.TbNota2.PreventEnterBeep = True
        Me.TbNota2.Size = New System.Drawing.Size(533, 64)
        Me.TbNota2.TabIndex = 10
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX12.Location = New System.Drawing.Point(483, 146)
        Me.LabelX12.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(71, 28)
        Me.LabelX12.TabIndex = 23
        Me.LabelX12.Text = "Nota 2:"
        '
        'TbLlave
        '
        '
        '
        '
        Me.TbLlave.Border.Class = "TextBoxBorder"
        Me.TbLlave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbLlave.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbLlave.Location = New System.Drawing.Point(203, 218)
        Me.TbLlave.Margin = New System.Windows.Forms.Padding(4)
        Me.TbLlave.MaxLength = 255
        Me.TbLlave.Name = "TbLlave"
        Me.TbLlave.PreventEnterBeep = True
        Me.TbLlave.Size = New System.Drawing.Size(847, 28)
        Me.TbLlave.TabIndex = 6
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(4, 4)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(167, 28)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Código:"
        '
        'SbEstado
        '
        '
        '
        '
        Me.SbEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SbEstado.Location = New System.Drawing.Point(957, 4)
        Me.SbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.SbEstado.Name = "SbEstado"
        Me.SbEstado.OffText = "INACTIVO"
        Me.SbEstado.OnBackColor = System.Drawing.Color.Gold
        Me.SbEstado.OnText = "ACTIVO"
        Me.SbEstado.OnTextColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SbEstado.Size = New System.Drawing.Size(144, 28)
        Me.SbEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SbEstado.TabIndex = 11
        '
        'CbCompania
        '
        CbCompania_DesignTimeLayout.LayoutString = resources.GetString("CbCompania_DesignTimeLayout.LayoutString")
        Me.CbCompania.DesignTimeLayout = CbCompania_DesignTimeLayout
        Me.CbCompania.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCompania.Location = New System.Drawing.Point(203, 39)
        Me.CbCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.CbCompania.Name = "CbCompania"
        Me.CbCompania.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.CbCompania.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.CbCompania.SelectedIndex = -1
        Me.CbCompania.SelectedItem = Nothing
        Me.CbCompania.Size = New System.Drawing.Size(267, 28)
        Me.CbCompania.TabIndex = 1
        Me.CbCompania.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX11.Location = New System.Drawing.Point(843, 4)
        Me.LabelX11.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(107, 28)
        Me.LabelX11.TabIndex = 20
        Me.LabelX11.Text = "Estado:"
        '
        'TbCodigo
        '
        '
        '
        '
        Me.TbCodigo.Border.Class = "TextBoxBorder"
        Me.TbCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbCodigo.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCodigo.Location = New System.Drawing.Point(203, 4)
        Me.TbCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TbCodigo.Name = "TbCodigo"
        Me.TbCodigo.PreventEnterBeep = True
        Me.TbCodigo.Size = New System.Drawing.Size(133, 28)
        Me.TbCodigo.TabIndex = 0
        '
        'TbNota1
        '
        '
        '
        '
        Me.TbNota1.Border.Class = "TextBoxBorder"
        Me.TbNota1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbNota1.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNota1.Location = New System.Drawing.Point(568, 75)
        Me.TbNota1.Margin = New System.Windows.Forms.Padding(4)
        Me.TbNota1.MaxLength = 255
        Me.TbNota1.Multiline = True
        Me.TbNota1.Name = "TbNota1"
        Me.TbNota1.PreventEnterBeep = True
        Me.TbNota1.Size = New System.Drawing.Size(533, 64)
        Me.TbNota1.TabIndex = 9
        '
        'DtiFechaIni
        '
        '
        '
        '
        Me.DtiFechaIni.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DtiFechaIni.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiFechaIni.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DtiFechaIni.ButtonDropDown.Visible = True
        Me.DtiFechaIni.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtiFechaIni.IsPopupCalendarOpen = False
        Me.DtiFechaIni.Location = New System.Drawing.Point(701, 4)
        Me.DtiFechaIni.Margin = New System.Windows.Forms.Padding(4)
        '
        '
        '
        '
        '
        '
        Me.DtiFechaIni.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiFechaIni.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DtiFechaIni.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DtiFechaIni.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DtiFechaIni.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DtiFechaIni.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DtiFechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DtiFechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DtiFechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DtiFechaIni.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiFechaIni.MonthCalendar.DisplayMonth = New Date(2017, 7, 1, 0, 0, 0, 0)
        Me.DtiFechaIni.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DtiFechaIni.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DtiFechaIni.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DtiFechaIni.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DtiFechaIni.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiFechaIni.MonthCalendar.TodayButtonVisible = True
        Me.DtiFechaIni.Name = "DtiFechaIni"
        Me.DtiFechaIni.Size = New System.Drawing.Size(133, 28)
        Me.DtiFechaIni.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DtiFechaIni.TabIndex = 7
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX10.Location = New System.Drawing.Point(483, 75)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(71, 28)
        Me.LabelX10.TabIndex = 18
        Me.LabelX10.Text = "Nota 1:"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(4, 39)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(167, 28)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Compañia:"
        '
        'DtiFechaLim
        '
        '
        '
        '
        Me.DtiFechaLim.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DtiFechaLim.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiFechaLim.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DtiFechaLim.ButtonDropDown.Visible = True
        Me.DtiFechaLim.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtiFechaLim.IsPopupCalendarOpen = False
        Me.DtiFechaLim.Location = New System.Drawing.Point(701, 39)
        Me.DtiFechaLim.Margin = New System.Windows.Forms.Padding(4)
        '
        '
        '
        '
        '
        '
        Me.DtiFechaLim.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiFechaLim.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DtiFechaLim.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DtiFechaLim.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DtiFechaLim.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DtiFechaLim.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DtiFechaLim.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DtiFechaLim.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DtiFechaLim.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DtiFechaLim.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiFechaLim.MonthCalendar.DisplayMonth = New Date(2017, 7, 1, 0, 0, 0, 0)
        Me.DtiFechaLim.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DtiFechaLim.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DtiFechaLim.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DtiFechaLim.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DtiFechaLim.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiFechaLim.MonthCalendar.TodayButtonVisible = True
        Me.DtiFechaLim.Name = "DtiFechaLim"
        Me.DtiFechaLim.Size = New System.Drawing.Size(133, 28)
        Me.DtiFechaLim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DtiFechaLim.TabIndex = 8
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX9.Location = New System.Drawing.Point(568, 39)
        Me.LabelX9.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(119, 28)
        Me.LabelX9.TabIndex = 16
        Me.LabelX9.Text = "Fecha limite:"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(4, 75)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(167, 28)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Sucursal:"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX8.Location = New System.Drawing.Point(568, 4)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(107, 28)
        Me.LabelX8.TabIndex = 15
        Me.LabelX8.Text = "Fecha inicio:"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX5.Location = New System.Drawing.Point(4, 146)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(169, 20)
        Me.LabelX5.TabIndex = 8
        Me.LabelX5.Text = "Nro. de Autorización:"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX7.Location = New System.Drawing.Point(4, 218)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(167, 28)
        Me.LabelX7.TabIndex = 13
        Me.LabelX7.Text = "Llave:"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX6.Location = New System.Drawing.Point(4, 182)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(162, 20)
        Me.LabelX6.TabIndex = 9
        Me.LabelX6.Text = "Ultimo nro. Factura:"
        '
        'TbiNroFactura
        '
        '
        '
        '
        Me.TbiNroFactura.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TbiNroFactura.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbiNroFactura.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TbiNroFactura.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbiNroFactura.Location = New System.Drawing.Point(203, 182)
        Me.TbiNroFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.TbiNroFactura.MinValue = 0
        Me.TbiNroFactura.Name = "TbiNroFactura"
        Me.TbiNroFactura.Size = New System.Drawing.Size(133, 28)
        Me.TbiNroFactura.TabIndex = 5
        '
        'CbAlmacen
        '
        CbAlmacen_DesignTimeLayout.LayoutString = resources.GetString("CbAlmacen_DesignTimeLayout.LayoutString")
        Me.CbAlmacen.DesignTimeLayout = CbAlmacen_DesignTimeLayout
        Me.CbAlmacen.Font = New System.Drawing.Font("Open Sans Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAlmacen.Location = New System.Drawing.Point(203, 75)
        Me.CbAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.CbAlmacen.Name = "CbAlmacen"
        Me.CbAlmacen.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.CbAlmacen.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.CbAlmacen.SelectedIndex = -1
        Me.CbAlmacen.SelectedItem = Nothing
        Me.CbAlmacen.Size = New System.Drawing.Size(267, 28)
        Me.CbAlmacen.TabIndex = 2
        Me.CbAlmacen.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'F1_Dosificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 1037)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "F1_Dosificacion"
        Me.Text = "F1_Dosificacion"
        Me.Controls.SetChildIndex(Me.SuperTabPrincipal, 0)
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabPrincipal.ResumeLayout(False)
        Me.SuperTabControlPanelRegistro.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelToolBar2.ResumeLayout(False)
        Me.MPanelSup.ResumeLayout(False)
        Me.PanelPrincipal.ResumeLayout(False)
        Me.GroupPanelBuscador.ResumeLayout(False)
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelDatosGenerales.ResumeLayout(False)
        Me.PanelExDatosGenerales.ResumeLayout(False)
        Me.PanelExDatosGenerales.PerformLayout()
        CType(Me.tbfinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbinicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbiSfc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbCompania, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtiFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtiFechaLim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbiNroFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanelDatosGenerales As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SbEstado As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbNota1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DtiFechaLim As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbiNroFactura As DevComponents.Editors.IntegerInput
    Friend WithEvents CbAlmacen As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DtiFechaIni As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents TbCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CbCompania As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelExDatosGenerales As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TbLlave As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TbNota2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbiSfc As DevComponents.Editors.IntegerInput
    Friend WithEvents TbNroAutoriz As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents swtipo As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbinicial As DevComponents.Editors.IntegerInput
    Friend WithEvents tbfinal As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelFinal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LbInicial As DevComponents.DotNetBar.LabelX
End Class
