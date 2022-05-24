<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdicionales
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
        Dim CodigoAdiLabel As System.Windows.Forms.Label
        Dim DetalleAdiLabel As System.Windows.Forms.Label
        Dim ValorAdiLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdicionales))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.AdicionalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdicionalesTableAdapter = New Soint.dbsointDataSetTableAdapters.adicionalesTableAdapter()
        Me.TableAdapterManager = New Soint.dbsointDataSetTableAdapters.TableAdapterManager()
        Me.AdicionalesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AdicionalesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Id_AdiTextBox = New System.Windows.Forms.TextBox()
        Me.txtCodigoAdi = New System.Windows.Forms.TextBox()
        Me.txtDetalleAdi = New System.Windows.Forms.TextBox()
        Me.txtValorAdi = New System.Windows.Forms.TextBox()
        Me.dgvCodpostal = New System.Windows.Forms.DataGridView()
        Me.IdAdiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoAdiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleAdiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorAdiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CodigoAdiLabel = New System.Windows.Forms.Label()
        DetalleAdiLabel = New System.Windows.Forms.Label()
        ValorAdiLabel = New System.Windows.Forms.Label()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdicionalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdicionalesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdicionalesBindingNavigator.SuspendLayout()
        CType(Me.dgvCodpostal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoAdiLabel
        '
        CodigoAdiLabel.AutoSize = True
        CodigoAdiLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoAdiLabel.Location = New System.Drawing.Point(97, 67)
        CodigoAdiLabel.Name = "CodigoAdiLabel"
        CodigoAdiLabel.Size = New System.Drawing.Size(62, 17)
        CodigoAdiLabel.TabIndex = 102
        CodigoAdiLabel.Text = "Código:"
        '
        'DetalleAdiLabel
        '
        DetalleAdiLabel.AutoSize = True
        DetalleAdiLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DetalleAdiLabel.Location = New System.Drawing.Point(72, 96)
        DetalleAdiLabel.Name = "DetalleAdiLabel"
        DetalleAdiLabel.Size = New System.Drawing.Size(87, 17)
        DetalleAdiLabel.TabIndex = 104
        DetalleAdiLabel.Text = "Descripción:"
        '
        'ValorAdiLabel
        '
        ValorAdiLabel.AutoSize = True
        ValorAdiLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorAdiLabel.Location = New System.Drawing.Point(409, 96)
        ValorAdiLabel.Name = "ValorAdiLabel"
        ValorAdiLabel.Size = New System.Drawing.Size(46, 17)
        ValorAdiLabel.TabIndex = 106
        ValorAdiLabel.Text = "Valor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(101, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(433, 36)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Actualización de Adicionales"
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdicionalesBindingSource
        '
        Me.AdicionalesBindingSource.DataMember = "adicionales"
        Me.AdicionalesBindingSource.DataSource = Me.DbsointDataSet
        '
        'AdicionalesTableAdapter
        '
        Me.AdicionalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adicionalesTableAdapter = Me.AdicionalesTableAdapter
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
        'AdicionalesBindingNavigator
        '
        Me.AdicionalesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AdicionalesBindingNavigator.AutoSize = False
        Me.AdicionalesBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AdicionalesBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AdicionalesBindingNavigator.BindingSource = Me.AdicionalesBindingSource
        Me.AdicionalesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AdicionalesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AdicionalesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.AdicionalesBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdicionalesBindingNavigator.GripMargin = New System.Windows.Forms.Padding(0)
        Me.AdicionalesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AdicionalesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AdicionalesBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.AdicionalesBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.AdicionalesBindingNavigator.Location = New System.Drawing.Point(37, 417)
        Me.AdicionalesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AdicionalesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AdicionalesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AdicionalesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AdicionalesBindingNavigator.Name = "AdicionalesBindingNavigator"
        Me.AdicionalesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AdicionalesBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.AdicionalesBindingNavigator.Size = New System.Drawing.Size(590, 35)
        Me.AdicionalesBindingNavigator.TabIndex = 0
        Me.AdicionalesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
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
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
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
        'AdicionalesBindingNavigatorSaveItem
        '
        Me.AdicionalesBindingNavigatorSaveItem.Image = CType(resources.GetObject("AdicionalesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AdicionalesBindingNavigatorSaveItem.Name = "AdicionalesBindingNavigatorSaveItem"
        Me.AdicionalesBindingNavigatorSaveItem.Size = New System.Drawing.Size(86, 32)
        Me.AdicionalesBindingNavigatorSaveItem.Text = "Guardar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 32)
        Me.ToolStripButton1.Text = "Salir"
        '
        'Id_AdiTextBox
        '
        Me.Id_AdiTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Id_AdiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Id_AdiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdicionalesBindingSource, "id_Adi", True))
        Me.Id_AdiTextBox.Enabled = False
        Me.Id_AdiTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_AdiTextBox.ForeColor = System.Drawing.Color.White
        Me.Id_AdiTextBox.Location = New System.Drawing.Point(244, 67)
        Me.Id_AdiTextBox.Name = "Id_AdiTextBox"
        Me.Id_AdiTextBox.Size = New System.Drawing.Size(60, 16)
        Me.Id_AdiTextBox.TabIndex = 101
        '
        'txtCodigoAdi
        '
        Me.txtCodigoAdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCodigoAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoAdi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdicionalesBindingSource, "CodigoAdi", True))
        Me.txtCodigoAdi.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoAdi.ForeColor = System.Drawing.Color.White
        Me.txtCodigoAdi.Location = New System.Drawing.Point(165, 65)
        Me.txtCodigoAdi.Name = "txtCodigoAdi"
        Me.txtCodigoAdi.Size = New System.Drawing.Size(58, 23)
        Me.txtCodigoAdi.TabIndex = 103
        Me.txtCodigoAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDetalleAdi
        '
        Me.txtDetalleAdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDetalleAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalleAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalleAdi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdicionalesBindingSource, "DetalleAdi", True))
        Me.txtDetalleAdi.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleAdi.ForeColor = System.Drawing.Color.White
        Me.txtDetalleAdi.Location = New System.Drawing.Point(165, 94)
        Me.txtDetalleAdi.Name = "txtDetalleAdi"
        Me.txtDetalleAdi.Size = New System.Drawing.Size(239, 23)
        Me.txtDetalleAdi.TabIndex = 105
        '
        'txtValorAdi
        '
        Me.txtValorAdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtValorAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorAdi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdicionalesBindingSource, "ValorAdi", True))
        Me.txtValorAdi.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorAdi.ForeColor = System.Drawing.Color.White
        Me.txtValorAdi.Location = New System.Drawing.Point(461, 94)
        Me.txtValorAdi.Name = "txtValorAdi"
        Me.txtValorAdi.Size = New System.Drawing.Size(100, 23)
        Me.txtValorAdi.TabIndex = 107
        Me.txtValorAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvCodpostal
        '
        Me.dgvCodpostal.AllowUserToAddRows = False
        Me.dgvCodpostal.AllowUserToDeleteRows = False
        Me.dgvCodpostal.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCodpostal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCodpostal.AutoGenerateColumns = False
        Me.dgvCodpostal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvCodpostal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCodpostal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCodpostal.ColumnHeadersHeight = 30
        Me.dgvCodpostal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCodpostal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAdiDataGridViewTextBoxColumn, Me.CodigoAdiDataGridViewTextBoxColumn, Me.DetalleAdiDataGridViewTextBoxColumn, Me.ValorAdiDataGridViewTextBoxColumn})
        Me.dgvCodpostal.DataSource = Me.AdicionalesBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCodpostal.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCodpostal.EnableHeadersVisualStyles = False
        Me.dgvCodpostal.GridColor = System.Drawing.Color.White
        Me.dgvCodpostal.Location = New System.Drawing.Point(66, 133)
        Me.dgvCodpostal.Name = "dgvCodpostal"
        Me.dgvCodpostal.ReadOnly = True
        Me.dgvCodpostal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCodpostal.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCodpostal.Size = New System.Drawing.Size(507, 267)
        Me.dgvCodpostal.TabIndex = 108
        '
        'IdAdiDataGridViewTextBoxColumn
        '
        Me.IdAdiDataGridViewTextBoxColumn.DataPropertyName = "id_Adi"
        Me.IdAdiDataGridViewTextBoxColumn.HeaderText = "id_Adi"
        Me.IdAdiDataGridViewTextBoxColumn.Name = "IdAdiDataGridViewTextBoxColumn"
        Me.IdAdiDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAdiDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoAdiDataGridViewTextBoxColumn
        '
        Me.CodigoAdiDataGridViewTextBoxColumn.DataPropertyName = "CodigoAdi"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CodigoAdiDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CodigoAdiDataGridViewTextBoxColumn.HeaderText = "CÓDIGO"
        Me.CodigoAdiDataGridViewTextBoxColumn.Name = "CodigoAdiDataGridViewTextBoxColumn"
        Me.CodigoAdiDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoAdiDataGridViewTextBoxColumn.Width = 80
        '
        'DetalleAdiDataGridViewTextBoxColumn
        '
        Me.DetalleAdiDataGridViewTextBoxColumn.DataPropertyName = "DetalleAdi"
        Me.DetalleAdiDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÓN"
        Me.DetalleAdiDataGridViewTextBoxColumn.Name = "DetalleAdiDataGridViewTextBoxColumn"
        Me.DetalleAdiDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleAdiDataGridViewTextBoxColumn.Width = 280
        '
        'ValorAdiDataGridViewTextBoxColumn
        '
        Me.ValorAdiDataGridViewTextBoxColumn.DataPropertyName = "ValorAdi"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ValorAdiDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ValorAdiDataGridViewTextBoxColumn.HeaderText = "VALOR"
        Me.ValorAdiDataGridViewTextBoxColumn.Name = "ValorAdiDataGridViewTextBoxColumn"
        Me.ValorAdiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(66, 53)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(507, 74)
        Me.PictureBox4.TabIndex = 146
        Me.PictureBox4.TabStop = False
        '
        'frmAdicionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(672, 506)
        Me.Controls.Add(Me.dgvCodpostal)
        Me.Controls.Add(Me.Id_AdiTextBox)
        Me.Controls.Add(CodigoAdiLabel)
        Me.Controls.Add(Me.txtCodigoAdi)
        Me.Controls.Add(DetalleAdiLabel)
        Me.Controls.Add(Me.txtDetalleAdi)
        Me.Controls.Add(ValorAdiLabel)
        Me.Controls.Add(Me.txtValorAdi)
        Me.Controls.Add(Me.AdicionalesBindingNavigator)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdicionales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZACIÓN DE ADICIONALES"
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdicionalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdicionalesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdicionalesBindingNavigator.ResumeLayout(False)
        Me.AdicionalesBindingNavigator.PerformLayout()
        CType(Me.dgvCodpostal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents AdicionalesBindingSource As BindingSource
    Friend WithEvents AdicionalesTableAdapter As dbsointDataSetTableAdapters.adicionalesTableAdapter
    Friend WithEvents TableAdapterManager As dbsointDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdicionalesBindingNavigator As BindingNavigator
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
    Friend WithEvents AdicionalesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Id_AdiTextBox As TextBox
    Friend WithEvents txtCodigoAdi As TextBox
    Friend WithEvents txtDetalleAdi As TextBox
    Friend WithEvents txtValorAdi As TextBox
    Friend WithEvents dgvCodpostal As DataGridView
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents IdAdiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoAdiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleAdiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorAdiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
