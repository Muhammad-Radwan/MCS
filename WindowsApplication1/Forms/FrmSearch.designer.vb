<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSearch))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsbhDataSet8BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MostafeedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLINICSQLhDataSet = New MCS.CLINICSQLhDataSet()
        Me.MainBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainTableAdapter = New MCS.CLINICSQLhDataSetTableAdapters.mainTableAdapter()
        Me.FnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HusbendDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.MainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsbhDataSet8BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostafeedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLINICSQLhDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox9)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(15, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 380)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(299, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(37, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "0"
        Me.Label1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(827, 271)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "نتيجة البحث"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FnumberDataGridViewTextBoxColumn, Me.NamexDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.SEXDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.HusbendDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.IdcardDataGridViewTextBoxColumn, Me.DatexDataGridViewTextBoxColumn, Me.CITYDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MainBindingSource1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 50
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(821, 240)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.Controls.Add(Me.ComboBox1)
        Me.GroupBox9.Location = New System.Drawing.Point(388, 21)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(442, 66)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "اسم المريض"
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(3, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(436, 32)
        Me.ComboBox1.TabIndex = 0
        '
        'MainBindingSource
        '
        Me.MainBindingSource.DataMember = "main"
        Me.MainBindingSource.DataSource = Me.DbsbhDataSet8BindingSource
        '
        'MostafeedBindingSource
        '
        Me.MostafeedBindingSource.DataMember = "Mostafeed"
        Me.MostafeedBindingSource.DataSource = Me.DbsbhDataSet8BindingSource
        '
        'CLINICSQLhDataSet
        '
        Me.CLINICSQLhDataSet.DataSetName = "CLINICSQLhDataSet"
        Me.CLINICSQLhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainBindingSource1
        '
        Me.MainBindingSource1.DataMember = "main"
        Me.MainBindingSource1.DataSource = Me.CLINICSQLhDataSet
        '
        'MainTableAdapter
        '
        Me.MainTableAdapter.ClearBeforeFill = True
        '
        'FnumberDataGridViewTextBoxColumn
        '
        Me.FnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FnumberDataGridViewTextBoxColumn.DataPropertyName = "fnumber"
        Me.FnumberDataGridViewTextBoxColumn.HeaderText = "رقم الملف"
        Me.FnumberDataGridViewTextBoxColumn.Name = "FnumberDataGridViewTextBoxColumn"
        Me.FnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamexDataGridViewTextBoxColumn
        '
        Me.NamexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamexDataGridViewTextBoxColumn.DataPropertyName = "namex"
        Me.NamexDataGridViewTextBoxColumn.HeaderText = "اسم المريض"
        Me.NamexDataGridViewTextBoxColumn.Name = "NamexDataGridViewTextBoxColumn"
        Me.NamexDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AgeDataGridViewTextBoxColumn.Visible = False
        '
        'SEXDataGridViewTextBoxColumn
        '
        Me.SEXDataGridViewTextBoxColumn.DataPropertyName = "SEX"
        Me.SEXDataGridViewTextBoxColumn.HeaderText = "SEX"
        Me.SEXDataGridViewTextBoxColumn.Name = "SEXDataGridViewTextBoxColumn"
        Me.SEXDataGridViewTextBoxColumn.ReadOnly = True
        Me.SEXDataGridViewTextBoxColumn.Visible = False
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Visible = False
        '
        'HusbendDataGridViewTextBoxColumn
        '
        Me.HusbendDataGridViewTextBoxColumn.DataPropertyName = "husbend"
        Me.HusbendDataGridViewTextBoxColumn.HeaderText = "husbend"
        Me.HusbendDataGridViewTextBoxColumn.Name = "HusbendDataGridViewTextBoxColumn"
        Me.HusbendDataGridViewTextBoxColumn.ReadOnly = True
        Me.HusbendDataGridViewTextBoxColumn.Visible = False
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhoneDataGridViewTextBoxColumn.Visible = False
        '
        'IdcardDataGridViewTextBoxColumn
        '
        Me.IdcardDataGridViewTextBoxColumn.DataPropertyName = "idcard"
        Me.IdcardDataGridViewTextBoxColumn.HeaderText = "idcard"
        Me.IdcardDataGridViewTextBoxColumn.Name = "IdcardDataGridViewTextBoxColumn"
        Me.IdcardDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdcardDataGridViewTextBoxColumn.Visible = False
        '
        'DatexDataGridViewTextBoxColumn
        '
        Me.DatexDataGridViewTextBoxColumn.DataPropertyName = "datex"
        Me.DatexDataGridViewTextBoxColumn.HeaderText = "datex"
        Me.DatexDataGridViewTextBoxColumn.Name = "DatexDataGridViewTextBoxColumn"
        Me.DatexDataGridViewTextBoxColumn.ReadOnly = True
        Me.DatexDataGridViewTextBoxColumn.Visible = False
        '
        'CITYDataGridViewTextBoxColumn
        '
        Me.CITYDataGridViewTextBoxColumn.DataPropertyName = "CITY"
        Me.CITYDataGridViewTextBoxColumn.HeaderText = "CITY"
        Me.CITYDataGridViewTextBoxColumn.Name = "CITYDataGridViewTextBoxColumn"
        Me.CITYDataGridViewTextBoxColumn.ReadOnly = True
        Me.CITYDataGridViewTextBoxColumn.Visible = False
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Visible = False
        '
        'SEARCH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(868, 406)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SEARCH"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "البحث بالاسم"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.MainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.DbsbhDataSet8BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostafeedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLINICSQLhDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DbsbhDataSet8BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MostafeedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CLINICSQLhDataSet As CLINICSQLhDataSet
    Friend WithEvents MainBindingSource1 As BindingSource
    Friend WithEvents MainTableAdapter As CLINICSQLhDataSetTableAdapters.mainTableAdapter
    Friend WithEvents FnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SEXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HusbendDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdcardDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
