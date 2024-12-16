Public Class 管理員身分驗證
    Private Sub 管理員身分驗證_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As String = 1080612
        Dim password As String = 1080619

        If (TextBox1.Text = id And TextBox2.Text = password) Then
            宿舍管理系統_管理員.Show()
            Me.Close()
        Else
            MsgBox("帳號或密碼輸入錯誤!")
        End If
    End Sub
End Class