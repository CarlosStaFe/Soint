﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProveedores
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
        Dim NroProvLabel As System.Windows.Forms.Label
        Dim RazonSocialProvLabel As System.Windows.Forms.Label
        Dim TitularProvLabel As System.Windows.Forms.Label
        Dim DomicilioProvLabel As System.Windows.Forms.Label
        Dim IdCodPosProvLabel As System.Windows.Forms.Label
        Dim TipoIvaProvLabel As System.Windows.Forms.Label
        Dim CuitProvLabel As System.Windows.Forms.Label
        Dim TelefProvLabel As System.Windows.Forms.Label
        Dim IngBrutosProvLabel As System.Windows.Forms.Label
        Dim ObsProvLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.ToolTipMsg = New System.Windows.Forms.ToolTip(Me.components)
        Me.DbsointDataSet = New Soint.dbsointDataSet()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New Soint.dbsointDataSetTableAdapters.proveedoresTableAdapter()
        Me.TableAdapterManager = New Soint.dbsointDataSetTableAdapters.TableAdapterManager()
        Me.ProveedoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProveedoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtId_Prov = New System.Windows.Forms.TextBox()
        Me.txtNroProv = New System.Windows.Forms.TextBox()
        Me.txtRazonSocialProv = New System.Windows.Forms.TextBox()
        Me.txtTitularProv = New System.Windows.Forms.TextBox()
        Me.txtDomicilioProv = New System.Windows.Forms.TextBox()
        Me.txtIdCodPosProv = New System.Windows.Forms.TextBox()
        Me.txtCuitProv = New System.Windows.Forms.TextBox()
        Me.txtTelefProv = New System.Windows.Forms.TextBox()
        Me.txtIngBrutosProv = New System.Windows.Forms.TextBox()
        Me.txtObsProv = New System.Windows.Forms.TextBox()
        Me.cmbTipoIvaProv = New System.Windows.Forms.ComboBox()
        Me.txtCodPos = New System.Windows.Forms.TextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtEmailProv = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        NroProvLabel = New System.Windows.Forms.Label()
        RazonSocialProvLabel = New System.Windows.Forms.Label()
        TitularProvLabel = New System.Windows.Forms.Label()
        DomicilioProvLabel = New System.Windows.Forms.Label()
        IdCodPosProvLabel = New System.Windows.Forms.Label()
        TipoIvaProvLabel = New System.Windows.Forms.Label()
        CuitProvLabel = New System.Windows.Forms.Label()
        TelefProvLabel = New System.Windows.Forms.Label()
        IngBrutosProvLabel = New System.Windows.Forms.Label()
        ObsProvLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProveedoresBindingNavigator.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NroProvLabel
        '
        NroProvLabel.AutoSize = True
        NroProvLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NroProvLabel.Location = New System.Drawing.Point(89, 65)
        NroProvLabel.Name = "NroProvLabel"
        NroProvLabel.Size = New System.Drawing.Size(64, 17)
        NroProvLabel.TabIndex = 161
        NroProvLabel.Text = "Número:"
        '
        'RazonSocialProvLabel
        '
        RazonSocialProvLabel.AutoSize = True
        RazonSocialProvLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RazonSocialProvLabel.Location = New System.Drawing.Point(59, 94)
        RazonSocialProvLabel.Name = "RazonSocialProvLabel"
        RazonSocialProvLabel.Size = New System.Drawing.Size(94, 17)
        RazonSocialProvLabel.TabIndex = 163
        RazonSocialProvLabel.Text = "Razón Social:"
        '
        'TitularProvLabel
        '
        TitularProvLabel.AutoSize = True
        TitularProvLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitularProvLabel.Location = New System.Drawing.Point(489, 94)
        TitularProvLabel.Name = "TitularProvLabel"
        TitularProvLabel.Size = New System.Drawing.Size(49, 17)
        TitularProvLabel.TabIndex = 165
        TitularProvLabel.Text = "Titular:"
        '
        'DomicilioProvLabel
        '
        DomicilioProvLabel.AutoSize = True
        DomicilioProvLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DomicilioProvLabel.Location = New System.Drawing.Point(80, 123)
        DomicilioProvLabel.Name = "DomicilioProvLabel"
        DomicilioProvLabel.Size = New System.Drawing.Size(73, 17)
        DomicilioProvLabel.TabIndex = 167
        DomicilioProvLabel.Text = "Domicilio:"
        '
        'IdCodPosProvLabel
        '
        IdCodPosProvLabel.AutoSize = True
        IdCodPosProvLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdCodPosProvLabel.Location = New System.Drawing.Point(48, 152)
        IdCodPosProvLabel.Name = "IdCodPosProvLabel"
        IdCodPosProvLabel.Size = New System.Drawing.Size(105, 17)
        IdCodPosProvLabel.TabIndex = 169
        IdCodPosProvLabel.Text = "Código Postal:"
        '
        'TipoIvaProvLabel
        '
        TipoIvaProvLabel.AutoSize = True
        TipoIvaProvLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoIvaProvLabel.Location = New System.Drawing.Point(527, 181)
        TipoIvaProvLabel.Name = "TipoIvaProvLabel"
        TipoIvaProvLabel.Size = New System.Drawing.Size(75, 17)
        TipoIvaProvLabel.TabIndex = 171
        TipoIvaProvLabel.Text = "Tipo I.V.A.:"
        '
        'CuitProvLabel
        '
        CuitProvLabel.AutoSize = True
        CuitProvLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CuitProvLabel.Location = New System.Drawing.Point(98, 210)
        CuitProvLabel.Name = "CuitProvLabel"
        CuitProvLabel.Size = New System.Drawing.Size(55, 17)
        CuitProvLabel.TabIndex = 173
        CuitProvLabel.Text = "C.U.I.T.:"
        '
        'TelefProvLabel
        '
        TelefProvLabel.AutoSize = True
        TelefProvLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefProvLabel.Location = New System.Drawing.Point(87, 181)
        TelefProvLabel.Name = "TelefProvLabel"
        TelefProvLabel.Size = New System.Drawing.Size(66, 17)
        TelefProvLabel.TabIndex = 175
        TelefProvLabel.Text = "Teléfono:"
        '
        'IngBrutosProvLabel
        '
        IngBrutosProvLabel.AutoSize = True
        IngBrutosProvLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IngBrutosProvLabel.Location = New System.Drawing.Point(75, 239)
        IngBrutosProvLabel.Name = "IngBrutosProvLabel"
        IngBrutosProvLabel.Size = New System.Drawing.Size(78, 17)
        IngBrutosProvLabel.TabIndex = 177
        IngBrutosProvLabel.Text = "Ing. Brutos:"
        '
        'ObsProvLabel
        '
        ObsProvLabel.AutoSize = True
        ObsProvLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsProvLabel.Location = New System.Drawing.Point(59, 294)
        ObsProvLabel.Name = "ObsProvLabel"
        ObsProvLabel.Size = New System.Drawing.Size(94, 17)
        ObsProvLabel.TabIndex = 181
        ObsProvLabel.Text = "Observación:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(102, 266)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 17)
        Label2.TabIndex = 183
        Label2.Text = "E-mail:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(259, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 36)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Actualización de Proveedores"
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
        Me.BtnUltimo.Location = New System.Drawing.Point(746, 349)
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
        Me.BtnPrimer.Location = New System.Drawing.Point(611, 349)
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
        Me.BtnSiguiente.Location = New System.Drawing.Point(701, 349)
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
        Me.BtnAnterior.Location = New System.Drawing.Point(656, 349)
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
        Me.BtnActualizar.Location = New System.Drawing.Point(471, 341)
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
        Me.BtnGrabar.Location = New System.Drawing.Point(120, 341)
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
        Me.BtnSalir.Location = New System.Drawing.Point(822, 341)
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
        Me.BtnModificar.Location = New System.Drawing.Point(203, 341)
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
        Me.BtnEliminar.Location = New System.Drawing.Point(299, 341)
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
        Me.BtnBuscar.Location = New System.Drawing.Point(391, 341)
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
        Me.BtnAgregar.Location = New System.Drawing.Point(37, 341)
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
        Me.PictureBox1.Location = New System.Drawing.Point(19, 333)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(563, 73)
        Me.PictureBox1.TabIndex = 156
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(588, 333)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 73)
        Me.PictureBox2.TabIndex = 157
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(816, 333)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(99, 73)
        Me.PictureBox3.TabIndex = 158
        Me.PictureBox3.TabStop = False
        '
        'ToolTipMsg
        '
        Me.ToolTipMsg.IsBalloon = True
        '
        'DbsointDataSet
        '
        Me.DbsointDataSet.DataSetName = "dbsointDataSet"
        Me.DbsointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DbsointDataSet
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.gruposobrasTableAdapter = Nothing
        Me.TableAdapterManager.gruposTableAdapter = Nothing
        Me.TableAdapterManager.herramientasTableAdapter = Nothing
        Me.TableAdapterManager.horasjobsTableAdapter = Nothing
        Me.TableAdapterManager.obrasTableAdapter = Nothing
        Me.TableAdapterManager.operadoresTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.rubrosTableAdapter = Nothing
        Me.TableAdapterManager.subrubrosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Soint.dbsointDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'ProveedoresBindingNavigator
        '
        Me.ProveedoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProveedoresBindingNavigator.BindingSource = Me.ProveedoresBindingSource
        Me.ProveedoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProveedoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProveedoresBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProveedoresBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ProveedoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProveedoresBindingNavigatorSaveItem})
        Me.ProveedoresBindingNavigator.Location = New System.Drawing.Point(0, 421)
        Me.ProveedoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProveedoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProveedoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProveedoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProveedoresBindingNavigator.Name = "ProveedoresBindingNavigator"
        Me.ProveedoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProveedoresBindingNavigator.Size = New System.Drawing.Size(948, 25)
        Me.ProveedoresBindingNavigator.TabIndex = 159
        Me.ProveedoresBindingNavigator.Text = "BindingNavigator1"
        Me.ProveedoresBindingNavigator.Visible = False
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
        'ProveedoresBindingNavigatorSaveItem
        '
        Me.ProveedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProveedoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProveedoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProveedoresBindingNavigatorSaveItem.Name = "ProveedoresBindingNavigatorSaveItem"
        Me.ProveedoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProveedoresBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'txtId_Prov
        '
        Me.txtId_Prov.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtId_Prov.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId_Prov.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "id_Prov", True))
        Me.txtId_Prov.Enabled = False
        Me.txtId_Prov.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId_Prov.ForeColor = System.Drawing.Color.White
        Me.txtId_Prov.Location = New System.Drawing.Point(215, 65)
        Me.txtId_Prov.Name = "txtId_Prov"
        Me.txtId_Prov.Size = New System.Drawing.Size(47, 16)
        Me.txtId_Prov.TabIndex = 1
        '
        'txtNroProv
        '
        Me.txtNroProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNroProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "NroProv", True))
        Me.txtNroProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroProv.ForeColor = System.Drawing.Color.White
        Me.txtNroProv.Location = New System.Drawing.Point(159, 63)
        Me.txtNroProv.Name = "txtNroProv"
        Me.txtNroProv.Size = New System.Drawing.Size(50, 23)
        Me.txtNroProv.TabIndex = 0
        '
        'txtRazonSocialProv
        '
        Me.txtRazonSocialProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRazonSocialProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazonSocialProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonSocialProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "RazonSocialProv", True))
        Me.txtRazonSocialProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocialProv.ForeColor = System.Drawing.Color.White
        Me.txtRazonSocialProv.Location = New System.Drawing.Point(159, 92)
        Me.txtRazonSocialProv.Name = "txtRazonSocialProv"
        Me.txtRazonSocialProv.Size = New System.Drawing.Size(323, 23)
        Me.txtRazonSocialProv.TabIndex = 2
        '
        'txtTitularProv
        '
        Me.txtTitularProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTitularProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitularProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTitularProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "TitularProv", True))
        Me.txtTitularProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitularProv.ForeColor = System.Drawing.Color.White
        Me.txtTitularProv.Location = New System.Drawing.Point(544, 92)
        Me.txtTitularProv.Name = "txtTitularProv"
        Me.txtTitularProv.Size = New System.Drawing.Size(323, 23)
        Me.txtTitularProv.TabIndex = 3
        '
        'txtDomicilioProv
        '
        Me.txtDomicilioProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDomicilioProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDomicilioProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilioProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "DomicilioProv", True))
        Me.txtDomicilioProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilioProv.ForeColor = System.Drawing.Color.White
        Me.txtDomicilioProv.Location = New System.Drawing.Point(159, 121)
        Me.txtDomicilioProv.Name = "txtDomicilioProv"
        Me.txtDomicilioProv.Size = New System.Drawing.Size(498, 23)
        Me.txtDomicilioProv.TabIndex = 4
        '
        'txtIdCodPosProv
        '
        Me.txtIdCodPosProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIdCodPosProv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdCodPosProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "IdCodPosProv", True))
        Me.txtIdCodPosProv.Enabled = False
        Me.txtIdCodPosProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCodPosProv.ForeColor = System.Drawing.Color.White
        Me.txtIdCodPosProv.Location = New System.Drawing.Point(792, 153)
        Me.txtIdCodPosProv.Name = "txtIdCodPosProv"
        Me.txtIdCodPosProv.Size = New System.Drawing.Size(75, 16)
        Me.txtIdCodPosProv.TabIndex = 8
        '
        'txtCuitProv
        '
        Me.txtCuitProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCuitProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuitProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "CuitProv", True))
        Me.txtCuitProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuitProv.ForeColor = System.Drawing.Color.White
        Me.txtCuitProv.Location = New System.Drawing.Point(159, 208)
        Me.txtCuitProv.Name = "txtCuitProv"
        Me.txtCuitProv.Size = New System.Drawing.Size(206, 23)
        Me.txtCuitProv.TabIndex = 11
        '
        'txtTelefProv
        '
        Me.txtTelefProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTelefProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "TelefProv", True))
        Me.txtTelefProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefProv.ForeColor = System.Drawing.Color.White
        Me.txtTelefProv.Location = New System.Drawing.Point(159, 179)
        Me.txtTelefProv.Name = "txtTelefProv"
        Me.txtTelefProv.Size = New System.Drawing.Size(315, 23)
        Me.txtTelefProv.TabIndex = 9
        '
        'txtIngBrutosProv
        '
        Me.txtIngBrutosProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtIngBrutosProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIngBrutosProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "IngBrutosProv", True))
        Me.txtIngBrutosProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngBrutosProv.ForeColor = System.Drawing.Color.White
        Me.txtIngBrutosProv.Location = New System.Drawing.Point(159, 237)
        Me.txtIngBrutosProv.Name = "txtIngBrutosProv"
        Me.txtIngBrutosProv.Size = New System.Drawing.Size(206, 23)
        Me.txtIngBrutosProv.TabIndex = 12
        '
        'txtObsProv
        '
        Me.txtObsProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtObsProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "ObsProv", True))
        Me.txtObsProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsProv.ForeColor = System.Drawing.Color.White
        Me.txtObsProv.Location = New System.Drawing.Point(159, 292)
        Me.txtObsProv.Name = "txtObsProv"
        Me.txtObsProv.Size = New System.Drawing.Size(708, 23)
        Me.txtObsProv.TabIndex = 14
        '
        'cmbTipoIvaProv
        '
        Me.cmbTipoIvaProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbTipoIvaProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "TipoIvaProv", True))
        Me.cmbTipoIvaProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTipoIvaProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoIvaProv.ForeColor = System.Drawing.Color.White
        Me.cmbTipoIvaProv.FormattingEnabled = True
        Me.cmbTipoIvaProv.Location = New System.Drawing.Point(608, 175)
        Me.cmbTipoIvaProv.Name = "cmbTipoIvaProv"
        Me.cmbTipoIvaProv.Size = New System.Drawing.Size(259, 25)
        Me.cmbTipoIvaProv.TabIndex = 10
        '
        'txtCodPos
        '
        Me.txtCodPos.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCodPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPos.ForeColor = System.Drawing.Color.White
        Me.txtCodPos.Location = New System.Drawing.Point(159, 150)
        Me.txtCodPos.Name = "txtCodPos"
        Me.txtCodPos.Size = New System.Drawing.Size(50, 23)
        Me.txtCodPos.TabIndex = 5
        '
        'txtLocalidad
        '
        Me.txtLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalidad.Enabled = False
        Me.txtLocalidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.ForeColor = System.Drawing.Color.White
        Me.txtLocalidad.Location = New System.Drawing.Point(216, 150)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(258, 23)
        Me.txtLocalidad.TabIndex = 6
        '
        'txtProvincia
        '
        Me.txtProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvincia.Enabled = False
        Me.txtProvincia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvincia.ForeColor = System.Drawing.Color.White
        Me.txtProvincia.Location = New System.Drawing.Point(481, 150)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(252, 23)
        Me.txtProvincia.TabIndex = 7
        '
        'txtEmailProv
        '
        Me.txtEmailProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtEmailProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailProv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "EmailProv", True))
        Me.txtEmailProv.ForeColor = System.Drawing.Color.White
        Me.txtEmailProv.Location = New System.Drawing.Point(159, 266)
        Me.txtEmailProv.Name = "txtEmailProv"
        Me.txtEmailProv.Size = New System.Drawing.Size(708, 20)
        Me.txtEmailProv.TabIndex = 13
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(18, 51)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(896, 275)
        Me.PictureBox4.TabIndex = 184
        Me.PictureBox4.TabStop = False
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(948, 446)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtEmailProv)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.txtCodPos)
        Me.Controls.Add(Me.cmbTipoIvaProv)
        Me.Controls.Add(Me.txtId_Prov)
        Me.Controls.Add(NroProvLabel)
        Me.Controls.Add(Me.txtNroProv)
        Me.Controls.Add(RazonSocialProvLabel)
        Me.Controls.Add(Me.txtRazonSocialProv)
        Me.Controls.Add(TitularProvLabel)
        Me.Controls.Add(Me.txtTitularProv)
        Me.Controls.Add(DomicilioProvLabel)
        Me.Controls.Add(Me.txtDomicilioProv)
        Me.Controls.Add(IdCodPosProvLabel)
        Me.Controls.Add(Me.txtIdCodPosProv)
        Me.Controls.Add(TipoIvaProvLabel)
        Me.Controls.Add(CuitProvLabel)
        Me.Controls.Add(Me.txtCuitProv)
        Me.Controls.Add(TelefProvLabel)
        Me.Controls.Add(Me.txtTelefProv)
        Me.Controls.Add(IngBrutosProvLabel)
        Me.Controls.Add(Me.txtIngBrutosProv)
        Me.Controls.Add(ObsProvLabel)
        Me.Controls.Add(Me.txtObsProv)
        Me.Controls.Add(Me.ProveedoresBindingNavigator)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZACIÓN DE PROVEEDORES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsointDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProveedoresBindingNavigator.ResumeLayout(False)
        Me.ProveedoresBindingNavigator.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
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
    Friend WithEvents ToolTipMsg As ToolTip
    Friend WithEvents DbsointDataSet As dbsointDataSet
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As dbsointDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents TableAdapterManager As dbsointDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresBindingNavigator As BindingNavigator
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
    Friend WithEvents ProveedoresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtId_Prov As TextBox
    Friend WithEvents txtNroProv As TextBox
    Friend WithEvents txtRazonSocialProv As TextBox
    Friend WithEvents txtTitularProv As TextBox
    Friend WithEvents txtDomicilioProv As TextBox
    Friend WithEvents txtIdCodPosProv As TextBox
    Friend WithEvents txtCuitProv As TextBox
    Friend WithEvents txtTelefProv As TextBox
    Friend WithEvents txtIngBrutosProv As TextBox
    Friend WithEvents txtObsProv As TextBox
    Friend WithEvents cmbTipoIvaProv As ComboBox
    Friend WithEvents txtCodPos As TextBox
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtEmailProv As TextBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
