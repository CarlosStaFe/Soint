<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtaCteCli
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtaCteCli))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtApelyNomb = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvCtasctes = New System.Windows.Forms.DataGridView()
        Me.IdCCCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCCCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCCCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCbteCCCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrefijoCCCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubfijoCCCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleCCCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeCCCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberCCCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoCCCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCCCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtactecliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.CtactecliTableAdapter = New Soint.dbsointDataSetTableAdapters.ctactecliTableAdapter()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCtasctes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtactecliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(269, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(410, 36)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Cuentas Corrientes Clientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(687, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "SALDO:"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.Black
        Me.txtSaldo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtSaldo.Location = New System.Drawing.Point(758, 69)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(117, 27)
        Me.txtSaldo.TabIndex = 101
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtApelyNomb
        '
        Me.txtApelyNomb.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtApelyNomb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApelyNomb.Enabled = False
        Me.txtApelyNomb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApelyNomb.ForeColor = System.Drawing.Color.White
        Me.txtApelyNomb.Location = New System.Drawing.Point(198, 72)
        Me.txtApelyNomb.Name = "txtApelyNomb"
        Me.txtApelyNomb.Size = New System.Drawing.Size(305, 23)
        Me.txtApelyNomb.TabIndex = 99
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.White
        Me.txtCliente.Location = New System.Drawing.Point(130, 72)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(62, 23)
        Me.txtCliente.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Cliente:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(19, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(975, 47)
        Me.PictureBox1.TabIndex = 102
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
        Me.dgvCtasctes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCCCliDataGridViewTextBoxColumn, Me.NroCCCliDataGridViewTextBoxColumn, Me.FechaCCCliDataGridViewTextBoxColumn, Me.TipoCbteCCCliDataGridViewTextBoxColumn, Me.PrefijoCCCliDataGridViewTextBoxColumn, Me.SubfijoCCCliDataGridViewTextBoxColumn, Me.DetalleCCCliDataGridViewTextBoxColumn, Me.DebeCCCliDataGridViewTextBoxColumn, Me.HaberCCCliDataGridViewTextBoxColumn, Me.SaldoCCCliDataGridViewTextBoxColumn, Me.ObsCCCliDataGridViewTextBoxColumn})
        Me.dgvCtasctes.DataSource = Me.CtactecliBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCtasctes.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCtasctes.EnableHeadersVisualStyles = False
        Me.dgvCtasctes.GridColor = System.Drawing.Color.White
        Me.dgvCtasctes.Location = New System.Drawing.Point(20, 113)
        Me.dgvCtasctes.Name = "dgvCtasctes"
        Me.dgvCtasctes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtasctes.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCtasctes.Size = New System.Drawing.Size(974, 452)
        Me.dgvCtasctes.TabIndex = 104
        '
        'IdCCCliDataGridViewTextBoxColumn
        '
        Me.IdCCCliDataGridViewTextBoxColumn.DataPropertyName = "id_CCCli"
        Me.IdCCCliDataGridViewTextBoxColumn.HeaderText = "id_CCCli"
        Me.IdCCCliDataGridViewTextBoxColumn.Name = "IdCCCliDataGridViewTextBoxColumn"
        Me.IdCCCliDataGridViewTextBoxColumn.Visible = False
        '
        'NroCCCliDataGridViewTextBoxColumn
        '
        Me.NroCCCliDataGridViewTextBoxColumn.DataPropertyName = "NroCCCli"
        Me.NroCCCliDataGridViewTextBoxColumn.HeaderText = "NroCCCli"
        Me.NroCCCliDataGridViewTextBoxColumn.Name = "NroCCCliDataGridViewTextBoxColumn"
        Me.NroCCCliDataGridViewTextBoxColumn.Visible = False
        '
        'FechaCCCliDataGridViewTextBoxColumn
        '
        Me.FechaCCCliDataGridViewTextBoxColumn.DataPropertyName = "FechaCCCli"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaCCCliDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaCCCliDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FechaCCCliDataGridViewTextBoxColumn.Name = "FechaCCCliDataGridViewTextBoxColumn"
        Me.FechaCCCliDataGridViewTextBoxColumn.Width = 80
        '
        'TipoCbteCCCliDataGridViewTextBoxColumn
        '
        Me.TipoCbteCCCliDataGridViewTextBoxColumn.DataPropertyName = "TipoCbteCCCli"
        Me.TipoCbteCCCliDataGridViewTextBoxColumn.HeaderText = "TIPO"
        Me.TipoCbteCCCliDataGridViewTextBoxColumn.Name = "TipoCbteCCCliDataGridViewTextBoxColumn"
        Me.TipoCbteCCCliDataGridViewTextBoxColumn.Width = 50
        '
        'PrefijoCCCliDataGridViewTextBoxColumn
        '
        Me.PrefijoCCCliDataGridViewTextBoxColumn.DataPropertyName = "PrefijoCCCli"
        Me.PrefijoCCCliDataGridViewTextBoxColumn.HeaderText = "PREF."
        Me.PrefijoCCCliDataGridViewTextBoxColumn.Name = "PrefijoCCCliDataGridViewTextBoxColumn"
        Me.PrefijoCCCliDataGridViewTextBoxColumn.Width = 40
        '
        'SubfijoCCCliDataGridViewTextBoxColumn
        '
        Me.SubfijoCCCliDataGridViewTextBoxColumn.DataPropertyName = "SubfijoCCCli"
        Me.SubfijoCCCliDataGridViewTextBoxColumn.HeaderText = "NÚMERO"
        Me.SubfijoCCCliDataGridViewTextBoxColumn.Name = "SubfijoCCCliDataGridViewTextBoxColumn"
        '
        'DetalleCCCliDataGridViewTextBoxColumn
        '
        Me.DetalleCCCliDataGridViewTextBoxColumn.DataPropertyName = "DetalleCCCli"
        Me.DetalleCCCliDataGridViewTextBoxColumn.HeaderText = "DETALLE"
        Me.DetalleCCCliDataGridViewTextBoxColumn.Name = "DetalleCCCliDataGridViewTextBoxColumn"
        Me.DetalleCCCliDataGridViewTextBoxColumn.Width = 150
        '
        'DebeCCCliDataGridViewTextBoxColumn
        '
        Me.DebeCCCliDataGridViewTextBoxColumn.DataPropertyName = "DebeCCCli"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DebeCCCliDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.DebeCCCliDataGridViewTextBoxColumn.HeaderText = "DEBE"
        Me.DebeCCCliDataGridViewTextBoxColumn.Name = "DebeCCCliDataGridViewTextBoxColumn"
        '
        'HaberCCCliDataGridViewTextBoxColumn
        '
        Me.HaberCCCliDataGridViewTextBoxColumn.DataPropertyName = "HaberCCCli"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.HaberCCCliDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.HaberCCCliDataGridViewTextBoxColumn.HeaderText = "HABER"
        Me.HaberCCCliDataGridViewTextBoxColumn.Name = "HaberCCCliDataGridViewTextBoxColumn"
        '
        'SaldoCCCliDataGridViewTextBoxColumn
        '
        Me.SaldoCCCliDataGridViewTextBoxColumn.DataPropertyName = "SaldoCCCli"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.SaldoCCCliDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.SaldoCCCliDataGridViewTextBoxColumn.HeaderText = "SALDO"
        Me.SaldoCCCliDataGridViewTextBoxColumn.Name = "SaldoCCCliDataGridViewTextBoxColumn"
        '
        'ObsCCCliDataGridViewTextBoxColumn
        '
        Me.ObsCCCliDataGridViewTextBoxColumn.DataPropertyName = "ObsCCCli"
        Me.ObsCCCliDataGridViewTextBoxColumn.HeaderText = "Obs."
        Me.ObsCCCliDataGridViewTextBoxColumn.Name = "ObsCCCliDataGridViewTextBoxColumn"
        '
        'CtactecliBindingSource
        '
        Me.CtactecliBindingSource.DataMember = "ctactecli"
        Me.CtactecliBindingSource.DataSource = Me.DbsointDataSet
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CtactecliTableAdapter
        '
        Me.CtactecliTableAdapter.ClearBeforeFill = True
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
        Me.btnActualizar.Location = New System.Drawing.Point(451, 579)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(119, 44)
        Me.btnActualizar.TabIndex = 108
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
        Me.btnLimpiar.Location = New System.Drawing.Point(219, 579)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(99, 44)
        Me.btnLimpiar.TabIndex = 106
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
        Me.btnSalir.Location = New System.Drawing.Point(664, 579)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(99, 44)
        Me.btnSalir.TabIndex = 105
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(20, 571)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(975, 61)
        Me.PictureBox2.TabIndex = 107
        Me.PictureBox2.TabStop = False
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'frmCtaCteCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1021, 647)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dgvCtasctes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtApelyNomb)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCtaCteCli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUENTAS CORRIENTES DE CLIENTES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCtasctes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtactecliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtApelyNomb As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvCtasctes As DataGridView
    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents CtactecliBindingSource As BindingSource
    Friend WithEvents CtactecliTableAdapter As dbsointDataSetTableAdapters.ctactecliTableAdapter
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents IdCCCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCCCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCCCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCbteCCCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrefijoCCCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubfijoCCCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleCCCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DebeCCCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HaberCCCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoCCCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsCCCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolTipMsg As ToolTip
End Class
