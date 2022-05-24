<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsClientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ClientesTableAdapter = New Soint.dbsointDataSetTableAdapters.clientesTableAdapter()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.IdCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitularCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCodPosCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoIvaCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngBrutosCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsCliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnSalir.Location = New System.Drawing.Point(532, 553)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(57, 56)
        Me.BtnSalir.TabIndex = 95
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(432, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(310, 36)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Consulta de Clientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(10, 538)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 19)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Haga doble clic en el renglón seleccionado..."
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClientes.AutoGenerateColumns = False
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClientes.ColumnHeadersHeight = 40
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCliDataGridViewTextBoxColumn, Me.NroCliDataGridViewTextBoxColumn, Me.NombreCliDataGridViewTextBoxColumn, Me.TitularCliDataGridViewTextBoxColumn, Me.DomicilioCliDataGridViewTextBoxColumn, Me.IdCodPosCliDataGridViewTextBoxColumn, Me.TelefCliDataGridViewTextBoxColumn, Me.TipoIvaCliDataGridViewTextBoxColumn, Me.CuitCliDataGridViewTextBoxColumn, Me.IngBrutosCliDataGridViewTextBoxColumn, Me.ObsCliDataGridViewTextBoxColumn, Me.EmailCli})
        Me.dgvClientes.DataSource = Me.ClientesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvClientes.EnableHeadersVisualStyles = False
        Me.dgvClientes.GridColor = System.Drawing.Color.White
        Me.dgvClientes.Location = New System.Drawing.Point(12, 102)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvClientes.Size = New System.Drawing.Size(1102, 433)
        Me.dgvClientes.TabIndex = 92
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.DbsointDataSet
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(230, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(523, 23)
        Me.txtNombre.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(109, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Nombre Cliente:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1102, 41)
        Me.PictureBox1.TabIndex = 96
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(518, 546)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 69)
        Me.PictureBox2.TabIndex = 97
        Me.PictureBox2.TabStop = False
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'IdCliDataGridViewTextBoxColumn
        '
        Me.IdCliDataGridViewTextBoxColumn.DataPropertyName = "id_Cli"
        Me.IdCliDataGridViewTextBoxColumn.HeaderText = "id_Cli"
        Me.IdCliDataGridViewTextBoxColumn.Name = "IdCliDataGridViewTextBoxColumn"
        Me.IdCliDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCliDataGridViewTextBoxColumn.Visible = False
        '
        'NroCliDataGridViewTextBoxColumn
        '
        Me.NroCliDataGridViewTextBoxColumn.DataPropertyName = "NroCli"
        Me.NroCliDataGridViewTextBoxColumn.HeaderText = "NRO."
        Me.NroCliDataGridViewTextBoxColumn.Name = "NroCliDataGridViewTextBoxColumn"
        Me.NroCliDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroCliDataGridViewTextBoxColumn.Width = 50
        '
        'NombreCliDataGridViewTextBoxColumn
        '
        Me.NombreCliDataGridViewTextBoxColumn.DataPropertyName = "NombreCli"
        Me.NombreCliDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NombreCliDataGridViewTextBoxColumn.Name = "NombreCliDataGridViewTextBoxColumn"
        Me.NombreCliDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreCliDataGridViewTextBoxColumn.Width = 200
        '
        'TitularCliDataGridViewTextBoxColumn
        '
        Me.TitularCliDataGridViewTextBoxColumn.DataPropertyName = "TitularCli"
        Me.TitularCliDataGridViewTextBoxColumn.HeaderText = "TITULAR"
        Me.TitularCliDataGridViewTextBoxColumn.Name = "TitularCliDataGridViewTextBoxColumn"
        Me.TitularCliDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitularCliDataGridViewTextBoxColumn.Width = 200
        '
        'DomicilioCliDataGridViewTextBoxColumn
        '
        Me.DomicilioCliDataGridViewTextBoxColumn.DataPropertyName = "DomicilioCli"
        Me.DomicilioCliDataGridViewTextBoxColumn.HeaderText = "DOMICILIO"
        Me.DomicilioCliDataGridViewTextBoxColumn.Name = "DomicilioCliDataGridViewTextBoxColumn"
        Me.DomicilioCliDataGridViewTextBoxColumn.ReadOnly = True
        Me.DomicilioCliDataGridViewTextBoxColumn.Width = 150
        '
        'IdCodPosCliDataGridViewTextBoxColumn
        '
        Me.IdCodPosCliDataGridViewTextBoxColumn.DataPropertyName = "IdCodPosCli"
        Me.IdCodPosCliDataGridViewTextBoxColumn.HeaderText = "idCodPos"
        Me.IdCodPosCliDataGridViewTextBoxColumn.Name = "IdCodPosCliDataGridViewTextBoxColumn"
        Me.IdCodPosCliDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCodPosCliDataGridViewTextBoxColumn.Visible = False
        '
        'TelefCliDataGridViewTextBoxColumn
        '
        Me.TelefCliDataGridViewTextBoxColumn.DataPropertyName = "TelefCli"
        Me.TelefCliDataGridViewTextBoxColumn.HeaderText = "TELÉFONO"
        Me.TelefCliDataGridViewTextBoxColumn.Name = "TelefCliDataGridViewTextBoxColumn"
        Me.TelefCliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoIvaCliDataGridViewTextBoxColumn
        '
        Me.TipoIvaCliDataGridViewTextBoxColumn.DataPropertyName = "TipoIvaCli"
        Me.TipoIvaCliDataGridViewTextBoxColumn.HeaderText = "TIPO I.V.A."
        Me.TipoIvaCliDataGridViewTextBoxColumn.Name = "TipoIvaCliDataGridViewTextBoxColumn"
        Me.TipoIvaCliDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoIvaCliDataGridViewTextBoxColumn.Width = 150
        '
        'CuitCliDataGridViewTextBoxColumn
        '
        Me.CuitCliDataGridViewTextBoxColumn.DataPropertyName = "CuitCli"
        Me.CuitCliDataGridViewTextBoxColumn.HeaderText = "C.U.I.T"
        Me.CuitCliDataGridViewTextBoxColumn.Name = "CuitCliDataGridViewTextBoxColumn"
        Me.CuitCliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IngBrutosCliDataGridViewTextBoxColumn
        '
        Me.IngBrutosCliDataGridViewTextBoxColumn.DataPropertyName = "IngBrutosCli"
        Me.IngBrutosCliDataGridViewTextBoxColumn.HeaderText = "ING. BRUTO"
        Me.IngBrutosCliDataGridViewTextBoxColumn.Name = "IngBrutosCliDataGridViewTextBoxColumn"
        Me.IngBrutosCliDataGridViewTextBoxColumn.ReadOnly = True
        Me.IngBrutosCliDataGridViewTextBoxColumn.Visible = False
        '
        'ObsCliDataGridViewTextBoxColumn
        '
        Me.ObsCliDataGridViewTextBoxColumn.DataPropertyName = "ObsCli"
        Me.ObsCliDataGridViewTextBoxColumn.HeaderText = "OBSERV."
        Me.ObsCliDataGridViewTextBoxColumn.Name = "ObsCliDataGridViewTextBoxColumn"
        Me.ObsCliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailCli
        '
        Me.EmailCli.DataPropertyName = "EmailCli"
        Me.EmailCli.HeaderText = "EmailCli"
        Me.EmailCli.Name = "EmailCli"
        Me.EmailCli.ReadOnly = True
        Me.EmailCli.Visible = False
        '
        'frmConsClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1138, 627)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CONSULTA DEL PADRÓN DE CLIENTES"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As dbsointDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents IdCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitularCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCodPosCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoIvaCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuitCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IngBrutosCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsCliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailCli As DataGridViewTextBoxColumn
End Class
