<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategory
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCategoryId = New System.Windows.Forms.TextBox()
        Me.btnList = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCategoryAd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdbActive = New System.Windows.Forms.RadioButton()
        Me.rdbPassive = New System.Windows.Forms.RadioButton()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnId = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kategori Id :"
        '
        'txtCategoryId
        '
        Me.txtCategoryId.Location = New System.Drawing.Point(98, 12)
        Me.txtCategoryId.Name = "txtCategoryId"
        Me.txtCategoryId.Size = New System.Drawing.Size(159, 20)
        Me.txtCategoryId.TabIndex = 2
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(89, 118)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(168, 48)
        Me.btnList.TabIndex = 3
        Me.btnList.Text = "Listele"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(274, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(514, 370)
        Me.DataGridView1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Kategori Durumu :"
        '
        'txtCategoryAd
        '
        Me.txtCategoryAd.Location = New System.Drawing.Point(98, 49)
        Me.txtCategoryAd.Name = "txtCategoryAd"
        Me.txtCategoryAd.Size = New System.Drawing.Size(159, 20)
        Me.txtCategoryAd.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Kategori Adı :"
        '
        'rdbActive
        '
        Me.rdbActive.AutoSize = True
        Me.rdbActive.Location = New System.Drawing.Point(98, 82)
        Me.rdbActive.Name = "rdbActive"
        Me.rdbActive.Size = New System.Drawing.Size(46, 17)
        Me.rdbActive.TabIndex = 9
        Me.rdbActive.TabStop = True
        Me.rdbActive.Text = "Aktif"
        Me.rdbActive.UseVisualStyleBackColor = True
        '
        'rdbPassive
        '
        Me.rdbPassive.AutoSize = True
        Me.rdbPassive.Location = New System.Drawing.Point(182, 82)
        Me.rdbPassive.Name = "rdbPassive"
        Me.rdbPassive.Size = New System.Drawing.Size(48, 17)
        Me.rdbPassive.TabIndex = 10
        Me.rdbPassive.TabStop = True
        Me.rdbPassive.Text = "Pasif"
        Me.rdbPassive.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(89, 172)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(168, 48)
        Me.BtnAdd.TabIndex = 11
        Me.BtnAdd.Text = "Ekle"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(89, 280)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(168, 48)
        Me.BtnUpdate.TabIndex = 12
        Me.BtnUpdate.Text = "Güncelle"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(89, 226)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(168, 48)
        Me.BtnDelete.TabIndex = 13
        Me.BtnDelete.Text = "Sil"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnId
        '
        Me.BtnId.Location = New System.Drawing.Point(89, 334)
        Me.BtnId.Name = "BtnId"
        Me.BtnId.Size = New System.Drawing.Size(168, 48)
        Me.BtnId.TabIndex = 14
        Me.BtnId.Text = "Id Göre Getir"
        Me.BtnId.UseVisualStyleBackColor = True
        '
        'FrmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnId)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.rdbPassive)
        Me.Controls.Add(Me.rdbActive)
        Me.Controls.Add(Me.txtCategoryAd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.txtCategoryId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCategory"
        Me.Text = "Form Category"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCategoryId As TextBox
    Friend WithEvents btnList As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCategoryAd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rdbActive As RadioButton
    Friend WithEvents rdbPassive As RadioButton
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnId As Button
End Class
