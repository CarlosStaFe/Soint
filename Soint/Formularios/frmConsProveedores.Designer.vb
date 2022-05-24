<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsProveedores))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvProveedores = New System.Windows.Forms.DataGridView()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ProveedoresTableAdapter = New Soint.dbsointDataSetTableAdapters.proveedoresTableAdapter()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.IdProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitularProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCodPosProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoIvaProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngBrutosProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsProvDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailProv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(440, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(374, 36)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Consulta de Proveedores"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(238, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(523, 23)
        Me.txtNombre.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(96, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Nombre Proveedor:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(20, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1102, 41)
        Me.PictureBox1.TabIndex = 100
        Me.PictureBox1.TabStop = False
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
        Me.BtnSalir.Location = New System.Drawing.Point(540, 549)
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
        Me.Label2.Location = New System.Drawing.Point(18, 534)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 19)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Haga doble clic en el renglón seleccionado..."
        '
        'dgvProveedores
        '
        Me.dgvProveedores.AllowUserToAddRows = False
        Me.dgvProveedores.AllowUserToDeleteRows = False
        Me.dgvProveedores.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProveedores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProveedores.AutoGenerateColumns = False
        Me.dgvProveedores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProveedores.ColumnHeadersHeight = 40
        Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProvDataGridViewTextBoxColumn, Me.NroProvDataGridViewTextBoxColumn, Me.RazonSocialProvDataGridViewTextBoxColumn, Me.TitularProvDataGridViewTextBoxColumn, Me.DomicilioProvDataGridViewTextBoxColumn, Me.IdCodPosProvDataGridViewTextBoxColumn, Me.TipoIvaProvDataGridViewTextBoxColumn, Me.CuitProvDataGridViewTextBoxColumn, Me.TelefProvDataGridViewTextBoxColumn, Me.IngBrutosProvDataGridViewTextBoxColumn, Me.SaldoProvDataGridViewTextBoxColumn, Me.ObsProvDataGridViewTextBoxColumn, Me.EmailProv})
        Me.dgvProveedores.DataSource = Me.ProveedoresBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProveedores.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProveedores.EnableHeadersVisualStyles = False
        Me.dgvProveedores.GridColor = System.Drawing.Color.White
        Me.dgvProveedores.Location = New System.Drawing.Point(20, 98)
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.ReadOnly = True
        Me.dgvProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProveedores.Size = New System.Drawing.Size(1102, 433)
        Me.dgvProveedores.TabIndex = 101
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DbsointDataSet
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(526, 542)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 69)
        Me.PictureBox2.TabIndex = 104
        Me.PictureBox2.TabStop = False
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'IdProvDataGridViewTextBoxColumn
        '
        Me.IdProvDataGridViewTextBoxColumn.DataPropertyName = "id_Prov"
        Me.IdProvDataGridViewTextBoxColumn.HeaderText = "id_Prov"
        Me.IdProvDataGridViewTextBoxColumn.Name = "IdProvDataGridViewTextBoxColumn"
        Me.IdProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProvDataGridViewTextBoxColumn.Visible = False
        '
        'NroProvDataGridViewTextBoxColumn
        '
        Me.NroProvDataGridViewTextBoxColumn.DataPropertyName = "NroProv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NroProvDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.NroProvDataGridViewTextBoxColumn.HeaderText = "NRO."
        Me.NroProvDataGridViewTextBoxColumn.Name = "NroProvDataGridViewTextBoxColumn"
        Me.NroProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroProvDataGridViewTextBoxColumn.Width = 50
        '
        'RazonSocialProvDataGridViewTextBoxColumn
        '
        Me.RazonSocialProvDataGridViewTextBoxColumn.DataPropertyName = "RazonSocialProv"
        Me.RazonSocialProvDataGridViewTextBoxColumn.HeaderText = "RAZÓN SOCIAL"
        Me.RazonSocialProvDataGridViewTextBoxColumn.Name = "RazonSocialProvDataGridViewTextBoxColumn"
        Me.RazonSocialProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.RazonSocialProvDataGridViewTextBoxColumn.Width = 180
        '
        'TitularProvDataGridViewTextBoxColumn
        '
        Me.TitularProvDataGridViewTextBoxColumn.DataPropertyName = "TitularProv"
        Me.TitularProvDataGridViewTextBoxColumn.HeaderText = "TITULAR"
        Me.TitularProvDataGridViewTextBoxColumn.Name = "TitularProvDataGridViewTextBoxColumn"
        Me.TitularProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitularProvDataGridViewTextBoxColumn.Width = 180
        '
        'DomicilioProvDataGridViewTextBoxColumn
        '
        Me.DomicilioProvDataGridViewTextBoxColumn.DataPropertyName = "DomicilioProv"
        Me.DomicilioProvDataGridViewTextBoxColumn.HeaderText = "DOMICILIO"
        Me.DomicilioProvDataGridViewTextBoxColumn.Name = "DomicilioProvDataGridViewTextBoxColumn"
        Me.DomicilioProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.DomicilioProvDataGridViewTextBoxColumn.Width = 180
        '
        'IdCodPosProvDataGridViewTextBoxColumn
        '
        Me.IdCodPosProvDataGridViewTextBoxColumn.DataPropertyName = "IdCodPosProv"
        Me.IdCodPosProvDataGridViewTextBoxColumn.HeaderText = "IdCodPosProv"
        Me.IdCodPosProvDataGridViewTextBoxColumn.Name = "IdCodPosProvDataGridViewTextBoxColumn"
        Me.IdCodPosProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCodPosProvDataGridViewTextBoxColumn.Visible = False
        '
        'TipoIvaProvDataGridViewTextBoxColumn
        '
        Me.TipoIvaProvDataGridViewTextBoxColumn.DataPropertyName = "TipoIvaProv"
        Me.TipoIvaProvDataGridViewTextBoxColumn.HeaderText = "TIPO I.V.A."
        Me.TipoIvaProvDataGridViewTextBoxColumn.Name = "TipoIvaProvDataGridViewTextBoxColumn"
        Me.TipoIvaProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoIvaProvDataGridViewTextBoxColumn.Width = 140
        '
        'CuitProvDataGridViewTextBoxColumn
        '
        Me.CuitProvDataGridViewTextBoxColumn.DataPropertyName = "CuitProv"
        Me.CuitProvDataGridViewTextBoxColumn.HeaderText = "C.U.I.T."
        Me.CuitProvDataGridViewTextBoxColumn.Name = "CuitProvDataGridViewTextBoxColumn"
        Me.CuitProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuitProvDataGridViewTextBoxColumn.Width = 80
        '
        'TelefProvDataGridViewTextBoxColumn
        '
        Me.TelefProvDataGridViewTextBoxColumn.DataPropertyName = "TelefProv"
        Me.TelefProvDataGridViewTextBoxColumn.HeaderText = "TELÉFONO"
        Me.TelefProvDataGridViewTextBoxColumn.Name = "TelefProvDataGridViewTextBoxColumn"
        Me.TelefProvDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IngBrutosProvDataGridViewTextBoxColumn
        '
        Me.IngBrutosProvDataGridViewTextBoxColumn.DataPropertyName = "IngBrutosProv"
        Me.IngBrutosProvDataGridViewTextBoxColumn.HeaderText = "IngBrutosProv"
        Me.IngBrutosProvDataGridViewTextBoxColumn.Name = "IngBrutosProvDataGridViewTextBoxColumn"
        Me.IngBrutosProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.IngBrutosProvDataGridViewTextBoxColumn.Visible = False
        '
        'SaldoProvDataGridViewTextBoxColumn
        '
        Me.SaldoProvDataGridViewTextBoxColumn.DataPropertyName = "SaldoProv"
        Me.SaldoProvDataGridViewTextBoxColumn.HeaderText = "SaldoProv"
        Me.SaldoProvDataGridViewTextBoxColumn.Name = "SaldoProvDataGridViewTextBoxColumn"
        Me.SaldoProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoProvDataGridViewTextBoxColumn.Visible = False
        '
        'ObsProvDataGridViewTextBoxColumn
        '
        Me.ObsProvDataGridViewTextBoxColumn.DataPropertyName = "ObsProv"
        Me.ObsProvDataGridViewTextBoxColumn.HeaderText = "OBSERVACIÓN"
        Me.ObsProvDataGridViewTextBoxColumn.Name = "ObsProvDataGridViewTextBoxColumn"
        Me.ObsProvDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsProvDataGridViewTextBoxColumn.Width = 130
        '
        'EmailProv
        '
        Me.EmailProv.DataPropertyName = "EmailProv"
        Me.EmailProv.HeaderText = "EmailProv"
        Me.EmailProv.Name = "EmailProv"
        Me.EmailProv.ReadOnly = True
        Me.EmailProv.Visible = False
        '
        'frmConsProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1243, 631)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvProveedores)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE PROVEEDORES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvProveedores As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As dbsointDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents IdProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitularProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCodPosProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoIvaProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuitProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IngBrutosProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsProvDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailProv As DataGridViewTextBoxColumn
End Class
