<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPpal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPpal))
        Me.PanelBotonesMenu = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SubMenuSistema = New System.Windows.Forms.Panel()
        Me.btnBackupRestore = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnNiveles = New System.Windows.Forms.Button()
        Me.btnSistema = New System.Windows.Forms.Button()
        Me.SubMenuParametros = New System.Windows.Forms.Panel()
        Me.btnCategIVA = New System.Windows.Forms.Button()
        Me.btnSubRubros = New System.Windows.Forms.Button()
        Me.btnRubros = New System.Windows.Forms.Button()
        Me.btnGrupos = New System.Windows.Forms.Button()
        Me.btnAdicionales = New System.Windows.Forms.Button()
        Me.btnCodPostales = New System.Windows.Forms.Button()
        Me.btnParametros = New System.Windows.Forms.Button()
        Me.SubMenuCaja = New System.Windows.Forms.Panel()
        Me.btnCajaMayor = New System.Windows.Forms.Button()
        Me.btnActualizarProv = New System.Windows.Forms.Button()
        Me.btnCaja = New System.Windows.Forms.Button()
        Me.SubMenuPaniol = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnTools = New System.Windows.Forms.Button()
        Me.btnPaniol = New System.Windows.Forms.Button()
        Me.SubMenuProveedores = New System.Windows.Forms.Panel()
        Me.btnLibroCompras = New System.Windows.Forms.Button()
        Me.btnPadronPro = New System.Windows.Forms.Button()
        Me.btnSaldosPro = New System.Windows.Forms.Button()
        Me.btnPagosPro = New System.Windows.Forms.Button()
        Me.btnCtasCtesPro = New System.Windows.Forms.Button()
        Me.btnCargarCompras = New System.Windows.Forms.Button()
        Me.btnActualizarPro = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.SubMenuObras = New System.Windows.Forms.Panel()
        Me.btnListarObras = New System.Windows.Forms.Button()
        Me.btnActualizarObra = New System.Windows.Forms.Button()
        Me.btnObras = New System.Windows.Forms.Button()
        Me.SubMenuClientes = New System.Windows.Forms.Panel()
        Me.btnListarClientes = New System.Windows.Forms.Button()
        Me.btnSaldosCli = New System.Windows.Forms.Button()
        Me.btnPagosCli = New System.Windows.Forms.Button()
        Me.btnCtasCtesCli = New System.Windows.Forms.Button()
        Me.btnFacturarCli = New System.Windows.Forms.Button()
        Me.btnActualizarCli = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.SubMenuEmpleados = New System.Windows.Forms.Panel()
        Me.btnLegajos = New System.Windows.Forms.Button()
        Me.btnCategoriaEmp = New System.Windows.Forms.Button()
        Me.btnListarEmpleados = New System.Windows.Forms.Button()
        Me.btnListarSaldos = New System.Windows.Forms.Button()
        Me.btnCtasCtesEmp = New System.Windows.Forms.Button()
        Me.btnLiquidar = New System.Windows.Forms.Button()
        Me.btnCargarAdicionales = New System.Windows.Forms.Button()
        Me.btnCargarHoras = New System.Windows.Forms.Button()
        Me.btnActualizarEmp = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.btnPreventivos = New System.Windows.Forms.Button()
        Me.PanelBotonesMenu.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.SubMenuSistema.SuspendLayout()
        Me.SubMenuParametros.SuspendLayout()
        Me.SubMenuCaja.SuspendLayout()
        Me.SubMenuPaniol.SuspendLayout()
        Me.SubMenuProveedores.SuspendLayout()
        Me.SubMenuObras.SuspendLayout()
        Me.SubMenuClientes.SuspendLayout()
        Me.SubMenuEmpleados.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBotonesMenu
        '
        Me.PanelBotonesMenu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PanelBotonesMenu.Controls.Add(Me.PanelFormularios)
        Me.PanelBotonesMenu.Controls.Add(Me.PanelMenu)
        Me.PanelBotonesMenu.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelBotonesMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBotonesMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelBotonesMenu.Name = "PanelBotonesMenu"
        Me.PanelBotonesMenu.Size = New System.Drawing.Size(1436, 729)
        Me.PanelBotonesMenu.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelFormularios.Controls.Add(Me.PictureBox2)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(250, 40)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1186, 689)
        Me.PanelFormularios.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(306, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(594, 676)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.Black
        Me.PanelMenu.Controls.Add(Me.btnSalir)
        Me.PanelMenu.Controls.Add(Me.SubMenuSistema)
        Me.PanelMenu.Controls.Add(Me.btnSistema)
        Me.PanelMenu.Controls.Add(Me.SubMenuParametros)
        Me.PanelMenu.Controls.Add(Me.btnParametros)
        Me.PanelMenu.Controls.Add(Me.SubMenuCaja)
        Me.PanelMenu.Controls.Add(Me.btnCaja)
        Me.PanelMenu.Controls.Add(Me.SubMenuPaniol)
        Me.PanelMenu.Controls.Add(Me.btnPaniol)
        Me.PanelMenu.Controls.Add(Me.SubMenuProveedores)
        Me.PanelMenu.Controls.Add(Me.btnProveedores)
        Me.PanelMenu.Controls.Add(Me.SubMenuObras)
        Me.PanelMenu.Controls.Add(Me.btnObras)
        Me.PanelMenu.Controls.Add(Me.SubMenuClientes)
        Me.PanelMenu.Controls.Add(Me.btnClientes)
        Me.PanelMenu.Controls.Add(Me.SubMenuEmpleados)
        Me.PanelMenu.Controls.Add(Me.btnEmpleados)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 689)
        Me.PanelMenu.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(0, 1515)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnSalir.Size = New System.Drawing.Size(233, 50)
        Me.btnSalir.TabIndex = 48
        Me.btnSalir.Text = "Salir del Sistema"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'SubMenuSistema
        '
        Me.SubMenuSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuSistema.Controls.Add(Me.btnBackupRestore)
        Me.SubMenuSistema.Controls.Add(Me.btnUsuarios)
        Me.SubMenuSistema.Controls.Add(Me.btnNiveles)
        Me.SubMenuSistema.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuSistema.Location = New System.Drawing.Point(0, 1432)
        Me.SubMenuSistema.Name = "SubMenuSistema"
        Me.SubMenuSistema.Size = New System.Drawing.Size(233, 83)
        Me.SubMenuSistema.TabIndex = 47
        '
        'btnBackupRestore
        '
        Me.btnBackupRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackupRestore.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBackupRestore.FlatAppearance.BorderSize = 0
        Me.btnBackupRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackupRestore.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackupRestore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBackupRestore.Location = New System.Drawing.Point(0, 50)
        Me.btnBackupRestore.Name = "btnBackupRestore"
        Me.btnBackupRestore.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnBackupRestore.Size = New System.Drawing.Size(233, 25)
        Me.btnBackupRestore.TabIndex = 9
        Me.btnBackupRestore.Text = "Backup y Restore"
        Me.btnBackupRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackupRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBackupRestore.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 25)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnUsuarios.Size = New System.Drawing.Size(233, 25)
        Me.btnUsuarios.TabIndex = 8
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnNiveles
        '
        Me.btnNiveles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNiveles.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNiveles.FlatAppearance.BorderSize = 0
        Me.btnNiveles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNiveles.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNiveles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNiveles.Location = New System.Drawing.Point(0, 0)
        Me.btnNiveles.Name = "btnNiveles"
        Me.btnNiveles.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnNiveles.Size = New System.Drawing.Size(233, 25)
        Me.btnNiveles.TabIndex = 2
        Me.btnNiveles.Text = "Niveles"
        Me.btnNiveles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNiveles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNiveles.UseVisualStyleBackColor = True
        '
        'btnSistema
        '
        Me.btnSistema.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSistema.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSistema.FlatAppearance.BorderSize = 0
        Me.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSistema.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSistema.ForeColor = System.Drawing.Color.White
        Me.btnSistema.Image = CType(resources.GetObject("btnSistema.Image"), System.Drawing.Image)
        Me.btnSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSistema.Location = New System.Drawing.Point(0, 1382)
        Me.btnSistema.Name = "btnSistema"
        Me.btnSistema.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnSistema.Size = New System.Drawing.Size(233, 50)
        Me.btnSistema.TabIndex = 46
        Me.btnSistema.Text = "Sistema"
        Me.btnSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSistema.UseVisualStyleBackColor = True
        '
        'SubMenuParametros
        '
        Me.SubMenuParametros.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuParametros.Controls.Add(Me.btnCategIVA)
        Me.SubMenuParametros.Controls.Add(Me.btnSubRubros)
        Me.SubMenuParametros.Controls.Add(Me.btnRubros)
        Me.SubMenuParametros.Controls.Add(Me.btnGrupos)
        Me.SubMenuParametros.Controls.Add(Me.btnAdicionales)
        Me.SubMenuParametros.Controls.Add(Me.btnCodPostales)
        Me.SubMenuParametros.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuParametros.Location = New System.Drawing.Point(0, 1224)
        Me.SubMenuParametros.Name = "SubMenuParametros"
        Me.SubMenuParametros.Size = New System.Drawing.Size(233, 158)
        Me.SubMenuParametros.TabIndex = 45
        '
        'btnCategIVA
        '
        Me.btnCategIVA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategIVA.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCategIVA.FlatAppearance.BorderSize = 0
        Me.btnCategIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategIVA.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategIVA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCategIVA.Location = New System.Drawing.Point(0, 125)
        Me.btnCategIVA.Name = "btnCategIVA"
        Me.btnCategIVA.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCategIVA.Size = New System.Drawing.Size(233, 25)
        Me.btnCategIVA.TabIndex = 14
        Me.btnCategIVA.Text = "Categorías I.V.A."
        Me.btnCategIVA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategIVA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCategIVA.UseVisualStyleBackColor = True
        '
        'btnSubRubros
        '
        Me.btnSubRubros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubRubros.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubRubros.FlatAppearance.BorderSize = 0
        Me.btnSubRubros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubRubros.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubRubros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubRubros.Location = New System.Drawing.Point(0, 100)
        Me.btnSubRubros.Name = "btnSubRubros"
        Me.btnSubRubros.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnSubRubros.Size = New System.Drawing.Size(233, 25)
        Me.btnSubRubros.TabIndex = 13
        Me.btnSubRubros.Text = "SubRubros"
        Me.btnSubRubros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubRubros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSubRubros.UseVisualStyleBackColor = True
        '
        'btnRubros
        '
        Me.btnRubros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRubros.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRubros.FlatAppearance.BorderSize = 0
        Me.btnRubros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRubros.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRubros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRubros.Location = New System.Drawing.Point(0, 75)
        Me.btnRubros.Name = "btnRubros"
        Me.btnRubros.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnRubros.Size = New System.Drawing.Size(233, 25)
        Me.btnRubros.TabIndex = 12
        Me.btnRubros.Text = "Rubros"
        Me.btnRubros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRubros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRubros.UseVisualStyleBackColor = True
        '
        'btnGrupos
        '
        Me.btnGrupos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrupos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGrupos.FlatAppearance.BorderSize = 0
        Me.btnGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrupos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrupos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGrupos.Location = New System.Drawing.Point(0, 50)
        Me.btnGrupos.Name = "btnGrupos"
        Me.btnGrupos.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnGrupos.Size = New System.Drawing.Size(233, 25)
        Me.btnGrupos.TabIndex = 11
        Me.btnGrupos.Text = "Grupos"
        Me.btnGrupos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrupos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGrupos.UseVisualStyleBackColor = True
        '
        'btnAdicionales
        '
        Me.btnAdicionales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdicionales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAdicionales.FlatAppearance.BorderSize = 0
        Me.btnAdicionales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionales.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdicionales.Location = New System.Drawing.Point(0, 25)
        Me.btnAdicionales.Name = "btnAdicionales"
        Me.btnAdicionales.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnAdicionales.Size = New System.Drawing.Size(233, 25)
        Me.btnAdicionales.TabIndex = 8
        Me.btnAdicionales.Text = "Adicionales"
        Me.btnAdicionales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdicionales.UseVisualStyleBackColor = True
        '
        'btnCodPostales
        '
        Me.btnCodPostales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCodPostales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCodPostales.FlatAppearance.BorderSize = 0
        Me.btnCodPostales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCodPostales.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCodPostales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCodPostales.Location = New System.Drawing.Point(0, 0)
        Me.btnCodPostales.Name = "btnCodPostales"
        Me.btnCodPostales.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCodPostales.Size = New System.Drawing.Size(233, 25)
        Me.btnCodPostales.TabIndex = 2
        Me.btnCodPostales.Text = "Códigos Postales"
        Me.btnCodPostales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCodPostales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCodPostales.UseVisualStyleBackColor = True
        '
        'btnParametros
        '
        Me.btnParametros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnParametros.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnParametros.FlatAppearance.BorderSize = 0
        Me.btnParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParametros.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParametros.ForeColor = System.Drawing.Color.White
        Me.btnParametros.Image = CType(resources.GetObject("btnParametros.Image"), System.Drawing.Image)
        Me.btnParametros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParametros.Location = New System.Drawing.Point(0, 1174)
        Me.btnParametros.Name = "btnParametros"
        Me.btnParametros.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnParametros.Size = New System.Drawing.Size(233, 50)
        Me.btnParametros.TabIndex = 44
        Me.btnParametros.Text = "Parámetros"
        Me.btnParametros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnParametros.UseVisualStyleBackColor = True
        '
        'SubMenuCaja
        '
        Me.SubMenuCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuCaja.Controls.Add(Me.btnCajaMayor)
        Me.SubMenuCaja.Controls.Add(Me.btnActualizarProv)
        Me.SubMenuCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuCaja.Location = New System.Drawing.Point(0, 1107)
        Me.SubMenuCaja.Name = "SubMenuCaja"
        Me.SubMenuCaja.Size = New System.Drawing.Size(233, 67)
        Me.SubMenuCaja.TabIndex = 43
        '
        'btnCajaMayor
        '
        Me.btnCajaMayor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCajaMayor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCajaMayor.FlatAppearance.BorderSize = 0
        Me.btnCajaMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCajaMayor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCajaMayor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCajaMayor.Location = New System.Drawing.Point(0, 25)
        Me.btnCajaMayor.Name = "btnCajaMayor"
        Me.btnCajaMayor.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCajaMayor.Size = New System.Drawing.Size(233, 25)
        Me.btnCajaMayor.TabIndex = 14
        Me.btnCajaMayor.Text = "Caja Mayor"
        Me.btnCajaMayor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCajaMayor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCajaMayor.UseVisualStyleBackColor = True
        '
        'btnActualizarProv
        '
        Me.btnActualizarProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarProv.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActualizarProv.FlatAppearance.BorderSize = 0
        Me.btnActualizarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarProv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizarProv.Location = New System.Drawing.Point(0, 0)
        Me.btnActualizarProv.Name = "btnActualizarProv"
        Me.btnActualizarProv.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnActualizarProv.Size = New System.Drawing.Size(233, 25)
        Me.btnActualizarProv.TabIndex = 2
        Me.btnActualizarProv.Text = "Actualizar"
        Me.btnActualizarProv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizarProv.UseVisualStyleBackColor = True
        '
        'btnCaja
        '
        Me.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCaja.FlatAppearance.BorderSize = 0
        Me.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaja.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaja.ForeColor = System.Drawing.Color.White
        Me.btnCaja.Image = CType(resources.GetObject("btnCaja.Image"), System.Drawing.Image)
        Me.btnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCaja.Location = New System.Drawing.Point(0, 1057)
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnCaja.Size = New System.Drawing.Size(233, 50)
        Me.btnCaja.TabIndex = 42
        Me.btnCaja.Text = "Caja"
        Me.btnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCaja.UseVisualStyleBackColor = True
        '
        'SubMenuPaniol
        '
        Me.SubMenuPaniol.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuPaniol.Controls.Add(Me.Button1)
        Me.SubMenuPaniol.Controls.Add(Me.Button2)
        Me.SubMenuPaniol.Controls.Add(Me.btnTools)
        Me.SubMenuPaniol.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuPaniol.Location = New System.Drawing.Point(0, 969)
        Me.SubMenuPaniol.Name = "SubMenuPaniol"
        Me.SubMenuPaniol.Size = New System.Drawing.Size(233, 88)
        Me.SubMenuPaniol.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(0, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(233, 25)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "X"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(0, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(233, 25)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "X"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnTools
        '
        Me.btnTools.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTools.FlatAppearance.BorderSize = 0
        Me.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTools.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTools.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTools.Location = New System.Drawing.Point(0, 0)
        Me.btnTools.Name = "btnTools"
        Me.btnTools.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnTools.Size = New System.Drawing.Size(233, 25)
        Me.btnTools.TabIndex = 2
        Me.btnTools.Text = "Herramientas"
        Me.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTools.UseVisualStyleBackColor = True
        '
        'btnPaniol
        '
        Me.btnPaniol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPaniol.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPaniol.FlatAppearance.BorderSize = 0
        Me.btnPaniol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaniol.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaniol.ForeColor = System.Drawing.Color.White
        Me.btnPaniol.Image = CType(resources.GetObject("btnPaniol.Image"), System.Drawing.Image)
        Me.btnPaniol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaniol.Location = New System.Drawing.Point(0, 919)
        Me.btnPaniol.Name = "btnPaniol"
        Me.btnPaniol.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnPaniol.Size = New System.Drawing.Size(233, 50)
        Me.btnPaniol.TabIndex = 40
        Me.btnPaniol.Text = "Pañol"
        Me.btnPaniol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPaniol.UseVisualStyleBackColor = True
        '
        'SubMenuProveedores
        '
        Me.SubMenuProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuProveedores.Controls.Add(Me.btnLibroCompras)
        Me.SubMenuProveedores.Controls.Add(Me.btnPadronPro)
        Me.SubMenuProveedores.Controls.Add(Me.btnSaldosPro)
        Me.SubMenuProveedores.Controls.Add(Me.btnPagosPro)
        Me.SubMenuProveedores.Controls.Add(Me.btnCtasCtesPro)
        Me.SubMenuProveedores.Controls.Add(Me.btnCargarCompras)
        Me.SubMenuProveedores.Controls.Add(Me.btnActualizarPro)
        Me.SubMenuProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuProveedores.Location = New System.Drawing.Point(0, 736)
        Me.SubMenuProveedores.Name = "SubMenuProveedores"
        Me.SubMenuProveedores.Size = New System.Drawing.Size(233, 183)
        Me.SubMenuProveedores.TabIndex = 18
        '
        'btnLibroCompras
        '
        Me.btnLibroCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLibroCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLibroCompras.FlatAppearance.BorderSize = 0
        Me.btnLibroCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibroCompras.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLibroCompras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLibroCompras.Location = New System.Drawing.Point(0, 150)
        Me.btnLibroCompras.Name = "btnLibroCompras"
        Me.btnLibroCompras.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnLibroCompras.Size = New System.Drawing.Size(233, 25)
        Me.btnLibroCompras.TabIndex = 13
        Me.btnLibroCompras.Text = "Libro Compras"
        Me.btnLibroCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLibroCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLibroCompras.UseVisualStyleBackColor = True
        '
        'btnPadronPro
        '
        Me.btnPadronPro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPadronPro.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPadronPro.FlatAppearance.BorderSize = 0
        Me.btnPadronPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPadronPro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPadronPro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPadronPro.Location = New System.Drawing.Point(0, 125)
        Me.btnPadronPro.Name = "btnPadronPro"
        Me.btnPadronPro.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnPadronPro.Size = New System.Drawing.Size(233, 25)
        Me.btnPadronPro.TabIndex = 12
        Me.btnPadronPro.Text = "Listar Padrón"
        Me.btnPadronPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPadronPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPadronPro.UseVisualStyleBackColor = True
        '
        'btnSaldosPro
        '
        Me.btnSaldosPro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaldosPro.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSaldosPro.FlatAppearance.BorderSize = 0
        Me.btnSaldosPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaldosPro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaldosPro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaldosPro.Location = New System.Drawing.Point(0, 100)
        Me.btnSaldosPro.Name = "btnSaldosPro"
        Me.btnSaldosPro.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnSaldosPro.Size = New System.Drawing.Size(233, 25)
        Me.btnSaldosPro.TabIndex = 11
        Me.btnSaldosPro.Text = "Listar Saldos"
        Me.btnSaldosPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaldosPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaldosPro.UseVisualStyleBackColor = True
        '
        'btnPagosPro
        '
        Me.btnPagosPro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagosPro.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPagosPro.FlatAppearance.BorderSize = 0
        Me.btnPagosPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagosPro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagosPro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPagosPro.Location = New System.Drawing.Point(0, 75)
        Me.btnPagosPro.Name = "btnPagosPro"
        Me.btnPagosPro.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnPagosPro.Size = New System.Drawing.Size(233, 25)
        Me.btnPagosPro.TabIndex = 10
        Me.btnPagosPro.Text = "Cargar Pagos"
        Me.btnPagosPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagosPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPagosPro.UseVisualStyleBackColor = True
        '
        'btnCtasCtesPro
        '
        Me.btnCtasCtesPro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCtasCtesPro.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCtasCtesPro.FlatAppearance.BorderSize = 0
        Me.btnCtasCtesPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCtasCtesPro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtasCtesPro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCtasCtesPro.Location = New System.Drawing.Point(0, 50)
        Me.btnCtasCtesPro.Name = "btnCtasCtesPro"
        Me.btnCtasCtesPro.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCtasCtesPro.Size = New System.Drawing.Size(233, 25)
        Me.btnCtasCtesPro.TabIndex = 9
        Me.btnCtasCtesPro.Text = "Cuentas Corrientes"
        Me.btnCtasCtesPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCtasCtesPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCtasCtesPro.UseVisualStyleBackColor = True
        '
        'btnCargarCompras
        '
        Me.btnCargarCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargarCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCargarCompras.FlatAppearance.BorderSize = 0
        Me.btnCargarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarCompras.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarCompras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCargarCompras.Location = New System.Drawing.Point(0, 25)
        Me.btnCargarCompras.Name = "btnCargarCompras"
        Me.btnCargarCompras.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCargarCompras.Size = New System.Drawing.Size(233, 25)
        Me.btnCargarCompras.TabIndex = 8
        Me.btnCargarCompras.Text = "Cargar Compras"
        Me.btnCargarCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCargarCompras.UseVisualStyleBackColor = True
        '
        'btnActualizarPro
        '
        Me.btnActualizarPro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarPro.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActualizarPro.FlatAppearance.BorderSize = 0
        Me.btnActualizarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarPro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarPro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizarPro.Location = New System.Drawing.Point(0, 0)
        Me.btnActualizarPro.Name = "btnActualizarPro"
        Me.btnActualizarPro.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnActualizarPro.Size = New System.Drawing.Size(233, 25)
        Me.btnActualizarPro.TabIndex = 2
        Me.btnActualizarPro.Text = "Actualizar"
        Me.btnActualizarPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizarPro.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ForeColor = System.Drawing.Color.White
        Me.btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"), System.Drawing.Image)
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.Location = New System.Drawing.Point(0, 686)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnProveedores.Size = New System.Drawing.Size(233, 50)
        Me.btnProveedores.TabIndex = 17
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'SubMenuObras
        '
        Me.SubMenuObras.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuObras.Controls.Add(Me.btnPreventivos)
        Me.SubMenuObras.Controls.Add(Me.btnListarObras)
        Me.SubMenuObras.Controls.Add(Me.btnActualizarObra)
        Me.SubMenuObras.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuObras.Location = New System.Drawing.Point(0, 603)
        Me.SubMenuObras.Name = "SubMenuObras"
        Me.SubMenuObras.Size = New System.Drawing.Size(233, 83)
        Me.SubMenuObras.TabIndex = 16
        '
        'btnListarObras
        '
        Me.btnListarObras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListarObras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListarObras.FlatAppearance.BorderSize = 0
        Me.btnListarObras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarObras.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarObras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnListarObras.Location = New System.Drawing.Point(0, 25)
        Me.btnListarObras.Name = "btnListarObras"
        Me.btnListarObras.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnListarObras.Size = New System.Drawing.Size(233, 25)
        Me.btnListarObras.TabIndex = 10
        Me.btnListarObras.Text = "Listado de Obras"
        Me.btnListarObras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListarObras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListarObras.UseVisualStyleBackColor = True
        '
        'btnActualizarObra
        '
        Me.btnActualizarObra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarObra.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActualizarObra.FlatAppearance.BorderSize = 0
        Me.btnActualizarObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarObra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarObra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizarObra.Location = New System.Drawing.Point(0, 0)
        Me.btnActualizarObra.Name = "btnActualizarObra"
        Me.btnActualizarObra.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnActualizarObra.Size = New System.Drawing.Size(233, 25)
        Me.btnActualizarObra.TabIndex = 9
        Me.btnActualizarObra.Text = "Actualizar"
        Me.btnActualizarObra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarObra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizarObra.UseVisualStyleBackColor = True
        '
        'btnObras
        '
        Me.btnObras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnObras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnObras.FlatAppearance.BorderSize = 0
        Me.btnObras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnObras.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObras.ForeColor = System.Drawing.Color.White
        Me.btnObras.Image = CType(resources.GetObject("btnObras.Image"), System.Drawing.Image)
        Me.btnObras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnObras.Location = New System.Drawing.Point(0, 553)
        Me.btnObras.Name = "btnObras"
        Me.btnObras.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnObras.Size = New System.Drawing.Size(233, 50)
        Me.btnObras.TabIndex = 15
        Me.btnObras.Text = "Obras"
        Me.btnObras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnObras.UseVisualStyleBackColor = True
        '
        'SubMenuClientes
        '
        Me.SubMenuClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuClientes.Controls.Add(Me.btnListarClientes)
        Me.SubMenuClientes.Controls.Add(Me.btnSaldosCli)
        Me.SubMenuClientes.Controls.Add(Me.btnPagosCli)
        Me.SubMenuClientes.Controls.Add(Me.btnCtasCtesCli)
        Me.SubMenuClientes.Controls.Add(Me.btnFacturarCli)
        Me.SubMenuClientes.Controls.Add(Me.btnActualizarCli)
        Me.SubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuClientes.Location = New System.Drawing.Point(0, 395)
        Me.SubMenuClientes.Name = "SubMenuClientes"
        Me.SubMenuClientes.Size = New System.Drawing.Size(233, 158)
        Me.SubMenuClientes.TabIndex = 14
        '
        'btnListarClientes
        '
        Me.btnListarClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListarClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListarClientes.FlatAppearance.BorderSize = 0
        Me.btnListarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarClientes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnListarClientes.Location = New System.Drawing.Point(0, 125)
        Me.btnListarClientes.Name = "btnListarClientes"
        Me.btnListarClientes.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnListarClientes.Size = New System.Drawing.Size(233, 25)
        Me.btnListarClientes.TabIndex = 9
        Me.btnListarClientes.Text = "Listar Padrón"
        Me.btnListarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListarClientes.UseVisualStyleBackColor = True
        '
        'btnSaldosCli
        '
        Me.btnSaldosCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaldosCli.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSaldosCli.FlatAppearance.BorderSize = 0
        Me.btnSaldosCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaldosCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaldosCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaldosCli.Location = New System.Drawing.Point(0, 100)
        Me.btnSaldosCli.Name = "btnSaldosCli"
        Me.btnSaldosCli.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnSaldosCli.Size = New System.Drawing.Size(233, 25)
        Me.btnSaldosCli.TabIndex = 8
        Me.btnSaldosCli.Text = "Listar Saldos"
        Me.btnSaldosCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaldosCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaldosCli.UseVisualStyleBackColor = True
        '
        'btnPagosCli
        '
        Me.btnPagosCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagosCli.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPagosCli.FlatAppearance.BorderSize = 0
        Me.btnPagosCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagosCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagosCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPagosCli.Location = New System.Drawing.Point(0, 75)
        Me.btnPagosCli.Name = "btnPagosCli"
        Me.btnPagosCli.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnPagosCli.Size = New System.Drawing.Size(233, 25)
        Me.btnPagosCli.TabIndex = 7
        Me.btnPagosCli.Text = "Cargar Pagos"
        Me.btnPagosCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagosCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPagosCli.UseVisualStyleBackColor = True
        '
        'btnCtasCtesCli
        '
        Me.btnCtasCtesCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCtasCtesCli.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCtasCtesCli.FlatAppearance.BorderSize = 0
        Me.btnCtasCtesCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCtasCtesCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtasCtesCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCtasCtesCli.Location = New System.Drawing.Point(0, 50)
        Me.btnCtasCtesCli.Name = "btnCtasCtesCli"
        Me.btnCtasCtesCli.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCtasCtesCli.Size = New System.Drawing.Size(233, 25)
        Me.btnCtasCtesCli.TabIndex = 3
        Me.btnCtasCtesCli.Text = "Cuentas Corrientes"
        Me.btnCtasCtesCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCtasCtesCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCtasCtesCli.UseVisualStyleBackColor = True
        '
        'btnFacturarCli
        '
        Me.btnFacturarCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacturarCli.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFacturarCli.FlatAppearance.BorderSize = 0
        Me.btnFacturarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturarCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturarCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFacturarCli.Location = New System.Drawing.Point(0, 25)
        Me.btnFacturarCli.Name = "btnFacturarCli"
        Me.btnFacturarCli.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnFacturarCli.Size = New System.Drawing.Size(233, 25)
        Me.btnFacturarCli.TabIndex = 2
        Me.btnFacturarCli.Text = "Facturar"
        Me.btnFacturarCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFacturarCli.UseVisualStyleBackColor = True
        '
        'btnActualizarCli
        '
        Me.btnActualizarCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarCli.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActualizarCli.FlatAppearance.BorderSize = 0
        Me.btnActualizarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarCli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizarCli.Location = New System.Drawing.Point(0, 0)
        Me.btnActualizarCli.Name = "btnActualizarCli"
        Me.btnActualizarCli.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnActualizarCli.Size = New System.Drawing.Size(233, 25)
        Me.btnActualizarCli.TabIndex = 1
        Me.btnActualizarCli.Text = "Actualizar"
        Me.btnActualizarCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizarCli.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 345)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnClientes.Size = New System.Drawing.Size(233, 50)
        Me.btnClientes.TabIndex = 13
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'SubMenuEmpleados
        '
        Me.SubMenuEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SubMenuEmpleados.Controls.Add(Me.btnLegajos)
        Me.SubMenuEmpleados.Controls.Add(Me.btnCategoriaEmp)
        Me.SubMenuEmpleados.Controls.Add(Me.btnListarEmpleados)
        Me.SubMenuEmpleados.Controls.Add(Me.btnListarSaldos)
        Me.SubMenuEmpleados.Controls.Add(Me.btnCtasCtesEmp)
        Me.SubMenuEmpleados.Controls.Add(Me.btnLiquidar)
        Me.SubMenuEmpleados.Controls.Add(Me.btnCargarAdicionales)
        Me.SubMenuEmpleados.Controls.Add(Me.btnCargarHoras)
        Me.SubMenuEmpleados.Controls.Add(Me.btnActualizarEmp)
        Me.SubMenuEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuEmpleados.Location = New System.Drawing.Point(0, 112)
        Me.SubMenuEmpleados.Name = "SubMenuEmpleados"
        Me.SubMenuEmpleados.Size = New System.Drawing.Size(233, 233)
        Me.SubMenuEmpleados.TabIndex = 12
        '
        'btnLegajos
        '
        Me.btnLegajos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLegajos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLegajos.FlatAppearance.BorderSize = 0
        Me.btnLegajos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLegajos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLegajos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLegajos.Location = New System.Drawing.Point(0, 200)
        Me.btnLegajos.Name = "btnLegajos"
        Me.btnLegajos.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnLegajos.Size = New System.Drawing.Size(233, 25)
        Me.btnLegajos.TabIndex = 17
        Me.btnLegajos.Text = "Legajos"
        Me.btnLegajos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLegajos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLegajos.UseVisualStyleBackColor = True
        '
        'btnCategoriaEmp
        '
        Me.btnCategoriaEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategoriaEmp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCategoriaEmp.FlatAppearance.BorderSize = 0
        Me.btnCategoriaEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoriaEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoriaEmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCategoriaEmp.Location = New System.Drawing.Point(0, 175)
        Me.btnCategoriaEmp.Name = "btnCategoriaEmp"
        Me.btnCategoriaEmp.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCategoriaEmp.Size = New System.Drawing.Size(233, 25)
        Me.btnCategoriaEmp.TabIndex = 16
        Me.btnCategoriaEmp.Text = "Categorías"
        Me.btnCategoriaEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategoriaEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCategoriaEmp.UseVisualStyleBackColor = True
        '
        'btnListarEmpleados
        '
        Me.btnListarEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListarEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListarEmpleados.FlatAppearance.BorderSize = 0
        Me.btnListarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarEmpleados.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarEmpleados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnListarEmpleados.Location = New System.Drawing.Point(0, 150)
        Me.btnListarEmpleados.Name = "btnListarEmpleados"
        Me.btnListarEmpleados.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnListarEmpleados.Size = New System.Drawing.Size(233, 25)
        Me.btnListarEmpleados.TabIndex = 15
        Me.btnListarEmpleados.Text = "Listar Padrón"
        Me.btnListarEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListarEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListarEmpleados.UseVisualStyleBackColor = True
        '
        'btnListarSaldos
        '
        Me.btnListarSaldos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListarSaldos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListarSaldos.FlatAppearance.BorderSize = 0
        Me.btnListarSaldos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarSaldos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarSaldos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnListarSaldos.Location = New System.Drawing.Point(0, 125)
        Me.btnListarSaldos.Name = "btnListarSaldos"
        Me.btnListarSaldos.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnListarSaldos.Size = New System.Drawing.Size(233, 25)
        Me.btnListarSaldos.TabIndex = 14
        Me.btnListarSaldos.Text = "Listar Saldos"
        Me.btnListarSaldos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListarSaldos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListarSaldos.UseVisualStyleBackColor = True
        '
        'btnCtasCtesEmp
        '
        Me.btnCtasCtesEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCtasCtesEmp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCtasCtesEmp.FlatAppearance.BorderSize = 0
        Me.btnCtasCtesEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCtasCtesEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtasCtesEmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCtasCtesEmp.Location = New System.Drawing.Point(0, 100)
        Me.btnCtasCtesEmp.Name = "btnCtasCtesEmp"
        Me.btnCtasCtesEmp.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCtasCtesEmp.Size = New System.Drawing.Size(233, 25)
        Me.btnCtasCtesEmp.TabIndex = 13
        Me.btnCtasCtesEmp.Text = "Cuentas Corrientes"
        Me.btnCtasCtesEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCtasCtesEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCtasCtesEmp.UseVisualStyleBackColor = True
        '
        'btnLiquidar
        '
        Me.btnLiquidar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLiquidar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLiquidar.FlatAppearance.BorderSize = 0
        Me.btnLiquidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLiquidar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiquidar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLiquidar.Location = New System.Drawing.Point(0, 75)
        Me.btnLiquidar.Name = "btnLiquidar"
        Me.btnLiquidar.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnLiquidar.Size = New System.Drawing.Size(233, 25)
        Me.btnLiquidar.TabIndex = 12
        Me.btnLiquidar.Text = "Liquidar"
        Me.btnLiquidar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLiquidar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLiquidar.UseVisualStyleBackColor = True
        '
        'btnCargarAdicionales
        '
        Me.btnCargarAdicionales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargarAdicionales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCargarAdicionales.FlatAppearance.BorderSize = 0
        Me.btnCargarAdicionales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarAdicionales.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarAdicionales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCargarAdicionales.Location = New System.Drawing.Point(0, 50)
        Me.btnCargarAdicionales.Name = "btnCargarAdicionales"
        Me.btnCargarAdicionales.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCargarAdicionales.Size = New System.Drawing.Size(233, 25)
        Me.btnCargarAdicionales.TabIndex = 11
        Me.btnCargarAdicionales.Text = "Cargar Adicionales"
        Me.btnCargarAdicionales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarAdicionales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCargarAdicionales.UseVisualStyleBackColor = True
        '
        'btnCargarHoras
        '
        Me.btnCargarHoras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargarHoras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCargarHoras.FlatAppearance.BorderSize = 0
        Me.btnCargarHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarHoras.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarHoras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCargarHoras.Location = New System.Drawing.Point(0, 25)
        Me.btnCargarHoras.Name = "btnCargarHoras"
        Me.btnCargarHoras.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnCargarHoras.Size = New System.Drawing.Size(233, 25)
        Me.btnCargarHoras.TabIndex = 3
        Me.btnCargarHoras.Text = "Cargar Horas"
        Me.btnCargarHoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarHoras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCargarHoras.UseVisualStyleBackColor = True
        '
        'btnActualizarEmp
        '
        Me.btnActualizarEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarEmp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActualizarEmp.FlatAppearance.BorderSize = 0
        Me.btnActualizarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarEmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizarEmp.Location = New System.Drawing.Point(0, 0)
        Me.btnActualizarEmp.Name = "btnActualizarEmp"
        Me.btnActualizarEmp.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnActualizarEmp.Size = New System.Drawing.Size(233, 25)
        Me.btnActualizarEmp.TabIndex = 2
        Me.btnActualizarEmp.Text = "Actualizar"
        Me.btnActualizarEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizarEmp.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.ForeColor = System.Drawing.Color.White
        Me.btnEmpleados.Image = CType(resources.GetObject("btnEmpleados.Image"), System.Drawing.Image)
        Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.Location = New System.Drawing.Point(0, 62)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnEmpleados.Size = New System.Drawing.Size(233, 50)
        Me.btnEmpleados.TabIndex = 11
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.Black
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(233, 62)
        Me.PanelLogo.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.Black
        Me.PanelBarraTitulo.Controls.Add(Me.Label2)
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1436, 40)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(513, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Menú General Sistema Administrativo Empresa SOINT S.R.L."
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(1377, 10)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(20, 20)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(1377, 10)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(20, 20)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 2
        Me.btnMaximizar.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1351, 10)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(20, 20)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1403, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(20, 20)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'btnPreventivos
        '
        Me.btnPreventivos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreventivos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPreventivos.FlatAppearance.BorderSize = 0
        Me.btnPreventivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreventivos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreventivos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPreventivos.Location = New System.Drawing.Point(0, 50)
        Me.btnPreventivos.Name = "btnPreventivos"
        Me.btnPreventivos.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnPreventivos.Size = New System.Drawing.Size(233, 25)
        Me.btnPreventivos.TabIndex = 11
        Me.btnPreventivos.Text = "Preventivos"
        Me.btnPreventivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreventivos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPreventivos.UseVisualStyleBackColor = True
        '
        'MenuPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1436, 729)
        Me.Controls.Add(Me.PanelBotonesMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "MenuPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPpal"
        Me.PanelBotonesMenu.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.SubMenuSistema.ResumeLayout(False)
        Me.SubMenuParametros.ResumeLayout(False)
        Me.SubMenuCaja.ResumeLayout(False)
        Me.SubMenuPaniol.ResumeLayout(False)
        Me.SubMenuProveedores.ResumeLayout(False)
        Me.SubMenuObras.ResumeLayout(False)
        Me.SubMenuClientes.ResumeLayout(False)
        Me.SubMenuEmpleados.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBotonesMenu As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SubMenuProveedores As Panel
    Friend WithEvents btnCargarCompras As Button
    Friend WithEvents btnActualizarPro As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents SubMenuObras As Panel
    Friend WithEvents btnObras As Button
    Friend WithEvents SubMenuClientes As Panel
    Friend WithEvents btnCtasCtesCli As Button
    Friend WithEvents btnFacturarCli As Button
    Friend WithEvents btnActualizarCli As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents SubMenuEmpleados As Panel
    Friend WithEvents btnCargarHoras As Button
    Friend WithEvents btnActualizarEmp As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPagosCli As Button
    Friend WithEvents btnActualizarObra As Button
    Friend WithEvents btnListarObras As Button
    Friend WithEvents btnListarClientes As Button
    Friend WithEvents btnSaldosCli As Button
    Friend WithEvents btnPadronPro As Button
    Friend WithEvents btnSaldosPro As Button
    Friend WithEvents btnPagosPro As Button
    Friend WithEvents btnCtasCtesPro As Button
    Friend WithEvents btnCategoriaEmp As Button
    Friend WithEvents btnListarEmpleados As Button
    Friend WithEvents btnListarSaldos As Button
    Friend WithEvents btnCtasCtesEmp As Button
    Friend WithEvents btnLiquidar As Button
    Friend WithEvents btnCargarAdicionales As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents SubMenuSistema As Panel
    Friend WithEvents btnBackupRestore As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnNiveles As Button
    Friend WithEvents btnSistema As Button
    Friend WithEvents SubMenuParametros As Panel
    Friend WithEvents btnAdicionales As Button
    Friend WithEvents btnCodPostales As Button
    Friend WithEvents btnParametros As Button
    Friend WithEvents SubMenuCaja As Panel
    Friend WithEvents btnCajaMayor As Button
    Friend WithEvents btnActualizarProv As Button
    Friend WithEvents btnCaja As Button
    Friend WithEvents SubMenuPaniol As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnTools As Button
    Friend WithEvents btnPaniol As Button
    Friend WithEvents btnSubRubros As Button
    Friend WithEvents btnRubros As Button
    Friend WithEvents btnGrupos As Button
    Friend WithEvents btnCategIVA As Button
    Friend WithEvents btnLegajos As Button
    Friend WithEvents btnLibroCompras As Button
    Friend WithEvents btnPreventivos As Button
End Class
