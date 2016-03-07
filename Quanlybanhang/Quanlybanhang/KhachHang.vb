Public Class frmKhachHang
    Private _DBAccess As New DataBaseAccess


    Private Sub LoadKH()
        Dim sqlQuerry As String = String.Format("Select MaKH, Hoten,Diachi, SDT from KhachHang")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuerry)
        Me.grvBangKH.DataSource = dTable
        With Me.grvBangKH
            .Columns(0).HeaderText = "MaKH"
            .Columns(1).HeaderText = "Hoten"
            .Columns(2).HeaderText = "Diachi"
            .Columns(3).HeaderText = "SDT"
        End With
    End Sub

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub

    Private Sub LoadDataGridView()
        Dim sqlQuerry As String = "Select * From KhachHang"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuerry)
        Me.grvBangKH.DataSource = dTable
    End Sub

    Private Sub Search(MaKH As String, value As String)
        Dim sqlQuerry As String = "Select * From KhachHang"
        If Me.cboTimKiem.SelectedIndex = 0 Then 'tim theo MAKH'
            sqlQuerry += String.Format(" WHERE MaKH LIKE '{0}%'", value)
        ElseIf Me.cboTimKiem.SelectedIndex = 1 Then    'Tim Theo Hoten'
            sqlQuerry += String.Format(" WHERE Hoten LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuerry)
        Me.grvBangKH.DataSource = dTable
    End Sub

    Private Sub cboTimKiem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTimKiem.SelectedIndexChanged
            LoadDataGridView()
    End Sub

    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        Search(Me.cboTimKiem.SelectedValue, Me.txtTimKiem.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim AddKH As New frmThemKH(False)
        AddKH.ShowDialog()
        If AddKH.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadKH()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Ma As String = Me.grvBangKH.Rows(Me.grvBangKH.CurrentCell.RowIndex).Cells("MaKH").Value
        Dim sqlQuery As String = String.Format("DELETE KhachHang where MaKH = '{0}'", Ma)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK)
            LoadKH()
        Else
            MessageBox.Show("Lỗi!Hãy thử lại", "Error)", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim EditKH As New frmThemKH(True)
        With Me.grvBangKH
            EditKH.txtMaKH.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
            EditKH.txtHoTen.Text = .Rows(.CurrentCell.RowIndex).Cells("Hoten").Value
            EditKH.txtDiaChi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
            EditKH.txtSDT.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
        End With
        EditKH.ShowDialog()
        If EditKH.DialogResult = Windows.Forms.DialogResult.Yes Then
            LoadKH()
        End If
    End Sub
End Class
