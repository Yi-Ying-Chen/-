Imports System.Data.SqlClient
Public Class 管理學生
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\奕穎\Documents\第四組期末專題.新增刪除修改\第四組期末專題\宿舍資料.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub 學生BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles 學生BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.學生BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.宿舍資料DataSet)

    End Sub

    Private Sub 學生_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 '宿舍資料DataSet.學生' 資料表。您可以視需要進行移動或移除。
        Me.學生TableAdapter.Fill(Me.宿舍資料DataSet.學生)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles 搜尋.Click
        Try
            Try

                Me.學生TableAdapter.FillByKeyword(Me.宿舍資料DataSet.學生, Trim(ToolStripTextBox1.Text))


            Catch ex As Exception
                Me.學生TableAdapter.FillBysql(Me.宿舍資料DataSet.學生, Trim(ToolStripTextBox1.Text))


            End Try


        Catch ex2 As Exception


            Me.學生TableAdapter.FillByemail(Me.宿舍資料DataSet.學生, Trim(ToolStripTextBox1.Text))


        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.學生TableAdapter.Fill(Me.宿舍資料DataSet.學生)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click '新增
        conn.Open()

        Dim i As Integer = 學生DataGridView.CurrentRow.Index


        Dim m_學號 = 學號TextBox.Text
        Dim m_姓名 = 姓名TextBox.Text
        Dim m_系級 = 系級TextBox.Text
        Dim m_電話 = 電話TextBox.Text
        Dim m_電子郵件 = 電子郵件TextBox.Text
        Dim m_房號 = 房號TextBox.Text
        Dim m_ID = IDTextBox.Text


        Dim sqladd As String = "INSERT INTO 學生(學號,姓名,系級,電話,電子郵件,房號,ID) VALUES('" & 學號TextBox.Text & "',N'" & 姓名TextBox.Text & "','" & 系級TextBox.Text & "','" & 電話TextBox.Text & "','" & 電子郵件TextBox.Text & "','" & 房號TextBox.Text & "','" & IDTextBox.Text & "')"
        Dim add = New SqlCommand(sqladd, conn)
        Try
            add.ExecuteNonQuery()
        Catch ex3 As Exception
            MsgBox("此寢室房號或管理員ID不存在!")
        End Try
        MsgBox("新增結束")
        conn.Close()

        Try
            Me.學生TableAdapter.InsertQuery(m_學號, m_姓名, m_系級, m_電話, m_電子郵件, m_房號, m_ID)
        Catch ex4 As Exception
            MsgBox("本次新增失敗!!")
        End Try

        Me.學生DataGridView.Refresh()
        Me.學生BindingSource.DataSource = 學生TableAdapter.GetData()
        Me.學生BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click '刪除
        Dim m_學號 = 學號TextBox.Text
        Dim m_姓名 = 姓名TextBox.Text
        Dim m_系級 = 系級TextBox.Text
        Dim m_電話 = 電話TextBox.Text
        Dim m_電子郵件 = 電子郵件TextBox.Text
        Dim m_房號 = 房號TextBox.Text
        Dim m_ID = IDTextBox.Text

        conn.Open()
        Dim sqldel As String = "DELETE FROM 學生 WHERE 學號 IN ('" & 學號TextBox.Text & "')"
        Dim del = New SqlCommand(sqldel, conn)
        del.ExecuteNonQuery()
        MsgBox("刪除成功!!!")
        conn.Close()

        Me.學生TableAdapter.DeleteQuery(m_學號)

        學生DataGridView.Refresh()
        Me.學生BindingSource.DataSource = 學生TableAdapter.GetData()
        Me.學生BindingSource.ResetBindings(False)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click '修改
        Dim i As Integer = 學生DataGridView.CurrentRow.Index
        Dim columnValue As String = 學生DataGridView.Item(0, i).Value

        學生DataGridView.CurrentCell = 學生DataGridView.Rows(i).Cells(0)

        Dim m_學號 = 學號TextBox.Text
        Dim m_姓名 = 姓名TextBox.Text
        Dim m_系級 = 系級TextBox.Text
        Dim m_電話 = 電話TextBox.Text
        Dim m_電子郵件 = 電子郵件TextBox.Text
        Dim m_房號 = 房號TextBox.Text
        Dim m_ID = IDTextBox.Text

        conn.Open()
        Dim sqlupd As String = "UPDATE 學生 Set 學號 = '" & 學號TextBox.Text & "',姓名 = N'" & 姓名TextBox.Text & "',系級 = '" & 系級TextBox.Text & "',電話 = '" & 電話TextBox.Text & "', 電子郵件 = '" & 電子郵件TextBox.Text & "',房號 = '" & 房號TextBox.Text & "',ID = '" & IDTextBox.Text & "' WHERE 學號 = '" & ComboBox1.Text & "'"
        Dim upd = New SqlCommand(sqlupd, conn)
        Try
            upd.ExecuteNonQuery()
        Catch ex5 As Exception
            MsgBox("此寢室房號或管理員ID不存在!!!")
        End Try
        MsgBox("修改結束")
        conn.Close()

        Try
            Me.學生TableAdapter.UpdateQuery(m_學號, m_姓名, m_系級, m_電話, m_電子郵件, m_房號, m_ID)
        Catch ex6 As Exception
            MsgBox("本次修改失敗!!")
        End Try

        Me.學生DataGridView.Refresh()
        Me.學生BindingSource.DataSource = 學生TableAdapter.GetData()
        Me.學生BindingSource.ResetBindings(False)
    End Sub
End Class