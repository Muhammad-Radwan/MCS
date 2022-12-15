<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TADEELDN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TADEELDN))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.B11 = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.B11)
        Me.Panel1.Controls.Add(Me.GroupBox9)
        Me.Panel1.Font = New System.Drawing.Font("ae_AlMothnna", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 112)
        Me.Panel1.TabIndex = 1
        '
        'B11
        '
        Me.B11.BackColor = System.Drawing.Color.MidnightBlue
        Me.B11.BackgroundImage = CType(resources.GetObject("B11.BackgroundImage"), System.Drawing.Image)
        Me.B11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B11.FlatAppearance.BorderSize = 6
        Me.B11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.B11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.B11.Font = New System.Drawing.Font("ae_AlMateen", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B11.ForeColor = System.Drawing.Color.White
        Me.B11.Location = New System.Drawing.Point(16, 29)
        Me.B11.Name = "B11"
        Me.B11.Size = New System.Drawing.Size(145, 58)
        Me.B11.TabIndex = 24
        Me.B11.Text = "تعديــل"
        Me.B11.UseVisualStyleBackColor = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.Controls.Add(Me.ComboBox4)
        Me.GroupBox9.Location = New System.Drawing.Point(181, 12)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(285, 75)
        Me.GroupBox9.TabIndex = 10
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "اسم الطبيب"
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.Color.White
        Me.ComboBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(3, 31)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(279, 37)
        Me.ComboBox4.Sorted = True
        Me.ComboBox4.TabIndex = 1
        '
        'TADEELDN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(517, 138)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "TADEELDN"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تعديل اسم الطبيب"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents B11 As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
End Class
