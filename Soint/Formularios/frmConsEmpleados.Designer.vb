<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsEmpleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.IdEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCodPosEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuilEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FuncionEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.EmpleadosTableAdapter = New Soint.dbsointDataSetTableAdapters.empleadosTableAdapter()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(246, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(513, 36)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Consulta de Padrón de Empleados"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(236, 68)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(523, 23)
        Me.txtNombre.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(94, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Nombre Empleado:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(18, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1034, 41)
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
        Me.BtnSalir.Location = New System.Drawing.Point(538, 557)
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
        Me.Label2.Location = New System.Drawing.Point(16, 542)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 19)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Haga doble clic en el renglón seleccionado..."
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmpleados.AutoGenerateColumns = False
        Me.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmpleados.ColumnHeadersHeight = 40
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpDataGridViewTextBoxColumn, Me.NroEmpDataGridViewTextBoxColumn, Me.NombreEmpDataGridViewTextBoxColumn, Me.DomicilioEmpDataGridViewTextBoxColumn, Me.IdCodPosEmpDataGridViewTextBoxColumn, Me.TelefEmpDataGridViewTextBoxColumn, Me.CategoriaEmpDataGridViewTextBoxColumn, Me.CuilEmpDataGridViewTextBoxColumn, Me.FuncionEmpDataGridViewTextBoxColumn, Me.ObsEmpDataGridViewTextBoxColumn})
        Me.dgvEmpleados.DataSource = Me.EmpleadosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpleados.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmpleados.EnableHeadersVisualStyles = False
        Me.dgvEmpleados.GridColor = System.Drawing.Color.White
        Me.dgvEmpleados.Location = New System.Drawing.Point(18, 106)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEmpleados.Size = New System.Drawing.Size(1034, 433)
        Me.dgvEmpleados.TabIndex = 101
        '
        'IdEmpDataGridViewTextBoxColumn
        '
        Me.IdEmpDataGridViewTextBoxColumn.DataPropertyName = "id_Emp"
        Me.IdEmpDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdEmpDataGridViewTextBoxColumn.Name = "IdEmpDataGridViewTextBoxColumn"
        Me.IdEmpDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEmpDataGridViewTextBoxColumn.Width = 30
        '
        'NroEmpDataGridViewTextBoxColumn
        '
        Me.NroEmpDataGridViewTextBoxColumn.DataPropertyName = "NroEmp"
        Me.NroEmpDataGridViewTextBoxColumn.HeaderText = "NRO."
        Me.NroEmpDataGridViewTextBoxColumn.Name = "NroEmpDataGridViewTextBoxColumn"
        Me.NroEmpDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroEmpDataGridViewTextBoxColumn.Width = 50
        '
        'NombreEmpDataGridViewTextBoxColumn
        '
        Me.NombreEmpDataGridViewTextBoxColumn.DataPropertyName = "NombreEmp"
        Me.NombreEmpDataGridViewTextBoxColumn.HeaderText = "APELLIDO Y NOMBRES"
        Me.NombreEmpDataGridViewTextBoxColumn.Name = "NombreEmpDataGridViewTextBoxColumn"
        Me.NombreEmpDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreEmpDataGridViewTextBoxColumn.Width = 200
        '
        'DomicilioEmpDataGridViewTextBoxColumn
        '
        Me.DomicilioEmpDataGridViewTextBoxColumn.DataPropertyName = "DomicilioEmp"
        Me.DomicilioEmpDataGridViewTextBoxColumn.HeaderText = "DOMICILIO"
        Me.DomicilioEmpDataGridViewTextBoxColumn.Name = "DomicilioEmpDataGridViewTextBoxColumn"
        Me.DomicilioEmpDataGridViewTextBoxColumn.ReadOnly = True
        Me.DomicilioEmpDataGridViewTextBoxColumn.Width = 200
        '
        'IdCodPosEmpDataGridViewTextBoxColumn
        '
        Me.IdCodPosEmpDataGridViewTextBoxColumn.DataPropertyName = "IdCodPosEmp"
        Me.IdCodPosEmpDataGridViewTextBoxColumn.HeaderText = "IdCodPosEmp"
        Me.IdCodPosEmpDataGridViewTextBoxColumn.Name = "IdCodPosEmpDataGridViewTextBoxColumn"
        Me.IdCodPosEmpDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCodPosEmpDataGridViewTextBoxColumn.Visible = False
        '
        'TelefEmpDataGridViewTextBoxColumn
        '
        Me.TelefEmpDataGridViewTextBoxColumn.DataPropertyName = "TelefEmp"
        Me.TelefEmpDataGridViewTextBoxColumn.HeaderText = "TELÉFONO"
        Me.TelefEmpDataGridViewTextBoxColumn.Name = "TelefEmpDataGridViewTextBoxColumn"
        Me.TelefEmpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoriaEmpDataGridViewTextBoxColumn
        '
        Me.CategoriaEmpDataGridViewTextBoxColumn.DataPropertyName = "CategoriaEmp"
        Me.CategoriaEmpDataGridViewTextBoxColumn.HeaderText = "CATEGORÍA"
        Me.CategoriaEmpDataGridViewTextBoxColumn.Name = "CategoriaEmpDataGridViewTextBoxColumn"
        Me.CategoriaEmpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuilEmpDataGridViewTextBoxColumn
        '
        Me.CuilEmpDataGridViewTextBoxColumn.DataPropertyName = "CuilEmp"
        Me.CuilEmpDataGridViewTextBoxColumn.HeaderText = "C.U.I.L."
        Me.CuilEmpDataGridViewTextBoxColumn.Name = "CuilEmpDataGridViewTextBoxColumn"
        Me.CuilEmpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FuncionEmpDataGridViewTextBoxColumn
        '
        Me.FuncionEmpDataGridViewTextBoxColumn.DataPropertyName = "FuncionEmp"
        Me.FuncionEmpDataGridViewTextBoxColumn.HeaderText = "FUNCIÓN"
        Me.FuncionEmpDataGridViewTextBoxColumn.Name = "FuncionEmpDataGridViewTextBoxColumn"
        Me.FuncionEmpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObsEmpDataGridViewTextBoxColumn
        '
        Me.ObsEmpDataGridViewTextBoxColumn.DataPropertyName = "ObsEmp"
        Me.ObsEmpDataGridViewTextBoxColumn.HeaderText = "OBS."
        Me.ObsEmpDataGridViewTextBoxColumn.Name = "ObsEmpDataGridViewTextBoxColumn"
        Me.ObsEmpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DbsointDataSet
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(524, 550)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 69)
        Me.PictureBox2.TabIndex = 104
        Me.PictureBox2.TabStop = False
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'frmConsEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1076, 627)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CONSULTA DE PADRON DE EMPLEADOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As dbsointDataSetTableAdapters.empleadosTableAdapter
    Friend WithEvents IdEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCodPosEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuilEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FuncionEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolTipMsg As ToolTip
End Class
