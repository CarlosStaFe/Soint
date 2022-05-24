<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategEmple
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
        Dim NombreCELabel As System.Windows.Forms.Label
        Dim ValorHoraCELabel As System.Windows.Forms.Label
        Dim ObsCELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategEmple))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.CategempleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategempleTableAdapter = New Soint.dbsointDataSetTableAdapters.categempleTableAdapter()
        Me.TableAdapterManager = New Soint.dbsointDataSetTableAdapters.TableAdapterManager()
        Me.CategempleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CategempleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txtId_CE = New System.Windows.Forms.TextBox()
        Me.txtNombreCE = New System.Windows.Forms.TextBox()
        Me.txtValorHoraCE = New System.Windows.Forms.TextBox()
        Me.txtObsCE = New System.Windows.Forms.TextBox()
        Me.dgvCategorias = New System.Windows.Forms.DataGridView()
        Me.IdCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorHoraCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NombreCELabel = New System.Windows.Forms.Label()
        ValorHoraCELabel = New System.Windows.Forms.Label()
        ObsCELabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategempleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategempleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CategempleBindingNavigator.SuspendLayout()
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreCELabel
        '
        NombreCELabel.AutoSize = True
        NombreCELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreCELabel.Location = New System.Drawing.Point(55, 68)
        NombreCELabel.Name = "NombreCELabel"
        NombreCELabel.Size = New System.Drawing.Size(78, 17)
        NombreCELabel.TabIndex = 3
        NombreCELabel.Text = "Cetegoría:"
        '
        'ValorHoraCELabel
        '
        ValorHoraCELabel.AutoSize = True
        ValorHoraCELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorHoraCELabel.Location = New System.Drawing.Point(52, 97)
        ValorHoraCELabel.Name = "ValorHoraCELabel"
        ValorHoraCELabel.Size = New System.Drawing.Size(81, 17)
        ValorHoraCELabel.TabIndex = 5
        ValorHoraCELabel.Text = "Valor Hora:"
        '
        'ObsCELabel
        '
        ObsCELabel.AutoSize = True
        ObsCELabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsCELabel.Location = New System.Drawing.Point(39, 126)
        ObsCELabel.Name = "ObsCELabel"
        ObsCELabel.Size = New System.Drawing.Size(94, 17)
        ObsCELabel.TabIndex = 7
        ObsCELabel.Text = "Observación:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(50, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(638, 36)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Actualización de Categorías de Empleados"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(18, 54)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(712, 134)
        Me.PictureBox4.TabIndex = 145
        Me.PictureBox4.TabStop = False
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategempleBindingSource
        '
        Me.CategempleBindingSource.DataMember = "categemple"
        Me.CategempleBindingSource.DataSource = Me.DbsointDataSet
        '
        'CategempleTableAdapter
        '
        Me.CategempleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adicionalesTableAdapter = Nothing
        Me.TableAdapterManager.adicionjobsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categempleTableAdapter = Me.CategempleTableAdapter
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
        Me.TableAdapterManager.gruposTableAdapter = Nothing
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
        'CategempleBindingNavigator
        '
        Me.CategempleBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CategempleBindingNavigator.AutoSize = False
        Me.CategempleBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CategempleBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CategempleBindingNavigator.BindingSource = Me.CategempleBindingSource
        Me.CategempleBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CategempleBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CategempleBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.CategempleBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategempleBindingNavigator.GripMargin = New System.Windows.Forms.Padding(0)
        Me.CategempleBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CategempleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator2, Me.CategempleBindingNavigatorSaveItem, Me.ToolStripSeparator3, Me.ToolStripButton1})
        Me.CategempleBindingNavigator.Location = New System.Drawing.Point(42, 494)
        Me.CategempleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CategempleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CategempleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CategempleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CategempleBindingNavigator.Name = "CategempleBindingNavigator"
        Me.CategempleBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CategempleBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CategempleBindingNavigator.Size = New System.Drawing.Size(604, 35)
        Me.CategempleBindingNavigator.TabIndex = 0
        Me.CategempleBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(87, 32)
        Me.BindingNavigatorAddNewItem.Text = "Agregar"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 32)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(87, 32)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 32)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 32)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.AutoSize = False
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 34)
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.AutoSize = False
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 32)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 32)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.AutoSize = False
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 35)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 35)
        '
        'CategempleBindingNavigatorSaveItem
        '
        Me.CategempleBindingNavigatorSaveItem.Image = CType(resources.GetObject("CategempleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CategempleBindingNavigatorSaveItem.Name = "CategempleBindingNavigatorSaveItem"
        Me.CategempleBindingNavigatorSaveItem.Size = New System.Drawing.Size(86, 32)
        Me.CategempleBindingNavigatorSaveItem.Text = "Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 35)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 32)
        Me.ToolStripButton1.Text = "Salir"
        '
        'txtId_CE
        '
        Me.txtId_CE.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_CE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_CE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategempleBindingSource, "id_CE", True))
        Me.txtId_CE.Enabled = False
        Me.txtId_CE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_CE.ForeColor = System.Drawing.Color.White
        Me.txtId_CE.Location = New System.Drawing.Point(581, 69)
        Me.txtId_CE.Name = "txtId_CE"
        Me.txtId_CE.Size = New System.Drawing.Size(59, 16)
        Me.txtId_CE.TabIndex = 147
        '
        'txtNombreCE
        '
        Me.txtNombreCE.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombreCE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategempleBindingSource, "NombreCE", True))
        Me.txtNombreCE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCE.ForeColor = System.Drawing.Color.White
        Me.txtNombreCE.Location = New System.Drawing.Point(139, 66)
        Me.txtNombreCE.Name = "txtNombreCE"
        Me.txtNombreCE.Size = New System.Drawing.Size(436, 23)
        Me.txtNombreCE.TabIndex = 149
        '
        'txtValorHoraCE
        '
        Me.txtValorHoraCE.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtValorHoraCE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorHoraCE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategempleBindingSource, "ValorHoraCE", True))
        Me.txtValorHoraCE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorHoraCE.ForeColor = System.Drawing.Color.White
        Me.txtValorHoraCE.Location = New System.Drawing.Point(139, 95)
        Me.txtValorHoraCE.Name = "txtValorHoraCE"
        Me.txtValorHoraCE.Size = New System.Drawing.Size(100, 23)
        Me.txtValorHoraCE.TabIndex = 151
        '
        'txtObsCE
        '
        Me.txtObsCE.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObsCE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsCE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategempleBindingSource, "ObsCE", True))
        Me.txtObsCE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsCE.ForeColor = System.Drawing.Color.White
        Me.txtObsCE.Location = New System.Drawing.Point(139, 124)
        Me.txtObsCE.Multiline = True
        Me.txtObsCE.Name = "txtObsCE"
        Me.txtObsCE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsCE.Size = New System.Drawing.Size(436, 52)
        Me.txtObsCE.TabIndex = 153
        '
        'dgvCategorias
        '
        Me.dgvCategorias.AllowUserToAddRows = False
        Me.dgvCategorias.AllowUserToDeleteRows = False
        Me.dgvCategorias.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCategorias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCategorias.AutoGenerateColumns = False
        Me.dgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCategorias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCategorias.ColumnHeadersHeight = 30
        Me.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCEDataGridViewTextBoxColumn, Me.NombreCEDataGridViewTextBoxColumn, Me.ValorHoraCEDataGridViewTextBoxColumn, Me.ObsCEDataGridViewTextBoxColumn})
        Me.dgvCategorias.DataSource = Me.CategempleBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCategorias.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCategorias.EnableHeadersVisualStyles = False
        Me.dgvCategorias.GridColor = System.Drawing.Color.White
        Me.dgvCategorias.Location = New System.Drawing.Point(18, 194)
        Me.dgvCategorias.Name = "dgvCategorias"
        Me.dgvCategorias.ReadOnly = True
        Me.dgvCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCategorias.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCategorias.Size = New System.Drawing.Size(712, 267)
        Me.dgvCategorias.TabIndex = 154
        '
        'IdCEDataGridViewTextBoxColumn
        '
        Me.IdCEDataGridViewTextBoxColumn.DataPropertyName = "id_CE"
        Me.IdCEDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdCEDataGridViewTextBoxColumn.Name = "IdCEDataGridViewTextBoxColumn"
        Me.IdCEDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCEDataGridViewTextBoxColumn.Visible = False
        Me.IdCEDataGridViewTextBoxColumn.Width = 50
        '
        'NombreCEDataGridViewTextBoxColumn
        '
        Me.NombreCEDataGridViewTextBoxColumn.DataPropertyName = "NombreCE"
        Me.NombreCEDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÓN"
        Me.NombreCEDataGridViewTextBoxColumn.Name = "NombreCEDataGridViewTextBoxColumn"
        Me.NombreCEDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreCEDataGridViewTextBoxColumn.Width = 300
        '
        'ValorHoraCEDataGridViewTextBoxColumn
        '
        Me.ValorHoraCEDataGridViewTextBoxColumn.DataPropertyName = "ValorHoraCE"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ValorHoraCEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ValorHoraCEDataGridViewTextBoxColumn.HeaderText = "IMPORTE"
        Me.ValorHoraCEDataGridViewTextBoxColumn.Name = "ValorHoraCEDataGridViewTextBoxColumn"
        Me.ValorHoraCEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObsCEDataGridViewTextBoxColumn
        '
        Me.ObsCEDataGridViewTextBoxColumn.DataPropertyName = "ObsCE"
        Me.ObsCEDataGridViewTextBoxColumn.HeaderText = "OBS"
        Me.ObsCEDataGridViewTextBoxColumn.Name = "ObsCEDataGridViewTextBoxColumn"
        Me.ObsCEDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsCEDataGridViewTextBoxColumn.Width = 250
        '
        'frmCategEmple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1209, 582)
        Me.Controls.Add(Me.dgvCategorias)
        Me.Controls.Add(Me.txtId_CE)
        Me.Controls.Add(Me.txtNombreCE)
        Me.Controls.Add(Me.txtValorHoraCE)
        Me.Controls.Add(Me.txtObsCE)
        Me.Controls.Add(Me.CategempleBindingNavigator)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(NombreCELabel)
        Me.Controls.Add(ValorHoraCELabel)
        Me.Controls.Add(ObsCELabel)
        Me.Controls.Add(Me.PictureBox4)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCategEmple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ACTUALIZACIÓN DE CATEGORÍA DE EMPLEADOS"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategempleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategempleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CategempleBindingNavigator.ResumeLayout(False)
        Me.CategempleBindingNavigator.PerformLayout()
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents CategempleBindingSource As BindingSource
    Friend WithEvents CategempleTableAdapter As dbsointDataSetTableAdapters.categempleTableAdapter
    Friend WithEvents TableAdapterManager As dbsointDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategempleBindingNavigator As BindingNavigator
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
    Friend WithEvents CategempleBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId_CE As TextBox
    Friend WithEvents txtNombreCE As TextBox
    Friend WithEvents txtValorHoraCE As TextBox
    Friend WithEvents txtObsCE As TextBox
    Friend WithEvents dgvCategorias As DataGridView
    Friend WithEvents IdCEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorHoraCEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsCEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
