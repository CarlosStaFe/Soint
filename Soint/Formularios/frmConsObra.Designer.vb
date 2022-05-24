<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsObra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsObra))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvObras = New System.Windows.Forms.DataGridView()
        Me.IdObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitularObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LugarObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecEstadoObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsObraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ObrasTableAdapter = New Soint.dbsointDataSetTableAdapters.obrasTableAdapter()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvObras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(285, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(281, 36)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Consulta de Obras"
        '
        'txtTitular
        '
        Me.txtTitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTitular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitular.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitular.ForeColor = System.Drawing.Color.White
        Me.txtTitular.Location = New System.Drawing.Point(192, 56)
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(523, 23)
        Me.txtTitular.TabIndex = 97
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(41, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(791, 41)
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(100, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Titular Obra:"
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
        Me.BtnSalir.Location = New System.Drawing.Point(534, 441)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(57, 56)
        Me.BtnSalir.TabIndex = 103
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(44, 428)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 19)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Haga doble clic en el renglón seleccionado..."
        '
        'dgvObras
        '
        Me.dgvObras.AllowUserToAddRows = False
        Me.dgvObras.AllowUserToDeleteRows = False
        Me.dgvObras.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvObras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvObras.AutoGenerateColumns = False
        Me.dgvObras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvObras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvObras.ColumnHeadersHeight = 40
        Me.dgvObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvObras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdObraDataGridViewTextBoxColumn, Me.ClienteObraDataGridViewTextBoxColumn, Me.NroObraDataGridViewTextBoxColumn, Me.FechaObraDataGridViewTextBoxColumn, Me.TitularObraDataGridViewTextBoxColumn, Me.LugarObraDataGridViewTextBoxColumn, Me.EstadoObraDataGridViewTextBoxColumn, Me.FecEstadoObraDataGridViewTextBoxColumn, Me.ObsObraDataGridViewTextBoxColumn})
        Me.dgvObras.DataSource = Me.ObrasBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvObras.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvObras.EnableHeadersVisualStyles = False
        Me.dgvObras.GridColor = System.Drawing.Color.White
        Me.dgvObras.Location = New System.Drawing.Point(41, 95)
        Me.dgvObras.Name = "dgvObras"
        Me.dgvObras.ReadOnly = True
        Me.dgvObras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObras.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvObras.Size = New System.Drawing.Size(791, 330)
        Me.dgvObras.TabIndex = 101
        '
        'IdObraDataGridViewTextBoxColumn
        '
        Me.IdObraDataGridViewTextBoxColumn.DataPropertyName = "id_Obra"
        Me.IdObraDataGridViewTextBoxColumn.HeaderText = "id_Obra"
        Me.IdObraDataGridViewTextBoxColumn.Name = "IdObraDataGridViewTextBoxColumn"
        Me.IdObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdObraDataGridViewTextBoxColumn.Visible = False
        '
        'ClienteObraDataGridViewTextBoxColumn
        '
        Me.ClienteObraDataGridViewTextBoxColumn.DataPropertyName = "ClienteObra"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ClienteObraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClienteObraDataGridViewTextBoxColumn.HeaderText = "CLIENTE"
        Me.ClienteObraDataGridViewTextBoxColumn.Name = "ClienteObraDataGridViewTextBoxColumn"
        Me.ClienteObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteObraDataGridViewTextBoxColumn.Width = 80
        '
        'NroObraDataGridViewTextBoxColumn
        '
        Me.NroObraDataGridViewTextBoxColumn.DataPropertyName = "NroObra"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NroObraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.NroObraDataGridViewTextBoxColumn.HeaderText = "OBRA"
        Me.NroObraDataGridViewTextBoxColumn.Name = "NroObraDataGridViewTextBoxColumn"
        Me.NroObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroObraDataGridViewTextBoxColumn.Width = 50
        '
        'FechaObraDataGridViewTextBoxColumn
        '
        Me.FechaObraDataGridViewTextBoxColumn.DataPropertyName = "FechaObra"
        Me.FechaObraDataGridViewTextBoxColumn.HeaderText = "FechaObra"
        Me.FechaObraDataGridViewTextBoxColumn.Name = "FechaObraDataGridViewTextBoxColumn"
        Me.FechaObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaObraDataGridViewTextBoxColumn.Visible = False
        '
        'TitularObraDataGridViewTextBoxColumn
        '
        Me.TitularObraDataGridViewTextBoxColumn.DataPropertyName = "TitularObra"
        Me.TitularObraDataGridViewTextBoxColumn.HeaderText = "TITULAR"
        Me.TitularObraDataGridViewTextBoxColumn.Name = "TitularObraDataGridViewTextBoxColumn"
        Me.TitularObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitularObraDataGridViewTextBoxColumn.Width = 200
        '
        'LugarObraDataGridViewTextBoxColumn
        '
        Me.LugarObraDataGridViewTextBoxColumn.DataPropertyName = "LugarObra"
        Me.LugarObraDataGridViewTextBoxColumn.HeaderText = "LUGAR"
        Me.LugarObraDataGridViewTextBoxColumn.Name = "LugarObraDataGridViewTextBoxColumn"
        Me.LugarObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.LugarObraDataGridViewTextBoxColumn.Width = 200
        '
        'EstadoObraDataGridViewTextBoxColumn
        '
        Me.EstadoObraDataGridViewTextBoxColumn.DataPropertyName = "EstadoObra"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.EstadoObraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.EstadoObraDataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.EstadoObraDataGridViewTextBoxColumn.Name = "EstadoObraDataGridViewTextBoxColumn"
        Me.EstadoObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoObraDataGridViewTextBoxColumn.Width = 110
        '
        'FecEstadoObraDataGridViewTextBoxColumn
        '
        Me.FecEstadoObraDataGridViewTextBoxColumn.DataPropertyName = "FecEstadoObra"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FecEstadoObraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.FecEstadoObraDataGridViewTextBoxColumn.HeaderText = "FEC. ESTADO"
        Me.FecEstadoObraDataGridViewTextBoxColumn.Name = "FecEstadoObraDataGridViewTextBoxColumn"
        Me.FecEstadoObraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObsObraDataGridViewTextBoxColumn
        '
        Me.ObsObraDataGridViewTextBoxColumn.DataPropertyName = "ObsObra"
        Me.ObsObraDataGridViewTextBoxColumn.HeaderText = "ObsObra"
        Me.ObsObraDataGridViewTextBoxColumn.Name = "ObsObraDataGridViewTextBoxColumn"
        Me.ObsObraDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsObraDataGridViewTextBoxColumn.Visible = False
        '
        'ObrasBindingSource
        '
        Me.ObrasBindingSource.DataMember = "obras"
        Me.ObrasBindingSource.DataSource = Me.DbsointDataSet
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(520, 434)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 69)
        Me.PictureBox2.TabIndex = 104
        Me.PictureBox2.TabStop = False
        '
        'ObrasTableAdapter
        '
        Me.ObrasTableAdapter.ClearBeforeFill = True
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'frmConsObra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(906, 527)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvObras)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTitular)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsObra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE OBRAS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvObras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtTitular As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvObras As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents ObrasBindingSource As BindingSource
    Friend WithEvents ObrasTableAdapter As dbsointDataSetTableAdapters.obrasTableAdapter
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents IdObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitularObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LugarObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecEstadoObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManoObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EquiposDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HerramientasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndirectosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsObraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
