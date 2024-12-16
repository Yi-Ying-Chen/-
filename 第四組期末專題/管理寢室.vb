Imports System.Data.SqlClient
Public Class 管理寢室
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\奕穎\Documents\第四組期末專題.新增刪除修改\第四組期末專題\宿舍資料.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub 宿舍管理系統_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '宿舍資料DataSet.寢室' 資料表。您可以視需要進行移動或移除。
        Me.寢室TableAdapter.Fill(Me.宿舍資料DataSet.寢室)


    End Sub

    Private Sub 寢室BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles 寢室BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.寢室BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.宿舍資料DataSet)

    End Sub

    Private Sub 搜尋_Click(sender As Object, e As EventArgs) Handles 搜尋.Click
        Me.寢室TableAdapter.FillByKeyword(Me.宿舍資料DataSet.寢室, Trim(ToolStripTextBox1.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        conn.Open()

        Dim i As Integer = 寢室DataGridView.CurrentRow.Index


        Dim m_房號 = 房號TextBox.Text
        Dim m_入住人數 = 入住人數TextBox.Text
        Dim m_ID = IDTextBox.Text

        Dim sqladd As String = "INSERT INTO 寢室(房號,入住人數,ID) VALUES('" & 房號TextBox.Text & "','" & 入住人數TextBox.Text & "','" & IDTextBox.Text & "')"
        Dim add = New SqlCommand(sqladd, conn)
        Try
            add.ExecuteNonQuery()
        Catch ex1 As Exception
            MsgBox("此管理員ID不存在!")
        End Try
        MsgBox("新增結束")
        conn.Close()

        Try
            Me.寢室TableAdapter.InsertQuery(m_房號, m_入住人數, m_ID)
        Catch ex2 As Exception
            MsgBox("本次新增失敗!!")
        End Try

        Me.寢室DataGridView.Refresh()
        Me.寢室BindingSource.DataSource = 寢室TableAdapter.GetData()
        Me.寢室BindingSource.ResetBindings(False)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim i As Integer = 寢室DataGridView.CurrentRow.Index
        Dim columnValue As String = 寢室DataGridView.Item(0, i).Value

        寢室DataGridView.CurrentCell = 寢室DataGridView.Rows(i).Cells(0)

        'Try
        '    寢室TableAdapter.UpdateQuery(房號TextBox.Text, 入住人數TextBox.Text, IDTextBox.Text)
        '    MsgBox("修改成功")
        'Catch ex As Exception
        '    MsgBox("修改失敗")
        'End Try

        Dim m_房號 = 房號TextBox.Text
        Dim m_入住人數 = 入住人數TextBox.Text
        Dim m_ID = IDTextBox.Text

        conn.Open()
        Dim sqlupd As String = "UPDATE 寢室 Set 房號 = '" & 房號TextBox.Text & "',入住人數 = '" & 入住人數TextBox.Text & "',ID = '" & IDTextBox.Text & "' WHERE 房號 = '" & ComboBox1.Text & "'"
        Dim upd = New SqlCommand(sqlupd, conn)
        Try
            upd.ExecuteNonQuery()
        Catch ex3 As Exception
            MsgBox("此管理員ID不存在!!!")
        End Try
        MsgBox("修改結束")
        conn.Close()

        Try
            Me.寢室TableAdapter.UpdateQuery(m_房號, m_入住人數, m_ID)
        Catch ex4 As Exception
            MsgBox("本次修改失敗!!")
        End Try

        Me.寢室DataGridView.Refresh()
        Me.寢室BindingSource.DataSource = 寢室TableAdapter.GetData()
        Me.寢室BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'Dim i As Integer = 寢室DataGridView.CurrentRow.Index
        'Dim columnValue As String = 寢室DataGridView.Item(0, i).Value
        '宿舍資料DataSet.寢室.Rows(i).Delete()
        'Try
        '    寢室TableAdapter.DeleteQuery(columnValue)
        '    MsgBox("刪除成功")
        'Catch ex As Exception
        '    MsgBox("刪除失敗")
        'End Try

        Dim m_房號 = 房號TextBox.Text
        Dim m_入住人數 = 入住人數TextBox.Text
        Dim m_ID = IDTextBox.Text

        conn.Open()
        Dim sqldel As String = "DELETE FROM 寢室 WHERE 房號 IN ('" & 房號TextBox.Text & "')"
        Dim del = New SqlCommand(sqldel, conn)
        del.ExecuteNonQuery()
        MsgBox("刪除成功!!!")
        conn.Close()

        Me.寢室TableAdapter.DeleteQuery(m_房號)

        寢室DataGridView.Refresh()
        Me.寢室BindingSource.DataSource = 寢室TableAdapter.GetData()
        Me.寢室BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.寢室TableAdapter.Fill(Me.宿舍資料DataSet.寢室)
    End Sub
End Class
