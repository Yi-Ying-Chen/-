Public Class 查詢管理員
    Private Sub 管理員BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.管理員BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.宿舍資料DataSet)

    End Sub

    Private Sub 查詢管理員_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '宿舍資料DataSet.管理員' 資料表。您可以視需要進行移動或移除。
        Me.管理員TableAdapter.Fill(Me.宿舍資料DataSet.管理員)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.管理員TableAdapter.FillByKeyword(Me.宿舍資料DataSet.管理員, Trim(ToolStripTextBox2.Text))
        Catch ex As Exception
            Me.管理員TableAdapter.FillBysql(Me.宿舍資料DataSet.管理員, Trim(ToolStripTextBox2.Text))
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.管理員TableAdapter.Fill(Me.宿舍資料DataSet.管理員)
    End Sub
End Class