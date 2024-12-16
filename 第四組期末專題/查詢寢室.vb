Public Class 查詢寢室
    Private Sub 寢室BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.寢室BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.宿舍資料DataSet)

    End Sub

    Private Sub 查詢寢室_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '宿舍資料DataSet.寢室' 資料表。您可以視需要進行移動或移除。
        Me.寢室TableAdapter.Fill(Me.宿舍資料DataSet.寢室)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.寢室TableAdapter.FillByKeyword(Me.宿舍資料DataSet.寢室, Trim(ToolStripTextBox2.Text))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.寢室TableAdapter.Fill(Me.宿舍資料DataSet.寢室)
    End Sub
End Class