<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarAdicionales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargarAdicionales))
        Dim txtEmpleadoAJ As System.Windows.Forms.Label
        Dim txtCodigoAJ As System.Windows.Forms.Label
        Dim txtCantidadAJ As System.Windows.Forms.Label
        Dim txtValorAJ As System.Windows.Forms.Label
        Dim txtTotalAJ As System.Windows.Forms.Label
        Dim txtObraAJ As System.Windows.Forms.Label
        Dim txtConceptoAJ As System.Windows.Forms.Label
        Dim txtObsAJ As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.AdicionjobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdicionjobsTableAdapter = New Soint.dbsointDataSetTableAdapters.adicionjobsTableAdapter()
        Me.TableAdapterManager = New Soint.dbsointDataSetTableAdapters.TableAdapterManager()
        Me.AdicionjobsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.AdicionjobsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_AJTextBox = New System.Windows.Forms.TextBox()
        Me.EmpleadoAJTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoAJTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadAJTextBox = New System.Windows.Forms.TextBox()
        Me.ValorAJTextBox = New System.Windows.Forms.TextBox()
        Me.TotalAJTextBox = New System.Windows.Forms.TextBox()
        Me.ObraAJTextBox = New System.Windows.Forms.TextBox()
        Me.ConceptoAJTextBox = New System.Windows.Forms.TextBox()
        Me.ObsAJTextBox = New System.Windows.Forms.TextBox()
        Me.txtNombreEmp = New System.Windows.Forms.TextBox()
        Me.txtNombreAdic = New System.Windows.Forms.TextBox()
        Me.txtTitularObra = New System.Windows.Forms.TextBox()
        Me.txtNombreCpto = New System.Windows.Forms.TextBox()
        Me.dgvHoras = New System.Windows.Forms.DataGridView()
        Me.IdAJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoAJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoAJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadAJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorAJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObraAJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConceptoAJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsAJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        txtEmpleadoAJ = New System.Windows.Forms.Label()
        txtCodigoAJ = New System.Windows.Forms.Label()
        txtCantidadAJ = New System.Windows.Forms.Label()
        txtValorAJ = New System.Windows.Forms.Label()
        txtTotalAJ = New System.Windows.Forms.Label()
        txtObraAJ = New System.Windows.Forms.Label()
        txtConceptoAJ = New System.Windows.Forms.Label()
        txtObsAJ = New System.Windows.Forms.Label()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdicionjobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdicionjobsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdicionjobsBindingNavigator.SuspendLayout()
        CType(Me.dgvHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(137, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(544, 36)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Carga de Adicionales de Empleados"
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdicionjobsBindingSource
        '
        Me.AdicionjobsBindingSource.DataMember = "adicionjobs"
        Me.AdicionjobsBindingSource.DataSource = Me.DbsointDataSet
        '
        'AdicionjobsTableAdapter
        '
        Me.AdicionjobsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adicionalesTableAdapter = Nothing
        Me.TableAdapterManager.adicionjobsTableAdapter = Me.AdicionjobsTableAdapter
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
        Me.TableAdapterManager.horasjobsTableAdapter = Nothing
        Me.TableAdapterManager.obrasTableAdapter = Nothing
        Me.TableAdapterManager.operadoresTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Soint.dbsointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'AdicionjobsBindingNavigator
        '
        Me.AdicionjobsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AdicionjobsBindingNavigator.BindingSource = Me.AdicionjobsBindingSource
        Me.AdicionjobsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AdicionjobsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AdicionjobsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AdicionjobsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AdicionjobsBindingNavigatorSaveItem})
        Me.AdicionjobsBindingNavigator.Location = New System.Drawing.Point(0, 600)
        Me.AdicionjobsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AdicionjobsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AdicionjobsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AdicionjobsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AdicionjobsBindingNavigator.Name = "AdicionjobsBindingNavigator"
        Me.AdicionjobsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AdicionjobsBindingNavigator.Size = New System.Drawing.Size(1057, 25)
        Me.AdicionjobsBindingNavigator.TabIndex = 88
        Me.AdicionjobsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'AdicionjobsBindingNavigatorSaveItem
        '
        Me.AdicionjobsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AdicionjobsBindingNavigatorSaveItem.Image = CType(resources.GetObject("AdicionjobsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AdicionjobsBindingNavigatorSaveItem.Name = "AdicionjobsBindingNavigatorSaveItem"
        Me.AdicionjobsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AdicionjobsBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_AJTextBox
        '
        Me.Id_AJTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Id_AJTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Id_AJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdicionjobsBindingSource, "id_AJ", True))
        Me.Id_AJTextBox.Enabled = False
        Me.Id_AJTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_AJTextBox.ForeColor = System.Drawing.Color.White
        Me.Id_AJTextBox.Location = New System.Drawing.Point(544, 82)
        Me.Id_AJTextBox.Name = "Id_AJTextBox"
        Me.Id_AJTextBox.Size = New System.Drawing.Size(59, 16)
        Me.Id_AJTextBox.TabIndex = 89
        '
        'txtEmpleadoAJ
        '
        txtEmpleadoAJ.AutoSize = True
        txtEmpleadoAJ.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtEmpleadoAJ.Location = New System.Drawing.Point(74, 82)
        txtEmpleadoAJ.Name = "txtEmpleadoAJ"
        txtEmpleadoAJ.Size = New System.Drawing.Size(79, 17)
        txtEmpleadoAJ.TabIndex = 90
        txtEmpleadoAJ.Text = "Empleado:"
        '
        'EmpleadoAJTextBox
        '
        Me.EmpleadoAJTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.EmpleadoAJTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpleadoAJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdicionjobsBindingSource, "EmpleadoAJ", True))
        Me.EmpleadoAJTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpleadoAJTextBox.ForeColor = System.Drawing.Color.White
        Me.EmpleadoAJTextBox.Location = New System.Drawing.Point(159, 80)
        Me.EmpleadoAJTextBox.Name = "EmpleadoAJTextBox"
        Me.EmpleadoAJTextBox.Size = New System.Drawing.Size(62, 23)
        Me.EmpleadoAJTextBox.TabIndex = 91
        '
        'txtCodigoAJ
        '
        txtCodigoAJ.AutoSize = True
        txtCodigoAJ.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtCodigoAJ.Location = New System.Drawing.Point(80, 111)
        txtCodigoAJ.Name = "txtCodigoAJ"
        txtCodigoAJ.Size = New System.Drawing.Size(73, 17)
        txtCodigoAJ.TabIndex = 92
        txtCodigoAJ.Text = "Adicional:"
        '
        'CodigoAJTextBox
        '
        Me.CodigoAJTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CodigoAJTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CodigoAJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdicionjobsBindingSource, "CodigoAJ", True))
        Me.CodigoAJTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoAJTextBox.ForeColor = System.Drawing.Color.White
        Me.CodigoAJTextBox.Location = New System.Drawing.Point(159, 109)
        Me.CodigoAJTextBox.Name = "CodigoAJTextBox"
        Me.CodigoAJTextBox.Size = New System.Drawing.Size(62, 23)
        Me.CodigoAJTextBox.TabIndex = 93
        '
        'txtCantidadAJ
        '
        txtCantidadAJ.AutoSize = True
        txtCantidadAJ.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtCantidadAJ.Location = New System.Drawing.Point(78, 140)
        txtCantidadAJ.Name = "txtCantidadAJ"
        txtCantidadAJ.Size = New System.Drawing.Size(75, 17)
        txtCantidadAJ.TabIndex = 94
        txtCantidadAJ.Text = "Cantidad:"
        '
        'CantidadAJTextBox
        '
        Me.CantidadAJTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CantidadAJTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CantidadAJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdicionjobsBindingSource, "CantidadAJ", True))
        Me.CantidadAJTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadAJTextBox.ForeColor = System.Drawing.Color.White
        Me.CantidadAJTextBox.Location = New System.Drawing.Point(159, 138)
        Me.CantidadAJTextBox.Name = "CantidadAJTextBox"
        Me.CantidadAJTextBox.Size = New System.Drawing.Size(62, 23)
        Me.CantidadAJTextBox.TabIndex = 95
        '
        'txtValorAJ
        '
        txtValorAJ.AutoSize = True
        txtValorAJ.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtValorAJ.Location = New System.Drawing.Point(244, 140)
        txtValorAJ.Name = "txtValorAJ"
        txtValorAJ.Size = New System.Drawing.Size(63, 17)
        txtValorAJ.TabIndex = 96
        txtValorAJ.Text = "Importe:"
        '
        'ValorAJTextBox
        '
        Me.ValorAJTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ValorAJTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValorAJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdicionjobsBindingSource, "ValorAJ", True))
        Me.ValorAJTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorAJTextBox.ForeColor = System.Drawing.Color.White
        Me.ValorAJTextBox.Location = New System.Drawing.Point(313, 138)
        Me.ValorAJTextBox.Name = "ValorAJTextBox"
        Me.ValorAJTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ValorAJTextBox.TabIndex = 97
        '
        'txtTotalAJ
        '
        txtTotalAJ.AutoSize = True
        txtTotalAJ.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtTotalAJ.Location = New System.Drawing.Point(454, 140)
        txtTotalAJ.Name = "txtTotalAJ"
        txtTotalAJ.Size = New System.Drawing.Size(43, 17)
        txtTotalAJ.TabIndex = 98
        txtTotalAJ.Text = "Total:"
        '
        'TotalAJTextBox
        '
        Me.TotalAJTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TotalAJTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalAJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdicionjobsBindingSource, "TotalAJ", True))
        Me.TotalAJTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAJTextBox.ForeColor = System.Drawing.Color.White
        Me.TotalAJTextBox.Location = New System.Drawing.Point(503, 138)
        Me.TotalAJTextBox.Name = "TotalAJTextBox"
        Me.TotalAJTextBox.Size = New System.Drawing.Size(100, 23)
        Me.TotalAJTextBox.TabIndex = 99
        '
        'txtObraAJ
        '
        txtObraAJ.AutoSize = True
        txtObraAJ.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtObraAJ.Location = New System.Drawing.Point(108, 169)
        txtObraAJ.Name = "txtObraAJ"
        txtObraAJ.Size = New System.Drawing.Size(45, 17)
        txtObraAJ.TabIndex = 100
        txtObraAJ.Text = "Obra:"
        '
        'ObraAJTextBox
        '
        Me.ObraAJTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ObraAJTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ObraAJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdicionjobsBindingSource, "ObraAJ", True))
        Me.ObraAJTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObraAJTextBox.ForeColor = System.Drawing.Color.White
        Me.ObraAJTextBox.Location = New System.Drawing.Point(159, 167)
        Me.ObraAJTextBox.Name = "ObraAJTextBox"
        Me.ObraAJTextBox.Size = New System.Drawing.Size(62, 23)
        Me.ObraAJTextBox.TabIndex = 101
        '
        'txtConceptoAJ
        '
        txtConceptoAJ.AutoSize = True
        txtConceptoAJ.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtConceptoAJ.Location = New System.Drawing.Point(74, 198)
        txtConceptoAJ.Name = "txtConceptoAJ"
        txtConceptoAJ.Size = New System.Drawing.Size(79, 17)
        txtConceptoAJ.TabIndex = 102
        txtConceptoAJ.Text = "Concepto:"
        '
        'ConceptoAJTextBox
        '
        Me.ConceptoAJTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ConceptoAJTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConceptoAJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdicionjobsBindingSource, "ConceptoAJ", True))
        Me.ConceptoAJTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConceptoAJTextBox.ForeColor = System.Drawing.Color.White
        Me.ConceptoAJTextBox.Location = New System.Drawing.Point(159, 196)
        Me.ConceptoAJTextBox.Name = "ConceptoAJTextBox"
        Me.ConceptoAJTextBox.Size = New System.Drawing.Size(62, 23)
        Me.ConceptoAJTextBox.TabIndex = 103
        '
        'txtObsAJ
        '
        txtObsAJ.AutoSize = True
        txtObsAJ.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtObsAJ.Location = New System.Drawing.Point(59, 227)
        txtObsAJ.Name = "txtObsAJ"
        txtObsAJ.Size = New System.Drawing.Size(94, 17)
        txtObsAJ.TabIndex = 104
        txtObsAJ.Text = "Observación:"
        '
        'ObsAJTextBox
        '
        Me.ObsAJTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ObsAJTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ObsAJTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdicionjobsBindingSource, "ObsAJ", True))
        Me.ObsAJTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObsAJTextBox.ForeColor = System.Drawing.Color.White
        Me.ObsAJTextBox.Location = New System.Drawing.Point(159, 225)
        Me.ObsAJTextBox.Name = "ObsAJTextBox"
        Me.ObsAJTextBox.Size = New System.Drawing.Size(444, 23)
        Me.ObsAJTextBox.TabIndex = 105
        '
        'txtNombreEmp
        '
        Me.txtNombreEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombreEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreEmp.Enabled = False
        Me.txtNombreEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEmp.ForeColor = System.Drawing.Color.White
        Me.txtNombreEmp.Location = New System.Drawing.Point(227, 80)
        Me.txtNombreEmp.Name = "txtNombreEmp"
        Me.txtNombreEmp.Size = New System.Drawing.Size(311, 23)
        Me.txtNombreEmp.TabIndex = 106
        '
        'txtNombreAdic
        '
        Me.txtNombreAdic.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombreAdic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreAdic.Enabled = False
        Me.txtNombreAdic.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAdic.ForeColor = System.Drawing.Color.White
        Me.txtNombreAdic.Location = New System.Drawing.Point(227, 109)
        Me.txtNombreAdic.Name = "txtNombreAdic"
        Me.txtNombreAdic.Size = New System.Drawing.Size(311, 23)
        Me.txtNombreAdic.TabIndex = 107
        '
        'txtTitularObra
        '
        Me.txtTitularObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTitularObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitularObra.Enabled = False
        Me.txtTitularObra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitularObra.ForeColor = System.Drawing.Color.White
        Me.txtTitularObra.Location = New System.Drawing.Point(227, 167)
        Me.txtTitularObra.Name = "txtTitularObra"
        Me.txtTitularObra.Size = New System.Drawing.Size(311, 23)
        Me.txtTitularObra.TabIndex = 108
        '
        'txtNombreCpto
        '
        Me.txtNombreCpto.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombreCpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCpto.Enabled = False
        Me.txtNombreCpto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCpto.ForeColor = System.Drawing.Color.White
        Me.txtNombreCpto.Location = New System.Drawing.Point(227, 196)
        Me.txtNombreCpto.Name = "txtNombreCpto"
        Me.txtNombreCpto.Size = New System.Drawing.Size(311, 23)
        Me.txtNombreCpto.TabIndex = 109
        '
        'dgvHoras
        '
        Me.dgvHoras.AllowUserToAddRows = False
        Me.dgvHoras.AllowUserToDeleteRows = False
        Me.dgvHoras.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvHoras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHoras.AutoGenerateColumns = False
        Me.dgvHoras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvHoras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHoras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHoras.ColumnHeadersHeight = 30
        Me.dgvHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHoras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAJDataGridViewTextBoxColumn, Me.EmpleadoAJDataGridViewTextBoxColumn, Me.CodigoAJDataGridViewTextBoxColumn, Me.CantidadAJDataGridViewTextBoxColumn, Me.ValorAJDataGridViewTextBoxColumn, Me.TotalAJDataGridViewTextBoxColumn, Me.ObraAJDataGridViewTextBoxColumn, Me.ConceptoAJDataGridViewTextBoxColumn, Me.ObsAJDataGridViewTextBoxColumn})
        Me.dgvHoras.DataSource = Me.AdicionjobsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHoras.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHoras.EnableHeadersVisualStyles = False
        Me.dgvHoras.GridColor = System.Drawing.Color.White
        Me.dgvHoras.Location = New System.Drawing.Point(73, 262)
        Me.dgvHoras.Name = "dgvHoras"
        Me.dgvHoras.ReadOnly = True
        Me.dgvHoras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHoras.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvHoras.Size = New System.Drawing.Size(773, 323)
        Me.dgvHoras.TabIndex = 110
        '
        'IdAJDataGridViewTextBoxColumn
        '
        Me.IdAJDataGridViewTextBoxColumn.DataPropertyName = "id_AJ"
        Me.IdAJDataGridViewTextBoxColumn.HeaderText = "id_AJ"
        Me.IdAJDataGridViewTextBoxColumn.Name = "IdAJDataGridViewTextBoxColumn"
        Me.IdAJDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAJDataGridViewTextBoxColumn.Visible = False
        '
        'EmpleadoAJDataGridViewTextBoxColumn
        '
        Me.EmpleadoAJDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoAJ"
        Me.EmpleadoAJDataGridViewTextBoxColumn.HeaderText = "EmpleadoAJ"
        Me.EmpleadoAJDataGridViewTextBoxColumn.Name = "EmpleadoAJDataGridViewTextBoxColumn"
        Me.EmpleadoAJDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpleadoAJDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoAJDataGridViewTextBoxColumn
        '
        Me.CodigoAJDataGridViewTextBoxColumn.DataPropertyName = "CodigoAJ"
        Me.CodigoAJDataGridViewTextBoxColumn.HeaderText = "CodigoAJ"
        Me.CodigoAJDataGridViewTextBoxColumn.Name = "CodigoAJDataGridViewTextBoxColumn"
        Me.CodigoAJDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadAJDataGridViewTextBoxColumn
        '
        Me.CantidadAJDataGridViewTextBoxColumn.DataPropertyName = "CantidadAJ"
        Me.CantidadAJDataGridViewTextBoxColumn.HeaderText = "CantidadAJ"
        Me.CantidadAJDataGridViewTextBoxColumn.Name = "CantidadAJDataGridViewTextBoxColumn"
        Me.CantidadAJDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorAJDataGridViewTextBoxColumn
        '
        Me.ValorAJDataGridViewTextBoxColumn.DataPropertyName = "ValorAJ"
        Me.ValorAJDataGridViewTextBoxColumn.HeaderText = "ValorAJ"
        Me.ValorAJDataGridViewTextBoxColumn.Name = "ValorAJDataGridViewTextBoxColumn"
        Me.ValorAJDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalAJDataGridViewTextBoxColumn
        '
        Me.TotalAJDataGridViewTextBoxColumn.DataPropertyName = "TotalAJ"
        Me.TotalAJDataGridViewTextBoxColumn.HeaderText = "TotalAJ"
        Me.TotalAJDataGridViewTextBoxColumn.Name = "TotalAJDataGridViewTextBoxColumn"
        Me.TotalAJDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObraAJDataGridViewTextBoxColumn
        '
        Me.ObraAJDataGridViewTextBoxColumn.DataPropertyName = "ObraAJ"
        Me.ObraAJDataGridViewTextBoxColumn.HeaderText = "ObraAJ"
        Me.ObraAJDataGridViewTextBoxColumn.Name = "ObraAJDataGridViewTextBoxColumn"
        Me.ObraAJDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConceptoAJDataGridViewTextBoxColumn
        '
        Me.ConceptoAJDataGridViewTextBoxColumn.DataPropertyName = "ConceptoAJ"
        Me.ConceptoAJDataGridViewTextBoxColumn.HeaderText = "ConceptoAJ"
        Me.ConceptoAJDataGridViewTextBoxColumn.Name = "ConceptoAJDataGridViewTextBoxColumn"
        Me.ConceptoAJDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObsAJDataGridViewTextBoxColumn
        '
        Me.ObsAJDataGridViewTextBoxColumn.DataPropertyName = "ObsAJ"
        Me.ObsAJDataGridViewTextBoxColumn.HeaderText = "ObsAJ"
        Me.ObsAJDataGridViewTextBoxColumn.Name = "ObsAJDataGridViewTextBoxColumn"
        Me.ObsAJDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmCargarAdicionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1057, 625)
        Me.Controls.Add(Me.dgvHoras)
        Me.Controls.Add(Me.txtNombreCpto)
        Me.Controls.Add(Me.txtTitularObra)
        Me.Controls.Add(Me.txtNombreAdic)
        Me.Controls.Add(Me.txtNombreEmp)
        Me.Controls.Add(Me.Id_AJTextBox)
        Me.Controls.Add(txtEmpleadoAJ)
        Me.Controls.Add(Me.EmpleadoAJTextBox)
        Me.Controls.Add(txtCodigoAJ)
        Me.Controls.Add(Me.CodigoAJTextBox)
        Me.Controls.Add(txtCantidadAJ)
        Me.Controls.Add(Me.CantidadAJTextBox)
        Me.Controls.Add(txtValorAJ)
        Me.Controls.Add(Me.ValorAJTextBox)
        Me.Controls.Add(txtTotalAJ)
        Me.Controls.Add(Me.TotalAJTextBox)
        Me.Controls.Add(txtObraAJ)
        Me.Controls.Add(Me.ObraAJTextBox)
        Me.Controls.Add(txtConceptoAJ)
        Me.Controls.Add(Me.ConceptoAJTextBox)
        Me.Controls.Add(txtObsAJ)
        Me.Controls.Add(Me.ObsAJTextBox)
        Me.Controls.Add(Me.AdicionjobsBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCargarAdicionales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARGA DE ADICIONALES DE EMPLEADOS"
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdicionjobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdicionjobsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdicionjobsBindingNavigator.ResumeLayout(False)
        Me.AdicionjobsBindingNavigator.PerformLayout()
        CType(Me.dgvHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents AdicionjobsBindingSource As BindingSource
    Friend WithEvents AdicionjobsTableAdapter As dbsointDataSetTableAdapters.adicionjobsTableAdapter
    Friend WithEvents TableAdapterManager As dbsointDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdicionjobsBindingNavigator As BindingNavigator
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
    Friend WithEvents AdicionjobsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Id_AJTextBox As TextBox
    Friend WithEvents EmpleadoAJTextBox As TextBox
    Friend WithEvents CodigoAJTextBox As TextBox
    Friend WithEvents CantidadAJTextBox As TextBox
    Friend WithEvents ValorAJTextBox As TextBox
    Friend WithEvents TotalAJTextBox As TextBox
    Friend WithEvents ObraAJTextBox As TextBox
    Friend WithEvents ConceptoAJTextBox As TextBox
    Friend WithEvents ObsAJTextBox As TextBox
    Friend WithEvents txtNombreEmp As TextBox
    Friend WithEvents txtNombreAdic As TextBox
    Friend WithEvents txtTitularObra As TextBox
    Friend WithEvents txtNombreCpto As TextBox
    Friend WithEvents dgvHoras As DataGridView
    Friend WithEvents IdAJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoAJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoAJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadAJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorAJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObraAJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConceptoAJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsAJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
