<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtaCteProv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtaCteProv))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgvCtasctes = New System.Windows.Forms.DataGridView()
        Me.IdCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCbteCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrefijoCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubfijoCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCCProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtacteproBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CtacteproTableAdapter = New Soint.dbsointDataSetTableAdapters.ctacteproTableAdapter()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCtasctes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtacteproBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnActualizar.Location = New System.Drawing.Point(453, 581)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(119, 44)
        Me.btnActualizar.TabIndex = 113
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
        Me.btnLimpiar.Location = New System.Drawing.Point(221, 581)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(99, 44)
        Me.btnLimpiar.TabIndex = 111
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
        Me.btnSalir.Location = New System.Drawing.Point(666, 581)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(99, 44)
        Me.btnSalir.TabIndex = 110
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(22, 573)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(975, 61)
        Me.PictureBox2.TabIndex = 112
        Me.PictureBox2.TabStop = False
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
        Me.dgvCtasctes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCCProDataGridViewTextBoxColumn, Me.NroCCProDataGridViewTextBoxColumn, Me.FechaCCProDataGridViewTextBoxColumn, Me.TipoCbteCCProDataGridViewTextBoxColumn, Me.PrefijoCCProDataGridViewTextBoxColumn, Me.SubfijoCCProDataGridViewTextBoxColumn, Me.DetalleCCProDataGridViewTextBoxColumn, Me.DebeCCProDataGridViewTextBoxColumn, Me.HaberCCProDataGridViewTextBoxColumn, Me.SaldoCCProDataGridViewTextBoxColumn, Me.ObsCCProDataGridViewTextBoxColumn})
        Me.dgvCtasctes.DataSource = Me.CtacteproBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCtasctes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCtasctes.EnableHeadersVisualStyles = False
        Me.dgvCtasctes.GridColor = System.Drawing.Color.White
        Me.dgvCtasctes.Location = New System.Drawing.Point(23, 114)
        Me.dgvCtasctes.Name = "dgvCtasctes"
        Me.dgvCtasctes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCtasctes.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCtasctes.Size = New System.Drawing.Size(974, 452)
        Me.dgvCtasctes.TabIndex = 109
        '
        'IdCCProDataGridViewTextBoxColumn
        '
        Me.IdCCProDataGridViewTextBoxColumn.DataPropertyName = "id_CCPro"
        Me.IdCCProDataGridViewTextBoxColumn.HeaderText = "id_CCPro"
        Me.IdCCProDataGridViewTextBoxColumn.Name = "IdCCProDataGridViewTextBoxColumn"
        '
        'NroCCProDataGridViewTextBoxColumn
        '
        Me.NroCCProDataGridViewTextBoxColumn.DataPropertyName = "NroCCPro"
        Me.NroCCProDataGridViewTextBoxColumn.HeaderText = "NroCCPro"
        Me.NroCCProDataGridViewTextBoxColumn.Name = "NroCCProDataGridViewTextBoxColumn"
        '
        'FechaCCProDataGridViewTextBoxColumn
        '
        Me.FechaCCProDataGridViewTextBoxColumn.DataPropertyName = "FechaCCPro"
        Me.FechaCCProDataGridViewTextBoxColumn.HeaderText = "FechaCCPro"
        Me.FechaCCProDataGridViewTextBoxColumn.Name = "FechaCCProDataGridViewTextBoxColumn"
        '
        'TipoCbteCCProDataGridViewTextBoxColumn
        '
        Me.TipoCbteCCProDataGridViewTextBoxColumn.DataPropertyName = "TipoCbteCCPro"
        Me.TipoCbteCCProDataGridViewTextBoxColumn.HeaderText = "TipoCbteCCPro"
        Me.TipoCbteCCProDataGridViewTextBoxColumn.Name = "TipoCbteCCProDataGridViewTextBoxColumn"
        '
        'PrefijoCCProDataGridViewTextBoxColumn
        '
        Me.PrefijoCCProDataGridViewTextBoxColumn.DataPropertyName = "PrefijoCCPro"
        Me.PrefijoCCProDataGridViewTextBoxColumn.HeaderText = "PrefijoCCPro"
        Me.PrefijoCCProDataGridViewTextBoxColumn.Name = "PrefijoCCProDataGridViewTextBoxColumn"
        '
        'SubfijoCCProDataGridViewTextBoxColumn
        '
        Me.SubfijoCCProDataGridViewTextBoxColumn.DataPropertyName = "SubfijoCCPro"
        Me.SubfijoCCProDataGridViewTextBoxColumn.HeaderText = "SubfijoCCPro"
        Me.SubfijoCCProDataGridViewTextBoxColumn.Name = "SubfijoCCProDataGridViewTextBoxColumn"
        '
        'DetalleCCProDataGridViewTextBoxColumn
        '
        Me.DetalleCCProDataGridViewTextBoxColumn.DataPropertyName = "DetalleCCPro"
        Me.DetalleCCProDataGridViewTextBoxColumn.HeaderText = "DetalleCCPro"
        Me.DetalleCCProDataGridViewTextBoxColumn.Name = "DetalleCCProDataGridViewTextBoxColumn"
        '
        'DebeCCProDataGridViewTextBoxColumn
        '
        Me.DebeCCProDataGridViewTextBoxColumn.DataPropertyName = "DebeCCPro"
        Me.DebeCCProDataGridViewTextBoxColumn.HeaderText = "DebeCCPro"
        Me.DebeCCProDataGridViewTextBoxColumn.Name = "DebeCCProDataGridViewTextBoxColumn"
        '
        'HaberCCProDataGridViewTextBoxColumn
        '
        Me.HaberCCProDataGridViewTextBoxColumn.DataPropertyName = "HaberCCPro"
        Me.HaberCCProDataGridViewTextBoxColumn.HeaderText = "HaberCCPro"
        Me.HaberCCProDataGridViewTextBoxColumn.Name = "HaberCCProDataGridViewTextBoxColumn"
        '
        'SaldoCCProDataGridViewTextBoxColumn
        '
        Me.SaldoCCProDataGridViewTextBoxColumn.DataPropertyName = "SaldoCCPro"
        Me.SaldoCCProDataGridViewTextBoxColumn.HeaderText = "SaldoCCPro"
        Me.SaldoCCProDataGridViewTextBoxColumn.Name = "SaldoCCProDataGridViewTextBoxColumn"
        '
        'ObsCCProDataGridViewTextBoxColumn
        '
        Me.ObsCCProDataGridViewTextBoxColumn.DataPropertyName = "ObsCCPro"
        Me.ObsCCProDataGridViewTextBoxColumn.HeaderText = "ObsCCPro"
        Me.ObsCCProDataGridViewTextBoxColumn.Name = "ObsCCProDataGridViewTextBoxColumn"
        '
        'CtacteproBindingSource
        '
        Me.CtacteproBindingSource.DataMember = "ctactepro"
        Me.CtacteproBindingSource.DataSource = Me.DbsointDataSet
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(272, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(474, 36)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Cuentas Corrientes Proveedores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(690, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "SALDO:"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.Black
        Me.txtSaldo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.GreenYellow
        Me.txtSaldo.Location = New System.Drawing.Point(761, 70)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(117, 27)
        Me.txtSaldo.TabIndex = 106
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTitular
        '
        Me.txtTitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTitular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitular.Enabled = False
        Me.txtTitular.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitular.ForeColor = System.Drawing.Color.White
        Me.txtTitular.Location = New System.Drawing.Point(201, 73)
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(305, 23)
        Me.txtTitular.TabIndex = 104
        '
        'txtProveedor
        '
        Me.txtProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProveedor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.ForeColor = System.Drawing.Color.White
        Me.txtProveedor.Location = New System.Drawing.Point(133, 73)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(62, 23)
        Me.txtProveedor.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Proveedor:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(22, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(975, 47)
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        'CtacteproTableAdapter
        '
        Me.CtacteproTableAdapter.ClearBeforeFill = True
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'frmCtaCteProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1130, 658)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dgvCtasctes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtTitular)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCtaCteProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUENTAS CORRIENTES PROVEEDORES"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCtasctes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtacteproBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgvCtasctes As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtTitular As TextBox
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents CtacteproBindingSource As BindingSource
    Friend WithEvents CtacteproTableAdapter As dbsointDataSetTableAdapters.ctacteproTableAdapter
    Friend WithEvents IdCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCbteCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrefijoCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubfijoCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DebeCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HaberCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsCCProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolTipMsg As ToolTip
End Class
