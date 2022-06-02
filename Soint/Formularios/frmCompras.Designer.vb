<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Dim NroProvCpraLabel As System.Windows.Forms.Label
        Dim TitularCpraLabel As System.Windows.Forms.Label
        Dim FechaCpraLabel As System.Windows.Forms.Label
        Dim TipoCbteCpraLabel As System.Windows.Forms.Label
        Dim PrefijoCpraLabel As System.Windows.Forms.Label
        Dim SubfijoCpraLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompras))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter = New Soint.dbsointDataSetTableAdapters.comprasTableAdapter()
        Me.TableAdapterManager = New Soint.dbsointDataSetTableAdapters.TableAdapterManager()
        Me.DetallecpraTableAdapter = New Soint.dbsointDataSetTableAdapters.detallecpraTableAdapter()
        Me.txtId_Cpra = New System.Windows.Forms.TextBox()
        Me.txtNroProvCpra = New System.Windows.Forms.TextBox()
        Me.txtTitularCpra = New System.Windows.Forms.TextBox()
        Me.txtPrefijoCpra = New System.Windows.Forms.TextBox()
        Me.txtSubfijoCpra = New System.Windows.Forms.TextBox()
        Me.txtNetoCpra = New System.Windows.Forms.TextBox()
        Me.txtIvaResCpra = New System.Windows.Forms.TextBox()
        Me.txtIvaNoResCpra = New System.Windows.Forms.TextBox()
        Me.txtImpIntCpra = New System.Windows.Forms.TextBox()
        Me.txtTotalCpra = New System.Windows.Forms.TextBox()
        Me.txtFechaCpra = New System.Windows.Forms.TextBox()
        Me.DetallecpraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtId_DetCpra = New System.Windows.Forms.TextBox()
        Me.txtItemDetCpra = New System.Windows.Forms.TextBox()
        Me.txtCantDetCpra = New System.Windows.Forms.TextBox()
        Me.txtNetoDetCpra = New System.Windows.Forms.TextBox()
        Me.txtResDetCpra = New System.Windows.Forms.TextBox()
        Me.txtNoResDetCpra = New System.Windows.Forms.TextBox()
        Me.txtImpIntDetCpra = New System.Windows.Forms.TextBox()
        Me.txtTotalDetCpra = New System.Windows.Forms.TextBox()
        Me.txtSRubDetCpra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbxTipoCbteCpra = New System.Windows.Forms.ComboBox()
        Me.txtObraDetCpra = New System.Windows.Forms.TextBox()
        Me.txtDetalleDetCpra = New System.Windows.Forms.TextBox()
        Me.txtUnitDetCpra = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtIdSRubDetCpra = New System.Windows.Forms.TextBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.dgvDetCompras = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NroProvCpraLabel = New System.Windows.Forms.Label()
        TitularCpraLabel = New System.Windows.Forms.Label()
        FechaCpraLabel = New System.Windows.Forms.Label()
        TipoCbteCpraLabel = New System.Windows.Forms.Label()
        PrefijoCpraLabel = New System.Windows.Forms.Label()
        SubfijoCpraLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallecpraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NroProvCpraLabel
        '
        NroProvCpraLabel.AutoSize = True
        NroProvCpraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NroProvCpraLabel.Location = New System.Drawing.Point(33, 64)
        NroProvCpraLabel.Name = "NroProvCpraLabel"
        NroProvCpraLabel.Size = New System.Drawing.Size(76, 17)
        NroProvCpraLabel.TabIndex = 3
        NroProvCpraLabel.Text = "Nro. Prov.:"
        '
        'TitularCpraLabel
        '
        TitularCpraLabel.AutoSize = True
        TitularCpraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitularCpraLabel.Location = New System.Drawing.Point(241, 64)
        TitularCpraLabel.Name = "TitularCpraLabel"
        TitularCpraLabel.Size = New System.Drawing.Size(49, 17)
        TitularCpraLabel.TabIndex = 5
        TitularCpraLabel.Text = "Titular:"
        '
        'FechaCpraLabel
        '
        FechaCpraLabel.AutoSize = True
        FechaCpraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaCpraLabel.Location = New System.Drawing.Point(58, 93)
        FechaCpraLabel.Name = "FechaCpraLabel"
        FechaCpraLabel.Size = New System.Drawing.Size(51, 17)
        FechaCpraLabel.TabIndex = 7
        FechaCpraLabel.Text = "Fecha:"
        '
        'TipoCbteCpraLabel
        '
        TipoCbteCpraLabel.AutoSize = True
        TipoCbteCpraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoCbteCpraLabel.Location = New System.Drawing.Point(211, 93)
        TipoCbteCpraLabel.Name = "TipoCbteCpraLabel"
        TipoCbteCpraLabel.Size = New System.Drawing.Size(79, 17)
        TipoCbteCpraLabel.TabIndex = 9
        TipoCbteCpraLabel.Text = "Tipo Cbte.:"
        '
        'PrefijoCpraLabel
        '
        PrefijoCpraLabel.AutoSize = True
        PrefijoCpraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrefijoCpraLabel.Location = New System.Drawing.Point(435, 93)
        PrefijoCpraLabel.Name = "PrefijoCpraLabel"
        PrefijoCpraLabel.Size = New System.Drawing.Size(51, 17)
        PrefijoCpraLabel.TabIndex = 11
        PrefijoCpraLabel.Text = "Prefijo:"
        '
        'SubfijoCpraLabel
        '
        SubfijoCpraLabel.AutoSize = True
        SubfijoCpraLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubfijoCpraLabel.Location = New System.Drawing.Point(550, 93)
        SubfijoCpraLabel.Name = "SubfijoCpraLabel"
        SubfijoCpraLabel.Size = New System.Drawing.Size(54, 17)
        SubfijoCpraLabel.TabIndex = 13
        SubfijoCpraLabel.Text = "Subfijo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.YellowGreen
        Label1.Location = New System.Drawing.Point(17, 138)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(47, 17)
        Label1.TabIndex = 112
        Label1.Text = "CANT."
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.YellowGreen
        Label2.Location = New System.Drawing.Point(71, 138)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(58, 17)
        Label2.TabIndex = 113
        Label2.Text = "DETALLE"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.YellowGreen
        Label4.Location = New System.Drawing.Point(289, 138)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(68, 17)
        Label4.TabIndex = 114
        Label4.Text = "IMP. UNIT."
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.YellowGreen
        Label5.Location = New System.Drawing.Point(375, 138)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(71, 17)
        Label5.TabIndex = 115
        Label5.Text = "IMP. NETO"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.YellowGreen
        Label6.Location = New System.Drawing.Point(470, 138)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(78, 17)
        Label6.TabIndex = 116
        Label6.Text = "I.V.A. RESP."
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.YellowGreen
        Label7.Location = New System.Drawing.Point(557, 138)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(103, 17)
        Label7.TabIndex = 117
        Label7.Text = "I.V.A. NO RESP."
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.YellowGreen
        Label8.Location = New System.Drawing.Point(665, 138)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(84, 17)
        Label8.TabIndex = 118
        Label8.Text = "IMP. VARIOS"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.Color.YellowGreen
        Label9.Location = New System.Drawing.Point(771, 138)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(65, 17)
        Label9.TabIndex = 119
        Label9.Text = "SUBTOTAL"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.YellowGreen
        Label10.Location = New System.Drawing.Point(930, 138)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(87, 17)
        Label10.TabIndex = 120
        Label10.Text = "IMPUTACIÓN"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.Color.YellowGreen
        Label11.Location = New System.Drawing.Point(1105, 138)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(43, 17)
        Label11.TabIndex = 121
        Label11.Text = "OBRA"
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "compras"
        Me.ComprasBindingSource.DataSource = Me.DbsointDataSet
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.comprasTableAdapter = Me.ComprasTableAdapter
        Me.TableAdapterManager.comprobantesTableAdapter = Nothing
        Me.TableAdapterManager.conceptosTableAdapter = Nothing
        Me.TableAdapterManager.ctactecliTableAdapter = Nothing
        Me.TableAdapterManager.ctacteempTableAdapter = Nothing
        Me.TableAdapterManager.ctacteproTableAdapter = Nothing
        Me.TableAdapterManager.detallecpraTableAdapter = Me.DetallecpraTableAdapter
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
        'DetallecpraTableAdapter
        '
        Me.DetallecpraTableAdapter.ClearBeforeFill = True
        '
        'txtId_Cpra
        '
        Me.txtId_Cpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_Cpra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_Cpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "id_Cpra", True))
        Me.txtId_Cpra.Enabled = False
        Me.txtId_Cpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_Cpra.ForeColor = System.Drawing.Color.White
        Me.txtId_Cpra.Location = New System.Drawing.Point(708, 64)
        Me.txtId_Cpra.Name = "txtId_Cpra"
        Me.txtId_Cpra.Size = New System.Drawing.Size(59, 16)
        Me.txtId_Cpra.TabIndex = 2
        '
        'txtNroProvCpra
        '
        Me.txtNroProvCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroProvCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroProvCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "NroProvCpra", True))
        Me.txtNroProvCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroProvCpra.ForeColor = System.Drawing.Color.White
        Me.txtNroProvCpra.Location = New System.Drawing.Point(115, 62)
        Me.txtNroProvCpra.Name = "txtNroProvCpra"
        Me.txtNroProvCpra.Size = New System.Drawing.Size(77, 23)
        Me.txtNroProvCpra.TabIndex = 0
        '
        'txtTitularCpra
        '
        Me.txtTitularCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTitularCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitularCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "TitularCpra", True))
        Me.txtTitularCpra.Enabled = False
        Me.txtTitularCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitularCpra.ForeColor = System.Drawing.Color.White
        Me.txtTitularCpra.Location = New System.Drawing.Point(296, 62)
        Me.txtTitularCpra.Name = "txtTitularCpra"
        Me.txtTitularCpra.Size = New System.Drawing.Size(403, 23)
        Me.txtTitularCpra.TabIndex = 1
        '
        'txtPrefijoCpra
        '
        Me.txtPrefijoCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPrefijoCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrefijoCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "PrefijoCpra", True))
        Me.txtPrefijoCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefijoCpra.ForeColor = System.Drawing.Color.White
        Me.txtPrefijoCpra.Location = New System.Drawing.Point(492, 91)
        Me.txtPrefijoCpra.Name = "txtPrefijoCpra"
        Me.txtPrefijoCpra.Size = New System.Drawing.Size(50, 23)
        Me.txtPrefijoCpra.TabIndex = 5
        '
        'txtSubfijoCpra
        '
        Me.txtSubfijoCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSubfijoCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubfijoCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "SubfijoCpra", True))
        Me.txtSubfijoCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubfijoCpra.ForeColor = System.Drawing.Color.White
        Me.txtSubfijoCpra.Location = New System.Drawing.Point(610, 91)
        Me.txtSubfijoCpra.Name = "txtSubfijoCpra"
        Me.txtSubfijoCpra.Size = New System.Drawing.Size(88, 23)
        Me.txtSubfijoCpra.TabIndex = 6
        '
        'txtNetoCpra
        '
        Me.txtNetoCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNetoCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetoCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "NetoCpra", True))
        Me.txtNetoCpra.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetoCpra.ForeColor = System.Drawing.Color.Yellow
        Me.txtNetoCpra.Location = New System.Drawing.Point(505, 430)
        Me.txtNetoCpra.Name = "txtNetoCpra"
        Me.txtNetoCpra.Size = New System.Drawing.Size(95, 26)
        Me.txtNetoCpra.TabIndex = 17
        Me.txtNetoCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIvaResCpra
        '
        Me.txtIvaResCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIvaResCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIvaResCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "IvaResCpra", True))
        Me.txtIvaResCpra.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIvaResCpra.ForeColor = System.Drawing.Color.Yellow
        Me.txtIvaResCpra.Location = New System.Drawing.Point(604, 430)
        Me.txtIvaResCpra.Name = "txtIvaResCpra"
        Me.txtIvaResCpra.Size = New System.Drawing.Size(95, 26)
        Me.txtIvaResCpra.TabIndex = 18
        Me.txtIvaResCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIvaNoResCpra
        '
        Me.txtIvaNoResCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIvaNoResCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIvaNoResCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "IvaNoResCpra", True))
        Me.txtIvaNoResCpra.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIvaNoResCpra.ForeColor = System.Drawing.Color.Yellow
        Me.txtIvaNoResCpra.Location = New System.Drawing.Point(703, 430)
        Me.txtIvaNoResCpra.Name = "txtIvaNoResCpra"
        Me.txtIvaNoResCpra.Size = New System.Drawing.Size(95, 26)
        Me.txtIvaNoResCpra.TabIndex = 19
        Me.txtIvaNoResCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpIntCpra
        '
        Me.txtImpIntCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtImpIntCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImpIntCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "ImpIntCpra", True))
        Me.txtImpIntCpra.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpIntCpra.ForeColor = System.Drawing.Color.Yellow
        Me.txtImpIntCpra.Location = New System.Drawing.Point(802, 430)
        Me.txtImpIntCpra.Name = "txtImpIntCpra"
        Me.txtImpIntCpra.Size = New System.Drawing.Size(95, 26)
        Me.txtImpIntCpra.TabIndex = 20
        Me.txtImpIntCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCpra
        '
        Me.txtTotalCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTotalCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "TotalCpra", True))
        Me.txtTotalCpra.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCpra.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalCpra.Location = New System.Drawing.Point(901, 430)
        Me.txtTotalCpra.Name = "txtTotalCpra"
        Me.txtTotalCpra.Size = New System.Drawing.Size(95, 26)
        Me.txtTotalCpra.TabIndex = 21
        Me.txtTotalCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFechaCpra
        '
        Me.txtFechaCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFechaCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "FechaCpra", True))
        Me.txtFechaCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaCpra.ForeColor = System.Drawing.Color.White
        Me.txtFechaCpra.Location = New System.Drawing.Point(115, 91)
        Me.txtFechaCpra.Name = "txtFechaCpra"
        Me.txtFechaCpra.Size = New System.Drawing.Size(88, 23)
        Me.txtFechaCpra.TabIndex = 3
        '
        'DetallecpraBindingSource
        '
        Me.DetallecpraBindingSource.DataMember = "detallecpra"
        Me.DetallecpraBindingSource.DataSource = Me.DbsointDataSet
        '
        'txtId_DetCpra
        '
        Me.txtId_DetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_DetCpra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_DetCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallecpraBindingSource, "id_DetCpra", True))
        Me.txtId_DetCpra.Enabled = False
        Me.txtId_DetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_DetCpra.ForeColor = System.Drawing.Color.White
        Me.txtId_DetCpra.Location = New System.Drawing.Point(42, 432)
        Me.txtId_DetCpra.Name = "txtId_DetCpra"
        Me.txtId_DetCpra.Size = New System.Drawing.Size(74, 16)
        Me.txtId_DetCpra.TabIndex = 28
        Me.txtId_DetCpra.Visible = False
        '
        'txtItemDetCpra
        '
        Me.txtItemDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtItemDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemDetCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallecpraBindingSource, "ItemDetCpra", True))
        Me.txtItemDetCpra.Enabled = False
        Me.txtItemDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtItemDetCpra.Location = New System.Drawing.Point(122, 432)
        Me.txtItemDetCpra.Name = "txtItemDetCpra"
        Me.txtItemDetCpra.Size = New System.Drawing.Size(74, 16)
        Me.txtItemDetCpra.TabIndex = 32
        Me.txtItemDetCpra.Visible = False
        '
        'txtCantDetCpra
        '
        Me.txtCantDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCantDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantDetCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallecpraBindingSource, "CantDetCpra", True))
        Me.txtCantDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtCantDetCpra.Location = New System.Drawing.Point(18, 158)
        Me.txtCantDetCpra.Name = "txtCantDetCpra"
        Me.txtCantDetCpra.Size = New System.Drawing.Size(50, 23)
        Me.txtCantDetCpra.TabIndex = 7
        Me.txtCantDetCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetoDetCpra
        '
        Me.txtNetoDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNetoDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetoDetCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallecpraBindingSource, "NetoDetCpra", True))
        Me.txtNetoDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetoDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtNetoDetCpra.Location = New System.Drawing.Point(361, 158)
        Me.txtNetoDetCpra.Name = "txtNetoDetCpra"
        Me.txtNetoDetCpra.Size = New System.Drawing.Size(95, 23)
        Me.txtNetoDetCpra.TabIndex = 10
        Me.txtNetoDetCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtResDetCpra
        '
        Me.txtResDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtResDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResDetCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallecpraBindingSource, "ResDetCpra", True))
        Me.txtResDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtResDetCpra.Location = New System.Drawing.Point(460, 158)
        Me.txtResDetCpra.Name = "txtResDetCpra"
        Me.txtResDetCpra.Size = New System.Drawing.Size(95, 23)
        Me.txtResDetCpra.TabIndex = 11
        Me.txtResDetCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNoResDetCpra
        '
        Me.txtNoResDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNoResDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoResDetCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallecpraBindingSource, "NoResDetCpra", True))
        Me.txtNoResDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoResDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtNoResDetCpra.Location = New System.Drawing.Point(559, 158)
        Me.txtNoResDetCpra.Name = "txtNoResDetCpra"
        Me.txtNoResDetCpra.Size = New System.Drawing.Size(95, 23)
        Me.txtNoResDetCpra.TabIndex = 12
        Me.txtNoResDetCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpIntDetCpra
        '
        Me.txtImpIntDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtImpIntDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImpIntDetCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallecpraBindingSource, "ImpIntDetCpra", True))
        Me.txtImpIntDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpIntDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtImpIntDetCpra.Location = New System.Drawing.Point(658, 158)
        Me.txtImpIntDetCpra.Name = "txtImpIntDetCpra"
        Me.txtImpIntDetCpra.Size = New System.Drawing.Size(95, 23)
        Me.txtImpIntDetCpra.TabIndex = 13
        Me.txtImpIntDetCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDetCpra
        '
        Me.txtTotalDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTotalDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDetCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallecpraBindingSource, "TotalDetCpra", True))
        Me.txtTotalDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtTotalDetCpra.Location = New System.Drawing.Point(757, 158)
        Me.txtTotalDetCpra.Name = "txtTotalDetCpra"
        Me.txtTotalDetCpra.Size = New System.Drawing.Size(95, 23)
        Me.txtTotalDetCpra.TabIndex = 14
        Me.txtTotalDetCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSRubDetCpra
        '
        Me.txtSRubDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSRubDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSRubDetCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallecpraBindingSource, "SRubDetCpra", True))
        Me.txtSRubDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSRubDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtSRubDetCpra.Location = New System.Drawing.Point(856, 158)
        Me.txtSRubDetCpra.Name = "txtSRubDetCpra"
        Me.txtSRubDetCpra.Size = New System.Drawing.Size(240, 23)
        Me.txtSRubDetCpra.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(318, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(508, 36)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Carga de Compras a Proveedores"
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'cbxTipoCbteCpra
        '
        Me.cbxTipoCbteCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cbxTipoCbteCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "TipoCbteCpra", True))
        Me.cbxTipoCbteCpra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxTipoCbteCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoCbteCpra.ForeColor = System.Drawing.Color.White
        Me.cbxTipoCbteCpra.FormattingEnabled = True
        Me.cbxTipoCbteCpra.Items.AddRange(New Object() {"FAA", "FAB", "FAC", "NCA", "NCB", "NCC", "REM", "REC", "X"})
        Me.cbxTipoCbteCpra.Location = New System.Drawing.Point(296, 90)
        Me.cbxTipoCbteCpra.Name = "cbxTipoCbteCpra"
        Me.cbxTipoCbteCpra.Size = New System.Drawing.Size(77, 25)
        Me.cbxTipoCbteCpra.TabIndex = 4
        '
        'txtObraDetCpra
        '
        Me.txtObraDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObraDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObraDetCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallecpraBindingSource, "ObraDetCpra", True))
        Me.txtObraDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObraDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtObraDetCpra.Location = New System.Drawing.Point(1100, 158)
        Me.txtObraDetCpra.Name = "txtObraDetCpra"
        Me.txtObraDetCpra.Size = New System.Drawing.Size(55, 23)
        Me.txtObraDetCpra.TabIndex = 16
        Me.txtObraDetCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDetalleDetCpra
        '
        Me.txtDetalleDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDetalleDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalleDetCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallecpraBindingSource, "DetalleDetCpra", True))
        Me.txtDetalleDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtDetalleDetCpra.Location = New System.Drawing.Point(74, 158)
        Me.txtDetalleDetCpra.Name = "txtDetalleDetCpra"
        Me.txtDetalleDetCpra.Size = New System.Drawing.Size(206, 23)
        Me.txtDetalleDetCpra.TabIndex = 8
        '
        'txtUnitDetCpra
        '
        Me.txtUnitDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtUnitDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnitDetCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallecpraBindingSource, "UnitDetCpra", True))
        Me.txtUnitDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtUnitDetCpra.Location = New System.Drawing.Point(284, 158)
        Me.txtUnitDetCpra.Name = "txtUnitDetCpra"
        Me.txtUnitDetCpra.Size = New System.Drawing.Size(73, 23)
        Me.txtUnitDetCpra.TabIndex = 9
        Me.txtUnitDetCpra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(19, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(758, 73)
        Me.PictureBox1.TabIndex = 148
        Me.PictureBox1.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(1051, 64)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(96, 44)
        Me.btnAgregar.TabIndex = 149
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(794, 64)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(96, 44)
        Me.btnLimpiar.TabIndex = 150
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(783, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(375, 73)
        Me.PictureBox2.TabIndex = 151
        Me.PictureBox2.TabStop = False
        '
        'txtIdSRubDetCpra
        '
        Me.txtIdSRubDetCpra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIdSRubDetCpra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdSRubDetCpra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallecpraBindingSource, "IdSRubDetCpra", True))
        Me.txtIdSRubDetCpra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSRubDetCpra.ForeColor = System.Drawing.Color.White
        Me.txtIdSRubDetCpra.Location = New System.Drawing.Point(202, 432)
        Me.txtIdSRubDetCpra.Name = "txtIdSRubDetCpra"
        Me.txtIdSRubDetCpra.Size = New System.Drawing.Size(74, 16)
        Me.txtIdSRubDetCpra.TabIndex = 152
        Me.txtIdSRubDetCpra.Visible = False
        '
        'btnGrabar
        '
        Me.btnGrabar.AutoSize = True
        Me.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrabar.FlatAppearance.BorderSize = 0
        Me.btnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.ForeColor = System.Drawing.Color.White
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(159, 482)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGrabar.Size = New System.Drawing.Size(59, 56)
        Me.btnGrabar.TabIndex = 153
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.AutoSize = True
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(911, 482)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSalir.Size = New System.Drawing.Size(87, 56)
        Me.btnSalir.TabIndex = 156
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.AutoSize = True
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(398, 482)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnModificar.Size = New System.Drawing.Size(80, 56)
        Me.btnModificar.TabIndex = 154
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(658, 482)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEliminar.Size = New System.Drawing.Size(73, 56)
        Me.btnEliminar.TabIndex = 155
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(17, 417)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1141, 51)
        Me.PictureBox3.TabIndex = 157
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(17, 474)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1141, 71)
        Me.PictureBox4.TabIndex = 158
        Me.PictureBox4.TabStop = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(911, 64)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(119, 44)
        Me.btnActualizar.TabIndex = 160
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'dgvDetCompras
        '
        Me.dgvDetCompras.AllowUserToAddRows = False
        Me.dgvDetCompras.AllowUserToDeleteRows = False
        Me.dgvDetCompras.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvDetCompras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetCompras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvDetCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetCompras.ColumnHeadersHeight = 40
        Me.dgvDetCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDetCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetCompras.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvDetCompras.EnableHeadersVisualStyles = False
        Me.dgvDetCompras.GridColor = System.Drawing.Color.White
        Me.dgvDetCompras.Location = New System.Drawing.Point(17, 187)
        Me.dgvDetCompras.Name = "dgvDetCompras"
        Me.dgvDetCompras.ReadOnly = True
        Me.dgvDetCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvDetCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetCompras.Size = New System.Drawing.Size(1141, 224)
        Me.dgvDetCompras.TabIndex = 161
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "ITEM"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 45
        '
        'Column4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "CANT."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "DETALLE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 250
        '
        'Column6
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column6.HeaderText = "IMP. UNIT."
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column7.HeaderText = "IMP. NETO"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column8.HeaderText = "I.V.A. REPONS."
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column9.HeaderText = "I.V.A. NO RESPONS."
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column10.HeaderText = "IMPUESTOS VARIOS"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column11.HeaderText = "SUBTOTAL"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Column12"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Visible = False
        '
        'Column13
        '
        Me.Column13.HeaderText = "IMPUTACIÓN"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column14.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column14.HeaderText = "OBRA"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 50
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1355, 573)
        Me.Controls.Add(Me.dgvDetCompras)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtIdSRubDetCpra)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtUnitDetCpra)
        Me.Controls.Add(Me.txtDetalleDetCpra)
        Me.Controls.Add(Me.txtObraDetCpra)
        Me.Controls.Add(Me.cbxTipoCbteCpra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtId_DetCpra)
        Me.Controls.Add(Me.txtItemDetCpra)
        Me.Controls.Add(Me.txtCantDetCpra)
        Me.Controls.Add(Me.txtNetoDetCpra)
        Me.Controls.Add(Me.txtResDetCpra)
        Me.Controls.Add(Me.txtNoResDetCpra)
        Me.Controls.Add(Me.txtImpIntDetCpra)
        Me.Controls.Add(Me.txtTotalDetCpra)
        Me.Controls.Add(Me.txtSRubDetCpra)
        Me.Controls.Add(Me.txtFechaCpra)
        Me.Controls.Add(Me.txtId_Cpra)
        Me.Controls.Add(NroProvCpraLabel)
        Me.Controls.Add(Me.txtNroProvCpra)
        Me.Controls.Add(TitularCpraLabel)
        Me.Controls.Add(Me.txtTitularCpra)
        Me.Controls.Add(FechaCpraLabel)
        Me.Controls.Add(TipoCbteCpraLabel)
        Me.Controls.Add(PrefijoCpraLabel)
        Me.Controls.Add(Me.txtPrefijoCpra)
        Me.Controls.Add(SubfijoCpraLabel)
        Me.Controls.Add(Me.txtSubfijoCpra)
        Me.Controls.Add(Me.txtNetoCpra)
        Me.Controls.Add(Me.txtIvaResCpra)
        Me.Controls.Add(Me.txtIvaNoResCpra)
        Me.Controls.Add(Me.txtImpIntCpra)
        Me.Controls.Add(Me.txtTotalCpra)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CARGA DE COMPRAS A PROVEEDORES"
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallecpraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents ComprasBindingSource As BindingSource
    Friend WithEvents ComprasTableAdapter As dbsointDataSetTableAdapters.comprasTableAdapter
    Friend WithEvents TableAdapterManager As dbsointDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtId_Cpra As TextBox
    Friend WithEvents txtNroProvCpra As TextBox
    Friend WithEvents txtTitularCpra As TextBox
    Friend WithEvents txtPrefijoCpra As TextBox
    Friend WithEvents txtSubfijoCpra As TextBox
    Friend WithEvents txtNetoCpra As TextBox
    Friend WithEvents txtIvaResCpra As TextBox
    Friend WithEvents txtIvaNoResCpra As TextBox
    Friend WithEvents txtImpIntCpra As TextBox
    Friend WithEvents txtTotalCpra As TextBox
    Friend WithEvents txtFechaCpra As TextBox
    Friend WithEvents DetallecpraTableAdapter As dbsointDataSetTableAdapters.detallecpraTableAdapter
    Friend WithEvents DetallecpraBindingSource As BindingSource
    Friend WithEvents txtId_DetCpra As TextBox
    Friend WithEvents txtItemDetCpra As TextBox
    Friend WithEvents txtCantDetCpra As TextBox
    Friend WithEvents txtNetoDetCpra As TextBox
    Friend WithEvents txtResDetCpra As TextBox
    Friend WithEvents txtNoResDetCpra As TextBox
    Friend WithEvents txtImpIntDetCpra As TextBox
    Friend WithEvents txtTotalDetCpra As TextBox
    Friend WithEvents txtSRubDetCpra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents cbxTipoCbteCpra As ComboBox
    Friend WithEvents TipoDetCpraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDetCpraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImputadoDetCpraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtObraDetCpra As TextBox
    Friend WithEvents NroDetCpraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtDetalleDetCpra As TextBox
    Friend WithEvents txtUnitDetCpra As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtIdSRubDetCpra As TextBox
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents dgvDetCompras As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
End Class
