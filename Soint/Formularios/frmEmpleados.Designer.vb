<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Dim NroEmpLabel As System.Windows.Forms.Label
        Dim NombreEmpLabel As System.Windows.Forms.Label
        Dim DomicilioEmpLabel As System.Windows.Forms.Label
        Dim IdCodPosEmpLabel As System.Windows.Forms.Label
        Dim TelefEmpLabel As System.Windows.Forms.Label
        Dim CategoriaEmpLabel As System.Windows.Forms.Label
        Dim FuncionEmpLabel As System.Windows.Forms.Label
        Dim ObsEmpLabel As System.Windows.Forms.Label
        Dim CuilEmpLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleados))
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New Soint.dbsointDataSetTableAdapters.empleadosTableAdapter()
        Me.TableAdapterManager = New Soint.dbsointDataSetTableAdapters.TableAdapterManager()
        Me.EmpleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmpleadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtId_Emp = New System.Windows.Forms.TextBox()
        Me.txtNroEmp = New System.Windows.Forms.TextBox()
        Me.txtNombreEmp = New System.Windows.Forms.TextBox()
        Me.txtDomicilioEmp = New System.Windows.Forms.TextBox()
        Me.txtIdCodPosEmp = New System.Windows.Forms.TextBox()
        Me.txtTelefEmp = New System.Windows.Forms.TextBox()
        Me.txtFuncionEmp = New System.Windows.Forms.TextBox()
        Me.txtObsEmp = New System.Windows.Forms.TextBox()
        Me.cmbCategoriaEmp = New System.Windows.Forms.ComboBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnPrimer = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCodPostal = New System.Windows.Forms.TextBox()
        Me.txtCuilEmp = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtFecNacEmp = New System.Windows.Forms.TextBox()
        NroEmpLabel = New System.Windows.Forms.Label()
        NombreEmpLabel = New System.Windows.Forms.Label()
        DomicilioEmpLabel = New System.Windows.Forms.Label()
        IdCodPosEmpLabel = New System.Windows.Forms.Label()
        TelefEmpLabel = New System.Windows.Forms.Label()
        CategoriaEmpLabel = New System.Windows.Forms.Label()
        FuncionEmpLabel = New System.Windows.Forms.Label()
        ObsEmpLabel = New System.Windows.Forms.Label()
        CuilEmpLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadosBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NroEmpLabel
        '
        NroEmpLabel.AutoSize = True
        NroEmpLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NroEmpLabel.Location = New System.Drawing.Point(99, 67)
        NroEmpLabel.Name = "NroEmpLabel"
        NroEmpLabel.Size = New System.Drawing.Size(79, 17)
        NroEmpLabel.TabIndex = 3
        NroEmpLabel.Text = "Empleado:"
        '
        'NombreEmpLabel
        '
        NombreEmpLabel.AutoSize = True
        NombreEmpLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreEmpLabel.Location = New System.Drawing.Point(46, 96)
        NombreEmpLabel.Name = "NombreEmpLabel"
        NombreEmpLabel.Size = New System.Drawing.Size(132, 17)
        NombreEmpLabel.TabIndex = 5
        NombreEmpLabel.Text = "Apellido y Nombre:"
        '
        'DomicilioEmpLabel
        '
        DomicilioEmpLabel.AutoSize = True
        DomicilioEmpLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DomicilioEmpLabel.Location = New System.Drawing.Point(105, 125)
        DomicilioEmpLabel.Name = "DomicilioEmpLabel"
        DomicilioEmpLabel.Size = New System.Drawing.Size(73, 17)
        DomicilioEmpLabel.TabIndex = 7
        DomicilioEmpLabel.Text = "Domicilio:"
        '
        'IdCodPosEmpLabel
        '
        IdCodPosEmpLabel.AutoSize = True
        IdCodPosEmpLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdCodPosEmpLabel.Location = New System.Drawing.Point(73, 154)
        IdCodPosEmpLabel.Name = "IdCodPosEmpLabel"
        IdCodPosEmpLabel.Size = New System.Drawing.Size(105, 17)
        IdCodPosEmpLabel.TabIndex = 9
        IdCodPosEmpLabel.Text = "Código Postal:"
        '
        'TelefEmpLabel
        '
        TelefEmpLabel.AutoSize = True
        TelefEmpLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefEmpLabel.Location = New System.Drawing.Point(112, 183)
        TelefEmpLabel.Name = "TelefEmpLabel"
        TelefEmpLabel.Size = New System.Drawing.Size(66, 17)
        TelefEmpLabel.TabIndex = 11
        TelefEmpLabel.Text = "Teléfono:"
        '
        'CategoriaEmpLabel
        '
        CategoriaEmpLabel.AutoSize = True
        CategoriaEmpLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaEmpLabel.Location = New System.Drawing.Point(99, 213)
        CategoriaEmpLabel.Name = "CategoriaEmpLabel"
        CategoriaEmpLabel.Size = New System.Drawing.Size(79, 17)
        CategoriaEmpLabel.TabIndex = 13
        CategoriaEmpLabel.Text = "Categoría:"
        '
        'FuncionEmpLabel
        '
        FuncionEmpLabel.AutoSize = True
        FuncionEmpLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FuncionEmpLabel.Location = New System.Drawing.Point(116, 243)
        FuncionEmpLabel.Name = "FuncionEmpLabel"
        FuncionEmpLabel.Size = New System.Drawing.Size(62, 17)
        FuncionEmpLabel.TabIndex = 15
        FuncionEmpLabel.Text = "Función:"
        '
        'ObsEmpLabel
        '
        ObsEmpLabel.AutoSize = True
        ObsEmpLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsEmpLabel.Location = New System.Drawing.Point(84, 272)
        ObsEmpLabel.Name = "ObsEmpLabel"
        ObsEmpLabel.Size = New System.Drawing.Size(94, 17)
        ObsEmpLabel.TabIndex = 17
        ObsEmpLabel.Text = "Observación:"
        '
        'CuilEmpLabel
        '
        CuilEmpLabel.AutoSize = True
        CuilEmpLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CuilEmpLabel.Location = New System.Drawing.Point(536, 213)
        CuilEmpLabel.Name = "CuilEmpLabel"
        CuilEmpLabel.Size = New System.Drawing.Size(56, 17)
        CuilEmpLabel.TabIndex = 117
        CuilEmpLabel.Text = "C.U.I.L.:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(521, 183)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(86, 17)
        Label2.TabIndex = 120
        Label2.Text = "Fecha Nac.:"
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DbsointDataSet
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.empleadosTableAdapter = Me.EmpleadosTableAdapter
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
        'EmpleadosBindingNavigator
        '
        Me.EmpleadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpleadosBindingNavigator.BindingSource = Me.EmpleadosBindingSource
        Me.EmpleadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EmpleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadosBindingNavigatorSaveItem})
        Me.EmpleadosBindingNavigator.Location = New System.Drawing.Point(0, 448)
        Me.EmpleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadosBindingNavigator.Name = "EmpleadosBindingNavigator"
        Me.EmpleadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadosBindingNavigator.Size = New System.Drawing.Size(1077, 25)
        Me.EmpleadosBindingNavigator.TabIndex = 0
        Me.EmpleadosBindingNavigator.Text = "BindingNavigator1"
        Me.EmpleadosBindingNavigator.Visible = False
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
        'EmpleadosBindingNavigatorSaveItem
        '
        Me.EmpleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpleadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpleadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpleadosBindingNavigatorSaveItem.Name = "EmpleadosBindingNavigatorSaveItem"
        Me.EmpleadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpleadosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'txtId_Emp
        '
        Me.txtId_Emp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_Emp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_Emp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "id_Emp", True))
        Me.txtId_Emp.Enabled = False
        Me.txtId_Emp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_Emp.ForeColor = System.Drawing.Color.White
        Me.txtId_Emp.Location = New System.Drawing.Point(290, 67)
        Me.txtId_Emp.Name = "txtId_Emp"
        Me.txtId_Emp.Size = New System.Drawing.Size(80, 16)
        Me.txtId_Emp.TabIndex = 1
        '
        'txtNroEmp
        '
        Me.txtNroEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "NroEmp", True))
        Me.txtNroEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroEmp.ForeColor = System.Drawing.Color.White
        Me.txtNroEmp.Location = New System.Drawing.Point(184, 65)
        Me.txtNroEmp.Name = "txtNroEmp"
        Me.txtNroEmp.Size = New System.Drawing.Size(77, 23)
        Me.txtNroEmp.TabIndex = 0
        Me.txtNroEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombreEmp
        '
        Me.txtNombreEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombreEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "NombreEmp", True))
        Me.txtNombreEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEmp.ForeColor = System.Drawing.Color.White
        Me.txtNombreEmp.Location = New System.Drawing.Point(184, 94)
        Me.txtNombreEmp.Name = "txtNombreEmp"
        Me.txtNombreEmp.Size = New System.Drawing.Size(585, 23)
        Me.txtNombreEmp.TabIndex = 2
        '
        'txtDomicilioEmp
        '
        Me.txtDomicilioEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDomicilioEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomicilioEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilioEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DomicilioEmp", True))
        Me.txtDomicilioEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilioEmp.ForeColor = System.Drawing.Color.White
        Me.txtDomicilioEmp.Location = New System.Drawing.Point(184, 123)
        Me.txtDomicilioEmp.Name = "txtDomicilioEmp"
        Me.txtDomicilioEmp.Size = New System.Drawing.Size(585, 23)
        Me.txtDomicilioEmp.TabIndex = 3
        '
        'txtIdCodPosEmp
        '
        Me.txtIdCodPosEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIdCodPosEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdCodPosEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "IdCodPosEmp", True))
        Me.txtIdCodPosEmp.Enabled = False
        Me.txtIdCodPosEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCodPosEmp.ForeColor = System.Drawing.Color.White
        Me.txtIdCodPosEmp.Location = New System.Drawing.Point(775, 154)
        Me.txtIdCodPosEmp.Name = "txtIdCodPosEmp"
        Me.txtIdCodPosEmp.Size = New System.Drawing.Size(77, 16)
        Me.txtIdCodPosEmp.TabIndex = 7
        '
        'txtTelefEmp
        '
        Me.txtTelefEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTelefEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "TelefEmp", True))
        Me.txtTelefEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefEmp.ForeColor = System.Drawing.Color.White
        Me.txtTelefEmp.Location = New System.Drawing.Point(184, 181)
        Me.txtTelefEmp.Name = "txtTelefEmp"
        Me.txtTelefEmp.Size = New System.Drawing.Size(331, 23)
        Me.txtTelefEmp.TabIndex = 8
        '
        'txtFuncionEmp
        '
        Me.txtFuncionEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFuncionEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFuncionEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFuncionEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "FuncionEmp", True))
        Me.txtFuncionEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuncionEmp.ForeColor = System.Drawing.Color.White
        Me.txtFuncionEmp.Location = New System.Drawing.Point(184, 241)
        Me.txtFuncionEmp.Name = "txtFuncionEmp"
        Me.txtFuncionEmp.Size = New System.Drawing.Size(585, 23)
        Me.txtFuncionEmp.TabIndex = 12
        '
        'txtObsEmp
        '
        Me.txtObsEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObsEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "ObsEmp", True))
        Me.txtObsEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsEmp.ForeColor = System.Drawing.Color.White
        Me.txtObsEmp.Location = New System.Drawing.Point(184, 270)
        Me.txtObsEmp.Multiline = True
        Me.txtObsEmp.Name = "txtObsEmp"
        Me.txtObsEmp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsEmp.Size = New System.Drawing.Size(585, 57)
        Me.txtObsEmp.TabIndex = 13
        '
        'cmbCategoriaEmp
        '
        Me.cmbCategoriaEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbCategoriaEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "CategoriaEmp", True))
        Me.cmbCategoriaEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategoriaEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoriaEmp.ForeColor = System.Drawing.Color.White
        Me.cmbCategoriaEmp.FormattingEnabled = True
        Me.cmbCategoriaEmp.Location = New System.Drawing.Point(184, 210)
        Me.cmbCategoriaEmp.Name = "cmbCategoriaEmp"
        Me.cmbCategoriaEmp.Size = New System.Drawing.Size(331, 25)
        Me.cmbCategoriaEmp.TabIndex = 10
        '
        'txtLocalidad
        '
        Me.txtLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalidad.Enabled = False
        Me.txtLocalidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.ForeColor = System.Drawing.Color.White
        Me.txtLocalidad.Location = New System.Drawing.Point(267, 152)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(248, 23)
        Me.txtLocalidad.TabIndex = 5
        '
        'txtProvincia
        '
        Me.txtProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvincia.Enabled = False
        Me.txtProvincia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.ForeColor = System.Drawing.Color.White
        Me.txtProvincia.Location = New System.Drawing.Point(521, 152)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(248, 23)
        Me.txtProvincia.TabIndex = 6
        '
        'BtnUltimo
        '
        Me.BtnUltimo.AutoSize = True
        Me.BtnUltimo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUltimo.FlatAppearance.BorderSize = 0
        Me.BtnUltimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUltimo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUltimo.ForeColor = System.Drawing.Color.White
        Me.BtnUltimo.Image = CType(resources.GetObject("BtnUltimo.Image"), System.Drawing.Image)
        Me.BtnUltimo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnUltimo.Location = New System.Drawing.Point(753, 364)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnUltimo.Size = New System.Drawing.Size(38, 38)
        Me.BtnUltimo.TabIndex = 23
        Me.BtnUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUltimo.UseVisualStyleBackColor = True
        '
        'BtnPrimer
        '
        Me.BtnPrimer.AutoSize = True
        Me.BtnPrimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrimer.FlatAppearance.BorderSize = 0
        Me.BtnPrimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnPrimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrimer.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrimer.ForeColor = System.Drawing.Color.White
        Me.BtnPrimer.Image = CType(resources.GetObject("BtnPrimer.Image"), System.Drawing.Image)
        Me.BtnPrimer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPrimer.Location = New System.Drawing.Point(618, 364)
        Me.BtnPrimer.Name = "BtnPrimer"
        Me.BtnPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPrimer.Size = New System.Drawing.Size(38, 38)
        Me.BtnPrimer.TabIndex = 20
        Me.BtnPrimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPrimer.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.AutoSize = True
        Me.BtnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSiguiente.FlatAppearance.BorderSize = 0
        Me.BtnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiguiente.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.ForeColor = System.Drawing.Color.White
        Me.BtnSiguiente.Image = CType(resources.GetObject("BtnSiguiente.Image"), System.Drawing.Image)
        Me.BtnSiguiente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSiguiente.Location = New System.Drawing.Point(708, 364)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSiguiente.Size = New System.Drawing.Size(38, 38)
        Me.BtnSiguiente.TabIndex = 22
        Me.BtnSiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.AutoSize = True
        Me.BtnAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnterior.FlatAppearance.BorderSize = 0
        Me.BtnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnterior.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnterior.ForeColor = System.Drawing.Color.White
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAnterior.Location = New System.Drawing.Point(663, 364)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAnterior.Size = New System.Drawing.Size(38, 38)
        Me.BtnAnterior.TabIndex = 21
        Me.BtnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAnterior.UseVisualStyleBackColor = True
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
        Me.BtnActualizar.Location = New System.Drawing.Point(478, 356)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnActualizar.Size = New System.Drawing.Size(87, 56)
        Me.BtnActualizar.TabIndex = 19
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
        Me.BtnGrabar.Location = New System.Drawing.Point(127, 356)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGrabar.Size = New System.Drawing.Size(59, 56)
        Me.BtnGrabar.TabIndex = 15
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
        Me.BtnSalir.Location = New System.Drawing.Point(829, 356)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(87, 56)
        Me.BtnSalir.TabIndex = 24
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
        Me.BtnModificar.Location = New System.Drawing.Point(210, 356)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnModificar.Size = New System.Drawing.Size(80, 56)
        Me.BtnModificar.TabIndex = 16
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
        Me.BtnEliminar.Location = New System.Drawing.Point(306, 356)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEliminar.Size = New System.Drawing.Size(73, 56)
        Me.BtnEliminar.TabIndex = 17
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
        Me.BtnBuscar.Location = New System.Drawing.Point(398, 356)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnBuscar.Size = New System.Drawing.Size(59, 56)
        Me.BtnBuscar.TabIndex = 18
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
        Me.BtnAgregar.Location = New System.Drawing.Point(44, 356)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAgregar.Size = New System.Drawing.Size(66, 56)
        Me.BtnAgregar.TabIndex = 14
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(26, 348)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(563, 73)
        Me.PictureBox1.TabIndex = 113
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(595, 348)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 73)
        Me.PictureBox2.TabIndex = 114
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(823, 348)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(99, 73)
        Me.PictureBox3.TabIndex = 115
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(247, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(425, 36)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Actualización de Empleados"
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'txtCodPostal
        '
        Me.txtCodPostal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPostal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPostal.ForeColor = System.Drawing.Color.White
        Me.txtCodPostal.Location = New System.Drawing.Point(184, 152)
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(77, 23)
        Me.txtCodPostal.TabIndex = 4
        '
        'txtCuilEmp
        '
        Me.txtCuilEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCuilEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuilEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "CuilEmp", True))
        Me.txtCuilEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuilEmp.ForeColor = System.Drawing.Color.White
        Me.txtCuilEmp.Location = New System.Drawing.Point(598, 211)
        Me.txtCuilEmp.Name = "txtCuilEmp"
        Me.txtCuilEmp.Size = New System.Drawing.Size(171, 23)
        Me.txtCuilEmp.TabIndex = 11
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(26, 50)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(896, 292)
        Me.PictureBox4.TabIndex = 118
        Me.PictureBox4.TabStop = False
        '
        'txtFecNacEmp
        '
        Me.txtFecNacEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecNacEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecNacEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "FecNacEmp", True))
        Me.txtFecNacEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecNacEmp.ForeColor = System.Drawing.Color.White
        Me.txtFecNacEmp.Location = New System.Drawing.Point(613, 181)
        Me.txtFecNacEmp.Name = "txtFecNacEmp"
        Me.txtFecNacEmp.Size = New System.Drawing.Size(100, 23)
        Me.txtFecNacEmp.TabIndex = 9
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(971, 450)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtFecNacEmp)
        Me.Controls.Add(CuilEmpLabel)
        Me.Controls.Add(Me.txtCuilEmp)
        Me.Controls.Add(Me.txtCodPostal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnUltimo)
        Me.Controls.Add(Me.BtnPrimer)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.BtnAnterior)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.cmbCategoriaEmp)
        Me.Controls.Add(Me.txtId_Emp)
        Me.Controls.Add(NroEmpLabel)
        Me.Controls.Add(Me.txtNroEmp)
        Me.Controls.Add(NombreEmpLabel)
        Me.Controls.Add(Me.txtNombreEmp)
        Me.Controls.Add(DomicilioEmpLabel)
        Me.Controls.Add(Me.txtDomicilioEmp)
        Me.Controls.Add(IdCodPosEmpLabel)
        Me.Controls.Add(Me.txtIdCodPosEmp)
        Me.Controls.Add(TelefEmpLabel)
        Me.Controls.Add(Me.txtTelefEmp)
        Me.Controls.Add(CategoriaEmpLabel)
        Me.Controls.Add(FuncionEmpLabel)
        Me.Controls.Add(Me.txtFuncionEmp)
        Me.Controls.Add(ObsEmpLabel)
        Me.Controls.Add(Me.txtObsEmp)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.EmpleadosBindingNavigator)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmpleados"
        Me.Text = "ACTUALIZACIÓN DE EMPLEADOS"
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadosBindingNavigator.ResumeLayout(False)
        Me.EmpleadosBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As dbsointDataSetTableAdapters.empleadosTableAdapter
    Friend WithEvents TableAdapterManager As dbsointDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosBindingNavigator As BindingNavigator
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
    Friend WithEvents EmpleadosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId_Emp As TextBox
    Friend WithEvents txtNroEmp As TextBox
    Friend WithEvents txtNombreEmp As TextBox
    Friend WithEvents txtDomicilioEmp As TextBox
    Friend WithEvents txtIdCodPosEmp As TextBox
    Friend WithEvents txtTelefEmp As TextBox
    Friend WithEvents txtFuncionEmp As TextBox
    Friend WithEvents txtObsEmp As TextBox
    Friend WithEvents cmbCategoriaEmp As ComboBox
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents BtnUltimo As Button
    Friend WithEvents BtnPrimer As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents txtCodPostal As TextBox
    Friend WithEvents txtCuilEmp As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtFecNacEmp As TextBox
End Class
