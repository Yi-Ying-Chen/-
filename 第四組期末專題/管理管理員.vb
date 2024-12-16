Imports System.Data.SqlClient
Public Class 管理管理員
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\奕穎\Documents\第四組期末專題.新增刪除修改\第四組期末專題\宿舍資料.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub 管理員BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles 管理員BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.管理員BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.宿舍資料DataSet)

    End Sub

    Private Sub 管理員_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '宿舍資料DataSet.管理員' 資料表。您可以視需要進行移動或移除。
        Me.管理員TableAdapter.Fill(Me.宿舍資料DataSet.管理員)

    End Sub

    Private Sub 搜尋_Click(sender As Object, e As EventArgs) Handles 搜尋.Click
        Try
            Me.管理員TableAdapter.FillByKeyword(Me.宿舍資料DataSet.管理員, Trim(ToolStripTextBox1.Text))
        Catch ex As Exception
            Me.管理員TableAdapter.FillBysql(Me.宿舍資料DataSet.管理員, Trim(ToolStripTextBox1.Text))
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click '新增
        conn.Open()

        Dim i As Integer = 管理員DataGridView.CurrentRow.Index


        Dim m_ID = IDTextBox.Text
        Dim m_姓名 = 姓名TextBox.Text
        Dim m_電話 = 電話TextBox.Text
        Dim m_電子郵件 = 電子郵件TextBox.Text


        Dim sqladd As String = "INSERT INTO 管理員(ID,姓名,電話,電子郵件) VALUES('" & IDTextBox.Text & "',N'" & 姓名TextBox.Text & "','" & 電話TextBox.Text & "','" & 電子郵件TextBox.Text & "')"
        Dim add = New SqlCommand(sqladd, conn)
        add.ExecuteNonQuery()
        MsgBox("新增成功!!!")
        conn.Close()

        Me.管理員TableAdapter.InsertQuery(m_ID, m_姓名, m_電話, m_電子郵件)

        Me.管理員DataGridView.Refresh()
        Me.管理員BindingSource.DataSource = 管理員TableAdapter.GetData()
        Me.管理員BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click '刪除
        Dim m_ID = IDTextBox.Text
        Dim m_姓名 = 姓名TextBox.Text
        Dim m_電話 = 電話TextBox.Text
        Dim m_電子郵件 = 電子郵件TextBox.Text

        conn.Open()
        Dim sqldel As String = "DELETE FROM 管理員 WHERE ID IN ('" & IDTextBox.Text & "')"
        Dim del = New SqlCommand(sqldel, conn)
        del.ExecuteNonQuery()
        MsgBox("刪除成功!!!")
        conn.Close()

        Me.管理員TableAdapter.DeleteQuery(m_ID)

        管理員DataGridView.Refresh()
        Me.管理員BindingSource.DataSource = 管理員TableAdapter.GetData()
        Me.管理員BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click '修改
        Dim m_ID = IDTextBox.Text
        Dim m_姓名 = 姓名TextBox.Text
        Dim m_電話 = 電話TextBox.Text
        Dim m_電子郵件 = 電子郵件TextBox.Text

        Dim i As Integer = 管理員DataGridView.CurrentRow.Index
        Dim columnValue As String = 管理員DataGridView.Item(0, i).Value

        管理員DataGridView.CurrentCell = 管理員DataGridView.Rows(i).Cells(0)

        conn.Open()
        Dim sqlupd As String = "UPDATE 管理員 Set ID = '" & IDTextBox.Text & "',姓名 = N'" & 姓名TextBox.Text & "',電話 = '" & 電話TextBox.Text & "', 電子郵件 = '" & 電子郵件TextBox.Text & "' WHERE ID = '" & ComboBox1.Text & "'"
        Dim upd = New SqlCommand(sqlupd, conn)
        upd.ExecuteNonQuery()
        MsgBox("修改成功!!!")
        conn.Close()

        管理員DataGridView.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.管理員TableAdapter.Fill(Me.宿舍資料DataSet.管理員)
    End Sub
End Class