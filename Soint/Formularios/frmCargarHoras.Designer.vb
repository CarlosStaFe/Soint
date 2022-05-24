<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCargarHoras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CodDebMatLabel As System.Windows.Forms.Label
        Dim ImpDebMatLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargarHoras))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreEmp = New System.Windows.Forms.TextBox()
        Me.txtNroEmp = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.dgvHoras = New System.Windows.Forms.DataGridView()
        Me.IdHJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObraHJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaHJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoHJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasHJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorHJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalHJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoHJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YyyyHJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MmHJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuinceHJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaLiqHJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsHJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasjobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.HorasjobsTableAdapter = New Soint.dbsointDataSetTableAdapters.horasjobsTableAdapter()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TableAdapterManager = New Soint.dbsointDataSetTableAdapters.TableAdapterManager()
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtId_Emp = New System.Windows.Forms.TextBox()
        Me.txtCategoriaEmp = New System.Windows.Forms.TextBox()
        Me.txtTotalHoras = New System.Windows.Forms.TextBox()
        Me.txtTotalSubtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNroObra = New System.Windows.Forms.TextBox()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CodDebMatLabel = New System.Windows.Forms.Label()
        ImpDebMatLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorasjobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodDebMatLabel
        '
        CodDebMatLabel.AutoSize = True
        CodDebMatLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodDebMatLabel.ForeColor = System.Drawing.Color.White
        CodDebMatLabel.Location = New System.Drawing.Point(158, 124)
        CodDebMatLabel.Name = "CodDebMatLabel"
        CodDebMatLabel.Size = New System.Drawing.Size(44, 17)
        CodDebMatLabel.TabIndex = 90
        CodDebMatLabel.Text = "Horas"
        '
        'ImpDebMatLabel
        '
        ImpDebMatLabel.AutoSize = True
        ImpDebMatLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImpDebMatLabel.ForeColor = System.Drawing.Color.White
        ImpDebMatLabel.Location = New System.Drawing.Point(355, 124)
        ImpDebMatLabel.Name = "ImpDebMatLabel"
        ImpDebMatLabel.Size = New System.Drawing.Size(62, 17)
        ImpDebMatLabel.TabIndex = 92
        ImpDebMatLabel.Text = "Subtotal"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(253, 124)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(59, 17)
        Label3.TabIndex = 98
        Label3.Text = "Importe"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.White
        Label4.Location = New System.Drawing.Point(65, 124)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(47, 17)
        Label4.TabIndex = 100
        Label4.Text = "Fecha"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(516, 124)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(90, 17)
        Label5.TabIndex = 111
        Label5.Text = "Observación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(210, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(456, 36)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Carga de Horas de Empleados"
        '
        'txtHoras
        '
        Me.txtHoras.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoras.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoras.ForeColor = System.Drawing.Color.White
        Me.txtHoras.Location = New System.Drawing.Point(153, 145)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(55, 23)
        Me.txtHoras.TabIndex = 8
        Me.txtHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubtotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.ForeColor = System.Drawing.Color.White
        Me.txtSubtotal.Location = New System.Drawing.Point(338, 145)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(96, 23)
        Me.txtSubtotal.TabIndex = 10
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(121, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Empleado:"
        '
        'txtNombreEmp
        '
        Me.txtNombreEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNombreEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreEmp.Enabled = False
        Me.txtNombreEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEmp.ForeColor = System.Drawing.Color.White
        Me.txtNombreEmp.Location = New System.Drawing.Point(262, 93)
        Me.txtNombreEmp.Name = "txtNombreEmp"
        Me.txtNombreEmp.Size = New System.Drawing.Size(402, 23)
        Me.txtNombreEmp.TabIndex = 4
        '
        'txtNroEmp
        '
        Me.txtNroEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroEmp.ForeColor = System.Drawing.Color.White
        Me.txtNroEmp.Location = New System.Drawing.Point(206, 93)
        Me.txtNroEmp.Name = "txtNroEmp"
        Me.txtNroEmp.Size = New System.Drawing.Size(50, 23)
        Me.txtNroEmp.TabIndex = 3
        Me.txtNroEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImporte
        '
        Me.txtImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporte.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.White
        Me.txtImporte.Location = New System.Drawing.Point(236, 145)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(96, 23)
        Me.txtImporte.TabIndex = 9
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.White
        Me.txtFecha.Location = New System.Drawing.Point(44, 145)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(87, 23)
        Me.txtFecha.TabIndex = 7
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvHoras
        '
        Me.dgvHoras.AllowUserToAddRows = False
        Me.dgvHoras.AllowUserToDeleteRows = False
        Me.dgvHoras.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvHoras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHoras.AutoGenerateColumns = False
        Me.dgvHoras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvHoras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHoras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHoras.ColumnHeadersHeight = 30
        Me.dgvHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHoras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdHJDataGridViewTextBoxColumn, Me.ObraHJ, Me.FechaHJDataGridViewTextBoxColumn, Me.EmpleadoHJDataGridViewTextBoxColumn, Me.HorasHJDataGridViewTextBoxColumn, Me.ValorHJDataGridViewTextBoxColumn, Me.SubtotalHJDataGridViewTextBoxColumn, Me.EstadoHJDataGridViewTextBoxColumn, Me.YyyyHJDataGridViewTextBoxColumn, Me.MmHJDataGridViewTextBoxColumn, Me.QuinceHJDataGridViewTextBoxColumn, Me.FechaLiqHJDataGridViewTextBoxColumn, Me.ObsHJDataGridViewTextBoxColumn})
        Me.dgvHoras.DataSource = Me.HorasjobsBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHoras.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvHoras.EnableHeadersVisualStyles = False
        Me.dgvHoras.GridColor = System.Drawing.Color.White
        Me.dgvHoras.Location = New System.Drawing.Point(35, 188)
        Me.dgvHoras.Name = "dgvHoras"
        Me.dgvHoras.ReadOnly = True
        Me.dgvHoras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHoras.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvHoras.Size = New System.Drawing.Size(773, 323)
        Me.dgvHoras.TabIndex = 17
        '
        'IdHJDataGridViewTextBoxColumn
        '
        Me.IdHJDataGridViewTextBoxColumn.DataPropertyName = "id_HJ"
        Me.IdHJDataGridViewTextBoxColumn.HeaderText = "id_HJ"
        Me.IdHJDataGridViewTextBoxColumn.Name = "IdHJDataGridViewTextBoxColumn"
        Me.IdHJDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdHJDataGridViewTextBoxColumn.Visible = False
        '
        'ObraHJ
        '
        Me.ObraHJ.DataPropertyName = "ObraHJ"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ObraHJ.DefaultCellStyle = DataGridViewCellStyle3
        Me.ObraHJ.HeaderText = "OBRA"
        Me.ObraHJ.Name = "ObraHJ"
        Me.ObraHJ.ReadOnly = True
        Me.ObraHJ.Width = 40
        '
        'FechaHJDataGridViewTextBoxColumn
        '
        Me.FechaHJDataGridViewTextBoxColumn.DataPropertyName = "FechaHJ"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.FechaHJDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechaHJDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FechaHJDataGridViewTextBoxColumn.Name = "FechaHJDataGridViewTextBoxColumn"
        Me.FechaHJDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaHJDataGridViewTextBoxColumn.Width = 80
        '
        'EmpleadoHJDataGridViewTextBoxColumn
        '
        Me.EmpleadoHJDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoHJ"
        Me.EmpleadoHJDataGridViewTextBoxColumn.HeaderText = "EmpleadoHJ"
        Me.EmpleadoHJDataGridViewTextBoxColumn.Name = "EmpleadoHJDataGridViewTextBoxColumn"
        Me.EmpleadoHJDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpleadoHJDataGridViewTextBoxColumn.Visible = False
        '
        'HorasHJDataGridViewTextBoxColumn
        '
        Me.HorasHJDataGridViewTextBoxColumn.DataPropertyName = "HorasHJ"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.HorasHJDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.HorasHJDataGridViewTextBoxColumn.HeaderText = "HORAS"
        Me.HorasHJDataGridViewTextBoxColumn.Name = "HorasHJDataGridViewTextBoxColumn"
        Me.HorasHJDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorHJDataGridViewTextBoxColumn
        '
        Me.ValorHJDataGridViewTextBoxColumn.DataPropertyName = "ValorHJ"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ValorHJDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.ValorHJDataGridViewTextBoxColumn.HeaderText = "VALOR HORA"
        Me.ValorHJDataGridViewTextBoxColumn.Name = "ValorHJDataGridViewTextBoxColumn"
        Me.ValorHJDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubtotalHJDataGridViewTextBoxColumn
        '
        Me.SubtotalHJDataGridViewTextBoxColumn.DataPropertyName = "SubtotalHJ"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.SubtotalHJDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.SubtotalHJDataGridViewTextBoxColumn.HeaderText = "SUBTOTAL"
        Me.SubtotalHJDataGridViewTextBoxColumn.Name = "SubtotalHJDataGridViewTextBoxColumn"
        Me.SubtotalHJDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoHJDataGridViewTextBoxColumn
        '
        Me.EstadoHJDataGridViewTextBoxColumn.DataPropertyName = "EstadoHJ"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.EstadoHJDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.EstadoHJDataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.EstadoHJDataGridViewTextBoxColumn.Name = "EstadoHJDataGridViewTextBoxColumn"
        Me.EstadoHJDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YyyyHJDataGridViewTextBoxColumn
        '
        Me.YyyyHJDataGridViewTextBoxColumn.DataPropertyName = "YyyyHJ"
        Me.YyyyHJDataGridViewTextBoxColumn.HeaderText = "YyyyHJ"
        Me.YyyyHJDataGridViewTextBoxColumn.Name = "YyyyHJDataGridViewTextBoxColumn"
        Me.YyyyHJDataGridViewTextBoxColumn.ReadOnly = True
        Me.YyyyHJDataGridViewTextBoxColumn.Visible = False
        '
        'MmHJDataGridViewTextBoxColumn
        '
        Me.MmHJDataGridViewTextBoxColumn.DataPropertyName = "MmHJ"
        Me.MmHJDataGridViewTextBoxColumn.HeaderText = "MmHJ"
        Me.MmHJDataGridViewTextBoxColumn.Name = "MmHJDataGridViewTextBoxColumn"
        Me.MmHJDataGridViewTextBoxColumn.ReadOnly = True
        Me.MmHJDataGridViewTextBoxColumn.Visible = False
        '
        'QuinceHJDataGridViewTextBoxColumn
        '
        Me.QuinceHJDataGridViewTextBoxColumn.DataPropertyName = "QuinceHJ"
        Me.QuinceHJDataGridViewTextBoxColumn.HeaderText = "QuinceHJ"
        Me.QuinceHJDataGridViewTextBoxColumn.Name = "QuinceHJDataGridViewTextBoxColumn"
        Me.QuinceHJDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuinceHJDataGridViewTextBoxColumn.Visible = False
        '
        'FechaLiqHJDataGridViewTextBoxColumn
        '
        Me.FechaLiqHJDataGridViewTextBoxColumn.DataPropertyName = "FechaLiqHJ"
        Me.FechaLiqHJDataGridViewTextBoxColumn.HeaderText = "FechaLiqHJ"
        Me.FechaLiqHJDataGridViewTextBoxColumn.Name = "FechaLiqHJDataGridViewTextBoxColumn"
        Me.FechaLiqHJDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaLiqHJDataGridViewTextBoxColumn.Visible = False
        '
        'ObsHJDataGridViewTextBoxColumn
        '
        Me.ObsHJDataGridViewTextBoxColumn.DataPropertyName = "ObsHJ"
        Me.ObsHJDataGridViewTextBoxColumn.HeaderText = "OBSERVACIÓN"
        Me.ObsHJDataGridViewTextBoxColumn.Name = "ObsHJDataGridViewTextBoxColumn"
        Me.ObsHJDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsHJDataGridViewTextBoxColumn.Width = 200
        '
        'HorasjobsBindingSource
        '
        Me.HorasjobsBindingSource.DataMember = "horasjobs"
        Me.HorasjobsBindingSource.DataSource = Me.DbsointDataSet
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HorasjobsTableAdapter
        '
        Me.HorasjobsTableAdapter.ClearBeforeFill = True
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
        Me.btnSalir.Location = New System.Drawing.Point(828, 427)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(119, 44)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
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
        Me.btnLimpiar.Location = New System.Drawing.Point(828, 337)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(119, 44)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = True
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
        Me.btnActualizar.Location = New System.Drawing.Point(828, 157)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(119, 44)
        Me.btnActualizar.TabIndex = 13
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizar.UseVisualStyleBackColor = True
        Me.btnActualizar.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(828, 247)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(119, 44)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = True
        Me.btnEliminar.Visible = False
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
        Me.btnAgregar.Location = New System.Drawing.Point(828, 67)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(119, 44)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = True
        Me.btnAgregar.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(819, 52)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(138, 436)
        Me.PictureBox4.TabIndex = 107
        Me.PictureBox4.TabStop = False
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
        Me.TableAdapterManager.empleadosTableAdapter = Nothing
        Me.TableAdapterManager.herramientasTableAdapter = Nothing
        Me.TableAdapterManager.horasjobsTableAdapter = Me.HorasjobsTableAdapter
        Me.TableAdapterManager.obrasTableAdapter = Nothing
        Me.TableAdapterManager.operadoresTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.subrubrosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Soint.dbsointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.ForeColor = System.Drawing.Color.White
        Me.txtObs.Location = New System.Drawing.Point(439, 145)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(351, 23)
        Me.txtObs.TabIndex = 11
        '
        'txtId_Emp
        '
        Me.txtId_Emp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_Emp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_Emp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HorasjobsBindingSource, "EmpleadoHJ", True))
        Me.txtId_Emp.Enabled = False
        Me.txtId_Emp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_Emp.ForeColor = System.Drawing.Color.White
        Me.txtId_Emp.Location = New System.Drawing.Point(669, 95)
        Me.txtId_Emp.Name = "txtId_Emp"
        Me.txtId_Emp.Size = New System.Drawing.Size(60, 16)
        Me.txtId_Emp.TabIndex = 5
        '
        'txtCategoriaEmp
        '
        Me.txtCategoriaEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCategoriaEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCategoriaEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HorasjobsBindingSource, "EmpleadoHJ", True))
        Me.txtCategoriaEmp.Enabled = False
        Me.txtCategoriaEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoriaEmp.ForeColor = System.Drawing.Color.White
        Me.txtCategoriaEmp.Location = New System.Drawing.Point(735, 95)
        Me.txtCategoriaEmp.Name = "txtCategoriaEmp"
        Me.txtCategoriaEmp.Size = New System.Drawing.Size(60, 16)
        Me.txtCategoriaEmp.TabIndex = 6
        Me.txtCategoriaEmp.Visible = False
        '
        'txtTotalHoras
        '
        Me.txtTotalHoras.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTotalHoras.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHoras.ForeColor = System.Drawing.Color.LawnGreen
        Me.txtTotalHoras.Location = New System.Drawing.Point(197, 517)
        Me.txtTotalHoras.Name = "txtTotalHoras"
        Me.txtTotalHoras.Size = New System.Drawing.Size(96, 26)
        Me.txtTotalHoras.TabIndex = 18
        Me.txtTotalHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalSubtotal
        '
        Me.txtTotalSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTotalSubtotal.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSubtotal.ForeColor = System.Drawing.Color.Yellow
        Me.txtTotalSubtotal.Location = New System.Drawing.Point(403, 517)
        Me.txtTotalSubtotal.Name = "txtTotalSubtotal"
        Me.txtTotalSubtotal.Size = New System.Drawing.Size(96, 26)
        Me.txtTotalSubtotal.TabIndex = 19
        Me.txtTotalSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(39, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Obra:"
        '
        'txtNroObra
        '
        Me.txtNroObra.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroObra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroObra.ForeColor = System.Drawing.Color.White
        Me.txtNroObra.Location = New System.Drawing.Point(90, 64)
        Me.txtNroObra.Name = "txtNroObra"
        Me.txtNroObra.Size = New System.Drawing.Size(50, 23)
        Me.txtNroObra.TabIndex = 0
        Me.txtNroObra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTitular
        '
        Me.txtTitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTitular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitular.Enabled = False
        Me.txtTitular.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitular.ForeColor = System.Drawing.Color.White
        Me.txtTitular.Location = New System.Drawing.Point(146, 64)
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(342, 23)
        Me.txtTitular.TabIndex = 1
        '
        'txtLugar
        '
        Me.txtLugar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtLugar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLugar.Enabled = False
        Me.txtLugar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugar.ForeColor = System.Drawing.Color.White
        Me.txtLugar.Location = New System.Drawing.Point(494, 64)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(296, 23)
        Me.txtLugar.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(299, 519)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 19)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Hs."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(380, 519)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 19)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "$"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(31, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(782, 129)
        Me.PictureBox1.TabIndex = 119
        Me.PictureBox1.TabStop = False
        '
        'frmCargarHoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1048, 595)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtLugar)
        Me.Controls.Add(Me.txtTitular)
        Me.Controls.Add(Me.txtNroObra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalSubtotal)
        Me.Controls.Add(Me.txtTotalHoras)
        Me.Controls.Add(Me.txtCategoriaEmp)
        Me.Controls.Add(Me.txtId_Emp)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.dgvHoras)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(CodDebMatLabel)
        Me.Controls.Add(Me.txtHoras)
        Me.Controls.Add(ImpDebMatLabel)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombreEmp)
        Me.Controls.Add(Me.txtNroEmp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCargarHoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARGA DE HORAS DE EMPLEADOS"
        CType(Me.dgvHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorasjobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtHoras As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreEmp As TextBox
    Friend WithEvents txtNroEmp As TextBox
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents dgvHoras As DataGridView
    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents HorasjobsBindingSource As BindingSource
    Friend WithEvents HorasjobsTableAdapter As dbsointDataSetTableAdapters.horasjobsTableAdapter
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TableAdapterManager As dbsointDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents txtObs As TextBox
    Friend WithEvents txtId_Emp As TextBox
    Friend WithEvents txtCategoriaEmp As TextBox
    Friend WithEvents txtTotalHoras As TextBox
    Friend WithEvents txtTotalSubtotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNroObra As TextBox
    Friend WithEvents txtTitular As TextBox
    Friend WithEvents txtLugar As TextBox
    Friend WithEvents IdHJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObraHJ As DataGridViewTextBoxColumn
    Friend WithEvents FechaHJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoHJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorasHJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorHJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalHJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoHJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YyyyHJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MmHJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuinceHJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaLiqHJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsHJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
