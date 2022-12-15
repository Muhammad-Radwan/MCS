<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PHARMACY
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PHARMACY))
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.PharmacyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsbhDataSet = New MCS.dbsbhDataSet
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PharmacyTableAdapter = New MCS.dbsbhDataSetTableAdapters.PharmacyTableAdapter
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.DbsbhDataSet1 = New MCS.dbsbhDataSet1
        Me.PharmacymainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmacymainTableAdapter = New MCS.dbsbhDataSet1TableAdapters.pharmacymainTableAdapter
        Me.fnumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.namex = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dateph = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsbhDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.DbsbhDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacymainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Name = "Label5"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Panel3)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Name = "Label4"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label3)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Name = "Label3"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fnumber, Me.namex, Me.Dateph})
        Me.DataGridView1.DataSource = Me.PharmacymainBindingSource
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle26
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle28
        '
        'PharmacyBindingSource
        '
        Me.PharmacyBindingSource.DataMember = "Pharmacy"
        Me.PharmacyBindingSource.DataSource = Me.DbsbhDataSet
        '
        'DbsbhDataSet
        '
        Me.DbsbhDataSet.DataSetName = "dbsbhDataSet"
        Me.DbsbhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Name = "Label1"
        '
        'PharmacyTableAdapter
        '
        Me.PharmacyTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Name = "Label9"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Name = "Label10"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Name = "Label11"
        '
        'DbsbhDataSet1
        '
        Me.DbsbhDataSet1.DataSetName = "dbsbhDataSet1"
        Me.DbsbhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PharmacymainBindingSource
        '
        Me.PharmacymainBindingSource.DataMember = "pharmacymain"
        Me.PharmacymainBindingSource.DataSource = Me.DbsbhDataSet1
        '
        'PharmacymainTableAdapter
        '
        Me.PharmacymainTableAdapter.ClearBeforeFill = True
        '
        'fnumber
        '
        Me.fnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fnumber.DataPropertyName = "fnumber"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.fnumber.DefaultCellStyle = DataGridViewCellStyle24
        resources.ApplyResources(Me.fnumber, "fnumber")
        Me.fnumber.Name = "fnumber"
        Me.fnumber.ReadOnly = True
        '
        'namex
        '
        Me.namex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.namex.DataPropertyName = "namex"
        resources.ApplyResources(Me.namex, "namex")
        Me.namex.Name = "namex"
        Me.namex.ReadOnly = True
        '
        'Dateph
        '
        Me.Dateph.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Dateph.DataPropertyName = "Dateph"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.Format = "G"
        DataGridViewCellStyle25.NullValue = Nothing
        Me.Dateph.DefaultCellStyle = DataGridViewCellStyle25
        resources.ApplyResources(Me.Dateph, "Dateph")
        Me.Dateph.Name = "Dateph"
        Me.Dateph.ReadOnly = True
        '
        'PHARMACY
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "PHARMACY"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsbhDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DbsbhDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacymainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    'Friend WithEvents DbsbhDataSet As MCS.dbsbhDataSet
    Friend WithEvents PharmacyBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents PharmacyTableAdapter As MCS.dbsbhDataSetTableAdapters.PharmacyTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    'Friend WithEvents DbsbhDataSet1 As MCS.dbsbhDataSet1
    Friend WithEvents PharmacymainBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents PharmacymainTableAdapter As MCS.dbsbhDataSet1TableAdapters.pharmacymainTableAdapter
    Friend WithEvents fnumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dateph As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
