<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 查詢學生違規紀錄
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(查詢學生違規紀錄))
        Me.宿舍資料DataSet = New 第四組期末專題.宿舍資料DataSet()
        Me.學生違規紀錄BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.學生違規紀錄TableAdapter = New 第四組期末專題.宿舍資料DataSetTableAdapters.學生違規紀錄TableAdapter()
        Me.TableAdapterManager = New 第四組期末專題.宿舍資料DataSetTableAdapters.TableAdapterManager()
        Me.學生違規紀錄BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.學生違規紀錄DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.宿舍資料DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.學生違規紀錄BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.學生違規紀錄BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.學生違規紀錄BindingNavigator.SuspendLayout()
        CType(Me.學生違規紀錄DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '宿舍資料DataSet
        '
        Me.宿舍資料DataSet.DataSetName = "宿舍資料DataSet"
        Me.宿舍資料DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '學生違規紀錄BindingSource
        '
        Me.學生違規紀錄BindingSource.DataMember = "學生違規紀錄"
        Me.學生違規紀錄BindingSource.DataSource = Me.宿舍資料DataSet
        '
        '學生違規紀錄TableAdapter
        '
        Me.學生違規紀錄TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = 第四組期末專題.宿舍資料DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.學生TableAdapter = Nothing
        Me.TableAdapterManager.學生違規紀錄TableAdapter = Me.學生違規紀錄TableAdapter
        Me.TableAdapterManager.寢室TableAdapter = Nothing
        Me.TableAdapterManager.管理員TableAdapter = Nothing
        '
        '學生違規紀錄BindingNavigator
        '
        Me.學生違規紀錄BindingNavigator.AddNewItem = Nothing
        Me.學生違規紀錄BindingNavigator.BindingSource = Me.學生違規紀錄BindingSource
        Me.學生違規紀錄BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.學生違規紀錄BindingNavigator.DeleteItem = Nothing
        Me.學生違規紀錄BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripTextBox1, Me.ToolStripTextBox2, Me.ToolStripButton1})
        Me.學生違規紀錄BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.學生違規紀錄BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.學生違規紀錄BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.學生違規紀錄BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.學生違規紀錄BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.學生違規紀錄BindingNavigator.Name = "學生違規紀錄BindingNavigator"
        Me.學生違規紀錄BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.學生違規紀錄BindingNavigator.Size = New System.Drawing.Size(720, 25)
        Me.學生違規紀錄BindingNavigator.TabIndex = 0
        Me.學生違規紀錄BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(27, 22)
        Me.BindingNavigatorCountItem.Text = "/{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目總數"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "移到最前面"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "移到上一個"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "目前的位置"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "移到下一個"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "移到最後面"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Enabled = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBox1.Text = "違規紀錄搜尋"
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripButton1.Text = "搜尋"
        '
        '學生違規紀錄DataGridView
        '
        Me.學生違規紀錄DataGridView.AutoGenerateColumns = False
        Me.學生違規紀錄DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.學生違規紀錄DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.學生違規紀錄DataGridView.DataSource = Me.學生違規紀錄BindingSource
        Me.學生違規紀錄DataGridView.Location = New System.Drawing.Point(141, 56)
        Me.學生違規紀錄DataGridView.Name = "學生違規紀錄DataGridView"
        Me.學生違規紀錄DataGridView.RowTemplate.Height = 24
        Me.學生違規紀錄DataGridView.Size = New System.Drawing.Size(348, 220)
        Me.學生違規紀錄DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "學號"
        Me.DataGridViewTextBoxColumn1.HeaderText = "學號"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "最近一次違規項目"
        Me.DataGridViewTextBoxColumn2.HeaderText = "最近一次違規項目"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "最近一次違規時間"
        Me.DataGridViewTextBoxColumn3.HeaderText = "最近一次違規時間"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(533, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 81)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "重新整理"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '查詢學生違規紀錄
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.學生違規紀錄DataGridView)
        Me.Controls.Add(Me.學生違規紀錄BindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "查詢學生違規紀錄"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查詢學生違規紀錄"
        CType(Me.宿舍資料DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.學生違規紀錄BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.學生違規紀錄BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.學生違規紀錄BindingNavigator.ResumeLayout(False)
        Me.學生違規紀錄BindingNavigator.PerformLayout()
        CType(Me.學生違規紀錄DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 宿舍資料DataSet As 宿舍資料DataSet
    Friend WithEvents 學生違規紀錄BindingSource As BindingSource
    Friend WithEvents 學生違規紀錄TableAdapter As 宿舍資料DataSetTableAdapters.學生違規紀錄TableAdapter
    Friend WithEvents TableAdapterManager As 宿舍資料DataSetTableAdapters.TableAdapterManager
    Friend WithEvents 學生違規紀錄BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents 學生違規紀錄DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Button1 As Button
End Class
