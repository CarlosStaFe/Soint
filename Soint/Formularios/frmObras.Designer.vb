<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmObras
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
        Me.components = New System.ComponentModel.Container()
        Dim ClienteObraLabel As System.Windows.Forms.Label
        Dim NroObraLabel As System.Windows.Forms.Label
        Dim TitularObraLabel As System.Windows.Forms.Label
        Dim LugarObraLabel As System.Windows.Forms.Label
        Dim ObsObraLabel As System.Windows.Forms.Label
        Dim FechaObraLabel1 As System.Windows.Forms.Label
        Dim FecEstadoObraLabel1 As System.Windows.Forms.Label
        Dim EstadoObraLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmObras))
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ObrasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ObrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ObrasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtId_Obra = New System.Windows.Forms.TextBox()
        Me.txtClienteObra = New System.Windows.Forms.TextBox()
        Me.txtNroObra = New System.Windows.Forms.TextBox()
        Me.txtTitularObra = New System.Windows.Forms.TextBox()
        Me.txtLugarObra = New System.Windows.Forms.TextBox()
        Me.txtObsObra = New System.Windows.Forms.TextBox()
        Me.txtFechaObra = New System.Windows.Forms.TextBox()
        Me.txtFecEstadoObra = New System.Windows.Forms.TextBox()
        Me.cmbEstadoObra = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvObras = New System.Windows.Forms.DataGridView()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ObrasTableAdapter = New Soint.dbsointDataSetTableAdapters.obrasTableAdapter()
        Me.TableAdapterManager = New Soint.dbsointDataSetTableAdapters.TableAdapterManager()
        Me.txtNombreObra = New System.Windows.Forms.TextBox()
        Me.IdObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreObra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitularObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LugarObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecEstadoObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ClienteObraLabel = New System.Windows.Forms.Label()
        NroObraLabel = New System.Windows.Forms.Label()
        TitularObraLabel = New System.Windows.Forms.Label()
        LugarObraLabel = New System.Windows.Forms.Label()
        ObsObraLabel = New System.Windows.Forms.Label()
        FechaObraLabel1 = New System.Windows.Forms.Label()
        FecEstadoObraLabel1 = New System.Windows.Forms.Label()
        EstadoObraLabel1 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.ObrasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ObrasBindingNavigator.SuspendLayout()
        CType(Me.ObrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvObras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClienteObraLabel
        '
        ClienteObraLabel.AutoSize = True
        ClienteObraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClienteObraLabel.Location = New System.Drawing.Point(75, 65)
        ClienteObraLabel.Name = "ClienteObraLabel"
        ClienteObraLabel.Size = New System.Drawing.Size(58, 17)
        ClienteObraLabel.TabIndex = 3
        ClienteObraLabel.Text = "Cliente:"
        '
        'NroObraLabel
        '
        NroObraLabel.AutoSize = True
        NroObraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NroObraLabel.Location = New System.Drawing.Point(57, 94)
        NroObraLabel.Name = "NroObraLabel"
        NroObraLabel.Size = New System.Drawing.Size(76, 17)
        NroObraLabel.TabIndex = 5
        NroObraLabel.Text = "Nro. Obra:"
        '
        'TitularObraLabel
        '
        TitularObraLabel.AutoSize = True
        TitularObraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitularObraLabel.Location = New System.Drawing.Point(214, 65)
        TitularObraLabel.Name = "TitularObraLabel"
        TitularObraLabel.Size = New System.Drawing.Size(86, 17)
        TitularObraLabel.TabIndex = 9
        TitularObraLabel.Text = "Titular Obra:"
        '
        'LugarObraLabel
        '
        LugarObraLabel.AutoSize = True
        LugarObraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LugarObraLabel.Location = New System.Drawing.Point(48, 123)
        LugarObraLabel.Name = "LugarObraLabel"
        LugarObraLabel.Size = New System.Drawing.Size(85, 17)
        LugarObraLabel.TabIndex = 11
        LugarObraLabel.Text = "Lugar Obra:"
        '
        'ObsObraLabel
        '
        ObsObraLabel.AutoSize = True
        ObsObraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsObraLabel.Location = New System.Drawing.Point(39, 183)
        ObsObraLabel.Name = "ObsObraLabel"
        ObsObraLabel.Size = New System.Drawing.Size(94, 17)
        ObsObraLabel.TabIndex = 27
        ObsObraLabel.Text = "Observación:"
        '
        'FechaObraLabel1
        '
        FechaObraLabel1.AutoSize = True
        FechaObraLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaObraLabel1.Location = New System.Drawing.Point(212, 94)
        FechaObraLabel1.Name = "FechaObraLabel1"
        FechaObraLabel1.Size = New System.Drawing.Size(65, 17)
        FechaObraLabel1.TabIndex = 28
        FechaObraLabel1.Text = "Nombre:"
        '
        'FecEstadoObraLabel1
        '
        FecEstadoObraLabel1.AutoSize = True
        FecEstadoObraLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FecEstadoObraLabel1.Location = New System.Drawing.Point(391, 153)
        FecEstadoObraLabel1.Name = "FecEstadoObraLabel1"
        FecEstadoObraLabel1.Size = New System.Drawing.Size(86, 17)
        FecEstadoObraLabel1.TabIndex = 29
        FecEstadoObraLabel1.Text = "Fec. Estado:"
        '
        'EstadoObraLabel1
        '
        EstadoObraLabel1.AutoSize = True
        EstadoObraLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoObraLabel1.Location = New System.Drawing.Point(40, 153)
        EstadoObraLabel1.Name = "EstadoObraLabel1"
        EstadoObraLabel1.Size = New System.Drawing.Size(93, 17)
        EstadoObraLabel1.TabIndex = 30
        EstadoObraLabel1.Text = "Estado Obra:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(585, 94)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(88, 17)
        Label1.TabIndex = 132
        Label1.Text = "Fecha Obra:"
        '
        'ObrasBindingNavigator
        '
        Me.ObrasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ObrasBindingNavigator.BindingSource = Me.ObrasBindingSource
        Me.ObrasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ObrasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ObrasBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ObrasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ObrasBindingNavigatorSaveItem})
        Me.ObrasBindingNavigator.Location = New System.Drawing.Point(0, 606)
        Me.ObrasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ObrasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ObrasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ObrasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ObrasBindingNavigator.Name = "ObrasBindingNavigator"
        Me.ObrasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ObrasBindingNavigator.Size = New System.Drawing.Size(1158, 25)
        Me.ObrasBindingNavigator.TabIndex = 0
        Me.ObrasBindingNavigator.Text = "BindingNavigator1"
        Me.ObrasBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'ObrasBindingSource
        '
        Me.ObrasBindingSource.DataMember = "obras"
        Me.ObrasBindingSource.DataSource = Me.DbsointDataSet
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ObrasBindingNavigatorSaveItem
        '
        Me.ObrasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ObrasBindingNavigatorSaveItem.Image = CType(resources.GetObject("ObrasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ObrasBindingNavigatorSaveItem.Name = "ObrasBindingNavigatorSaveItem"
        Me.ObrasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ObrasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'txtId_Obra
        '
        Me.txtId_Obra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_Obra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_Obra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObrasBindingSource, "id_Obra", True))
        Me.txtId_Obra.Enabled = False
        Me.txtId_Obra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_Obra.ForeColor = System.Drawing.Color.White
        Me.txtId_Obra.Location = New System.Drawing.Point(788, 183)
        Me.txtId_Obra.Name = "txtId_Obra"
        Me.txtId_Obra.Size = New System.Drawing.Size(64, 16)
        Me.txtId_Obra.TabIndex = 17
        '
        'txtClienteObra
        '
        Me.txtClienteObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtClienteObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClienteObra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteObra.ForeColor = System.Drawing.Color.White
        Me.txtClienteObra.Location = New System.Drawing.Point(138, 63)
        Me.txtClienteObra.Name = "txtClienteObra"
        Me.txtClienteObra.Size = New System.Drawing.Size(70, 23)
        Me.txtClienteObra.TabIndex = 0
        '
        'txtNroObra
        '
        Me.txtNroObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroObra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroObra.ForeColor = System.Drawing.Color.White
        Me.txtNroObra.Location = New System.Drawing.Point(139, 92)
        Me.txtNroObra.Name = "txtNroObra"
        Me.txtNroObra.Size = New System.Drawing.Size(70, 23)
        Me.txtNroObra.TabIndex = 2
        '
        'txtTitularObra
        '
        Me.txtTitularObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTitularObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitularObra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitularObra.ForeColor = System.Drawing.Color.White
        Me.txtTitularObra.Location = New System.Drawing.Point(306, 63)
        Me.txtTitularObra.Name = "txtTitularObra"
        Me.txtTitularObra.Size = New System.Drawing.Size(474, 23)
        Me.txtTitularObra.TabIndex = 1
        '
        'txtLugarObra
        '
        Me.txtLugarObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtLugarObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLugarObra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLugarObra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarObra.ForeColor = System.Drawing.Color.White
        Me.txtLugarObra.Location = New System.Drawing.Point(139, 121)
        Me.txtLugarObra.Name = "txtLugarObra"
        Me.txtLugarObra.Size = New System.Drawing.Size(641, 23)
        Me.txtLugarObra.TabIndex = 5
        '
        'txtObsObra
        '
        Me.txtObsObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObsObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsObra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsObra.ForeColor = System.Drawing.Color.White
        Me.txtObsObra.Location = New System.Drawing.Point(139, 181)
        Me.txtObsObra.Name = "txtObsObra"
        Me.txtObsObra.Size = New System.Drawing.Size(641, 23)
        Me.txtObsObra.TabIndex = 8
        '
        'txtFechaObra
        '
        Me.txtFechaObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFechaObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaObra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaObra.ForeColor = System.Drawing.Color.White
        Me.txtFechaObra.Location = New System.Drawing.Point(679, 92)
        Me.txtFechaObra.Name = "txtFechaObra"
        Me.txtFechaObra.Size = New System.Drawing.Size(100, 23)
        Me.txtFechaObra.TabIndex = 4
        '
        'txtFecEstadoObra
        '
        Me.txtFecEstadoObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecEstadoObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecEstadoObra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecEstadoObra.ForeColor = System.Drawing.Color.White
        Me.txtFecEstadoObra.Location = New System.Drawing.Point(483, 151)
        Me.txtFecEstadoObra.Name = "txtFecEstadoObra"
        Me.txtFecEstadoObra.Size = New System.Drawing.Size(100, 23)
        Me.txtFecEstadoObra.TabIndex = 7
        '
        'cmbEstadoObra
        '
        Me.cmbEstadoObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbEstadoObra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEstadoObra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstadoObra.ForeColor = System.Drawing.Color.White
        Me.cmbEstadoObra.FormattingEnabled = True
        Me.cmbEstadoObra.Items.AddRange(New Object() {"PENDIENTE", "PRESUPUESTADA", "EN PROCESO", "SUSPENDIDA", "TERMINADA"})
        Me.cmbEstadoObra.Location = New System.Drawing.Point(139, 150)
        Me.cmbEstadoObra.Name = "cmbEstadoObra"
        Me.cmbEstadoObra.Size = New System.Drawing.Size(241, 25)
        Me.cmbEstadoObra.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(250, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(351, 36)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Actualización de Obras"
        '
        'dgvObras
        '
        Me.dgvObras.AllowUserToAddRows = False
        Me.dgvObras.AllowUserToDeleteRows = False
        Me.dgvObras.AllowUserToOrderColumns = True
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        Me.dgvObras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvObras.AutoGenerateColumns = False
        Me.dgvObras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvObras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvObras.ColumnHeadersHeight = 30
        Me.dgvObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvObras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdObraDataGridViewTextBoxColumn, Me.ClienteObraDataGridViewTextBoxColumn, Me.NroObraDataGridViewTextBoxColumn, Me.NombreObra, Me.FechaObraDataGridViewTextBoxColumn, Me.TitularObraDataGridViewTextBoxColumn, Me.LugarObraDataGridViewTextBoxColumn, Me.EstadoObraDataGridViewTextBoxColumn, Me.FecEstadoObraDataGridViewTextBoxColumn, Me.ObsObraDataGridViewTextBoxColumn})
        Me.dgvObras.DataSource = Me.ObrasBindingSource
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvObras.DefaultCellStyle = DataGridViewCellStyle20
        Me.dgvObras.EnableHeadersVisualStyles = False
        Me.dgvObras.GridColor = System.Drawing.Color.White
        Me.dgvObras.Location = New System.Drawing.Point(27, 220)
        Me.dgvObras.Name = "dgvObras"
        Me.dgvObras.ReadOnly = True
        Me.dgvObras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObras.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvObras.Size = New System.Drawing.Size(835, 267)
        Me.dgvObras.TabIndex = 9
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.AutoSize = True
        Me.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActualizar.FlatAppearance.BorderSize = 0
        Me.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(655, 501)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnActualizar.Size = New System.Drawing.Size(87, 56)
        Me.BtnActualizar.TabIndex = 15
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.AutoSize = True
        Me.BtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGrabar.FlatAppearance.BorderSize = 0
        Me.BtnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrabar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.ForeColor = System.Drawing.Color.White
        Me.BtnGrabar.Image = CType(resources.GetObject("BtnGrabar.Image"), System.Drawing.Image)
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGrabar.Location = New System.Drawing.Point(168, 501)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGrabar.Size = New System.Drawing.Size(59, 56)
        Me.BtnGrabar.TabIndex = 11
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGrabar.UseVisualStyleBackColor = True
        Me.BtnGrabar.Visible = False
        '
        'BtnSalir
        '
        Me.BtnSalir.AutoSize = True
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(777, 501)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(77, 56)
        Me.BtnSalir.TabIndex = 16
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.AutoSize = True
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnModificar.Location = New System.Drawing.Point(281, 501)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnModificar.Size = New System.Drawing.Size(80, 56)
        Me.BtnModificar.TabIndex = 12
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.AutoSize = True
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(415, 501)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEliminar.Size = New System.Drawing.Size(73, 56)
        Me.BtnEliminar.TabIndex = 13
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.AutoSize = True
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar.Location = New System.Drawing.Point(542, 501)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnBuscar.Size = New System.Drawing.Size(59, 56)
        Me.BtnBuscar.TabIndex = 14
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.AutoSize = True
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAgregar.Location = New System.Drawing.Point(48, 501)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAgregar.Size = New System.Drawing.Size(66, 56)
        Me.BtnAgregar.TabIndex = 10
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(27, 493)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(738, 73)
        Me.PictureBox1.TabIndex = 127
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(771, 493)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(89, 73)
        Me.PictureBox3.TabIndex = 129
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(27, 54)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(835, 160)
        Me.PictureBox2.TabIndex = 130
        Me.PictureBox2.TabStop = False
        '
        'ObrasTableAdapter
        '
        Me.ObrasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adicionalesTableAdapter = Nothing
        Me.TableAdapterManager.adicionjobsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categempleTableAdapter = Nothing
        Me.TableAdapterManager.categivaTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.codpostalTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.comprobantesTableAdapter = Nothing
        Me.TableAdapterManager.conceptosTableAdapter = Nothing
        Me.TableAdapterManager.ctactecliTableAdapter = Nothing
        Me.TableAdapterManager.ctacteempTableAdapter = Nothing
        Me.TableAdapterManager.ctacteproTableAdapter = Nothing
        Me.TableAdapterManager.detallecpraTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.gruposobrasTableAdapter = Nothing
        Me.TableAdapterManager.gruposTableAdapter = Nothing
        Me.TableAdapterManager.herramientasTableAdapter = Nothing
        Me.TableAdapterManager.horasjobsTableAdapter = Nothing
        Me.TableAdapterManager.obrasTableAdapter = Me.ObrasTableAdapter
        Me.TableAdapterManager.operadoresTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.subrubrosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Soint.dbsointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'txtNombreObra
        '
        Me.txtNombreObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombreObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreObra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreObra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObrasBindingSource, "NombreObra", True))
        Me.txtNombreObra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreObra.ForeColor = System.Drawing.Color.White
        Me.txtNombreObra.Location = New System.Drawing.Point(283, 92)
        Me.txtNombreObra.Name = "txtNombreObra"
        Me.txtNombreObra.Size = New System.Drawing.Size(296, 23)
        Me.txtNombreObra.TabIndex = 3
        '
        'IdObraDataGridViewTextBoxColumn
        '
        Me.IdObraDataGridViewTextBoxColumn.DataPropertyName = "id_Obra"
        Me.IdObraDataGridViewTextBoxColumn.HeaderText = "id_Obra"
        Me.IdObraDataGridViewTextBoxColumn.Name = "IdObraDataGridViewTextBoxColumn"
        Me.IdObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdObraDataGridViewTextBoxColumn.Visible = False
        '
        'ClienteObraDataGridViewTextBoxColumn
        '
        Me.ClienteObraDataGridViewTextBoxColumn.DataPropertyName = "ClienteObra"
        Me.ClienteObraDataGridViewTextBoxColumn.HeaderText = "ClienteObra"
        Me.ClienteObraDataGridViewTextBoxColumn.Name = "ClienteObraDataGridViewTextBoxColumn"
        Me.ClienteObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteObraDataGridViewTextBoxColumn.Visible = False
        '
        'NroObraDataGridViewTextBoxColumn
        '
        Me.NroObraDataGridViewTextBoxColumn.DataPropertyName = "NroObra"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NroObraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle17
        Me.NroObraDataGridViewTextBoxColumn.HeaderText = "NRO."
        Me.NroObraDataGridViewTextBoxColumn.Name = "NroObraDataGridViewTextBoxColumn"
        Me.NroObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroObraDataGridViewTextBoxColumn.Width = 50
        '
        'NombreObra
        '
        Me.NombreObra.DataPropertyName = "NombreObra"
        Me.NombreObra.HeaderText = "NOMBRE"
        Me.NombreObra.Name = "NombreObra"
        Me.NombreObra.ReadOnly = True
        Me.NombreObra.Width = 200
        '
        'FechaObraDataGridViewTextBoxColumn
        '
        Me.FechaObraDataGridViewTextBoxColumn.DataPropertyName = "FechaObra"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FechaObraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle18
        Me.FechaObraDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FechaObraDataGridViewTextBoxColumn.Name = "FechaObraDataGridViewTextBoxColumn"
        Me.FechaObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaObraDataGridViewTextBoxColumn.Width = 80
        '
        'TitularObraDataGridViewTextBoxColumn
        '
        Me.TitularObraDataGridViewTextBoxColumn.DataPropertyName = "TitularObra"
        Me.TitularObraDataGridViewTextBoxColumn.HeaderText = "TitularObra"
        Me.TitularObraDataGridViewTextBoxColumn.Name = "TitularObraDataGridViewTextBoxColumn"
        Me.TitularObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitularObraDataGridViewTextBoxColumn.Visible = False
        '
        'LugarObraDataGridViewTextBoxColumn
        '
        Me.LugarObraDataGridViewTextBoxColumn.DataPropertyName = "LugarObra"
        Me.LugarObraDataGridViewTextBoxColumn.HeaderText = "LUGAR"
        Me.LugarObraDataGridViewTextBoxColumn.Name = "LugarObraDataGridViewTextBoxColumn"
        Me.LugarObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.LugarObraDataGridViewTextBoxColumn.Width = 200
        '
        'EstadoObraDataGridViewTextBoxColumn
        '
        Me.EstadoObraDataGridViewTextBoxColumn.DataPropertyName = "EstadoObra"
        Me.EstadoObraDataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.EstadoObraDataGridViewTextBoxColumn.Name = "EstadoObraDataGridViewTextBoxColumn"
        Me.EstadoObraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FecEstadoObraDataGridViewTextBoxColumn
        '
        Me.FecEstadoObraDataGridViewTextBoxColumn.DataPropertyName = "FecEstadoObra"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FecEstadoObraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle19
        Me.FecEstadoObraDataGridViewTextBoxColumn.HeaderText = "FEC. ESTADO"
        Me.FecEstadoObraDataGridViewTextBoxColumn.Name = "FecEstadoObraDataGridViewTextBoxColumn"
        Me.FecEstadoObraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObsObraDataGridViewTextBoxColumn
        '
        Me.ObsObraDataGridViewTextBoxColumn.DataPropertyName = "ObsObra"
        Me.ObsObraDataGridViewTextBoxColumn.HeaderText = "OBSERVACIÓN"
        Me.ObsObraDataGridViewTextBoxColumn.Name = "ObsObraDataGridViewTextBoxColumn"
        Me.ObsObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsObraDataGridViewTextBoxColumn.Width = 250
        '
        'frmObras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(912, 609)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtNombreObra)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.dgvObras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(EstadoObraLabel1)
        Me.Controls.Add(Me.cmbEstadoObra)
        Me.Controls.Add(FecEstadoObraLabel1)
        Me.Controls.Add(Me.txtFecEstadoObra)
        Me.Controls.Add(FechaObraLabel1)
        Me.Controls.Add(Me.txtFechaObra)
        Me.Controls.Add(Me.txtId_Obra)
        Me.Controls.Add(ClienteObraLabel)
        Me.Controls.Add(Me.txtClienteObra)
        Me.Controls.Add(NroObraLabel)
        Me.Controls.Add(Me.txtNroObra)
        Me.Controls.Add(TitularObraLabel)
        Me.Controls.Add(Me.txtTitularObra)
        Me.Controls.Add(LugarObraLabel)
        Me.Controls.Add(Me.txtLugarObra)
        Me.Controls.Add(ObsObraLabel)
        Me.Controls.Add(Me.txtObsObra)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ObrasBindingNavigator)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmObras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZACIÓN DE OBRAS"
        CType(Me.ObrasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ObrasBindingNavigator.ResumeLayout(False)
        Me.ObrasBindingNavigator.PerformLayout()
        CType(Me.ObrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvObras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents ObrasBindingSource As BindingSource
    Friend WithEvents ObrasTableAdapter As dbsointDataSetTableAdapters.obrasTableAdapter
    Friend WithEvents TableAdapterManager As dbsointDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ObrasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ObrasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId_Obra As TextBox
    Friend WithEvents txtClienteObra As TextBox
    Friend WithEvents txtNroObra As TextBox
    Friend WithEvents txtTitularObra As TextBox
    Friend WithEvents txtLugarObra As TextBox
    Friend WithEvents txtObsObra As TextBox
    Friend WithEvents txtFechaObra As TextBox
    Friend WithEvents txtFecEstadoObra As TextBox
    Friend WithEvents cmbEstadoObra As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvObras As DataGridView
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ManoObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EquiposDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HerramientasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndirectosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtNombreObra As TextBox
    Friend WithEvents IdObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreObra As DataGridViewTextBoxColumn
    Friend WithEvents FechaObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitularObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LugarObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecEstadoObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
