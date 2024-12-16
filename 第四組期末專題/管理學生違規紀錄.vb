Imports System.Data.SqlClient
Public Class 管理學生違規紀錄
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\奕穎\Documents\第四組期末專題.新增刪除修改\第四組期末專題\宿舍資料.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub 學生違規紀錄BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles 學生違規紀錄BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.學生違規紀錄BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.宿舍資料DataSet)

    End Sub

    Private Sub 學生違規紀錄_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '宿舍資料DataSet.學生違規紀錄' 資料表。您可以視需要進行移動或移除。
        Me.學生違規紀錄TableAdapter.Fill(Me.宿舍資料DataSet.學生違規紀錄)

    End Sub

    Private Sub 搜尋_Click(sender As Object, e As EventArgs) Handles 搜尋.Click
        Try
            Me.學生違規紀錄TableAdapter.FillByKeyword(Me.宿舍資料DataSet.學生違規紀錄, Trim(ToolStripTextBox1.Text))


        Catch ex As Exception

            Me.學生違規紀錄TableAdapter.FillBysql(Me.宿舍資料DataSet.學生違規紀錄, Trim(ToolStripTextBox1.Text))

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click '新增
        conn.Open()

        Dim i As Integer = 學生違規紀錄DataGridView.CurrentRow.Index


        Dim m_學號 = 學號TextBox.Text
        Dim m_最近一次違規項目 = 最近一次違規項目TextBox.Text
        Dim m_最近一次違規時間 = 最近一次違規時間TextBox.Text


        Dim sqladd As String = "INSERT INTO 學生違規紀錄(學號,最近一次違規項目,最近一次違規時間) VALUES('" & 學號TextBox.Text & "',N'" & 最近一次違規項目TextBox.Text & "','" & 最近一次違規時間TextBox.Text & "')"
        Dim add = New SqlCommand(sqladd, conn)
        Try
            add.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox("此學生學號不存在!")
        End Try
        MsgBox("新增結束")
        conn.Close()

        Try
            Me.學生違規紀錄TableAdapter.InsertQuery(m_學號, m_最近一次違規項目, m_最近一次違規時間)
        Catch ex2 As Exception
            MsgBox("本次新增失敗!!")
        End Try

        Me.學生違規紀錄DataGridView.Refresh()
        Me.學生違規紀錄BindingSource.DataSource = 學生違規紀錄TableAdapter.GetData()
        Me.學生違規紀錄BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click '修改
        Dim m_學號 = 學號TextBox.Text
        Dim m_最近一次違規項目 = 最近一次違規項目TextBox.Text
        Dim m_最近一次違規時間 = 最近一次違規時間TextBox.Text

        Dim i As Integer = 學生違規紀錄DataGridView.CurrentRow.Index
        Dim columnValue As String = 學生違規紀錄DataGridView.Item(0, i).Value

        學生違規紀錄DataGridView.CurrentCell = 學生違規紀錄DataGridView.Rows(i).Cells(0)

        conn.Open()
        Dim sqlupd As String = "UPDATE 學生違規紀錄 Set 學號 = '" & 學號TextBox.Text & "',最近一次違規項目 = N'" & 最近一次違規項目TextBox.Text & "',最近一次違規時間 = '" & 最近一次違規時間TextBox.Text & "' WHERE 學號 = '" & ComboBox1.Text & "'"
        Dim upd = New SqlCommand(sqlupd, conn)
        Try
            upd.ExecuteNonQuery()
        Catch ex3 As Exception
            MsgBox("此學生學號不存在!!!")
        End Try
        MsgBox("修改結束")
        conn.Close()

        Try
            Me.學生違規紀錄TableAdapter.UpdateQuery(m_學號, m_最近一次違規項目, m_最近一次違規時間)
        Catch ex4 As Exception
            MsgBox("本次修改失敗!!")
        End Try

        Me.學生違規紀錄DataGridView.Refresh()
        Me.學生違規紀錄BindingSource.DataSource = 學生違規紀錄TableAdapter.GetData()
        Me.學生違規紀錄BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.學生違規紀錄TableAdapter.Fill(Me.宿舍資料DataSet.學生違規紀錄)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click '刪除
        Dim m_學號 = 學號TextBox.Text
        Dim m_最近一次違規項目 = 最近一次違規項目TextBox.Text
        Dim m_最近一次違規時間 = 最近一次違規時間TextBox.Text

        conn.Open()
        Dim sqldel As String = "DELETE FROM 學生違規紀錄 WHERE 學號 IN ('" & 學號TextBox.Text & "')"
        Dim del = New SqlCommand(sqldel, conn)
        del.ExecuteNonQuery()
        MsgBox("刪除成功!!!")
        conn.Close()

        Me.學生違規紀錄TableAdapter.DeleteQuery(m_學號)

        Me.學生違規紀錄DataGridView.Refresh()
        Me.學生違規紀錄BindingSource.DataSource = 學生違規紀錄TableAdapter.GetData()
        Me.學生違規紀錄BindingSource.ResetBindings(False)
    End Sub
End Class