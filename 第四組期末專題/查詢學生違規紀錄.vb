Public Class 查詢學生違規紀錄
    Private Sub 學生違規紀錄BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.學生違規紀錄BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.宿舍資料DataSet)

    End Sub

    Private Sub 查詢學生違規紀錄_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '宿舍資料DataSet.學生違規紀錄' 資料表。您可以視需要進行移動或移除。
        Me.學生違規紀錄TableAdapter.Fill(Me.宿舍資料DataSet.學生違規紀錄)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.學生違規紀錄TableAdapter.FillByKeyword(Me.宿舍資料DataSet.學生違規紀錄, Trim(ToolStripTextBox2.Text))


        Catch ex As Exception

            Me.學生違規紀錄TableAdapter.FillBysql(Me.宿舍資料DataSet.學生違規紀錄, Trim(ToolStripTextBox2.Text))

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.學生違規紀錄TableAdapter.Fill(Me.宿舍資料DataSet.學生違規紀錄)
    End Sub
End Class