<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim NroCliLabel As System.Windows.Forms.Label
        Dim NombreCliLabel As System.Windows.Forms.Label
        Dim TitularCliLabel As System.Windows.Forms.Label
        Dim DomicilioCliLabel As System.Windows.Forms.Label
        Dim IdCodPosCliLabel As System.Windows.Forms.Label
        Dim TelefCliLabel As System.Windows.Forms.Label
        Dim TipoIvaCliLabel As System.Windows.Forms.Label
        Dim CuitCliLabel As System.Windows.Forms.Label
        Dim IngBrutosCliLabel As System.Windows.Forms.Label
        Dim ObsCliLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Soint.dbsointDataSetTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New Soint.dbsointDataSetTableAdapters.TableAdapterManager()
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtId_Cli = New System.Windows.Forms.TextBox()
        Me.txtNroCli = New System.Windows.Forms.TextBox()
        Me.txtNombreCli = New System.Windows.Forms.TextBox()
        Me.txtTitularCli = New System.Windows.Forms.TextBox()
        Me.txtDomicilioCli = New System.Windows.Forms.TextBox()
        Me.txtIdCodPosCli = New System.Windows.Forms.TextBox()
        Me.txtTelefCli = New System.Windows.Forms.TextBox()
        Me.txtIngBrutosCli = New System.Windows.Forms.TextBox()
        Me.txtObsCli = New System.Windows.Forms.TextBox()
        Me.cmbTipoIvaCli = New System.Windows.Forms.ComboBox()
        Me.CategivaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtCodPostal = New System.Windows.Forms.TextBox()
        Me.txtCuitCli = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CategivaTableAdapter = New Soint.dbsointDataSetTableAdapters.categivaTableAdapter()
        Me.txtEmailCli = New System.Windows.Forms.TextBox()
        NroCliLabel = New System.Windows.Forms.Label()
        NombreCliLabel = New System.Windows.Forms.Label()
        TitularCliLabel = New System.Windows.Forms.Label()
        DomicilioCliLabel = New System.Windows.Forms.Label()
        IdCodPosCliLabel = New System.Windows.Forms.Label()
        TelefCliLabel = New System.Windows.Forms.Label()
        TipoIvaCliLabel = New System.Windows.Forms.Label()
        CuitCliLabel = New System.Windows.Forms.Label()
        IngBrutosCliLabel = New System.Windows.Forms.Label()
        ObsCliLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        CType(Me.CategivaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NroCliLabel
        '
        NroCliLabel.AutoSize = True
        NroCliLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NroCliLabel.Location = New System.Drawing.Point(74, 62)
        NroCliLabel.Name = "NroCliLabel"
        NroCliLabel.Size = New System.Drawing.Size(89, 17)
        NroCliLabel.TabIndex = 3
        NroCliLabel.Text = "Nro. Cliente:"
        '
        'NombreCliLabel
        '
        NombreCliLabel.AutoSize = True
        NombreCliLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreCliLabel.Location = New System.Drawing.Point(98, 91)
        NombreCliLabel.Name = "NombreCliLabel"
        NombreCliLabel.Size = New System.Drawing.Size(65, 17)
        NombreCliLabel.TabIndex = 5
        NombreCliLabel.Text = "Nombre:"
        '
        'TitularCliLabel
        '
        TitularCliLabel.AutoSize = True
        TitularCliLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitularCliLabel.Location = New System.Drawing.Point(114, 120)
        TitularCliLabel.Name = "TitularCliLabel"
        TitularCliLabel.Size = New System.Drawing.Size(49, 17)
        TitularCliLabel.TabIndex = 7
        TitularCliLabel.Text = "Titular:"
        '
        'DomicilioCliLabel
        '
        DomicilioCliLabel.AutoSize = True
        DomicilioCliLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DomicilioCliLabel.Location = New System.Drawing.Point(90, 149)
        DomicilioCliLabel.Name = "DomicilioCliLabel"
        DomicilioCliLabel.Size = New System.Drawing.Size(73, 17)
        DomicilioCliLabel.TabIndex = 9
        DomicilioCliLabel.Text = "Domicilio:"
        '
        'IdCodPosCliLabel
        '
        IdCodPosCliLabel.AutoSize = True
        IdCodPosCliLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdCodPosCliLabel.Location = New System.Drawing.Point(75, 177)
        IdCodPosCliLabel.Name = "IdCodPosCliLabel"
        IdCodPosCliLabel.Size = New System.Drawing.Size(88, 17)
        IdCodPosCliLabel.TabIndex = 11
        IdCodPosCliLabel.Text = "Cod. Postal:"
        '
        'TelefCliLabel
        '
        TelefCliLabel.AutoSize = True
        TelefCliLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefCliLabel.Location = New System.Drawing.Point(85, 207)
        TelefCliLabel.Name = "TelefCliLabel"
        TelefCliLabel.Size = New System.Drawing.Size(78, 17)
        TelefCliLabel.TabIndex = 13
        TelefCliLabel.Text = "Teleféfono:"
        '
        'TipoIvaCliLabel
        '
        TipoIvaCliLabel.AutoSize = True
        TipoIvaCliLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoIvaCliLabel.Location = New System.Drawing.Point(54, 235)
        TipoIvaCliLabel.Name = "TipoIvaCliLabel"
        TipoIvaCliLabel.Size = New System.Drawing.Size(109, 17)
        TipoIvaCliLabel.TabIndex = 15
        TipoIvaCliLabel.Text = "Situación Fiscal:"
        '
        'CuitCliLabel
        '
        CuitCliLabel.AutoSize = True
        CuitCliLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CuitCliLabel.Location = New System.Drawing.Point(58, 264)
        CuitCliLabel.Name = "CuitCliLabel"
        CuitCliLabel.Size = New System.Drawing.Size(105, 17)
        CuitCliLabel.TabIndex = 17
        CuitCliLabel.Text = "C.U.I.T./C.U.I.L.:"
        '
        'IngBrutosCliLabel
        '
        IngBrutosCliLabel.AutoSize = True
        IngBrutosCliLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IngBrutosCliLabel.Location = New System.Drawing.Point(85, 294)
        IngBrutosCliLabel.Name = "IngBrutosCliLabel"
        IngBrutosCliLabel.Size = New System.Drawing.Size(78, 17)
        IngBrutosCliLabel.TabIndex = 19
        IngBrutosCliLabel.Text = "Ing. Brutos:"
        '
        'ObsCliLabel
        '
        ObsCliLabel.AutoSize = True
        ObsCliLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsCliLabel.Location = New System.Drawing.Point(69, 352)
        ObsCliLabel.Name = "ObsCliLabel"
        ObsCliLabel.Size = New System.Drawing.Size(94, 17)
        ObsCliLabel.TabIndex = 21
        ObsCliLabel.Text = "Observación:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(112, 322)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 17)
        Label2.TabIndex = 105
        Label2.Text = "E-mail:"
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.DbsointDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adicionalesTableAdapter = Nothing
        Me.TableAdapterManager.adicionjobsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categempleTableAdapter = Nothing
        Me.TableAdapterManager.categivaTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
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
        'ClientesBindingNavigator
        '
        Me.ClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientesBindingNavigator.BindingSource = Me.ClientesBindingSource
        Me.ClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientesBindingNavigatorSaveItem})
        Me.ClientesBindingNavigator.Location = New System.Drawing.Point(0, 534)
        Me.ClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientesBindingNavigator.Name = "ClientesBindingNavigator"
        Me.ClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(951, 25)
        Me.ClientesBindingNavigator.TabIndex = 0
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
        Me.ClientesBindingNavigator.Visible = False
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
        'ClientesBindingNavigatorSaveItem
        '
        Me.ClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesBindingNavigatorSaveItem.Name = "ClientesBindingNavigatorSaveItem"
        Me.ClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'txtId_Cli
        '
        Me.txtId_Cli.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_Cli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_Cli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "id_Cli", True))
        Me.txtId_Cli.Enabled = False
        Me.txtId_Cli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_Cli.ForeColor = System.Drawing.Color.White
        Me.txtId_Cli.Location = New System.Drawing.Point(256, 61)
        Me.txtId_Cli.Name = "txtId_Cli"
        Me.txtId_Cli.Size = New System.Drawing.Size(71, 16)
        Me.txtId_Cli.TabIndex = 1
        '
        'txtNroCli
        '
        Me.txtNroCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroCli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "NroCli", True))
        Me.txtNroCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroCli.ForeColor = System.Drawing.Color.White
        Me.txtNroCli.Location = New System.Drawing.Point(169, 59)
        Me.txtNroCli.Name = "txtNroCli"
        Me.txtNroCli.Size = New System.Drawing.Size(81, 23)
        Me.txtNroCli.TabIndex = 0
        Me.txtNroCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombreCli
        '
        Me.txtNombreCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombreCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "NombreCli", True))
        Me.txtNombreCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCli.ForeColor = System.Drawing.Color.White
        Me.txtNombreCli.Location = New System.Drawing.Point(169, 88)
        Me.txtNombreCli.Name = "txtNombreCli"
        Me.txtNombreCli.Size = New System.Drawing.Size(601, 23)
        Me.txtNombreCli.TabIndex = 2
        '
        'txtTitularCli
        '
        Me.txtTitularCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTitularCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitularCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTitularCli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "TitularCli", True))
        Me.txtTitularCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitularCli.ForeColor = System.Drawing.Color.White
        Me.txtTitularCli.Location = New System.Drawing.Point(169, 117)
        Me.txtTitularCli.Name = "txtTitularCli"
        Me.txtTitularCli.Size = New System.Drawing.Size(601, 23)
        Me.txtTitularCli.TabIndex = 3
        '
        'txtDomicilioCli
        '
        Me.txtDomicilioCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDomicilioCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomicilioCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilioCli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "DomicilioCli", True))
        Me.txtDomicilioCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilioCli.ForeColor = System.Drawing.Color.White
        Me.txtDomicilioCli.Location = New System.Drawing.Point(169, 146)
        Me.txtDomicilioCli.Name = "txtDomicilioCli"
        Me.txtDomicilioCli.Size = New System.Drawing.Size(601, 23)
        Me.txtDomicilioCli.TabIndex = 4
        '
        'txtIdCodPosCli
        '
        Me.txtIdCodPosCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIdCodPosCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdCodPosCli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "IdCodPosCli", True))
        Me.txtIdCodPosCli.Enabled = False
        Me.txtIdCodPosCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCodPosCli.ForeColor = System.Drawing.Color.White
        Me.txtIdCodPosCli.Location = New System.Drawing.Point(776, 177)
        Me.txtIdCodPosCli.Name = "txtIdCodPosCli"
        Me.txtIdCodPosCli.Size = New System.Drawing.Size(61, 16)
        Me.txtIdCodPosCli.TabIndex = 8
        '
        'txtTelefCli
        '
        Me.txtTelefCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTelefCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefCli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "TelefCli", True))
        Me.txtTelefCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefCli.ForeColor = System.Drawing.Color.White
        Me.txtTelefCli.Location = New System.Drawing.Point(169, 204)
        Me.txtTelefCli.Name = "txtTelefCli"
        Me.txtTelefCli.Size = New System.Drawing.Size(244, 23)
        Me.txtTelefCli.TabIndex = 9
        '
        'txtIngBrutosCli
        '
        Me.txtIngBrutosCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIngBrutosCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIngBrutosCli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "IngBrutosCli", True))
        Me.txtIngBrutosCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngBrutosCli.ForeColor = System.Drawing.Color.White
        Me.txtIngBrutosCli.Location = New System.Drawing.Point(169, 291)
        Me.txtIngBrutosCli.Name = "txtIngBrutosCli"
        Me.txtIngBrutosCli.Size = New System.Drawing.Size(143, 23)
        Me.txtIngBrutosCli.TabIndex = 12
        '
        'txtObsCli
        '
        Me.txtObsCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObsCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsCli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "ObsCli", True))
        Me.txtObsCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsCli.ForeColor = System.Drawing.Color.White
        Me.txtObsCli.Location = New System.Drawing.Point(169, 349)
        Me.txtObsCli.Multiline = True
        Me.txtObsCli.Name = "txtObsCli"
        Me.txtObsCli.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsCli.Size = New System.Drawing.Size(601, 42)
        Me.txtObsCli.TabIndex = 14
        '
        'cmbTipoIvaCli
        '
        Me.cmbTipoIvaCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbTipoIvaCli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "TipoIvaCli", True))
        Me.cmbTipoIvaCli.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CategivaBindingSource, "DescripcionCI", True))
        Me.cmbTipoIvaCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoIvaCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoIvaCli.ForeColor = System.Drawing.Color.White
        Me.cmbTipoIvaCli.FormattingEnabled = True
        Me.cmbTipoIvaCli.Location = New System.Drawing.Point(169, 232)
        Me.cmbTipoIvaCli.Name = "cmbTipoIvaCli"
        Me.cmbTipoIvaCli.Size = New System.Drawing.Size(331, 25)
        Me.cmbTipoIvaCli.TabIndex = 10
        '
        'CategivaBindingSource
        '
        Me.CategivaBindingSource.DataMember = "categiva"
        Me.CategivaBindingSource.DataSource = Me.DbsointDataSet
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
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
        Me.BtnUltimo.Location = New System.Drawing.Point(748, 424)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnUltimo.Size = New System.Drawing.Size(38, 38)
        Me.BtnUltimo.TabIndex = 24
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
        Me.BtnPrimer.Location = New System.Drawing.Point(613, 424)
        Me.BtnPrimer.Name = "BtnPrimer"
        Me.BtnPrimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPrimer.Size = New System.Drawing.Size(38, 38)
        Me.BtnPrimer.TabIndex = 21
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
        Me.BtnSiguiente.Location = New System.Drawing.Point(703, 424)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSiguiente.Size = New System.Drawing.Size(38, 38)
        Me.BtnSiguiente.TabIndex = 23
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
        Me.BtnAnterior.Location = New System.Drawing.Point(658, 424)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAnterior.Size = New System.Drawing.Size(38, 38)
        Me.BtnAnterior.TabIndex = 22
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
        Me.BtnActualizar.Location = New System.Drawing.Point(473, 416)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnActualizar.Size = New System.Drawing.Size(87, 56)
        Me.BtnActualizar.TabIndex = 20
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
        Me.BtnGrabar.Location = New System.Drawing.Point(122, 416)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGrabar.Size = New System.Drawing.Size(59, 56)
        Me.BtnGrabar.TabIndex = 16
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGrabar.UseVisualStyleBackColor = True
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
        Me.BtnSalir.Location = New System.Drawing.Point(824, 416)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(87, 56)
        Me.BtnSalir.TabIndex = 25
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
        Me.BtnModificar.Location = New System.Drawing.Point(205, 416)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnModificar.Size = New System.Drawing.Size(80, 56)
        Me.BtnModificar.TabIndex = 17
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
        Me.BtnEliminar.Location = New System.Drawing.Point(301, 416)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEliminar.Size = New System.Drawing.Size(73, 56)
        Me.BtnEliminar.TabIndex = 18
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
        Me.BtnBuscar.Location = New System.Drawing.Point(393, 416)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnBuscar.Size = New System.Drawing.Size(59, 56)
        Me.BtnBuscar.TabIndex = 19
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
        Me.BtnAgregar.Location = New System.Drawing.Point(39, 416)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAgregar.Size = New System.Drawing.Size(66, 56)
        Me.BtnAgregar.TabIndex = 15
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(21, 408)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(563, 73)
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(590, 408)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 73)
        Me.PictureBox2.TabIndex = 100
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(818, 408)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(99, 73)
        Me.PictureBox3.TabIndex = 101
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(262, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 36)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Actualización de Clientes"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalidad.Enabled = False
        Me.txtLocalidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.ForeColor = System.Drawing.Color.White
        Me.txtLocalidad.Location = New System.Drawing.Point(236, 175)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(264, 23)
        Me.txtLocalidad.TabIndex = 6
        '
        'txtProvincia
        '
        Me.txtProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvincia.Enabled = False
        Me.txtProvincia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.ForeColor = System.Drawing.Color.White
        Me.txtProvincia.Location = New System.Drawing.Point(506, 175)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(264, 23)
        Me.txtProvincia.TabIndex = 7
        '
        'txtCodPostal
        '
        Me.txtCodPostal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPostal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPostal.ForeColor = System.Drawing.Color.White
        Me.txtCodPostal.Location = New System.Drawing.Point(169, 175)
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(61, 23)
        Me.txtCodPostal.TabIndex = 5
        Me.txtCodPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCuitCli
        '
        Me.txtCuitCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCuitCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuitCli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "CuitCli", True))
        Me.txtCuitCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuitCli.ForeColor = System.Drawing.Color.White
        Me.txtCuitCli.Location = New System.Drawing.Point(169, 262)
        Me.txtCuitCli.Name = "txtCuitCli"
        Me.txtCuitCli.Size = New System.Drawing.Size(143, 23)
        Me.txtCuitCli.TabIndex = 11
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(21, 49)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(896, 353)
        Me.PictureBox4.TabIndex = 103
        Me.PictureBox4.TabStop = False
        '
        'CategivaTableAdapter
        '
        Me.CategivaTableAdapter.ClearBeforeFill = True
        '
        'txtEmailCli
        '
        Me.txtEmailCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtEmailCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailCli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "EmailCli", True))
        Me.txtEmailCli.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailCli.ForeColor = System.Drawing.Color.White
        Me.txtEmailCli.Location = New System.Drawing.Point(169, 320)
        Me.txtEmailCli.Name = "txtEmailCli"
        Me.txtEmailCli.Size = New System.Drawing.Size(601, 23)
        Me.txtEmailCli.TabIndex = 13
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 505)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtEmailCli)
        Me.Controls.Add(Me.txtCuitCli)
        Me.Controls.Add(Me.txtCodPostal)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Me.txtLocalidad)
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
        Me.Controls.Add(Me.cmbTipoIvaCli)
        Me.Controls.Add(Me.txtId_Cli)
        Me.Controls.Add(NroCliLabel)
        Me.Controls.Add(Me.txtNroCli)
        Me.Controls.Add(NombreCliLabel)
        Me.Controls.Add(Me.txtNombreCli)
        Me.Controls.Add(TitularCliLabel)
        Me.Controls.Add(Me.txtTitularCli)
        Me.Controls.Add(DomicilioCliLabel)
        Me.Controls.Add(Me.txtDomicilioCli)
        Me.Controls.Add(IdCodPosCliLabel)
        Me.Controls.Add(Me.txtIdCodPosCli)
        Me.Controls.Add(TelefCliLabel)
        Me.Controls.Add(Me.txtTelefCli)
        Me.Controls.Add(TipoIvaCliLabel)
        Me.Controls.Add(CuitCliLabel)
        Me.Controls.Add(IngBrutosCliLabel)
        Me.Controls.Add(Me.txtIngBrutosCli)
        Me.Controls.Add(ObsCliLabel)
        Me.Controls.Add(Me.txtObsCli)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClientes"
        Me.Text = "ACTUALIZACIÓN DE CLIENTES"
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        CType(Me.CategivaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As dbsointDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As dbsointDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingNavigator As BindingNavigator
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
    Friend WithEvents ClientesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId_Cli As TextBox
    Friend WithEvents txtNroCli As TextBox
    Friend WithEvents txtNombreCli As TextBox
    Friend WithEvents txtTitularCli As TextBox
    Friend WithEvents txtDomicilioCli As TextBox
    Friend WithEvents txtIdCodPosCli As TextBox
    Friend WithEvents txtTelefCli As TextBox
    Friend WithEvents txtIngBrutosCli As TextBox
    Friend WithEvents txtObsCli As TextBox
    Friend WithEvents cmbTipoIvaCli As ComboBox
    Friend WithEvents ToolTipMsg As ToolTip
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
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtCodPostal As TextBox
    Friend WithEvents txtCuitCli As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents CategivaBindingSource As BindingSource
    Friend WithEvents CategivaTableAdapter As dbsointDataSetTableAdapters.categivaTableAdapter
    Friend WithEvents txtEmailCli As TextBox
End Class
