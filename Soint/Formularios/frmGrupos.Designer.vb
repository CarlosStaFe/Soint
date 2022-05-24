<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrupos
    Inherits System.Windows.Forms.Form

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
        Dim NombreGrupoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrupos))
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.GruposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GruposTableAdapter = New Soint.dbsointDataSetTableAdapters.gruposTableAdapter()
        Me.TableAdapterManager = New Soint.dbsointDataSetTableAdapters.TableAdapterManager()
        Me.Id_GrupoTextBox = New System.Windows.Forms.TextBox()
        Me.txtNombreGrupo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvObras = New System.Windows.Forms.DataGridView()
        Me.IdGrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreGrupoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GruposBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.GruposBindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.GruposBindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviusItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.GruposBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        NombreGrupoLabel = New System.Windows.Forms.Label()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvObras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GruposBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GruposBindingNavigator.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreGrupoLabel
        '
        NombreGrupoLabel.AutoSize = True
        NombreGrupoLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreGrupoLabel.Location = New System.Drawing.Point(81, 64)
        NombreGrupoLabel.Name = "NombreGrupoLabel"
        NombreGrupoLabel.Size = New System.Drawing.Size(110, 17)
        NombreGrupoLabel.TabIndex = 3
        NombreGrupoLabel.Text = "Nombre Grupo:"
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GruposBindingSource
        '
        Me.GruposBindingSource.DataMember = "grupos"
        Me.GruposBindingSource.DataSource = Me.DbsointDataSet
        '
        'GruposTableAdapter
        '
        Me.GruposTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ctactecliTableAdapter = Nothing
        Me.TableAdapterManager.ctacteempTableAdapter = Nothing
        Me.TableAdapterManager.ctacteproTableAdapter = Nothing
        Me.TableAdapterManager.detallecpraTableAdapter = Nothing
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.gruposobrasTableAdapter = Nothing
        Me.TableAdapterManager.gruposTableAdapter = Me.GruposTableAdapter
        Me.TableAdapterManager.herramientasTableAdapter = Nothing
        Me.TableAdapterManager.horasjobsTableAdapter = Nothing
        Me.TableAdapterManager.obrasTableAdapter = Nothing
        Me.TableAdapterManager.operadoresTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.subrubrosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Soint.dbsointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'Id_GrupoTextBox
        '
        Me.Id_GrupoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Id_GrupoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Id_GrupoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GruposBindingSource, "id_Grupo", True))
        Me.Id_GrupoTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_GrupoTextBox.ForeColor = System.Drawing.Color.White
        Me.Id_GrupoTextBox.Location = New System.Drawing.Point(564, 64)
        Me.Id_GrupoTextBox.Name = "Id_GrupoTextBox"
        Me.Id_GrupoTextBox.Size = New System.Drawing.Size(46, 16)
        Me.Id_GrupoTextBox.TabIndex = 2
        '
        'txtNombreGrupo
        '
        Me.txtNombreGrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombreGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreGrupo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GruposBindingSource, "NombreGrupo", True))
        Me.txtNombreGrupo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreGrupo.ForeColor = System.Drawing.Color.White
        Me.txtNombreGrupo.Location = New System.Drawing.Point(197, 62)
        Me.txtNombreGrupo.Name = "txtNombreGrupo"
        Me.txtNombreGrupo.Size = New System.Drawing.Size(354, 23)
        Me.txtNombreGrupo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(156, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(368, 36)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Actualización de Grupos"
        '
        'dgvObras
        '
        Me.dgvObras.AllowUserToAddRows = False
        Me.dgvObras.AllowUserToDeleteRows = False
        Me.dgvObras.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvObras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvObras.AutoGenerateColumns = False
        Me.dgvObras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvObras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvObras.ColumnHeadersHeight = 30
        Me.dgvObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvObras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdGrupoDataGridViewTextBoxColumn, Me.NombreGrupoDataGridViewTextBoxColumn})
        Me.dgvObras.DataSource = Me.GruposBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvObras.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvObras.EnableHeadersVisualStyles = False
        Me.dgvObras.GridColor = System.Drawing.Color.White
        Me.dgvObras.Location = New System.Drawing.Point(63, 103)
        Me.dgvObras.Name = "dgvObras"
        Me.dgvObras.ReadOnly = True
        Me.dgvObras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObras.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvObras.Size = New System.Drawing.Size(564, 246)
        Me.dgvObras.TabIndex = 104
        '
        'IdGrupoDataGridViewTextBoxColumn
        '
        Me.IdGrupoDataGridViewTextBoxColumn.DataPropertyName = "id_Grupo"
        Me.IdGrupoDataGridViewTextBoxColumn.HeaderText = "id_Grupo"
        Me.IdGrupoDataGridViewTextBoxColumn.Name = "IdGrupoDataGridViewTextBoxColumn"
        Me.IdGrupoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdGrupoDataGridViewTextBoxColumn.Visible = False
        '
        'NombreGrupoDataGridViewTextBoxColumn
        '
        Me.NombreGrupoDataGridViewTextBoxColumn.DataPropertyName = "NombreGrupo"
        Me.NombreGrupoDataGridViewTextBoxColumn.HeaderText = "NOMBRE DE GRUPO"
        Me.NombreGrupoDataGridViewTextBoxColumn.Name = "NombreGrupoDataGridViewTextBoxColumn"
        Me.NombreGrupoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreGrupoDataGridViewTextBoxColumn.Width = 500
        '
        'GruposBindingNavigator
        '
        Me.GruposBindingNavigator.AddNewItem = Me.GruposBindingNavigatorAddNewItem
        Me.GruposBindingNavigator.AutoSize = False
        Me.GruposBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.GruposBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GruposBindingNavigator.BindingSource = Me.GruposBindingSource
        Me.GruposBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GruposBindingNavigator.DeleteItem = Me.GruposBindingNavigatorDeleteItem
        Me.GruposBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.GruposBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GruposBindingNavigator.GripMargin = New System.Windows.Forms.Padding(0)
        Me.GruposBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.GruposBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviusItem, Me.ToolStripSeparator1, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.ToolStripSeparator2, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator3, Me.GruposBindingNavigatorAddNewItem, Me.ToolStripSeparator4, Me.GruposBindingNavigatorDeleteItem, Me.ToolStripSeparator5, Me.GruposBindingNavigatorSaveItem, Me.ToolStripSeparator6, Me.btnSalir})
        Me.GruposBindingNavigator.Location = New System.Drawing.Point(38, 359)
        Me.GruposBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GruposBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GruposBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GruposBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviusItem
        Me.GruposBindingNavigator.Name = "GruposBindingNavigator"
        Me.GruposBindingNavigator.Padding = New System.Windows.Forms.Padding(0)
        Me.GruposBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GruposBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.GruposBindingNavigator.Size = New System.Drawing.Size(635, 40)
        Me.GruposBindingNavigator.TabIndex = 149
        Me.GruposBindingNavigator.Text = "BindingNavigator"
        '
        'GruposBindingNavigatorAddNewItem
        '
        Me.GruposBindingNavigatorAddNewItem.Image = CType(resources.GetObject("GruposBindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.GruposBindingNavigatorAddNewItem.Name = "GruposBindingNavigatorAddNewItem"
        Me.GruposBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.GruposBindingNavigatorAddNewItem.Size = New System.Drawing.Size(87, 37)
        Me.GruposBindingNavigatorAddNewItem.Text = "Agregar"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 37)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'GruposBindingNavigatorDeleteItem
        '
        Me.GruposBindingNavigatorDeleteItem.Image = CType(resources.GetObject("GruposBindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.GruposBindingNavigatorDeleteItem.Name = "GruposBindingNavigatorDeleteItem"
        Me.GruposBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.GruposBindingNavigatorDeleteItem.Size = New System.Drawing.Size(87, 37)
        Me.GruposBindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 37)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviusItem
        '
        Me.BindingNavigatorMovePreviusItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviusItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviusItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviusItem.Name = "BindingNavigatorMovePreviusItem"
        Me.BindingNavigatorMovePreviusItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviusItem.Size = New System.Drawing.Size(24, 37)
        Me.BindingNavigatorMovePreviusItem.Text = "Mover anterior"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BindingNavigatorPositionItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 40)
        Me.ToolStripSeparator2.Visible = False
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 37)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 37)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 34)
        '
        'GruposBindingNavigatorSaveItem
        '
        Me.GruposBindingNavigatorSaveItem.Image = CType(resources.GetObject("GruposBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GruposBindingNavigatorSaveItem.Name = "GruposBindingNavigatorSaveItem"
        Me.GruposBindingNavigatorSaveItem.Size = New System.Drawing.Size(86, 37)
        Me.GruposBindingNavigatorSaveItem.Text = "Guardar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 34)
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(62, 37)
        Me.btnSalir.Text = "Salir"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(63, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(564, 47)
        Me.PictureBox2.TabIndex = 150
        Me.PictureBox2.TabStop = False
        '
        'frmGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(740, 477)
        Me.Controls.Add(Me.GruposBindingNavigator)
        Me.Controls.Add(Me.dgvObras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Id_GrupoTextBox)
        Me.Controls.Add(NombreGrupoLabel)
        Me.Controls.Add(Me.txtNombreGrupo)
        Me.Controls.Add(Me.PictureBox2)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGrupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZACIÓN DE GRUPOS"
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvObras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GruposBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GruposBindingNavigator.ResumeLayout(False)
        Me.GruposBindingNavigator.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents GruposBindingSource As BindingSource
    Friend WithEvents GruposTableAdapter As dbsointDataSetTableAdapters.gruposTableAdapter
    Friend WithEvents TableAdapterManager As dbsointDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_GrupoTextBox As TextBox
    Friend WithEvents txtNombreGrupo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvObras As DataGridView
    Friend WithEvents GruposBindingNavigator As BindingNavigator
    Friend WithEvents GruposBindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents GruposBindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviusItem As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents GruposBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents IdGrupoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreGrupoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As PictureBox
End Class
