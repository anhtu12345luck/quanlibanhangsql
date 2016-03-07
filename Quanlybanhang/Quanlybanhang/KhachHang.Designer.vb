<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.grvBangKH = New System.Windows.Forms.DataGridView()
        Me.lblTimKiem = New System.Windows.Forms.Label()
        Me.cboTimKiem = New System.Windows.Forms.ComboBox()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.grvBangKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grvBangKH
        '
        Me.grvBangKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvBangKH.Location = New System.Drawing.Point(13, 78)
        Me.grvBangKH.Name = "grvBangKH"
        Me.grvBangKH.Size = New System.Drawing.Size(645, 339)
        Me.grvBangKH.TabIndex = 0
        '
        'lblTimKiem
        '
        Me.lblTimKiem.AutoSize = True
        Me.lblTimKiem.Location = New System.Drawing.Point(13, 26)
        Me.lblTimKiem.Name = "lblTimKiem"
        Me.lblTimKiem.Size = New System.Drawing.Size(75, 21)
        Me.lblTimKiem.TabIndex = 1
        Me.lblTimKiem.Text = "Tìm Kiếm"
        '
        'cboTimKiem
        '
        Me.cboTimKiem.FormattingEnabled = True
        Me.cboTimKiem.Items.AddRange(New Object() {"MaKH", "Hoten"})
        Me.cboTimKiem.Location = New System.Drawing.Point(96, 26)
        Me.cboTimKiem.Name = "cboTimKiem"
        Me.cboTimKiem.Size = New System.Drawing.Size(196, 29)
        Me.cboTimKiem.TabIndex = 2
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(335, 26)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(323, 29)
        Me.txtTimKiem.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(687, 20)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(126, 38)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(687, 95)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(126, 38)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(687, 162)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(126, 38)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(687, 227)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(126, 38)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 444)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.cboTimKiem)
        Me.Controls.Add(Me.lblTimKiem)
        Me.Controls.Add(Me.grvBangKH)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmKhachHang"
        Me.Text = "Khách Hàng"
        CType(Me.grvBangKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grvBangKH As System.Windows.Forms.DataGridView
    Friend WithEvents lblTimKiem As System.Windows.Forms.Label
    Friend WithEvents cboTimKiem As System.Windows.Forms.ComboBox
    Friend WithEvents txtTimKiem As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button

End Class
