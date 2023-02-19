<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form23
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        'Me.DbsbhDataSet6 = New MCS.dbsbhDataSet6
        Me.DbsbhDataSet6BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.MainTableAdapter = New MCS.dbsbhDataSet6TableAdapters.mainTableAdapter
        Me.FnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HusbendDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        'CType(Me.DbsbhDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsbhDataSet6BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox9)
        Me.Panel1.Font = New System.Drawing.Font("ae_AlMothnna", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 306)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(428, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 197)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("ae_AlMothnna", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FnumberDataGridViewTextBoxColumn, Me.NamexDataGridViewTextBoxColumn, Me.HusbendDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MainBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("ae_AlMothnna", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(15, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("ae_AlMothnna", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Size = New System.Drawing.Size(456, 164)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.ComboBox1)
        Me.GroupBox9.Location = New System.Drawing.Point(18, 21)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(326, 66)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(15, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(291, 33)
        Me.ComboBox1.TabIndex = 0
        '
        'DbsbhDataSet6
        '
        'Me.DbsbhDataSet6.DataSetName = "dbsbhDataSet6"
        'Me.DbsbhDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbsbhDataSet6BindingSource
        '
        'Me.DbsbhDataSet6BindingSource.DataSource = Me.DbsbhDataSet6
        Me.DbsbhDataSet6BindingSource.Position = 0
        '
        'MainBindingSource
        '
        Me.MainBindingSource.DataMember = "main"
        'Me.MainBindingSource.DataSource = Me.DbsbhDataSet6
        '
        'MainTableAdapter
        '
        'Me.MainTableAdapter.ClearBeforeFill = True
        '
        'FnumberDataGridViewTextBoxColumn
        '
        Me.FnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FnumberDataGridViewTextBoxColumn.DataPropertyName = "fnumber"
        Me.FnumberDataGridViewTextBoxColumn.HeaderText = "fnumber"
        Me.FnumberDataGridViewTextBoxColumn.Name = "FnumberDataGridViewTextBoxColumn"
        Me.FnumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.FnumberDataGridViewTextBoxColumn.Width = 112
        '
        'NamexDataGridViewTextBoxColumn
        '
        Me.NamexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamexDataGridViewTextBoxColumn.DataPropertyName = "namex"
        Me.NamexDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NamexDataGridViewTextBoxColumn.Name = "NamexDataGridViewTextBoxColumn"
        Me.NamexDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HusbendDataGridViewTextBoxColumn
        '
        Me.HusbendDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HusbendDataGridViewTextBoxColumn.DataPropertyName = "husbend"
        Me.HusbendDataGridViewTextBoxColumn.HeaderText = "Husbend/Wife"
        Me.HusbendDataGridViewTextBoxColumn.Name = "HusbendDataGridViewTextBoxColumn"
        Me.HusbendDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form23
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(552, 334)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form23"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        'CType(Me.DbsbhDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsbhDataSet6BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DbsbhDataSet6BindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents DbsbhDataSet6 As MCS.dbsbhDataSet6
    Friend WithEvents MainBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents MainTableAdapter As MCS.dbsbhDataSet6TableAdapters.mainTableAdapter
    Friend WithEvents FnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HusbendDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
