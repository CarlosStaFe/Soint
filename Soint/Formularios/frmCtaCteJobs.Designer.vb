<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtaCteJobs
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtaCteJobs))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtApelyNomb = New System.Windows.Forms.TextBox()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvCtasctes = New System.Windows.Forms.DataGridView()
        Me.IdCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCbteCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubfijoCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCCEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtacteempBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.CtacteempTableAdapter = New Soint.dbsointDataSetTableAdapters.ctacteempTableAdapter()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCtasctes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtacteempBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(262, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(455, 36)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Cuentas Corrientes Empleados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(680, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "SALDO:"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.Black
        Me.txtSaldo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtSaldo.Location = New System.Drawing.Point(751, 69)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(117, 27)
        Me.txtSaldo.TabIndex = 94
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtApelyNomb
        '
        Me.txtApelyNomb.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtApelyNomb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApelyNomb.Enabled = False
        Me.txtApelyNomb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApelyNomb.ForeColor = System.Drawing.Color.White
        Me.txtApelyNomb.Location = New System.Drawing.Point(191, 72)
        Me.txtApelyNomb.Name = "txtApelyNomb"
        Me.txtApelyNomb.Size = New System.Drawing.Size(305, 23)
        Me.txtApelyNomb.TabIndex = 92
        '
        'txtEmpleado
        '
        Me.txtEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpleado.ForeColor = System.Drawing.Color.White
        Me.txtEmpleado.Location = New System.Drawing.Point(123, 72)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(62, 23)
        Me.txtEmpleado.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Empleado:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(975, 47)
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'dgvCtasctes
        '
        Me.dgvCtasctes.AllowUserToAddRows = False
        Me.dgvCtasctes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCtasctes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCtasctes.AutoGenerateColumns = False
        Me.dgvCtasctes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvCtasctes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtasctes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCtasctes.ColumnHeadersHeight = 30
        Me.dgvCtasctes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCtasctes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCCEmpDataGridViewTextBoxColumn, Me.NroCCEmpDataGridViewTextBoxColumn, Me.FechaCCEmpDataGridViewTextBoxColumn, Me.TipoCbteCCEmpDataGridViewTextBoxColumn, Me.SubfijoCCEmpDataGridViewTextBoxColumn, Me.CantidadCCEmpDataGridViewTextBoxColumn, Me.DetalleCCEmpDataGridViewTextBoxColumn, Me.ImpCCEmpDataGridViewTextBoxColumn, Me.TotalCCEmpDataGridViewTextBoxColumn, Me.DebeCCEmpDataGridViewTextBoxColumn, Me.HaberCCEmpDataGridViewTextBoxColumn, Me.SaldoCCEmpDataGridViewTextBoxColumn, Me.EstadoCCEmpDataGridViewTextBoxColumn, Me.ObsCCEmpDataGridViewTextBoxColumn})
        Me.dgvCtasctes.DataSource = Me.CtacteempBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCtasctes.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCtasctes.EnableHeadersVisualStyles = False
        Me.dgvCtasctes.GridColor = System.Drawing.Color.White
        Me.dgvCtasctes.Location = New System.Drawing.Point(13, 113)
        Me.dgvCtasctes.Name = "dgvCtasctes"
        Me.dgvCtasctes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtasctes.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCtasctes.Size = New System.Drawing.Size(974, 452)
        Me.dgvCtasctes.TabIndex = 97
        '
        'IdCCEmpDataGridViewTextBoxColumn
        '
        Me.IdCCEmpDataGridViewTextBoxColumn.DataPropertyName = "id_CCEmp"
        Me.IdCCEmpDataGridViewTextBoxColumn.HeaderText = "id_CCEmp"
        Me.IdCCEmpDataGridViewTextBoxColumn.Name = "IdCCEmpDataGridViewTextBoxColumn"
        Me.IdCCEmpDataGridViewTextBoxColumn.Visible = False
        '
        'NroCCEmpDataGridViewTextBoxColumn
        '
        Me.NroCCEmpDataGridViewTextBoxColumn.DataPropertyName = "NroCCEmp"
        Me.NroCCEmpDataGridViewTextBoxColumn.HeaderText = "NroCCEmp"
        Me.NroCCEmpDataGridViewTextBoxColumn.Name = "NroCCEmpDataGridViewTextBoxColumn"
        Me.NroCCEmpDataGridViewTextBoxColumn.Visible = False
        '
        'FechaCCEmpDataGridViewTextBoxColumn
        '
        Me.FechaCCEmpDataGridViewTextBoxColumn.DataPropertyName = "FechaCCEmp"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaCCEmpDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaCCEmpDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FechaCCEmpDataGridViewTextBoxColumn.Name = "FechaCCEmpDataGridViewTextBoxColumn"
        Me.FechaCCEmpDataGridViewTextBoxColumn.Width = 80
        '
        'TipoCbteCCEmpDataGridViewTextBoxColumn
        '
        Me.TipoCbteCCEmpDataGridViewTextBoxColumn.DataPropertyName = "TipoCbteCCEmp"
        Me.TipoCbteCCEmpDataGridViewTextBoxColumn.HeaderText = "TIPO"
        Me.TipoCbteCCEmpDataGridViewTextBoxColumn.Name = "TipoCbteCCEmpDataGridViewTextBoxColumn"
        Me.TipoCbteCCEmpDataGridViewTextBoxColumn.Width = 50
        '
        'SubfijoCCEmpDataGridViewTextBoxColumn
        '
        Me.SubfijoCCEmpDataGridViewTextBoxColumn.DataPropertyName = "SubfijoCCEmp"
        Me.SubfijoCCEmpDataGridViewTextBoxColumn.HeaderText = "COMPROB."
        Me.SubfijoCCEmpDataGridViewTextBoxColumn.Name = "SubfijoCCEmpDataGridViewTextBoxColumn"
        '
        'CantidadCCEmpDataGridViewTextBoxColumn
        '
        Me.CantidadCCEmpDataGridViewTextBoxColumn.DataPropertyName = "CantidadCCEmp"
        Me.CantidadCCEmpDataGridViewTextBoxColumn.HeaderText = "CANTIDAD"
        Me.CantidadCCEmpDataGridViewTextBoxColumn.Name = "CantidadCCEmpDataGridViewTextBoxColumn"
        Me.CantidadCCEmpDataGridViewTextBoxColumn.Width = 80
        '
        'DetalleCCEmpDataGridViewTextBoxColumn
        '
        Me.DetalleCCEmpDataGridViewTextBoxColumn.DataPropertyName = "DetalleCCEmp"
        Me.DetalleCCEmpDataGridViewTextBoxColumn.HeaderText = "DETALLE"
        Me.DetalleCCEmpDataGridViewTextBoxColumn.Name = "DetalleCCEmpDataGridViewTextBoxColumn"
        Me.DetalleCCEmpDataGridViewTextBoxColumn.Width = 150
        '
        'ImpCCEmpDataGridViewTextBoxColumn
        '
        Me.ImpCCEmpDataGridViewTextBoxColumn.DataPropertyName = "ImpCCEmp"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ImpCCEmpDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ImpCCEmpDataGridViewTextBoxColumn.HeaderText = "IMPORTE"
        Me.ImpCCEmpDataGridViewTextBoxColumn.Name = "ImpCCEmpDataGridViewTextBoxColumn"
        '
        'TotalCCEmpDataGridViewTextBoxColumn
        '
        Me.TotalCCEmpDataGridViewTextBoxColumn.DataPropertyName = "TotalCCEmp"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.TotalCCEmpDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalCCEmpDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TotalCCEmpDataGridViewTextBoxColumn.Name = "TotalCCEmpDataGridViewTextBoxColumn"
        '
        'DebeCCEmpDataGridViewTextBoxColumn
        '
        Me.DebeCCEmpDataGridViewTextBoxColumn.DataPropertyName = "DebeCCEmp"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DebeCCEmpDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.DebeCCEmpDataGridViewTextBoxColumn.HeaderText = "DEBE"
        Me.DebeCCEmpDataGridViewTextBoxColumn.Name = "DebeCCEmpDataGridViewTextBoxColumn"
        '
        'HaberCCEmpDataGridViewTextBoxColumn
        '
        Me.HaberCCEmpDataGridViewTextBoxColumn.DataPropertyName = "HaberCCEmp"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.HaberCCEmpDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.HaberCCEmpDataGridViewTextBoxColumn.HeaderText = "HABER"
        Me.HaberCCEmpDataGridViewTextBoxColumn.Name = "HaberCCEmpDataGridViewTextBoxColumn"
        '
        'SaldoCCEmpDataGridViewTextBoxColumn
        '
        Me.SaldoCCEmpDataGridViewTextBoxColumn.DataPropertyName = "SaldoCCEmp"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.SaldoCCEmpDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.SaldoCCEmpDataGridViewTextBoxColumn.HeaderText = "SALDO"
        Me.SaldoCCEmpDataGridViewTextBoxColumn.Name = "SaldoCCEmpDataGridViewTextBoxColumn"
        '
        'EstadoCCEmpDataGridViewTextBoxColumn
        '
        Me.EstadoCCEmpDataGridViewTextBoxColumn.DataPropertyName = "EstadoCCEmp"
        Me.EstadoCCEmpDataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.EstadoCCEmpDataGridViewTextBoxColumn.Name = "EstadoCCEmpDataGridViewTextBoxColumn"
        '
        'ObsCCEmpDataGridViewTextBoxColumn
        '
        Me.ObsCCEmpDataGridViewTextBoxColumn.DataPropertyName = "ObsCCEmp"
        Me.ObsCCEmpDataGridViewTextBoxColumn.HeaderText = "Obs."
        Me.ObsCCEmpDataGridViewTextBoxColumn.Name = "ObsCCEmpDataGridViewTextBoxColumn"
        '
        'CtacteempBindingSource
        '
        Me.CtacteempBindingSource.DataMember = "ctacteemp"
        Me.CtacteempBindingSource.DataSource = Me.DbsointDataSet
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CtacteempTableAdapter
        '
        Me.CtacteempTableAdapter.ClearBeforeFill = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.Enabled = False
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(443, 580)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(119, 44)
        Me.btnActualizar.TabIndex = 101
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizar.UseVisualStyleBackColor = True
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
        Me.btnLimpiar.Location = New System.Drawing.Point(211, 580)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(99, 44)
        Me.btnLimpiar.TabIndex = 99
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(656, 580)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(99, 44)
        Me.btnSalir.TabIndex = 98
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(12, 572)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(975, 61)
        Me.PictureBox2.TabIndex = 100
        Me.PictureBox2.TabStop = False
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'frmCtaCteJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1148, 645)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dgvCtasctes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtApelyNomb)
        Me.Controls.Add(Me.txtEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCtaCteJobs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUENTAS CORRIENTES DE EMPLEADOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCtasctes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtacteempBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtApelyNomb As TextBox
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvCtasctes As DataGridView
    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents CtacteempBindingSource As BindingSource
    Friend WithEvents CtacteempTableAdapter As dbsointDataSetTableAdapters.ctacteempTableAdapter
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents IdCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCbteCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubfijoCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DebeCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HaberCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsCCEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolTipMsg As ToolTip
End Class
