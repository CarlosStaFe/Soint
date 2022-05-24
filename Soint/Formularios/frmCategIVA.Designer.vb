<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategIVA
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
        Dim DescripcionCILabel As System.Windows.Forms.Label
        Dim RespInsCILabel As System.Windows.Forms.Label
        Dim RespNoInsCILabel As System.Windows.Forms.Label
        Dim AbrevCILabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategIVA))
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.CategivaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategivaTableAdapter = New Soint.dbsointDataSetTableAdapters.categivaTableAdapter()
        Me.TableAdapterManager = New Soint.dbsointDataSetTableAdapters.TableAdapterManager()
        Me.CategivaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CategivaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_CITextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionCITextBox = New System.Windows.Forms.TextBox()
        Me.RespInsCITextBox = New System.Windows.Forms.TextBox()
        Me.RespNoInsCITextBox = New System.Windows.Forms.TextBox()
        Me.AbrevCITextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvCodpostal = New System.Windows.Forms.DataGridView()
        Me.IdCIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionCIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RespInsCIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RespNoInsCIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbrevCIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        DescripcionCILabel = New System.Windows.Forms.Label()
        RespInsCILabel = New System.Windows.Forms.Label()
        RespNoInsCILabel = New System.Windows.Forms.Label()
        AbrevCILabel = New System.Windows.Forms.Label()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategivaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategivaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CategivaBindingNavigator.SuspendLayout()
        CType(Me.dgvCodpostal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionCILabel
        '
        DescripcionCILabel.AutoSize = True
        DescripcionCILabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionCILabel.Location = New System.Drawing.Point(148, 64)
        DescripcionCILabel.Name = "DescripcionCILabel"
        DescripcionCILabel.Size = New System.Drawing.Size(87, 17)
        DescripcionCILabel.TabIndex = 3
        DescripcionCILabel.Text = "Descripción:"
        '
        'RespInsCILabel
        '
        RespInsCILabel.AutoSize = True
        RespInsCILabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RespInsCILabel.Location = New System.Drawing.Point(70, 93)
        RespInsCILabel.Name = "RespInsCILabel"
        RespInsCILabel.Size = New System.Drawing.Size(165, 17)
        RespInsCILabel.TabIndex = 5
        RespInsCILabel.Text = "% Responsable Inscripto:"
        '
        'RespNoInsCILabel
        '
        RespNoInsCILabel.AutoSize = True
        RespNoInsCILabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RespNoInsCILabel.Location = New System.Drawing.Point(300, 93)
        RespNoInsCILabel.Name = "RespNoInsCILabel"
        RespNoInsCILabel.Size = New System.Drawing.Size(130, 17)
        RespNoInsCILabel.TabIndex = 7
        RespNoInsCILabel.Text = "% No Responsable:"
        '
        'AbrevCILabel
        '
        AbrevCILabel.AutoSize = True
        AbrevCILabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AbrevCILabel.Location = New System.Drawing.Point(493, 93)
        AbrevCILabel.Name = "AbrevCILabel"
        AbrevCILabel.Size = New System.Drawing.Size(88, 17)
        AbrevCILabel.TabIndex = 9
        AbrevCILabel.Text = "Abreviatura:"
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategivaBindingSource
        '
        Me.CategivaBindingSource.DataMember = "categiva"
        Me.CategivaBindingSource.DataSource = Me.DbsointDataSet
        '
        'CategivaTableAdapter
        '
        Me.CategivaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adicionalesTableAdapter = Nothing
        Me.TableAdapterManager.adicionjobsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categempleTableAdapter = Nothing
        Me.TableAdapterManager.categivaTableAdapter = Me.CategivaTableAdapter
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
        'CategivaBindingNavigator
        '
        Me.CategivaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CategivaBindingNavigator.AutoSize = False
        Me.CategivaBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CategivaBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CategivaBindingNavigator.BindingSource = Me.CategivaBindingSource
        Me.CategivaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CategivaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CategivaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.CategivaBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategivaBindingNavigator.GripMargin = New System.Windows.Forms.Padding(0)
        Me.CategivaBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CategivaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator2, Me.CategivaBindingNavigatorSaveItem, Me.ToolStripSeparator3, Me.ToolStripButton1})
        Me.CategivaBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.CategivaBindingNavigator.Location = New System.Drawing.Point(38, 364)
        Me.CategivaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CategivaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CategivaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CategivaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CategivaBindingNavigator.Name = "CategivaBindingNavigator"
        Me.CategivaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CategivaBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CategivaBindingNavigator.Size = New System.Drawing.Size(618, 36)
        Me.CategivaBindingNavigator.TabIndex = 0
        Me.CategivaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(93, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 20)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(90, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.AutoSize = False
        Me.BindingNavigatorSeparator.ForeColor = System.Drawing.Color.OrangeRed
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
        Me.BindingNavigatorSeparator1.ForeColor = System.Drawing.Color.OrangeRed
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.AutoSize = False
        Me.BindingNavigatorSeparator2.ForeColor = System.Drawing.Color.OrangeRed
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'CategivaBindingNavigatorSaveItem
        '
        Me.CategivaBindingNavigatorSaveItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategivaBindingNavigatorSaveItem.Image = CType(resources.GetObject("CategivaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CategivaBindingNavigatorSaveItem.Name = "CategivaBindingNavigatorSaveItem"
        Me.CategivaBindingNavigatorSaveItem.Size = New System.Drawing.Size(90, 24)
        Me.CategivaBindingNavigatorSaveItem.Text = "Guardar"
        '
        'Id_CITextBox
        '
        Me.Id_CITextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Id_CITextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Id_CITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategivaBindingSource, "id_CI", True))
        Me.Id_CITextBox.Enabled = False
        Me.Id_CITextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_CITextBox.ForeColor = System.Drawing.Color.White
        Me.Id_CITextBox.Location = New System.Drawing.Point(645, 64)
        Me.Id_CITextBox.Name = "Id_CITextBox"
        Me.Id_CITextBox.Size = New System.Drawing.Size(41, 16)
        Me.Id_CITextBox.TabIndex = 2
        '
        'DescripcionCITextBox
        '
        Me.DescripcionCITextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DescripcionCITextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescripcionCITextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescripcionCITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategivaBindingSource, "DescripcionCI", True))
        Me.DescripcionCITextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionCITextBox.ForeColor = System.Drawing.Color.White
        Me.DescripcionCITextBox.Location = New System.Drawing.Point(241, 62)
        Me.DescripcionCITextBox.Name = "DescripcionCITextBox"
        Me.DescripcionCITextBox.Size = New System.Drawing.Size(398, 23)
        Me.DescripcionCITextBox.TabIndex = 4
        '
        'RespInsCITextBox
        '
        Me.RespInsCITextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RespInsCITextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RespInsCITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategivaBindingSource, "RespInsCI", True))
        Me.RespInsCITextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RespInsCITextBox.ForeColor = System.Drawing.Color.White
        Me.RespInsCITextBox.Location = New System.Drawing.Point(241, 91)
        Me.RespInsCITextBox.Name = "RespInsCITextBox"
        Me.RespInsCITextBox.Size = New System.Drawing.Size(51, 23)
        Me.RespInsCITextBox.TabIndex = 6
        '
        'RespNoInsCITextBox
        '
        Me.RespNoInsCITextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RespNoInsCITextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RespNoInsCITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategivaBindingSource, "RespNoInsCI", True))
        Me.RespNoInsCITextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RespNoInsCITextBox.ForeColor = System.Drawing.Color.White
        Me.RespNoInsCITextBox.Location = New System.Drawing.Point(436, 91)
        Me.RespNoInsCITextBox.Name = "RespNoInsCITextBox"
        Me.RespNoInsCITextBox.Size = New System.Drawing.Size(51, 23)
        Me.RespNoInsCITextBox.TabIndex = 8
        '
        'AbrevCITextBox
        '
        Me.AbrevCITextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.AbrevCITextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AbrevCITextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AbrevCITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategivaBindingSource, "AbrevCI", True))
        Me.AbrevCITextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbrevCITextBox.ForeColor = System.Drawing.Color.White
        Me.AbrevCITextBox.Location = New System.Drawing.Point(587, 91)
        Me.AbrevCITextBox.Name = "AbrevCITextBox"
        Me.AbrevCITextBox.Size = New System.Drawing.Size(52, 23)
        Me.AbrevCITextBox.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(131, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(551, 36)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Actualización de Conceptos de I.V.A."
        '
        'dgvCodpostal
        '
        Me.dgvCodpostal.AllowUserToAddRows = False
        Me.dgvCodpostal.AllowUserToDeleteRows = False
        Me.dgvCodpostal.AllowUserToOrderColumns = True
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle36.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCodpostal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle36
        Me.dgvCodpostal.AutoGenerateColumns = False
        Me.dgvCodpostal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvCodpostal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle37.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCodpostal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle37
        Me.dgvCodpostal.ColumnHeadersHeight = 30
        Me.dgvCodpostal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCodpostal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCIDataGridViewTextBoxColumn, Me.DescripcionCIDataGridViewTextBoxColumn, Me.RespInsCIDataGridViewTextBoxColumn, Me.RespNoInsCIDataGridViewTextBoxColumn, Me.AbrevCIDataGridViewTextBoxColumn})
        Me.dgvCodpostal.DataSource = Me.CategivaBindingSource
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle41.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle41.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCodpostal.DefaultCellStyle = DataGridViewCellStyle41
        Me.dgvCodpostal.EnableHeadersVisualStyles = False
        Me.dgvCodpostal.GridColor = System.Drawing.Color.White
        Me.dgvCodpostal.Location = New System.Drawing.Point(12, 132)
        Me.dgvCodpostal.Name = "dgvCodpostal"
        Me.dgvCodpostal.ReadOnly = True
        Me.dgvCodpostal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle42.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle42.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCodpostal.RowHeadersDefaultCellStyle = DataGridViewCellStyle42
        Me.dgvCodpostal.Size = New System.Drawing.Size(759, 216)
        Me.dgvCodpostal.TabIndex = 109
        '
        'IdCIDataGridViewTextBoxColumn
        '
        Me.IdCIDataGridViewTextBoxColumn.DataPropertyName = "id_CI"
        Me.IdCIDataGridViewTextBoxColumn.HeaderText = "id_CI"
        Me.IdCIDataGridViewTextBoxColumn.Name = "IdCIDataGridViewTextBoxColumn"
        Me.IdCIDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCIDataGridViewTextBoxColumn.Visible = False
        '
        'DescripcionCIDataGridViewTextBoxColumn
        '
        Me.DescripcionCIDataGridViewTextBoxColumn.DataPropertyName = "DescripcionCI"
        Me.DescripcionCIDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÓN"
        Me.DescripcionCIDataGridViewTextBoxColumn.Name = "DescripcionCIDataGridViewTextBoxColumn"
        Me.DescripcionCIDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionCIDataGridViewTextBoxColumn.Width = 250
        '
        'RespInsCIDataGridViewTextBoxColumn
        '
        Me.RespInsCIDataGridViewTextBoxColumn.DataPropertyName = "RespInsCI"
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle38.Format = "N2"
        DataGridViewCellStyle38.NullValue = Nothing
        Me.RespInsCIDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle38
        Me.RespInsCIDataGridViewTextBoxColumn.HeaderText = "% RESP. INSCRIPTO"
        Me.RespInsCIDataGridViewTextBoxColumn.Name = "RespInsCIDataGridViewTextBoxColumn"
        Me.RespInsCIDataGridViewTextBoxColumn.ReadOnly = True
        Me.RespInsCIDataGridViewTextBoxColumn.Width = 180
        '
        'RespNoInsCIDataGridViewTextBoxColumn
        '
        Me.RespNoInsCIDataGridViewTextBoxColumn.DataPropertyName = "RespNoInsCI"
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle39.Format = "N2"
        DataGridViewCellStyle39.NullValue = Nothing
        Me.RespNoInsCIDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle39
        Me.RespNoInsCIDataGridViewTextBoxColumn.HeaderText = "% NO RESPONSABLE"
        Me.RespNoInsCIDataGridViewTextBoxColumn.Name = "RespNoInsCIDataGridViewTextBoxColumn"
        Me.RespNoInsCIDataGridViewTextBoxColumn.ReadOnly = True
        Me.RespNoInsCIDataGridViewTextBoxColumn.Width = 180
        '
        'AbrevCIDataGridViewTextBoxColumn
        '
        Me.AbrevCIDataGridViewTextBoxColumn.DataPropertyName = "AbrevCI"
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AbrevCIDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle40
        Me.AbrevCIDataGridViewTextBoxColumn.HeaderText = "ABREVIACIÓN"
        Me.AbrevCIDataGridViewTextBoxColumn.Name = "AbrevCIDataGridViewTextBoxColumn"
        Me.AbrevCIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(12, 52)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(759, 74)
        Me.PictureBox4.TabIndex = 147
        Me.PictureBox4.TabStop = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(63, 24)
        Me.ToolStripButton1.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.OrangeRed
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.OrangeRed
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.ForeColor = System.Drawing.Color.OrangeRed
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 34)
        '
        'frmCategIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(818, 487)
        Me.Controls.Add(Me.dgvCodpostal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Id_CITextBox)
        Me.Controls.Add(DescripcionCILabel)
        Me.Controls.Add(Me.DescripcionCITextBox)
        Me.Controls.Add(RespInsCILabel)
        Me.Controls.Add(Me.RespInsCITextBox)
        Me.Controls.Add(RespNoInsCILabel)
        Me.Controls.Add(Me.RespNoInsCITextBox)
        Me.Controls.Add(AbrevCILabel)
        Me.Controls.Add(Me.AbrevCITextBox)
        Me.Controls.Add(Me.CategivaBindingNavigator)
        Me.Controls.Add(Me.PictureBox4)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCategIVA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZACIÓN DE LA CATEGORÍAS DE I.V.A."
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategivaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategivaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CategivaBindingNavigator.ResumeLayout(False)
        Me.CategivaBindingNavigator.PerformLayout()
        CType(Me.dgvCodpostal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents CategivaBindingSource As BindingSource
    Friend WithEvents CategivaTableAdapter As dbsointDataSetTableAdapters.categivaTableAdapter
    Friend WithEvents TableAdapterManager As dbsointDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategivaBindingNavigator As BindingNavigator
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
    Friend WithEvents CategivaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Id_CITextBox As TextBox
    Friend WithEvents DescripcionCITextBox As TextBox
    Friend WithEvents RespInsCITextBox As TextBox
    Friend WithEvents RespNoInsCITextBox As TextBox
    Friend WithEvents AbrevCITextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvCodpostal As DataGridView
    Friend WithEvents IdCIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionCIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RespInsCIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RespNoInsCIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbrevCIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
