<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHerramientas
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
        Dim ToolLabel As System.Windows.Forms.Label
        Dim CodigoToolLabel As System.Windows.Forms.Label
        Dim DescripcionToolLabel As System.Windows.Forms.Label
        Dim CantidadToolLabel As System.Windows.Forms.Label
        Dim FuncionaToolLabel As System.Windows.Forms.Label
        Dim ObraToolLabel As System.Windows.Forms.Label
        Dim ResponsableToolLabel As System.Windows.Forms.Label
        Dim ObsToolLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHerramientas))
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.HerramientasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HerramientasTableAdapter = New Soint.dbsointDataSetTableAdapters.herramientasTableAdapter()
        Me.TableAdapterManager = New Soint.dbsointDataSetTableAdapters.TableAdapterManager()
        Me.txtId_Tool = New System.Windows.Forms.TextBox()
        Me.txtTipoTool = New System.Windows.Forms.TextBox()
        Me.txtCodigoTool = New System.Windows.Forms.TextBox()
        Me.txtDescripcionTool = New System.Windows.Forms.TextBox()
        Me.txtCantidadTool = New System.Windows.Forms.TextBox()
        Me.chbFuncionaTool = New System.Windows.Forms.CheckBox()
        Me.txtObraTool = New System.Windows.Forms.TextBox()
        Me.txtResponsableTool = New System.Windows.Forms.TextBox()
        Me.txtObsTool = New System.Windows.Forms.TextBox()
        Me.dgvCodpostal = New System.Windows.Forms.DataGridView()
        Me.IdToolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoToolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoToolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionToolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadToolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FuncionaTool = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ObraToolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsableToolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsToolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.HerramientasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.HerramientasBindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.HerramientasBindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviusItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.HerramientasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        ToolLabel = New System.Windows.Forms.Label()
        CodigoToolLabel = New System.Windows.Forms.Label()
        DescripcionToolLabel = New System.Windows.Forms.Label()
        CantidadToolLabel = New System.Windows.Forms.Label()
        FuncionaToolLabel = New System.Windows.Forms.Label()
        ObraToolLabel = New System.Windows.Forms.Label()
        ResponsableToolLabel = New System.Windows.Forms.Label()
        ObsToolLabel = New System.Windows.Forms.Label()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerramientasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCodpostal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerramientasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HerramientasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolLabel
        '
        ToolLabel.AutoSize = True
        ToolLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ToolLabel.Location = New System.Drawing.Point(96, 64)
        ToolLabel.Name = "ToolLabel"
        ToolLabel.Size = New System.Drawing.Size(38, 17)
        ToolLabel.TabIndex = 3
        ToolLabel.Text = "Tipo:"
        '
        'CodigoToolLabel
        '
        CodigoToolLabel.AutoSize = True
        CodigoToolLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoToolLabel.Location = New System.Drawing.Point(258, 64)
        CodigoToolLabel.Name = "CodigoToolLabel"
        CodigoToolLabel.Size = New System.Drawing.Size(62, 17)
        CodigoToolLabel.TabIndex = 5
        CodigoToolLabel.Text = "Código:"
        '
        'DescripcionToolLabel
        '
        DescripcionToolLabel.AutoSize = True
        DescripcionToolLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionToolLabel.Location = New System.Drawing.Point(440, 64)
        DescripcionToolLabel.Name = "DescripcionToolLabel"
        DescripcionToolLabel.Size = New System.Drawing.Size(87, 17)
        DescripcionToolLabel.TabIndex = 7
        DescripcionToolLabel.Text = "Descripción:"
        '
        'CantidadToolLabel
        '
        CantidadToolLabel.AutoSize = True
        CantidadToolLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CantidadToolLabel.Location = New System.Drawing.Point(59, 93)
        CantidadToolLabel.Name = "CantidadToolLabel"
        CantidadToolLabel.Size = New System.Drawing.Size(75, 17)
        CantidadToolLabel.TabIndex = 9
        CantidadToolLabel.Text = "Cantidad:"
        '
        'FuncionaToolLabel
        '
        FuncionaToolLabel.AutoSize = True
        FuncionaToolLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FuncionaToolLabel.Location = New System.Drawing.Point(249, 93)
        FuncionaToolLabel.Name = "FuncionaToolLabel"
        FuncionaToolLabel.Size = New System.Drawing.Size(71, 17)
        FuncionaToolLabel.TabIndex = 11
        FuncionaToolLabel.Text = "Funciona:"
        '
        'ObraToolLabel
        '
        ObraToolLabel.AutoSize = True
        ObraToolLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObraToolLabel.Location = New System.Drawing.Point(482, 95)
        ObraToolLabel.Name = "ObraToolLabel"
        ObraToolLabel.Size = New System.Drawing.Size(45, 17)
        ObraToolLabel.TabIndex = 13
        ObraToolLabel.Text = "Obra:"
        '
        'ResponsableToolLabel
        '
        ResponsableToolLabel.AutoSize = True
        ResponsableToolLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ResponsableToolLabel.Location = New System.Drawing.Point(41, 122)
        ResponsableToolLabel.Name = "ResponsableToolLabel"
        ResponsableToolLabel.Size = New System.Drawing.Size(93, 17)
        ResponsableToolLabel.TabIndex = 15
        ResponsableToolLabel.Text = "Responsable:"
        '
        'ObsToolLabel
        '
        ObsToolLabel.AutoSize = True
        ObsToolLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsToolLabel.Location = New System.Drawing.Point(433, 124)
        ObsToolLabel.Name = "ObsToolLabel"
        ObsToolLabel.Size = New System.Drawing.Size(94, 17)
        ObsToolLabel.TabIndex = 17
        ObsToolLabel.Text = "Observación:"
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HerramientasBindingSource
        '
        Me.HerramientasBindingSource.DataMember = "herramientas"
        Me.HerramientasBindingSource.DataSource = Me.DbsointDataSet
        '
        'HerramientasTableAdapter
        '
        Me.HerramientasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.herramientasTableAdapter = Me.HerramientasTableAdapter
        Me.TableAdapterManager.horasjobsTableAdapter = Nothing
        Me.TableAdapterManager.obrasTableAdapter = Nothing
        Me.TableAdapterManager.operadoresTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.subrubrosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Soint.dbsointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'txtId_Tool
        '
        Me.txtId_Tool.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_Tool.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_Tool.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerramientasBindingSource, "id_Tool", True))
        Me.txtId_Tool.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_Tool.ForeColor = System.Drawing.Color.White
        Me.txtId_Tool.Location = New System.Drawing.Point(917, 64)
        Me.txtId_Tool.Name = "txtId_Tool"
        Me.txtId_Tool.Size = New System.Drawing.Size(73, 16)
        Me.txtId_Tool.TabIndex = 2
        '
        'txtTipoTool
        '
        Me.txtTipoTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTipoTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoTool.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoTool.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerramientasBindingSource, "TipoTool", True))
        Me.txtTipoTool.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoTool.ForeColor = System.Drawing.Color.White
        Me.txtTipoTool.Location = New System.Drawing.Point(140, 62)
        Me.txtTipoTool.MaxLength = 10
        Me.txtTipoTool.Name = "txtTipoTool"
        Me.txtTipoTool.Size = New System.Drawing.Size(104, 23)
        Me.txtTipoTool.TabIndex = 4
        '
        'txtCodigoTool
        '
        Me.txtCodigoTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCodigoTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoTool.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerramientasBindingSource, "CodigoTool", True))
        Me.txtCodigoTool.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoTool.ForeColor = System.Drawing.Color.White
        Me.txtCodigoTool.Location = New System.Drawing.Point(326, 62)
        Me.txtCodigoTool.MaxLength = 20
        Me.txtCodigoTool.Name = "txtCodigoTool"
        Me.txtCodigoTool.Size = New System.Drawing.Size(104, 23)
        Me.txtCodigoTool.TabIndex = 6
        '
        'txtDescripcionTool
        '
        Me.txtDescripcionTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDescripcionTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionTool.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionTool.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerramientasBindingSource, "DescripcionTool", True))
        Me.txtDescripcionTool.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionTool.ForeColor = System.Drawing.Color.White
        Me.txtDescripcionTool.Location = New System.Drawing.Point(533, 62)
        Me.txtDescripcionTool.MaxLength = 50
        Me.txtDescripcionTool.Name = "txtDescripcionTool"
        Me.txtDescripcionTool.Size = New System.Drawing.Size(378, 23)
        Me.txtDescripcionTool.TabIndex = 8
        '
        'txtCantidadTool
        '
        Me.txtCantidadTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCantidadTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadTool.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerramientasBindingSource, "CantidadTool", True))
        Me.txtCantidadTool.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadTool.ForeColor = System.Drawing.Color.White
        Me.txtCantidadTool.Location = New System.Drawing.Point(140, 91)
        Me.txtCantidadTool.MaxLength = 15
        Me.txtCantidadTool.Name = "txtCantidadTool"
        Me.txtCantidadTool.Size = New System.Drawing.Size(104, 23)
        Me.txtCantidadTool.TabIndex = 10
        '
        'chbFuncionaTool
        '
        Me.chbFuncionaTool.Checked = True
        Me.chbFuncionaTool.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbFuncionaTool.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HerramientasBindingSource, "FuncionaTool", True))
        Me.chbFuncionaTool.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFuncionaTool.Location = New System.Drawing.Point(326, 90)
        Me.chbFuncionaTool.Name = "chbFuncionaTool"
        Me.chbFuncionaTool.Size = New System.Drawing.Size(104, 24)
        Me.chbFuncionaTool.TabIndex = 12
        Me.chbFuncionaTool.Text = "SI"
        Me.chbFuncionaTool.UseVisualStyleBackColor = True
        '
        'txtObraTool
        '
        Me.txtObraTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObraTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObraTool.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObraTool.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerramientasBindingSource, "ObraTool", True))
        Me.txtObraTool.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObraTool.ForeColor = System.Drawing.Color.White
        Me.txtObraTool.Location = New System.Drawing.Point(533, 93)
        Me.txtObraTool.MaxLength = 50
        Me.txtObraTool.Name = "txtObraTool"
        Me.txtObraTool.Size = New System.Drawing.Size(378, 23)
        Me.txtObraTool.TabIndex = 14
        '
        'txtResponsableTool
        '
        Me.txtResponsableTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtResponsableTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResponsableTool.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResponsableTool.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerramientasBindingSource, "ResponsableTool", True))
        Me.txtResponsableTool.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsableTool.ForeColor = System.Drawing.Color.White
        Me.txtResponsableTool.Location = New System.Drawing.Point(140, 120)
        Me.txtResponsableTool.MaxLength = 20
        Me.txtResponsableTool.Name = "txtResponsableTool"
        Me.txtResponsableTool.Size = New System.Drawing.Size(290, 23)
        Me.txtResponsableTool.TabIndex = 16
        '
        'txtObsTool
        '
        Me.txtObsTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObsTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsTool.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerramientasBindingSource, "ObsTool", True))
        Me.txtObsTool.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsTool.ForeColor = System.Drawing.Color.White
        Me.txtObsTool.Location = New System.Drawing.Point(533, 122)
        Me.txtObsTool.MaxLength = 100
        Me.txtObsTool.Multiline = True
        Me.txtObsTool.Name = "txtObsTool"
        Me.txtObsTool.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsTool.Size = New System.Drawing.Size(545, 36)
        Me.txtObsTool.TabIndex = 18
        '
        'dgvCodpostal
        '
        Me.dgvCodpostal.AllowUserToAddRows = False
        Me.dgvCodpostal.AllowUserToOrderColumns = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCodpostal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCodpostal.AutoGenerateColumns = False
        Me.dgvCodpostal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvCodpostal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCodpostal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCodpostal.ColumnHeadersHeight = 30
        Me.dgvCodpostal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCodpostal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdToolDataGridViewTextBoxColumn, Me.TipoToolDataGridViewTextBoxColumn, Me.CodigoToolDataGridViewTextBoxColumn, Me.DescripcionToolDataGridViewTextBoxColumn, Me.CantidadToolDataGridViewTextBoxColumn, Me.FuncionaTool, Me.ObraToolDataGridViewTextBoxColumn, Me.ResponsableToolDataGridViewTextBoxColumn, Me.ObsToolDataGridViewTextBoxColumn})
        Me.dgvCodpostal.DataSource = Me.HerramientasBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCodpostal.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCodpostal.EnableHeadersVisualStyles = False
        Me.dgvCodpostal.GridColor = System.Drawing.Color.White
        Me.dgvCodpostal.Location = New System.Drawing.Point(28, 176)
        Me.dgvCodpostal.Name = "dgvCodpostal"
        Me.dgvCodpostal.ReadOnly = True
        Me.dgvCodpostal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCodpostal.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCodpostal.Size = New System.Drawing.Size(1073, 326)
        Me.dgvCodpostal.TabIndex = 98
        '
        'IdToolDataGridViewTextBoxColumn
        '
        Me.IdToolDataGridViewTextBoxColumn.DataPropertyName = "id_Tool"
        Me.IdToolDataGridViewTextBoxColumn.HeaderText = "id_Tool"
        Me.IdToolDataGridViewTextBoxColumn.Name = "IdToolDataGridViewTextBoxColumn"
        Me.IdToolDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdToolDataGridViewTextBoxColumn.Visible = False
        '
        'TipoToolDataGridViewTextBoxColumn
        '
        Me.TipoToolDataGridViewTextBoxColumn.DataPropertyName = "TipoTool"
        Me.TipoToolDataGridViewTextBoxColumn.HeaderText = "TIPO"
        Me.TipoToolDataGridViewTextBoxColumn.Name = "TipoToolDataGridViewTextBoxColumn"
        Me.TipoToolDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoToolDataGridViewTextBoxColumn
        '
        Me.CodigoToolDataGridViewTextBoxColumn.DataPropertyName = "CodigoTool"
        Me.CodigoToolDataGridViewTextBoxColumn.HeaderText = "CÓDIGO"
        Me.CodigoToolDataGridViewTextBoxColumn.Name = "CodigoToolDataGridViewTextBoxColumn"
        Me.CodigoToolDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionToolDataGridViewTextBoxColumn
        '
        Me.DescripcionToolDataGridViewTextBoxColumn.DataPropertyName = "DescripcionTool"
        Me.DescripcionToolDataGridViewTextBoxColumn.HeaderText = "DESCRIPCIÓN"
        Me.DescripcionToolDataGridViewTextBoxColumn.Name = "DescripcionToolDataGridViewTextBoxColumn"
        Me.DescripcionToolDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionToolDataGridViewTextBoxColumn.Width = 200
        '
        'CantidadToolDataGridViewTextBoxColumn
        '
        Me.CantidadToolDataGridViewTextBoxColumn.DataPropertyName = "CantidadTool"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CantidadToolDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.CantidadToolDataGridViewTextBoxColumn.HeaderText = "CANTIDAD"
        Me.CantidadToolDataGridViewTextBoxColumn.Name = "CantidadToolDataGridViewTextBoxColumn"
        Me.CantidadToolDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadToolDataGridViewTextBoxColumn.Width = 80
        '
        'FuncionaTool
        '
        Me.FuncionaTool.DataPropertyName = "FuncionaTool"
        Me.FuncionaTool.HeaderText = "FUNCIONA"
        Me.FuncionaTool.Name = "FuncionaTool"
        Me.FuncionaTool.ReadOnly = True
        Me.FuncionaTool.Width = 80
        '
        'ObraToolDataGridViewTextBoxColumn
        '
        Me.ObraToolDataGridViewTextBoxColumn.DataPropertyName = "ObraTool"
        Me.ObraToolDataGridViewTextBoxColumn.HeaderText = "OBRA"
        Me.ObraToolDataGridViewTextBoxColumn.Name = "ObraToolDataGridViewTextBoxColumn"
        Me.ObraToolDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObraToolDataGridViewTextBoxColumn.Width = 200
        '
        'ResponsableToolDataGridViewTextBoxColumn
        '
        Me.ResponsableToolDataGridViewTextBoxColumn.DataPropertyName = "ResponsableTool"
        Me.ResponsableToolDataGridViewTextBoxColumn.HeaderText = "RESPONSABLE"
        Me.ResponsableToolDataGridViewTextBoxColumn.Name = "ResponsableToolDataGridViewTextBoxColumn"
        Me.ResponsableToolDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObsToolDataGridViewTextBoxColumn
        '
        Me.ObsToolDataGridViewTextBoxColumn.DataPropertyName = "ObsTool"
        Me.ObsToolDataGridViewTextBoxColumn.HeaderText = "OBSERVACIÓN"
        Me.ObsToolDataGridViewTextBoxColumn.Name = "ObsToolDataGridViewTextBoxColumn"
        Me.ObsToolDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsToolDataGridViewTextBoxColumn.Width = 200
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(310, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(456, 36)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Actualización de Herramientas"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(28, 50)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1073, 120)
        Me.PictureBox4.TabIndex = 147
        Me.PictureBox4.TabStop = False
        '
        'HerramientasBindingNavigator
        '
        Me.HerramientasBindingNavigator.AddNewItem = Me.HerramientasBindingNavigatorAddNewItem
        Me.HerramientasBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HerramientasBindingNavigator.AutoSize = False
        Me.HerramientasBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.HerramientasBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HerramientasBindingNavigator.BindingSource = Me.HerramientasBindingSource
        Me.HerramientasBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.HerramientasBindingNavigator.DeleteItem = Me.HerramientasBindingNavigatorDeleteItem
        Me.HerramientasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.HerramientasBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HerramientasBindingNavigator.GripMargin = New System.Windows.Forms.Padding(0)
        Me.HerramientasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.HerramientasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviusItem, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator3, Me.HerramientasBindingNavigatorAddNewItem, Me.ToolStripSeparator4, Me.HerramientasBindingNavigatorDeleteItem, Me.ToolStripSeparator5, Me.HerramientasBindingNavigatorSaveItem, Me.ToolStripSeparator6, Me.btnSalir})
        Me.HerramientasBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.HerramientasBindingNavigator.Location = New System.Drawing.Point(230, 518)
        Me.HerramientasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HerramientasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HerramientasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HerramientasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviusItem
        Me.HerramientasBindingNavigator.Name = "HerramientasBindingNavigator"
        Me.HerramientasBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.HerramientasBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.HerramientasBindingNavigator.Size = New System.Drawing.Size(635, 40)
        Me.HerramientasBindingNavigator.TabIndex = 148
        Me.HerramientasBindingNavigator.Text = "BindingNavigator1"
        '
        'HerramientasBindingNavigatorAddNewItem
        '
        Me.HerramientasBindingNavigatorAddNewItem.Image = CType(resources.GetObject("HerramientasBindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.HerramientasBindingNavigatorAddNewItem.Name = "HerramientasBindingNavigatorAddNewItem"
        Me.HerramientasBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.HerramientasBindingNavigatorAddNewItem.Size = New System.Drawing.Size(87, 24)
        Me.HerramientasBindingNavigatorAddNewItem.Text = "Agregar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(48, 20)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'HerramientasBindingNavigatorDeleteItem
        '
        Me.HerramientasBindingNavigatorDeleteItem.Image = CType(resources.GetObject("HerramientasBindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.HerramientasBindingNavigatorDeleteItem.Name = "HerramientasBindingNavigatorDeleteItem"
        Me.HerramientasBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.HerramientasBindingNavigatorDeleteItem.Size = New System.Drawing.Size(87, 24)
        Me.HerramientasBindingNavigatorDeleteItem.Text = "Eliminar"
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
        'BindingNavigatorMovePreviusItem
        '
        Me.BindingNavigatorMovePreviusItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviusItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviusItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviusItem.Name = "BindingNavigatorMovePreviusItem"
        Me.BindingNavigatorMovePreviusItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviusItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviusItem.Text = "Mover anterior"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posición"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.ForeColor = System.Drawing.Color.White
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 25)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        Me.ToolStripSeparator2.Visible = False
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
        'HerramientasBindingNavigatorSaveItem
        '
        Me.HerramientasBindingNavigatorSaveItem.Image = CType(resources.GetObject("HerramientasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HerramientasBindingNavigatorSaveItem.Name = "HerramientasBindingNavigatorSaveItem"
        Me.HerramientasBindingNavigatorSaveItem.Size = New System.Drawing.Size(86, 24)
        Me.HerramientasBindingNavigatorSaveItem.Text = "Guardar"
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
        Me.btnSalir.Size = New System.Drawing.Size(62, 24)
        Me.btnSalir.Text = "Salir"
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'frmHerramientas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1137, 587)
        Me.Controls.Add(Me.HerramientasBindingNavigator)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvCodpostal)
        Me.Controls.Add(Me.txtId_Tool)
        Me.Controls.Add(ToolLabel)
        Me.Controls.Add(Me.txtTipoTool)
        Me.Controls.Add(CodigoToolLabel)
        Me.Controls.Add(Me.txtCodigoTool)
        Me.Controls.Add(DescripcionToolLabel)
        Me.Controls.Add(Me.txtDescripcionTool)
        Me.Controls.Add(CantidadToolLabel)
        Me.Controls.Add(Me.txtCantidadTool)
        Me.Controls.Add(FuncionaToolLabel)
        Me.Controls.Add(Me.chbFuncionaTool)
        Me.Controls.Add(ObraToolLabel)
        Me.Controls.Add(Me.txtObraTool)
        Me.Controls.Add(ResponsableToolLabel)
        Me.Controls.Add(Me.txtResponsableTool)
        Me.Controls.Add(ObsToolLabel)
        Me.Controls.Add(Me.txtObsTool)
        Me.Controls.Add(Me.PictureBox4)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHerramientas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ACTUALIZACIÓN DE HERRAMIENTAS"
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerramientasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCodpostal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerramientasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HerramientasBindingNavigator.ResumeLayout(False)
        Me.HerramientasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents HerramientasBindingSource As BindingSource
    Friend WithEvents HerramientasTableAdapter As dbsointDataSetTableAdapters.herramientasTableAdapter
    Friend WithEvents TableAdapterManager As dbsointDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtId_Tool As TextBox
    Friend WithEvents txtTipoTool As TextBox
    Friend WithEvents txtCodigoTool As TextBox
    Friend WithEvents txtDescripcionTool As TextBox
    Friend WithEvents txtCantidadTool As TextBox
    Friend WithEvents chbFuncionaTool As CheckBox
    Friend WithEvents txtObraTool As TextBox
    Friend WithEvents txtResponsableTool As TextBox
    Friend WithEvents txtObsTool As TextBox
    Friend WithEvents dgvCodpostal As DataGridView
    Friend WithEvents IdToolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoToolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoToolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionToolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadToolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FuncionaTool As DataGridViewCheckBoxColumn
    Friend WithEvents ObraToolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResponsableToolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsToolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents HerramientasBindingNavigator As BindingNavigator
    Friend WithEvents HerramientasBindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents HerramientasBindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviusItem As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents HerramientasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents ToolTipMsg As ToolTip
End Class
