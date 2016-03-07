<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemKH
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
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.lblHoTen = New System.Windows.Forms.Label()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.lblSDT = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Location = New System.Drawing.Point(34, 20)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(52, 21)
        Me.lblMaKH.TabIndex = 0
        Me.lblMaKH.Text = "MaKH"
        '
        'lblHoTen
        '
        Me.lblHoTen.AutoSize = True
        Me.lblHoTen.Location = New System.Drawing.Point(34, 66)
        Me.lblHoTen.Name = "lblHoTen"
        Me.lblHoTen.Size = New System.Drawing.Size(52, 21)
        Me.lblHoTen.TabIndex = 0
        Me.lblHoTen.Text = "Hoten"
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Location = New System.Drawing.Point(33, 118)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(53, 21)
        Me.lblDiaChi.TabIndex = 0
        Me.lblDiaChi.Text = "Diachi"
        '
        'lblSDT
        '
        Me.lblSDT.AutoSize = True
        Me.lblSDT.Location = New System.Drawing.Point(33, 164)
        Me.lblSDT.Name = "lblSDT"
        Me.lblSDT.Size = New System.Drawing.Size(38, 21)
        Me.lblSDT.TabIndex = 0
        Me.lblSDT.Text = "SDT"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(93, 20)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(209, 29)
        Me.txtMaKH.TabIndex = 1
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(92, 63)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(210, 29)
        Me.txtHoTen.TabIndex = 1
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(92, 110)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(210, 29)
        Me.txtDiaChi.TabIndex = 1
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(93, 156)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(209, 29)
        Me.txtSDT.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(216, 213)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 29)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(92, 213)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(86, 29)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmThemKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 271)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.lblSDT)
        Me.Controls.Add(Me.lblDiaChi)
        Me.Controls.Add(Me.lblHoTen)
        Me.Controls.Add(Me.lblMaKH)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmThemKH"
        Me.Text = "ThemKH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaKH As System.Windows.Forms.Label
    Friend WithEvents lblHoTen As System.Windows.Forms.Label
    Friend WithEvents lblDiaChi As System.Windows.Forms.Label
    Friend WithEvents lblSDT As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents txtHoTen As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtSDT As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
